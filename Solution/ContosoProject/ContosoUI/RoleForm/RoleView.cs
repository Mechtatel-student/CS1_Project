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

namespace ContosoUI.RoleForm
{
    public partial class RoleView : DevExpress.XtraBars.Ribbon.RibbonForm, IRoleView
    {
        private readonly RolePresenter _presenter;
        private BindingSource binding = new BindingSource();

        public RoleView()
        {
            InitializeComponent();
            _presenter = new RolePresenter(this, new RoleModel());
        }

       private void RoleView_Load(object sender, EventArgs e)
        {
            binding.DataSource = _presenter;

            roleGridControl.DataBindings.Add("DataSource", binding, "Roles");
            ShowDependentOnRole(Program.AuthUser.Role);
        }

       private void ShowDependentOnRole(Role role)
       {
           if (!role.Permissions.Any(x => x.Title == "Edit Role"))
           {
               barSaveButton.Visibility = BarItemVisibility.Never;
               barAddButton.Visibility = BarItemVisibility.Never;
           }
       }


        private void FillThePermissionsList()
        {
            permissionsCheckedListBox.Items.Clear();
            foreach (var permission in _presenter.AvalaiblePermissions)
            {
                permissionsCheckedListBox.Items.Add(permission,_presenter.CurrentRole.Permissions.Contains(permission));
            }
        }
     
        private void barSaveButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.Save();
        }

        private void barAddButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.AddNewRole();
        }

        private void permissionsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_presenter.CurrentRole == null) return;
            var checkedPermission = permissionsCheckedListBox.SelectedItem as Permission;
            if (checkedPermission != null)
            {
                _presenter.ChangedRolePermission(checkedPermission, e.NewValue == CheckState.Checked);
            }
        }



        private void RoleView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.Stop();
        }

        private void roleGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            permissionsCheckedListBox.DataBindings.Clear();
            GridView view = (GridView) sender;
            int id = (int) view.GetRowCellValue(e.FocusedRowHandle, "Id");
            _presenter.UsePermissionWithRoleID(id);
            FillThePermissionsList();
        }
    }
}