namespace ContosoUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.smallLogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLoginTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPasswordTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlOKButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallLogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPasswordTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOKButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.smallLogoPictureEdit);
            this.layoutControl1.Controls.Add(this.okButton);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.passwordTextEdit);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(454, 175);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // smallLogoPictureEdit
            // 
            this.smallLogoPictureEdit.EditValue = ((object)(resources.GetObject("smallLogoPictureEdit.EditValue")));
            this.smallLogoPictureEdit.Location = new System.Drawing.Point(12, 12);
            this.smallLogoPictureEdit.Name = "smallLogoPictureEdit";
            this.smallLogoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.smallLogoPictureEdit.Size = new System.Drawing.Size(129, 151);
            this.smallLogoPictureEdit.StyleController = this.layoutControl1;
            this.smallLogoPictureEdit.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(150, 141);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(118, 22);
            this.okButton.StyleController = this.layoutControl1;
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(150, 98);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '●';
            this.passwordTextEdit.Size = new System.Drawing.Size(287, 20);
            this.passwordTextEdit.StyleController = this.layoutControl1;
            this.passwordTextEdit.TabIndex = 1;
            this.passwordTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextEdit_KeyPress);
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(150, 38);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(287, 20);
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.TabIndex = 2;
            this.loginTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextEdit_KeyPress);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLoginTextEdit,
            this.layoutControlPasswordTextEdit,
            this.layoutControlCancelButton,
            this.layoutControlOKButton,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(454, 175);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlLoginTextEdit
            // 
            this.layoutControlLoginTextEdit.Control = this.loginTextEdit;
            this.layoutControlLoginTextEdit.Location = new System.Drawing.Point(133, 0);
            this.layoutControlLoginTextEdit.MinSize = new System.Drawing.Size(151, 24);
            this.layoutControlLoginTextEdit.Name = "layoutControlLoginTextEdit";
            this.layoutControlLoginTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.layoutControlLoginTextEdit.Size = new System.Drawing.Size(301, 70);
            this.layoutControlLoginTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLoginTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLoginTextEdit.Text = "Login";
            this.layoutControlLoginTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLoginTextEdit.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlPasswordTextEdit
            // 
            this.layoutControlPasswordTextEdit.Control = this.passwordTextEdit;
            this.layoutControlPasswordTextEdit.Location = new System.Drawing.Point(133, 70);
            this.layoutControlPasswordTextEdit.MinSize = new System.Drawing.Size(151, 24);
            this.layoutControlPasswordTextEdit.Name = "layoutControlPasswordTextEdit";
            this.layoutControlPasswordTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.layoutControlPasswordTextEdit.Size = new System.Drawing.Size(301, 49);
            this.layoutControlPasswordTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlPasswordTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlPasswordTextEdit.Text = "Password";
            this.layoutControlPasswordTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlPasswordTextEdit.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlCancelButton
            // 
            this.layoutControlCancelButton.Control = this.cancelButton;
            this.layoutControlCancelButton.Location = new System.Drawing.Point(283, 119);
            this.layoutControlCancelButton.Name = "layoutControlCancelButton";
            this.layoutControlCancelButton.Padding = new DevExpress.XtraLayout.Utils.Padding(25, 7, 2, 2);
            this.layoutControlCancelButton.Size = new System.Drawing.Size(151, 36);
            this.layoutControlCancelButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCancelButton.TextVisible = false;
            // 
            // layoutControlOKButton
            // 
            this.layoutControlOKButton.Control = this.okButton;
            this.layoutControlOKButton.Location = new System.Drawing.Point(133, 119);
            this.layoutControlOKButton.Name = "layoutControlOKButton";
            this.layoutControlOKButton.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 25, 2, 2);
            this.layoutControlOKButton.Size = new System.Drawing.Size(150, 36);
            this.layoutControlOKButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlOKButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlOKButton.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.smallLogoPictureEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(133, 155);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 175);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smallLogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPasswordTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOKButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLoginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPasswordTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOKButton;
        private DevExpress.XtraEditors.PictureEdit smallLogoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

    }
}