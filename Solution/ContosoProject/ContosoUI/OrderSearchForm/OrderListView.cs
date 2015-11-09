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
using DevExpress.XtraEditors.Controls;
using Domain.Entities.Orders;

namespace ContosoUI.OrderSearchForm
{
    public partial class OrderListView : DevExpress.XtraBars.Ribbon.RibbonForm, IOrderListView
    {
        private readonly OrderListPresenter presenter;
        BindingSource binding = new BindingSource();

        public OrderListView()
        {
            InitializeComponent();
            presenter = new OrderListPresenter(this, new OrderListModel());
        }

        private void OrderListView_Load(object sender, EventArgs e)
        {
            binding.DataSource = presenter;

            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            orderItemsGridControl.DataBindings.Add("DataSource", binding, "OrdersList", false, DataSourceUpdateMode.OnPropertyChanged);

            clientLookUpEdit.Properties.DataSource = presenter.ClientsList;
            clientLookUpEdit.DataBindings.Add("EditValue", binding, "ClientID", false, DataSourceUpdateMode.OnPropertyChanged);
            clientLookUpEdit.Properties.ValueMember = "Id";
            clientLookUpEdit.Properties.DisplayMember = "Person";

            orderStatusComboBoxEdit.Properties.Items.AddRange(presenter.StatusList);
            orderStatusComboBoxEdit.DataBindings.Add("EditValue", binding, "StatusEnum");
        }

        private void searchOrderBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Search();
        }

        private void clearButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Clear();
        }

        private void orderItemsGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.Edit(id);
            }
        }

        private void orderNumberTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void orderStatusComboBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void orderStatusComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
             presenter.StatusEnum = (Status)orderStatusComboBoxEdit.SelectedItem;
        }

        private void OrderListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.Stop();
        }
    }
}