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

namespace ContosoUI.ClientSearchForm
{
    public partial class ClientListView : DevExpress.XtraBars.Ribbon.RibbonForm, IClientSearchView
    {
        private readonly ClientSearchPresenter presenter;
        BindingSource binding = new BindingSource();

        public ClientListView()
        {
            InitializeComponent();
            presenter = new ClientSearchPresenter(this, new ClientSearchModel());
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Any(x => x.Title == "Search Client by City"))
                clientCityTextEdit.Enabled = false;
        }

        private void ClientListView_Load(object sender, EventArgs e)
        {
            ShowDependentOnRole(Program.AuthUser.Role);

            binding.DataSource = presenter;

            clientCityTextEdit.DataBindings.Add("EditValue", binding, "City", false, DataSourceUpdateMode.OnPropertyChanged);
            clientFirstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
            clientLastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
            clientsGridControl.DataBindings.Add("DataSource", binding, "Clients", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void searchClientBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Search();
        }

        private void clearClientBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Clear();
        }

        private void clientsGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.Edit(id);
            }
        }

        private void clientFirstNameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void clientLastNameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void clientCityTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void ClientListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.Stop();
        }
    }
}