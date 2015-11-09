using Data.DummyData;
using Domain.DAO;
using Data.EFRepository;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
namespace ContosoUI
{
    public partial class LoginForm : Form
    {
        private readonly ProjectContext _context = new ProjectContext();
        public LoginForm()
        {
            InitializeComponent();

#if DEBUG
            loginTextEdit.Text = "Admin";
            passwordTextEdit.Text = "queryadmin";
#endif
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ChairsSplashScreen));
            IUserRepository userRepo = new EFUserDAO(_context);
            var hashedPass = passwordTextEdit.Text.CreateHash();
            var user = userRepo.Authentificate(loginTextEdit.Text, hashedPass);
            if (user != null)
            {
                Program.AuthUser = user;
                this.Close();
            }
            else
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Invalid login or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                okButton_Click(sender, e);
        }

        private void loginTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                okButton_Click(sender, e);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
