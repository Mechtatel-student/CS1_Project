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
using Domain.Entities.Users;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ContosoUI.UserSearchForm
{
    public partial class UsersListView : DevExpress.XtraBars.Ribbon.RibbonForm, IUserSearchView
    {
        private readonly UserSearchPresenter presenter;
        BindingSource binding = new BindingSource();
         
        public UsersListView()
        {
            InitializeComponent();
            presenter = new UserSearchPresenter(this, new UserSearchModel());
        }

        private void UsersListView_Load(object sender, EventArgs e)
        {
            binding.DataSource = presenter;

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
            usersGridControl.DataBindings.Add("DataSource", binding, "Users", false, DataSourceUpdateMode.OnPropertyChanged);
            usersGridControl.RefreshDataSource();
        }

        private void searchUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            presenter.Search();
        }

        private void clearUserBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            presenter.Clear();
        }

        private void usersGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                presenter.Edit(id);
            }
        }

        private void loginTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void firstNameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void lastNameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                binding.EndEdit();
                presenter.Search();
            }
        }

        private void UsersListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.Stop();
        }

    }
}