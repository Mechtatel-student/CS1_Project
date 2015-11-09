﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using DevExpress.XtraPrinting.Native;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    internal class RolePresenter : Presenter
    {
        private RoleModel _model;
        private IRoleView _view;

        private BindingList<Role> _roles = new BindingList<Role>();
        private BindingList<Permission> _avalaiblePermissions = new BindingList<Permission>();

        private Role _currentRole;

        public RolePresenter(IRoleView view, RoleModel model)
        {
            _view = view;
            _model = model;
            InitializeFields();
        }

        private void InitializeFields()
        {
            _roles = new BindingList<Role>(_model.RoleRepository.GetAll().ToList());
            _avalaiblePermissions = new BindingList<Permission>(_model.PermissionRepository.GetAll().ToList());
        }

        public void UsePermissionWithRoleID(int id)
        {
            _currentRole = _roles.First(x => x.Id == id);//.Clone() as Role;
        }

        public void ChangedRolePermission(Permission permission, bool state)
        {
            if (_currentRole.Permissions.Contains(permission))
            {
                if (!state)
                {
                    _currentRole.Permissions.Remove(permission);
                }
            }
            else
            {
                if (state)
                {
                    _currentRole.Permissions.Add(permission);
                }
            }
        }

        public void Save()
        {
            foreach (var role in _roles)
            {
                if (string.IsNullOrEmpty(role.Title))
                {
                    MessageBox.Show("You unable to save role with empty title!", "Warning");
                    return;
                }
                if (role.Id == 0)
                {
                    _model.RoleRepository.Create(role);
                }
                else
                {
                    _model.RoleRepository.Update(role);
                }
            }
        }

        public void AddNewRole()
        {
            _roles.Add(new Role(new List<Permission>()) { Title = "" });
            NotifyPropertyChanged("Roles");
        }
        #region Props
        public Role CurrentRole
        {
            get { return _currentRole; }
            set { _currentRole = value; }
        }

        public BindingList<Role> Roles
        {
            get { return _roles; }
            set
            {
                if (!value.SequenceEqual(_roles))
                {
                    _roles = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Permission> AvalaiblePermissions
        {
            get { return _avalaiblePermissions; }
        }
        #endregion

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
