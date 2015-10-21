﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI.UserForm
{
    public partial class UserForm : Form, IUserView
    {
        private readonly UserPresenter presenter;

        public UserForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel());
            roleComboBoxEdit.Properties.Items.AddRange(presenter.RoleList.Select(x => x.Title).ToList());
            BindingSource binding = new BindingSource();
            binding.DataSource = presenter;

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            middleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            passwordTextEdit.DataBindings.Add("EditValue", binding, "Password");
            roleComboBoxEdit.DataBindings.Add("EditValue", binding, "RoleTitle");
        }

        public UserForm(int id)
        {
            InitializeComponent();
            presenter = new UserPresenter(this, new UserModel());
            presenter.GetUser(id);
            RefreshForm();           
        }

        public void RefreshForm()
        {
            loginTextEdit.Text = presenter.Login;
            firstNameTextEdit.Text = presenter.FirstName;
            middleNameTextEdit.Text = presenter.MiddleName;
            lastNameTextEdit.Text = presenter.LastName;
            roleComboBoxEdit.Text = presenter.Role.Title;
            passwordTextEdit.Text = presenter.Password;
            stateButtonText();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            presenter.Clear(); 
            RefreshForm();
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            // Reset / revert
            presenter.State = !presenter.State;
            RefreshForm();            
        }

        private void stateButtonText()
        {
            if (presenter.State)
                stateButton.Text = "Remove";
            else
                stateButton.Text = "Revert";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void saveCloseButton_Click(object sender, EventArgs e)
        {
            presenter.SaveAndNew();
        }
    }
}