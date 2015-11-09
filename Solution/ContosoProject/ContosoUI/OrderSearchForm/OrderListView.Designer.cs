namespace ContosoUI.OrderSearchForm
{
    partial class OrderListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListView));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchOrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearOrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageOrderSearch = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.OrderViewFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarOrderView = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlOrderView = new DevExpress.XtraLayout.LayoutControl();
            this.orderStatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.orderItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderStateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupOrderView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderNumberTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlOrderItemsGridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlClientLookUpEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlOrderStatus = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderView)).BeginInit();
            this.layoutControlOrderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.searchOrderBarButton,
            this.clearOrderBarButton});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 4;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrderSearch});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(1014, 122);
            this.mainRibbon.StatusBar = this.ribbonStatusBarOrderView;
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // searchOrderBarButton
            // 
            this.searchOrderBarButton.Caption = "Search";
            this.searchOrderBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchOrderBarButton.Glyph")));
            this.searchOrderBarButton.Id = 2;
            this.searchOrderBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchOrderBarButton.LargeGlyph")));
            this.searchOrderBarButton.Name = "searchOrderBarButton";
            this.searchOrderBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchOrderBarButton_ItemClick);
            // 
            // clearOrderBarButton
            // 
            this.clearOrderBarButton.Caption = "Clear";
            this.clearOrderBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearOrderBarButton.Glyph")));
            this.clearOrderBarButton.Id = 3;
            this.clearOrderBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearOrderBarButton.LargeGlyph")));
            this.clearOrderBarButton.Name = "clearOrderBarButton";
            this.clearOrderBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearButton_ItemClick);
            // 
            // ribbonPageOrderSearch
            // 
            this.ribbonPageOrderSearch.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.OrderViewFileRibbonPageGroup});
            this.ribbonPageOrderSearch.MergeOrder = 50;
            this.ribbonPageOrderSearch.Name = "ribbonPageOrderSearch";
            this.ribbonPageOrderSearch.Text = "RibbonMerge";
            // 
            // OrderViewFileRibbonPageGroup
            // 
            this.OrderViewFileRibbonPageGroup.ItemLinks.Add(this.searchOrderBarButton);
            this.OrderViewFileRibbonPageGroup.ItemLinks.Add(this.clearOrderBarButton);
            this.OrderViewFileRibbonPageGroup.MergeOrder = 50;
            this.OrderViewFileRibbonPageGroup.Name = "OrderViewFileRibbonPageGroup";
            this.OrderViewFileRibbonPageGroup.Text = "Search";
            // 
            // ribbonStatusBarOrderView
            // 
            this.ribbonStatusBarOrderView.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBarOrderView.Name = "ribbonStatusBarOrderView";
            this.ribbonStatusBarOrderView.Ribbon = this.mainRibbon;
            this.ribbonStatusBarOrderView.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlOrderView
            // 
            this.layoutControlOrderView.Controls.Add(this.orderStatusComboBoxEdit);
            this.layoutControlOrderView.Controls.Add(this.clientLookUpEdit);
            this.layoutControlOrderView.Controls.Add(this.orderItemsGridControl);
            this.layoutControlOrderView.Controls.Add(this.orderNumberTextEdit);
            this.layoutControlOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlOrderView.Location = new System.Drawing.Point(0, 122);
            this.layoutControlOrderView.Name = "layoutControlOrderView";
            this.layoutControlOrderView.Root = this.layoutControlGroupOrderView;
            this.layoutControlOrderView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlOrderView.TabIndex = 2;
            this.layoutControlOrderView.Text = "layoutControl1";
            // 
            // orderStatusComboBoxEdit
            // 
            this.orderStatusComboBoxEdit.Location = new System.Drawing.Point(349, 33);
            this.orderStatusComboBoxEdit.MenuManager = this.mainRibbon;
            this.orderStatusComboBoxEdit.Name = "orderStatusComboBoxEdit";
            this.orderStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderStatusComboBoxEdit.Size = new System.Drawing.Size(317, 20);
            this.orderStatusComboBoxEdit.StyleController = this.layoutControlOrderView;
            this.orderStatusComboBoxEdit.TabIndex = 9;
            this.orderStatusComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.orderStatusComboBoxEdit_SelectedIndexChanged);
            this.orderStatusComboBoxEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderStatusComboBoxEdit_KeyPress);
            // 
            // clientLookUpEdit
            // 
            this.clientLookUpEdit.EditValue = "<Null>";
            this.clientLookUpEdit.Location = new System.Drawing.Point(680, 33);
            this.clientLookUpEdit.MenuManager = this.mainRibbon;
            this.clientLookUpEdit.Name = "clientLookUpEdit";
            this.clientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Person", "Client")});
            this.clientLookUpEdit.Size = new System.Drawing.Size(317, 20);
            this.clientLookUpEdit.StyleController = this.layoutControlOrderView;
            this.clientLookUpEdit.TabIndex = 8;
            // 
            // orderItemsGridControl
            // 
            this.orderItemsGridControl.Location = new System.Drawing.Point(17, 83);
            this.orderItemsGridControl.MainView = this.orderItemsGridView;
            this.orderItemsGridControl.MenuManager = this.mainRibbon;
            this.orderItemsGridControl.Name = "orderItemsGridControl";
            this.orderItemsGridControl.Size = new System.Drawing.Size(980, 514);
            this.orderItemsGridControl.TabIndex = 6;
            this.orderItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderItemsGridView});
            // 
            // orderItemsGridView
            // 
            this.orderItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberGridColumn,
            this.statusGridColumn,
            this.clientGridColumn,
            this.totalPriceGridColumn,
            this.orderStateGridColumn});
            this.orderItemsGridView.GridControl = this.orderItemsGridControl;
            this.orderItemsGridView.Name = "orderItemsGridView";
            this.orderItemsGridView.OptionsBehavior.Editable = false;
            this.orderItemsGridView.DoubleClick += new System.EventHandler(this.orderItemsGridView_DoubleClick);
            // 
            // orderNumberGridColumn
            // 
            this.orderNumberGridColumn.Caption = "Order number";
            this.orderNumberGridColumn.FieldName = "OrderNumber";
            this.orderNumberGridColumn.Name = "orderNumberGridColumn";
            this.orderNumberGridColumn.Visible = true;
            this.orderNumberGridColumn.VisibleIndex = 0;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Status";
            this.statusGridColumn.FieldName = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            // 
            // clientGridColumn
            // 
            this.clientGridColumn.Caption = "Client";
            this.clientGridColumn.FieldName = "Client.Person";
            this.clientGridColumn.Name = "clientGridColumn";
            this.clientGridColumn.Visible = true;
            this.clientGridColumn.VisibleIndex = 2;
            // 
            // totalPriceGridColumn
            // 
            this.totalPriceGridColumn.Caption = "Total price";
            this.totalPriceGridColumn.DisplayFormat.FormatString = "n2";
            this.totalPriceGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalPriceGridColumn.FieldName = "Sum";
            this.totalPriceGridColumn.Name = "totalPriceGridColumn";
            this.totalPriceGridColumn.Visible = true;
            this.totalPriceGridColumn.VisibleIndex = 3;
            // 
            // orderStateGridColumn
            // 
            this.orderStateGridColumn.Caption = "State";
            this.orderStateGridColumn.FieldName = "IsActive";
            this.orderStateGridColumn.Name = "orderStateGridColumn";
            this.orderStateGridColumn.Visible = true;
            this.orderStateGridColumn.VisibleIndex = 4;
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(17, 33);
            this.orderNumberTextEdit.MenuManager = this.mainRibbon;
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(318, 20);
            this.orderNumberTextEdit.StyleController = this.layoutControlOrderView;
            this.orderNumberTextEdit.TabIndex = 4;
            this.orderNumberTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderNumberTextEdit_KeyPress);
            // 
            // layoutControlGroupOrderView
            // 
            this.layoutControlGroupOrderView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupOrderView.GroupBordersVisible = false;
            this.layoutControlGroupOrderView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderNumberTextEdit,
            this.layoutControlOrderItemsGridControl,
            this.layoutControlClientLookUpEdit,
            this.layoutControlOrderStatus});
            this.layoutControlGroupOrderView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupOrderView.Name = "layoutControlGroupOrderView";
            this.layoutControlGroupOrderView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroupOrderView.TextVisible = false;
            // 
            // layoutControlOrderNumberTextEdit
            // 
            this.layoutControlOrderNumberTextEdit.Control = this.orderNumberTextEdit;
            this.layoutControlOrderNumberTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderNumberTextEdit.Name = "layoutControlOrderNumberTextEdit";
            this.layoutControlOrderNumberTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderNumberTextEdit.Size = new System.Drawing.Size(332, 50);
            this.layoutControlOrderNumberTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlOrderNumberTextEdit.Text = "Order number";
            this.layoutControlOrderNumberTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderNumberTextEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlOrderItemsGridControl
            // 
            this.layoutControlOrderItemsGridControl.Control = this.orderItemsGridControl;
            this.layoutControlOrderItemsGridControl.Location = new System.Drawing.Point(0, 50);
            this.layoutControlOrderItemsGridControl.Name = "layoutControlOrderItemsGridControl";
            this.layoutControlOrderItemsGridControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderItemsGridControl.Size = new System.Drawing.Size(994, 544);
            this.layoutControlOrderItemsGridControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlOrderItemsGridControl.Text = "Order items";
            this.layoutControlOrderItemsGridControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderItemsGridControl.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlClientLookUpEdit
            // 
            this.layoutControlClientLookUpEdit.Control = this.clientLookUpEdit;
            this.layoutControlClientLookUpEdit.Location = new System.Drawing.Point(663, 0);
            this.layoutControlClientLookUpEdit.Name = "layoutControlClientLookUpEdit";
            this.layoutControlClientLookUpEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLookUpEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlClientLookUpEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientLookUpEdit.Text = "Client";
            this.layoutControlClientLookUpEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLookUpEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlOrderStatus
            // 
            this.layoutControlOrderStatus.Control = this.orderStatusComboBoxEdit;
            this.layoutControlOrderStatus.Location = new System.Drawing.Point(332, 0);
            this.layoutControlOrderStatus.Name = "layoutControlOrderStatus";
            this.layoutControlOrderStatus.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderStatus.Size = new System.Drawing.Size(331, 50);
            this.layoutControlOrderStatus.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlOrderStatus.Text = "Status";
            this.layoutControlOrderStatus.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderStatus.TextSize = new System.Drawing.Size(67, 13);
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlOrderView);
            this.Controls.Add(this.ribbonStatusBarOrderView);
            this.Controls.Add(this.mainRibbon);
            this.Name = "OrderListView";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.ribbonStatusBarOrderView;
            this.Text = "Order Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderListView_FormClosed);
            this.Load += new System.EventHandler(this.OrderListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderView)).EndInit();
            this.layoutControlOrderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrderSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup OrderViewFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarOrderView;
        private DevExpress.XtraLayout.LayoutControl layoutControlOrderView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupOrderView;
        private DevExpress.XtraGrid.GridControl orderItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderItemsGridView;
        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderItemsGridControl;
        private DevExpress.XtraBars.BarButtonItem searchOrderBarButton;
        private DevExpress.XtraBars.BarButtonItem clearOrderBarButton;
        private DevExpress.XtraEditors.LookUpEdit clientLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLookUpEdit;
        private DevExpress.XtraEditors.ComboBoxEdit orderStatusComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn clientGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn orderStateGridColumn;
    }
}