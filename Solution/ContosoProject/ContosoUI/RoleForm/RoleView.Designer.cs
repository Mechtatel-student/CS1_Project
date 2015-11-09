namespace ContosoUI.RoleForm
{
    partial class RoleView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSaveButton = new DevExpress.XtraBars.BarButtonItem();
            this.barAddButton = new DevExpress.XtraBars.BarButtonItem();
            this.rolePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonFilePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonRolePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.roleLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.roleGridControl = new DevExpress.XtraGrid.GridControl();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.permissionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.roleLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutPermissionsListCheckBoxControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutRoleGridControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).BeginInit();
            this.roleLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPermissionsListCheckBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRoleGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barSaveButton,
            this.barAddButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rolePage});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1050, 122);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barSaveButton
            // 
            this.barSaveButton.Caption = "Save";
            this.barSaveButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveButton.Glyph")));
            this.barSaveButton.Id = 1;
            this.barSaveButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveButton.LargeGlyph")));
            this.barSaveButton.Name = "barSaveButton";
            this.barSaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSaveButton_ItemClick);
            // 
            // barAddButton
            // 
            this.barAddButton.Caption = "Add role";
            this.barAddButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barAddButton.Glyph")));
            this.barAddButton.Id = 5;
            this.barAddButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barAddButton.LargeGlyph")));
            this.barAddButton.Name = "barAddButton";
            this.barAddButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAddButton_ItemClick);
            // 
            // rolePage
            // 
            this.rolePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonFilePageGroup,
            this.ribbonRolePageGroup});
            this.rolePage.Name = "rolePage";
            this.rolePage.Text = "RibbonMerge";
            // 
            // ribbonFilePageGroup
            // 
            this.ribbonFilePageGroup.ItemLinks.Add(this.barSaveButton);
            this.ribbonFilePageGroup.MergeOrder = 50;
            this.ribbonFilePageGroup.Name = "ribbonFilePageGroup";
            this.ribbonFilePageGroup.Text = "Role";
            // 
            // ribbonRolePageGroup
            // 
            this.ribbonRolePageGroup.ItemLinks.Add(this.barAddButton);
            this.ribbonRolePageGroup.MergeOrder = 60;
            this.ribbonRolePageGroup.Name = "ribbonRolePageGroup";
            this.ribbonRolePageGroup.Text = "Edit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 436);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1050, 31);
            // 
            // roleLayoutControl
            // 
            this.roleLayoutControl.Controls.Add(this.roleGridControl);
            this.roleLayoutControl.Controls.Add(this.permissionsCheckedListBox);
            this.roleLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleLayoutControl.Location = new System.Drawing.Point(0, 122);
            this.roleLayoutControl.Name = "roleLayoutControl";
            this.roleLayoutControl.Root = this.roleLayoutControlGroup;
            this.roleLayoutControl.Size = new System.Drawing.Size(1050, 314);
            this.roleLayoutControl.TabIndex = 2;
            this.roleLayoutControl.Text = "layoutControl1";
            // 
            // roleGridControl
            // 
            this.roleGridControl.DataSource = this.roleBindingSource;
            this.roleGridControl.Location = new System.Drawing.Point(17, 33);
            this.roleGridControl.MainView = this.roleGridView;
            this.roleGridControl.MenuManager = this.ribbon;
            this.roleGridControl.Name = "roleGridControl";
            this.roleGridControl.Size = new System.Drawing.Size(465, 264);
            this.roleGridControl.TabIndex = 7;
            this.roleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roleGridView});
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Domain.Entities.Users.Role);
            // 
            // roleGridView
            // 
            this.roleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colPermissions,
            this.colId,
            this.colIsActive});
            this.roleGridView.GridControl = this.roleGridControl;
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.OptionsView.ShowGroupPanel = false;
            this.roleGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.roleGridView_FocusedRowChanged);
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 309;
            // 
            // colPermissions
            // 
            this.colPermissions.FieldName = "Permissions";
            this.colPermissions.Name = "colPermissions";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 1;
            this.colIsActive.Width = 138;
            // 
            // permissionsCheckedListBox
            // 
            this.permissionsCheckedListBox.FormattingEnabled = true;
            this.permissionsCheckedListBox.Location = new System.Drawing.Point(496, 33);
            this.permissionsCheckedListBox.Name = "permissionsCheckedListBox";
            this.permissionsCheckedListBox.Size = new System.Drawing.Size(537, 260);
            this.permissionsCheckedListBox.TabIndex = 6;
            this.permissionsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.permissionsCheckedListBox_ItemCheck);
            // 
            // roleLayoutControlGroup
            // 
            this.roleLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.roleLayoutControlGroup.GroupBordersVisible = false;
            this.roleLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutPermissionsListCheckBoxControl,
            this.layoutRoleGridControl});
            this.roleLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.roleLayoutControlGroup.Name = "roleLayoutControlGroup";
            this.roleLayoutControlGroup.Size = new System.Drawing.Size(1050, 314);
            this.roleLayoutControlGroup.TextVisible = false;
            // 
            // layoutPermissionsListCheckBoxControl
            // 
            this.layoutPermissionsListCheckBoxControl.Control = this.permissionsCheckedListBox;
            this.layoutPermissionsListCheckBoxControl.Location = new System.Drawing.Point(479, 0);
            this.layoutPermissionsListCheckBoxControl.Name = "layoutPermissionsListCheckBoxControl";
            this.layoutPermissionsListCheckBoxControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutPermissionsListCheckBoxControl.Size = new System.Drawing.Size(551, 294);
            this.layoutPermissionsListCheckBoxControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutPermissionsListCheckBoxControl.Text = "Permissions";
            this.layoutPermissionsListCheckBoxControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutPermissionsListCheckBoxControl.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutRoleGridControl
            // 
            this.layoutRoleGridControl.Control = this.roleGridControl;
            this.layoutRoleGridControl.Location = new System.Drawing.Point(0, 0);
            this.layoutRoleGridControl.Name = "layoutRoleGridControl";
            this.layoutRoleGridControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutRoleGridControl.Size = new System.Drawing.Size(479, 294);
            this.layoutRoleGridControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutRoleGridControl.Text = "Avalaible Roles";
            this.layoutRoleGridControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutRoleGridControl.TextSize = new System.Drawing.Size(72, 13);
            // 
            // RoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 467);
            this.Controls.Add(this.roleLayoutControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "RoleView";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Roles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoleView_FormClosed);
            this.Load += new System.EventHandler(this.RoleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).EndInit();
            this.roleLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPermissionsListCheckBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRoleGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rolePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonFilePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barSaveButton;
        private DevExpress.XtraLayout.LayoutControl roleLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup roleLayoutControlGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonRolePageGroup;
        private DevExpress.XtraBars.BarButtonItem barAddButton;
        private DevExpress.XtraGrid.GridControl roleGridControl;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView roleGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private System.Windows.Forms.CheckedListBox permissionsCheckedListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutPermissionsListCheckBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutRoleGridControl;
    }
}