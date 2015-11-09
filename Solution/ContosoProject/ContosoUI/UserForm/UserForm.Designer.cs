using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace ContosoUI.UserForm
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSaveButton = new DevExpress.XtraBars.BarButtonItem();
            this.barSaveAndNewButton = new DevExpress.XtraBars.BarButtonItem();
            this.barNewButton = new DevExpress.XtraBars.BarButtonItem();
            this.userStateButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageUserGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageUserFileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.permissionListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.roleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlEntireGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlLoginDataGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlLoginDataGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLoginTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPasswordTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlRoleComboBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroupPersonalData = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlPersonDataGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlFirstNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.middleNameLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLastNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroupLoginData = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroupPermissions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlPermissionsListBox = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEntireGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlLoginDataGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginDataGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPasswordTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlRoleComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupPersonalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPersonDataGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupLoginData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPermissionsListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barSaveButton,
            this.barSaveAndNewButton,
            this.barNewButton,
            this.userStateButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1014, 122);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barSaveButton
            // 
            this.barSaveButton.Caption = "Save";
            this.barSaveButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveButton.Glyph")));
            this.barSaveButton.Id = 2;
            this.barSaveButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveButton.LargeGlyph")));
            this.barSaveButton.Name = "barSaveButton";
            this.barSaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSaveButton_ItemClick);
            // 
            // barSaveAndNewButton
            // 
            this.barSaveAndNewButton.Caption = "Save and New";
            this.barSaveAndNewButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewButton.Glyph")));
            this.barSaveAndNewButton.Id = 4;
            this.barSaveAndNewButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewButton.LargeGlyph")));
            this.barSaveAndNewButton.Name = "barSaveAndNewButton";
            this.barSaveAndNewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSaveAndNewButton_ItemClick);
            // 
            // barNewButton
            // 
            this.barNewButton.Caption = "New";
            this.barNewButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barNewButton.Glyph")));
            this.barNewButton.Id = 5;
            this.barNewButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNewButton.LargeGlyph")));
            this.barNewButton.Name = "barNewButton";
            this.barNewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNewButton_ItemClick);
            // 
            // userStateButton
            // 
            this.userStateButton.Caption = "Remove";
            this.userStateButton.Glyph = ((System.Drawing.Image)(resources.GetObject("userStateButton.Glyph")));
            this.userStateButton.Id = 6;
            this.userStateButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userStateButton.LargeGlyph")));
            this.userStateButton.LargeImageIndex = 100;
            this.userStateButton.Name = "userStateButton";
            this.userStateButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stateButton_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageUserGroup,
            this.ribbonPageUserFileGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "RibbonMerge";
            // 
            // ribbonPageUserGroup
            // 
            this.ribbonPageUserGroup.ItemLinks.Add(this.barSaveButton);
            this.ribbonPageUserGroup.ItemLinks.Add(this.barSaveAndNewButton);
            this.ribbonPageUserGroup.ItemLinks.Add(this.barNewButton);
            this.ribbonPageUserGroup.MergeOrder = 50;
            this.ribbonPageUserGroup.Name = "ribbonPageUserGroup";
            this.ribbonPageUserGroup.Text = "User";
            // 
            // ribbonPageUserFileGroup
            // 
            this.ribbonPageUserFileGroup.ItemLinks.Add(this.userStateButton);
            this.ribbonPageUserFileGroup.MergeOrder = 60;
            this.ribbonPageUserFileGroup.Name = "ribbonPageUserFileGroup";
            this.ribbonPageUserFileGroup.Text = "Edit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.permissionListBoxControl);
            this.layoutControl.Controls.Add(this.lastNameTextEdit);
            this.layoutControl.Controls.Add(this.middleNameTextEdit);
            this.layoutControl.Controls.Add(this.firstNameTextEdit);
            this.layoutControl.Controls.Add(this.passwordTextEdit);
            this.layoutControl.Controls.Add(this.loginTextEdit);
            this.layoutControl.Controls.Add(this.roleLookUpEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 122);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(275, 431, 250, 350);
            this.layoutControl.Root = this.layoutControlEntireGroup;
            this.layoutControl.Size = new System.Drawing.Size(1014, 614);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl";
            // 
            // permissionListBoxControl
            // 
            this.permissionListBoxControl.Location = new System.Drawing.Point(532, 51);
            this.permissionListBoxControl.Name = "permissionListBoxControl";
            this.permissionListBoxControl.Size = new System.Drawing.Size(453, 534);
            this.permissionListBoxControl.StyleController = this.layoutControl;
            this.permissionListBoxControl.TabIndex = 5;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(29, 363);
            this.lastNameTextEdit.MenuManager = this.ribbon;
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(465, 20);
            this.lastNameTextEdit.StyleController = this.layoutControl;
            this.lastNameTextEdit.TabIndex = 9;
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.Location = new System.Drawing.Point(29, 313);
            this.middleNameTextEdit.MenuManager = this.ribbon;
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Size = new System.Drawing.Size(465, 20);
            this.middleNameTextEdit.StyleController = this.layoutControl;
            this.middleNameTextEdit.TabIndex = 8;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(29, 263);
            this.firstNameTextEdit.MenuManager = this.ribbon;
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(465, 20);
            this.firstNameTextEdit.StyleController = this.layoutControl;
            this.firstNameTextEdit.TabIndex = 7;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(29, 117);
            this.passwordTextEdit.MenuManager = this.ribbon;
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '●';
            this.passwordTextEdit.Size = new System.Drawing.Size(465, 20);
            this.passwordTextEdit.StyleController = this.layoutControl;
            this.passwordTextEdit.TabIndex = 5;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(29, 67);
            this.loginTextEdit.MenuManager = this.ribbon;
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(465, 20);
            this.loginTextEdit.StyleController = this.layoutControl;
            this.loginTextEdit.TabIndex = 4;
            // 
            // roleLookUpEdit
            // 
            this.roleLookUpEdit.Location = new System.Drawing.Point(29, 167);
            this.roleLookUpEdit.MenuManager = this.ribbon;
            this.roleLookUpEdit.Name = "roleLookUpEdit";
            this.roleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roleLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title")});
            this.roleLookUpEdit.Properties.DataSource = this.roleBindingSource;
            this.roleLookUpEdit.Properties.DisplayMember = "Title";
            this.roleLookUpEdit.Properties.NullText = "";
            this.roleLookUpEdit.Properties.PopupSizeable = false;
            this.roleLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.roleLookUpEdit.Properties.ValueMember = "Title";
            this.roleLookUpEdit.Size = new System.Drawing.Size(465, 20);
            this.roleLookUpEdit.StyleController = this.layoutControl;
            this.roleLookUpEdit.TabIndex = 6;
            this.roleLookUpEdit.EditValueChanged += new System.EventHandler(this.roleLookUpEdit_EditValueChanged);
            this.roleLookUpEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.roleLookUpEdit_EditValueChanging);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Domain.Entities.Users.Role);
            // 
            // layoutControlEntireGroup
            // 
            this.layoutControlEntireGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlEntireGroup.GroupBordersVisible = false;
            this.layoutControlEntireGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlLoginDataGroup,
            this.tabbedControlGroupPersonalData,
            this.tabbedControlGroupLoginData});
            this.layoutControlEntireGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlEntireGroup.Name = "layoutControlEntireGroup";
            this.layoutControlEntireGroup.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlEntireGroup.TextVisible = false;
            // 
            // tabbedControlLoginDataGroup
            // 
            this.tabbedControlLoginDataGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlLoginDataGroup.Name = "tabbedControlLoginDataGroup";
            this.tabbedControlLoginDataGroup.SelectedTabPage = this.layoutControlLoginDataGroup;
            this.tabbedControlLoginDataGroup.SelectedTabPageIndex = 0;
            this.tabbedControlLoginDataGroup.Size = new System.Drawing.Size(503, 196);
            this.tabbedControlLoginDataGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLoginDataGroup});
            // 
            // layoutControlLoginDataGroup
            // 
            this.layoutControlLoginDataGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLoginTextEdit,
            this.layoutControlPasswordTextEdit,
            this.layoutControlRoleComboBox});
            this.layoutControlLoginDataGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlLoginDataGroup.Name = "layoutControlLoginDataGroup";
            this.layoutControlLoginDataGroup.Size = new System.Drawing.Size(479, 150);
            this.layoutControlLoginDataGroup.Text = "Login data";
            // 
            // layoutControlLoginTextEdit
            // 
            this.layoutControlLoginTextEdit.Control = this.loginTextEdit;
            this.layoutControlLoginTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlLoginTextEdit.Name = "layoutControlLoginTextEdit";
            this.layoutControlLoginTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLoginTextEdit.Size = new System.Drawing.Size(479, 50);
            this.layoutControlLoginTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLoginTextEdit.Text = "Login";
            this.layoutControlLoginTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLoginTextEdit.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlPasswordTextEdit
            // 
            this.layoutControlPasswordTextEdit.Control = this.passwordTextEdit;
            this.layoutControlPasswordTextEdit.Location = new System.Drawing.Point(0, 50);
            this.layoutControlPasswordTextEdit.Name = "layoutControlPasswordTextEdit";
            this.layoutControlPasswordTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlPasswordTextEdit.Size = new System.Drawing.Size(479, 50);
            this.layoutControlPasswordTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlPasswordTextEdit.Text = "Password";
            this.layoutControlPasswordTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlPasswordTextEdit.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlRoleComboBox
            // 
            this.layoutControlRoleComboBox.Control = this.roleLookUpEdit;
            this.layoutControlRoleComboBox.Location = new System.Drawing.Point(0, 100);
            this.layoutControlRoleComboBox.Name = "layoutControlRoleComboBox";
            this.layoutControlRoleComboBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlRoleComboBox.Size = new System.Drawing.Size(479, 50);
            this.layoutControlRoleComboBox.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlRoleComboBox.Text = "Role";
            this.layoutControlRoleComboBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlRoleComboBox.TextSize = new System.Drawing.Size(59, 13);
            // 
            // tabbedControlGroupPersonalData
            // 
            this.tabbedControlGroupPersonalData.Location = new System.Drawing.Point(0, 196);
            this.tabbedControlGroupPersonalData.Name = "tabbedControlGroupPersonalData";
            this.tabbedControlGroupPersonalData.SelectedTabPage = this.layoutControlPersonDataGroup;
            this.tabbedControlGroupPersonalData.SelectedTabPageIndex = 0;
            this.tabbedControlGroupPersonalData.Size = new System.Drawing.Size(503, 398);
            this.tabbedControlGroupPersonalData.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlPersonDataGroup});
            // 
            // layoutControlPersonDataGroup
            // 
            this.layoutControlPersonDataGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlFirstNameTextEdit,
            this.middleNameLayoutControl,
            this.layoutControlLastNameTextEdit});
            this.layoutControlPersonDataGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPersonDataGroup.Name = "layoutControlPersonDataGroup";
            this.layoutControlPersonDataGroup.Size = new System.Drawing.Size(479, 352);
            this.layoutControlPersonDataGroup.Text = "Personal data";
            // 
            // layoutControlFirstNameTextEdit
            // 
            this.layoutControlFirstNameTextEdit.Control = this.firstNameTextEdit;
            this.layoutControlFirstNameTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlFirstNameTextEdit.Name = "layoutControlFirstNameTextEdit";
            this.layoutControlFirstNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlFirstNameTextEdit.Size = new System.Drawing.Size(479, 50);
            this.layoutControlFirstNameTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlFirstNameTextEdit.Text = "First name";
            this.layoutControlFirstNameTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlFirstNameTextEdit.TextSize = new System.Drawing.Size(59, 13);
            // 
            // middleNameLayoutControl
            // 
            this.middleNameLayoutControl.Control = this.middleNameTextEdit;
            this.middleNameLayoutControl.Location = new System.Drawing.Point(0, 50);
            this.middleNameLayoutControl.Name = "middleNameLayoutControl";
            this.middleNameLayoutControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.middleNameLayoutControl.Size = new System.Drawing.Size(479, 50);
            this.middleNameLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.middleNameLayoutControl.Text = "Middle name";
            this.middleNameLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.middleNameLayoutControl.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlLastNameTextEdit
            // 
            this.layoutControlLastNameTextEdit.Control = this.lastNameTextEdit;
            this.layoutControlLastNameTextEdit.Location = new System.Drawing.Point(0, 100);
            this.layoutControlLastNameTextEdit.Name = "layoutControlLastNameTextEdit";
            this.layoutControlLastNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLastNameTextEdit.Size = new System.Drawing.Size(479, 252);
            this.layoutControlLastNameTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLastNameTextEdit.Text = "Last name";
            this.layoutControlLastNameTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLastNameTextEdit.TextSize = new System.Drawing.Size(59, 13);
            // 
            // tabbedControlGroupLoginData
            // 
            this.tabbedControlGroupLoginData.Location = new System.Drawing.Point(503, 0);
            this.tabbedControlGroupLoginData.Name = "tabbedControlGroupLoginData";
            this.tabbedControlGroupLoginData.SelectedTabPage = this.layoutControlGroupPermissions;
            this.tabbedControlGroupLoginData.SelectedTabPageIndex = 0;
            this.tabbedControlGroupLoginData.Size = new System.Drawing.Size(491, 594);
            this.tabbedControlGroupLoginData.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupPermissions});
            // 
            // layoutControlGroupPermissions
            // 
            this.layoutControlGroupPermissions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlPermissionsListBox});
            this.layoutControlGroupPermissions.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupPermissions.Name = "layoutControlGroupPermissions";
            this.layoutControlGroupPermissions.Size = new System.Drawing.Size(467, 548);
            this.layoutControlGroupPermissions.Text = "Permissions";
            // 
            // layoutControlPermissionsListBox
            // 
            this.layoutControlPermissionsListBox.Control = this.permissionListBoxControl;
            this.layoutControlPermissionsListBox.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPermissionsListBox.Name = "layoutControlPermissionsListBox";
            this.layoutControlPermissionsListBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlPermissionsListBox.Size = new System.Drawing.Size(467, 548);
            this.layoutControlPermissionsListBox.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlPermissionsListBox.Text = "Permissions";
            this.layoutControlPermissionsListBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlPermissionsListBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlPermissionsListBox.TextVisible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "UserForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "User View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEntireGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlLoginDataGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginDataGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPasswordTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlRoleComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupPersonalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPersonDataGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupLoginData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPermissionsListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPage;
        private RibbonPageGroup ribbonPageUserGroup;
        private RibbonStatusBar ribbonStatusBar;
        private BarButtonItem barSaveButton;
        private LayoutControl layoutControl;
        private TextEdit lastNameTextEdit;
        private TextEdit middleNameTextEdit;
        private TextEdit firstNameTextEdit;
        private TextEdit passwordTextEdit;
        private TextEdit loginTextEdit;
        private LayoutControlGroup layoutControlEntireGroup;
        private TabbedControlGroup tabbedControlLoginDataGroup;
        private LayoutControlGroup layoutControlLoginDataGroup;
        private LayoutControlItem layoutControlLoginTextEdit;
        private LayoutControlItem layoutControlPasswordTextEdit;
        private LayoutControlItem layoutControlRoleComboBox;
        private BarButtonItem barSaveAndNewButton;
        private BarButtonItem barNewButton;
        private ListBoxControl permissionListBoxControl;
        private TabbedControlGroup tabbedControlGroupPersonalData;
        private LayoutControlGroup layoutControlPersonDataGroup;
        private LayoutControlItem layoutControlFirstNameTextEdit;
        private LayoutControlItem middleNameLayoutControl;
        private LayoutControlItem layoutControlLastNameTextEdit;
        private BarButtonItem userStateButton;
        private RibbonPageGroup ribbonPageUserFileGroup;
        private LookUpEdit roleLookUpEdit;
        private BindingSource roleBindingSource;
        private TabbedControlGroup tabbedControlGroupLoginData;
        private LayoutControlGroup layoutControlGroupPermissions;
        private LayoutControlItem layoutControlPermissionsListBox;
    }
}