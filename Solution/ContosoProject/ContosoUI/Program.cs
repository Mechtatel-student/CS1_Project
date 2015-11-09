using DevExpress.XtraSplashScreen;
using Domain.Entities.Users;
using System;
using System.Windows.Forms;

namespace ContosoUI
{
    static class Program
    {
        public static MainForm MainForm { get; private set; }
        public static User AuthUser { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            //auth
            var lf = new LoginForm();
            lf.ShowDialog();

            if (AuthUser != null)
            {
                MainForm = new MainForm();
                SplashScreenManager.CloseForm();
                Application.Run(MainForm);
            }
        }
    }
}
