namespace ContosoUI.ClientSearchForm
{
    partial class ClientListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListView));
            this.ribbonClientView = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchClientBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearClientBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageClientView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ClientFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlClientView = new DevExpress.XtraLayout.LayoutControl();
            this.clientsGridControl = new DevExpress.XtraGrid.GridControl();
            this.clientsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.middleNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addreddGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientStateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientCityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientLastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientFirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupClientView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlClientFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlClientsGridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlClientLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlClientCity = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientView)).BeginInit();
            this.layoutControlClientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientFirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientCity)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientView
            // 
            this.ribbonClientView.ExpandCollapseItem.Id = 0;
            this.ribbonClientView.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonClientView.ExpandCollapseItem,
            this.searchClientBarButton,
            this.clearClientBarButton});
            this.ribbonClientView.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientView.MaxItemId = 4;
            this.ribbonClientView.Name = "ribbonClientView";
            this.ribbonClientView.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageClientView});
            this.ribbonClientView.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonClientView.ShowCategoryInCaption = false;
            this.ribbonClientView.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonClientView.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonClientView.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonClientView.ShowQatLocationSelector = false;
            this.ribbonClientView.ShowToolbarCustomizeItem = false;
            this.ribbonClientView.Size = new System.Drawing.Size(1014, 122);
            this.ribbonClientView.StatusBar = this.ribbonStatusBar;
            this.ribbonClientView.Toolbar.ShowCustomizeItem = false;
            // 
            // searchClientBarButton
            // 
            this.searchClientBarButton.Caption = "Search";
            this.searchClientBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchClientBarButton.Glyph")));
            this.searchClientBarButton.Id = 2;
            this.searchClientBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchClientBarButton.LargeGlyph")));
            this.searchClientBarButton.Name = "searchClientBarButton";
            this.searchClientBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchClientBarButton_ItemClick);
            // 
            // clearClientBarButton
            // 
            this.clearClientBarButton.Caption = "Clear";
            this.clearClientBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearClientBarButton.Glyph")));
            this.clearClientBarButton.Id = 3;
            this.clearClientBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearClientBarButton.LargeGlyph")));
            this.clearClientBarButton.Name = "clearClientBarButton";
            this.clearClientBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearClientBarButton_ItemClick);
            // 
            // ribbonPageClientView
            // 
            this.ribbonPageClientView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ClientFileRibbonPageGroup});
            this.ribbonPageClientView.MergeOrder = 50;
            this.ribbonPageClientView.Name = "ribbonPageClientView";
            this.ribbonPageClientView.Text = "RibbonMerge";
            // 
            // ClientFileRibbonPageGroup
            // 
            this.ClientFileRibbonPageGroup.ItemLinks.Add(this.searchClientBarButton);
            this.ClientFileRibbonPageGroup.ItemLinks.Add(this.clearClientBarButton);
            this.ClientFileRibbonPageGroup.MergeOrder = 50;
            this.ClientFileRibbonPageGroup.Name = "ClientFileRibbonPageGroup";
            this.ClientFileRibbonPageGroup.Text = "Search";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonClientView;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlClientView
            // 
            this.layoutControlClientView.Controls.Add(this.clientsGridControl);
            this.layoutControlClientView.Controls.Add(this.clientCityTextEdit);
            this.layoutControlClientView.Controls.Add(this.clientLastNameTextEdit);
            this.layoutControlClientView.Controls.Add(this.clientFirstNameTextEdit);
            this.layoutControlClientView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlClientView.Location = new System.Drawing.Point(0, 122);
            this.layoutControlClientView.Name = "layoutControlClientView";
            this.layoutControlClientView.Root = this.layoutControlGroupClientView;
            this.layoutControlClientView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlClientView.TabIndex = 2;
            this.layoutControlClientView.Text = "layoutControl1";
            // 
            // clientsGridControl
            // 
            this.clientsGridControl.Location = new System.Drawing.Point(17, 67);
            this.clientsGridControl.MainView = this.clientsGridView;
            this.clientsGridControl.MenuManager = this.ribbonClientView;
            this.clientsGridControl.Name = "clientsGridControl";
            this.clientsGridControl.Size = new System.Drawing.Size(980, 530);
            this.clientsGridControl.TabIndex = 7;
            this.clientsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.clientsGridView});
            // 
            // clientsGridView
            // 
            this.clientsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.lastNameGridColumn,
            this.firstNameGridColumn,
            this.middleNameGridColumn,
            this.cityGridColumn,
            this.addreddGridColumn,
            this.clientStateGridColumn});
            this.clientsGridView.GridControl = this.clientsGridControl;
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.OptionsBehavior.Editable = false;
            this.clientsGridView.DoubleClick += new System.EventHandler(this.clientsGridView_DoubleClick);
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Last name";
            this.lastNameGridColumn.FieldName = "Person.LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 0;
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "First name";
            this.firstNameGridColumn.FieldName = "Person.FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 1;
            // 
            // middleNameGridColumn
            // 
            this.middleNameGridColumn.Caption = "Middle name";
            this.middleNameGridColumn.FieldName = "Person.MiddleName";
            this.middleNameGridColumn.Name = "middleNameGridColumn";
            this.middleNameGridColumn.Visible = true;
            this.middleNameGridColumn.VisibleIndex = 2;
            // 
            // cityGridColumn
            // 
            this.cityGridColumn.Caption = "City";
            this.cityGridColumn.FieldName = "ClientLocation.City";
            this.cityGridColumn.Name = "cityGridColumn";
            this.cityGridColumn.Visible = true;
            this.cityGridColumn.VisibleIndex = 3;
            // 
            // addreddGridColumn
            // 
            this.addreddGridColumn.Caption = "Address";
            this.addreddGridColumn.FieldName = "ClientLocation.Address";
            this.addreddGridColumn.Name = "addreddGridColumn";
            this.addreddGridColumn.Visible = true;
            this.addreddGridColumn.VisibleIndex = 4;
            // 
            // clientStateGridColumn
            // 
            this.clientStateGridColumn.Caption = "State";
            this.clientStateGridColumn.FieldName = "IsActive";
            this.clientStateGridColumn.Name = "clientStateGridColumn";
            this.clientStateGridColumn.Visible = true;
            this.clientStateGridColumn.VisibleIndex = 5;
            // 
            // clientCityTextEdit
            // 
            this.clientCityTextEdit.Location = new System.Drawing.Point(680, 33);
            this.clientCityTextEdit.MenuManager = this.ribbonClientView;
            this.clientCityTextEdit.Name = "clientCityTextEdit";
            this.clientCityTextEdit.Size = new System.Drawing.Size(317, 20);
            this.clientCityTextEdit.StyleController = this.layoutControlClientView;
            this.clientCityTextEdit.TabIndex = 6;
            this.clientCityTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientCityTextEdit_KeyPress);
            // 
            // clientLastNameTextEdit
            // 
            this.clientLastNameTextEdit.Location = new System.Drawing.Point(349, 33);
            this.clientLastNameTextEdit.MenuManager = this.ribbonClientView;
            this.clientLastNameTextEdit.Name = "clientLastNameTextEdit";
            this.clientLastNameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.clientLastNameTextEdit.StyleController = this.layoutControlClientView;
            this.clientLastNameTextEdit.TabIndex = 5;
            this.clientLastNameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientLastNameTextEdit_KeyPress);
            // 
            // clientFirstNameTextEdit
            // 
            this.clientFirstNameTextEdit.Location = new System.Drawing.Point(17, 33);
            this.clientFirstNameTextEdit.MenuManager = this.ribbonClientView;
            this.clientFirstNameTextEdit.Name = "clientFirstNameTextEdit";
            this.clientFirstNameTextEdit.Size = new System.Drawing.Size(318, 20);
            this.clientFirstNameTextEdit.StyleController = this.layoutControlClientView;
            this.clientFirstNameTextEdit.TabIndex = 4;
            this.clientFirstNameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientFirstNameTextEdit_KeyPress);
            // 
            // layoutControlGroupClientView
            // 
            this.layoutControlGroupClientView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupClientView.GroupBordersVisible = false;
            this.layoutControlGroupClientView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlClientFirstName,
            this.layoutControlClientsGridControl,
            this.layoutControlClientLastName,
            this.layoutControlClientCity});
            this.layoutControlGroupClientView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupClientView.Name = "layoutControlGroupClientView";
            this.layoutControlGroupClientView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroupClientView.TextVisible = false;
            // 
            // layoutControlClientFirstName
            // 
            this.layoutControlClientFirstName.Control = this.clientFirstNameTextEdit;
            this.layoutControlClientFirstName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlClientFirstName.Name = "layoutControlClientFirstName";
            this.layoutControlClientFirstName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientFirstName.Size = new System.Drawing.Size(332, 50);
            this.layoutControlClientFirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientFirstName.Text = "First name";
            this.layoutControlClientFirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientFirstName.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlClientsGridControl
            // 
            this.layoutControlClientsGridControl.Control = this.clientsGridControl;
            this.layoutControlClientsGridControl.Location = new System.Drawing.Point(0, 50);
            this.layoutControlClientsGridControl.Name = "layoutControlClientsGridControl";
            this.layoutControlClientsGridControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientsGridControl.Size = new System.Drawing.Size(994, 544);
            this.layoutControlClientsGridControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientsGridControl.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlClientsGridControl.TextVisible = false;
            // 
            // layoutControlClientLastName
            // 
            this.layoutControlClientLastName.Control = this.clientLastNameTextEdit;
            this.layoutControlClientLastName.Location = new System.Drawing.Point(332, 0);
            this.layoutControlClientLastName.Name = "layoutControlClientLastName";
            this.layoutControlClientLastName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLastName.Size = new System.Drawing.Size(331, 50);
            this.layoutControlClientLastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientLastName.Text = "Last name";
            this.layoutControlClientLastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLastName.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlClientCity
            // 
            this.layoutControlClientCity.Control = this.clientCityTextEdit;
            this.layoutControlClientCity.Location = new System.Drawing.Point(663, 0);
            this.layoutControlClientCity.Name = "layoutControlClientCity";
            this.layoutControlClientCity.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientCity.Size = new System.Drawing.Size(331, 50);
            this.layoutControlClientCity.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientCity.Text = "City";
            this.layoutControlClientCity.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientCity.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ClientListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlClientView);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonClientView);
            this.Name = "ClientListView";
            this.Ribbon = this.ribbonClientView;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Client Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientListView_FormClosed);
            this.Load += new System.EventHandler(this.ClientListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientView)).EndInit();
            this.layoutControlClientView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientFirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonClientView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageClientView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ClientFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControlClientView;
        private DevExpress.XtraEditors.TextEdit clientCityTextEdit;
        private DevExpress.XtraEditors.TextEdit clientLastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit clientFirstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupClientView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientFirstName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLastName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientCity;
        private DevExpress.XtraBars.BarButtonItem searchClientBarButton;
        private DevExpress.XtraBars.BarButtonItem clearClientBarButton;
        private DevExpress.XtraGrid.GridControl clientsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView clientsGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientsGridControl;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn cityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn middleNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addreddGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn clientStateGridColumn;
    }
}