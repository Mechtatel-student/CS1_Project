using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Users;
using Domain.DAO;
using Data.DummyData;

namespace ContosoUI.ProductSearchForm
{
    public partial class ProductListView : DevExpress.XtraBars.Ribbon.RibbonForm, IProductListView
    {
        private readonly ProductListPresenter presenter;
        BindingSource binding = new BindingSource();

        public ProductListView()
        {
            InitializeComponent();
            presenter = new ProductListPresenter(this, new ProductListModel());
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Any(x => x.Title == "Search Product by Category"))
                categoryLookUpEdit.Enabled = false;
        }

        private void ProductListView_Load(object sender, EventArgs e)
        {
            ShowDependentOnRole(Program.AuthUser.Role);

            binding.DataSource = presenter;

            skuTextEdit.DataBindings.Add("EditValue", binding, "SKU", false, DataSourceUpdateMode.OnPropertyChanged);
            productTitleTextEdit.DataBindings.Add("EditValue", binding, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            productsGridControl.DataBindings.Add("DataSource", binding, "Products", false, DataSourceUpdateMode.OnPropertyChanged);
           
            categoryLookUpEdit.Properties.DataSource = presenter.CategoriesList;
            categoryLookUpEdit.DataBindings.Add("EditValue", binding, "CategoryID", false, DataSourceUpdateMode.OnPropertyChanged);            
            categoryLookUpEdit.Properties.ValueMember = "Id";
            categoryLookUpEdit.Properties.DisplayMember = "Title";
        }

        private void searchProductBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Search();
        }

        private void clearProductBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Clear();
        }

        private void productsGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.Edit(id);
            }
        }

        private void skuTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void productTitleTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void ProductListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.Stop();
        }
    }
}