namespace ContosoUI.UserSearchForm
{
    partial class UsersListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListView));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchUserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearUserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.userSearchRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.userRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlUsers = new DevExpress.XtraLayout.LayoutControl();
            this.usersGridControl = new DevExpress.XtraGrid.GridControl();
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.loginGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userStateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupUsers = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLoginTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlFirstNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLastNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlUsersGrid = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsers)).BeginInit();
            this.layoutControlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.searchUserBarButton,
            this.clearUserBarButton});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 5;
            this.mainRibbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.userSearchRibbonPage});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(1014, 122);
            this.mainRibbon.StatusBar = this.usersRibbonStatusBar;
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // searchUserBarButton
            // 
            this.searchUserBarButton.Caption = "Search";
            this.searchUserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchUserBarButton.Glyph")));
            this.searchUserBarButton.Id = 2;
            this.searchUserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchUserBarButton.LargeGlyph")));
            this.searchUserBarButton.Name = "searchUserBarButton";
            this.searchUserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchUserBarButton_ItemClick);
            // 
            // clearUserBarButton
            // 
            this.clearUserBarButton.Caption = "Clear";
            this.clearUserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearUserBarButton.Glyph")));
            this.clearUserBarButton.Id = 3;
            this.clearUserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearUserBarButton.LargeGlyph")));
            this.clearUserBarButton.Name = "clearUserBarButton";
            this.clearUserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearUserBarButton_ItemClick);
            // 
            // userSearchRibbonPage
            // 
            this.userSearchRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.userRibbonPageGroup});
            this.userSearchRibbonPage.MergeOrder = 50;
            this.userSearchRibbonPage.Name = "userSearchRibbonPage";
            this.userSearchRibbonPage.Text = "RibbonMerge";
            // 
            // userRibbonPageGroup
            // 
            this.userRibbonPageGroup.ItemLinks.Add(this.searchUserBarButton);
            this.userRibbonPageGroup.ItemLinks.Add(this.clearUserBarButton);
            this.userRibbonPageGroup.MergeOrder = 50;
            this.userRibbonPageGroup.Name = "userRibbonPageGroup";
            this.userRibbonPageGroup.Text = "Search";
            // 
            // usersRibbonStatusBar
            // 
            this.usersRibbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.usersRibbonStatusBar.Name = "usersRibbonStatusBar";
            this.usersRibbonStatusBar.Ribbon = this.mainRibbon;
            this.usersRibbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlUsers
            // 
            this.layoutControlUsers.Controls.Add(this.usersGridControl);
            this.layoutControlUsers.Controls.Add(this.lastNameTextEdit);
            this.layoutControlUsers.Controls.Add(this.firstNameTextEdit);
            this.layoutControlUsers.Controls.Add(this.loginTextEdit);
            this.layoutControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlUsers.Location = new System.Drawing.Point(0, 122);
            this.layoutControlUsers.Name = "layoutControlUsers";
            this.layoutControlUsers.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(573, 123, 250, 350);
            this.layoutControlUsers.Root = this.layoutControlGroupUsers;
            this.layoutControlUsers.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlUsers.TabIndex = 2;
            this.layoutControlUsers.Text = "layoutControl1";
            // 
            // usersGridControl
            // 
            this.usersGridControl.Location = new System.Drawing.Point(17, 67);
            this.usersGridControl.MainView = this.usersGridView;
            this.usersGridControl.MenuManager = this.mainRibbon;
            this.usersGridControl.Name = "usersGridControl";
            this.usersGridControl.Size = new System.Drawing.Size(980, 530);
            this.usersGridControl.TabIndex = 7;
            this.usersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // usersGridView
            // 
            this.usersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.loginGridColumn,
            this.lastNameGridColumn,
            this.firstNameGridColumn,
            this.roleGridColumn,
            this.userStateGridColumn});
            this.usersGridView.GridControl = this.usersGridControl;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsBehavior.Editable = false;
            this.usersGridView.DoubleClick += new System.EventHandler(this.usersGridView_DoubleClick);
            // 
            // loginGridColumn
            // 
            this.loginGridColumn.Caption = "Login";
            this.loginGridColumn.FieldName = "Login";
            this.loginGridColumn.Name = "loginGridColumn";
            this.loginGridColumn.Visible = true;
            this.loginGridColumn.VisibleIndex = 0;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Last name";
            this.lastNameGridColumn.FieldName = "Person.LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 1;
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "First name";
            this.firstNameGridColumn.FieldName = "Person.FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 2;
            // 
            // roleGridColumn
            // 
            this.roleGridColumn.Caption = "Role";
            this.roleGridColumn.FieldName = "Role.Title";
            this.roleGridColumn.Name = "roleGridColumn";
            this.roleGridColumn.Visible = true;
            this.roleGridColumn.VisibleIndex = 3;
            // 
            // userStateGridColumn
            // 
            this.userStateGridColumn.Caption = "State";
            this.userStateGridColumn.FieldName = "IsActive";
            this.userStateGridColumn.Name = "userStateGridColumn";
            this.userStateGridColumn.Visible = true;
            this.userStateGridColumn.VisibleIndex = 4;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(680, 33);
            this.lastNameTextEdit.MenuManager = this.mainRibbon;
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.lastNameTextEdit.StyleController = this.layoutControlUsers;
            this.lastNameTextEdit.TabIndex = 6;
            this.lastNameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextEdit_KeyPress);
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(349, 33);
            this.firstNameTextEdit.MenuManager = this.mainRibbon;
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.firstNameTextEdit.StyleController = this.layoutControlUsers;
            this.firstNameTextEdit.TabIndex = 5;
            this.firstNameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextEdit_KeyPress);
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(17, 33);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(318, 20);
            this.loginTextEdit.StyleController = this.layoutControlUsers;
            this.loginTextEdit.TabIndex = 4;
            this.loginTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextEdit_KeyPress);
            // 
            // layoutControlGroupUsers
            // 
            this.layoutControlGroupUsers.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupUsers.GroupBordersVisible = false;
            this.layoutControlGroupUsers.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLoginTextEdit,
            this.layoutControlFirstNameTextEdit,
            this.layoutControlLastNameTextEdit,
            this.layoutControlUsersGrid});
            this.layoutControlGroupUsers.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupUsers.Name = "layoutControlGroupUsers";
            this.layoutControlGroupUsers.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroupUsers.TextVisible = false;
            // 
            // layoutControlLoginTextEdit
            // 
            this.layoutControlLoginTextEdit.Control = this.loginTextEdit;
            this.layoutControlLoginTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlLoginTextEdit.Name = "layoutControlLoginTextEdit";
            this.layoutControlLoginTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLoginTextEdit.Size = new System.Drawing.Size(332, 50);
            this.layoutControlLoginTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLoginTextEdit.Text = "Login";
            this.layoutControlLoginTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLoginTextEdit.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlFirstNameTextEdit
            // 
            this.layoutControlFirstNameTextEdit.Control = this.firstNameTextEdit;
            this.layoutControlFirstNameTextEdit.Location = new System.Drawing.Point(332, 0);
            this.layoutControlFirstNameTextEdit.Name = "layoutControlFirstNameTextEdit";
            this.layoutControlFirstNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlFirstNameTextEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlFirstNameTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlFirstNameTextEdit.Text = "First name";
            this.layoutControlFirstNameTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlFirstNameTextEdit.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlLastNameTextEdit
            // 
            this.layoutControlLastNameTextEdit.Control = this.lastNameTextEdit;
            this.layoutControlLastNameTextEdit.Location = new System.Drawing.Point(663, 0);
            this.layoutControlLastNameTextEdit.Name = "layoutControlLastNameTextEdit";
            this.layoutControlLastNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLastNameTextEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlLastNameTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLastNameTextEdit.Text = "Last name";
            this.layoutControlLastNameTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLastNameTextEdit.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlUsersGrid
            // 
            this.layoutControlUsersGrid.Control = this.usersGridControl;
            this.layoutControlUsersGrid.Location = new System.Drawing.Point(0, 50);
            this.layoutControlUsersGrid.Name = "layoutControlUsersGrid";
            this.layoutControlUsersGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlUsersGrid.Size = new System.Drawing.Size(994, 544);
            this.layoutControlUsersGrid.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlUsersGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlUsersGrid.TextVisible = false;
            // 
            // UsersListView
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlUsers);
            this.Controls.Add(this.usersRibbonStatusBar);
            this.Controls.Add(this.mainRibbon);
            this.Name = "UsersListView";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.usersRibbonStatusBar;
            this.Text = "User Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersListView_FormClosed);
            this.Load += new System.EventHandler(this.UsersListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsers)).EndInit();
            this.layoutControlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage userSearchRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup userRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar usersRibbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControlUsers;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupUsers;
        private DevExpress.XtraGrid.GridControl usersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLoginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlFirstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLastNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUsersGrid;
        private DevExpress.XtraBars.BarButtonItem searchUserBarButton;
        private DevExpress.XtraBars.BarButtonItem clearUserBarButton;
        private DevExpress.XtraGrid.Columns.GridColumn loginGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn roleGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn userStateGridColumn;
    }
}