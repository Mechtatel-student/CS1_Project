namespace ContosoUI.ProductSearchForm
{
    partial class ProductListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListView));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.searchProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageProductView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.productFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarProductView = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlProductView = new DevExpress.XtraLayout.LayoutControl();
            this.categoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.productsGridControl = new DevExpress.XtraGrid.GridControl();
            this.productsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.skuGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.titleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productStateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.skuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupProductView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlSKUTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductTitleTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductsGridView = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCategoryLookUpEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductView)).BeginInit();
            this.layoutControlProductView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSKUTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.searchProductBarButton,
            this.clearProductBarButton});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 4;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageProductView});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(1014, 122);
            this.mainRibbon.StatusBar = this.ribbonStatusBarProductView;
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // searchProductBarButton
            // 
            this.searchProductBarButton.Caption = "Search";
            this.searchProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchProductBarButton.Glyph")));
            this.searchProductBarButton.Id = 2;
            this.searchProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchProductBarButton.LargeGlyph")));
            this.searchProductBarButton.Name = "searchProductBarButton";
            this.searchProductBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchProductBarButton_ItemClick);
            // 
            // clearProductBarButton
            // 
            this.clearProductBarButton.Caption = "Clear";
            this.clearProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearProductBarButton.Glyph")));
            this.clearProductBarButton.Id = 3;
            this.clearProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearProductBarButton.LargeGlyph")));
            this.clearProductBarButton.Name = "clearProductBarButton";
            this.clearProductBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearProductBarButton_ItemClick);
            // 
            // ribbonPageProductView
            // 
            this.ribbonPageProductView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.productFileRibbonPageGroup});
            this.ribbonPageProductView.MergeOrder = 50;
            this.ribbonPageProductView.Name = "ribbonPageProductView";
            this.ribbonPageProductView.Text = "RibbonMerge";
            // 
            // productFileRibbonPageGroup
            // 
            this.productFileRibbonPageGroup.ItemLinks.Add(this.searchProductBarButton);
            this.productFileRibbonPageGroup.ItemLinks.Add(this.clearProductBarButton);
            this.productFileRibbonPageGroup.MergeOrder = 50;
            this.productFileRibbonPageGroup.Name = "productFileRibbonPageGroup";
            this.productFileRibbonPageGroup.Text = "Search";
            // 
            // ribbonStatusBarProductView
            // 
            this.ribbonStatusBarProductView.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBarProductView.Name = "ribbonStatusBarProductView";
            this.ribbonStatusBarProductView.Ribbon = this.mainRibbon;
            this.ribbonStatusBarProductView.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlProductView
            // 
            this.layoutControlProductView.Controls.Add(this.categoryLookUpEdit);
            this.layoutControlProductView.Controls.Add(this.productsGridControl);
            this.layoutControlProductView.Controls.Add(this.productTitleTextEdit);
            this.layoutControlProductView.Controls.Add(this.skuTextEdit);
            this.layoutControlProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlProductView.Location = new System.Drawing.Point(0, 122);
            this.layoutControlProductView.Name = "layoutControlProductView";
            this.layoutControlProductView.Root = this.layoutControlGroupProductView;
            this.layoutControlProductView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlProductView.TabIndex = 2;
            this.layoutControlProductView.Text = "layoutControl1";
            // 
            // categoryLookUpEdit
            // 
            this.categoryLookUpEdit.EditValue = "<Null>";
            this.categoryLookUpEdit.Location = new System.Drawing.Point(680, 33);
            this.categoryLookUpEdit.MenuManager = this.mainRibbon;
            this.categoryLookUpEdit.Name = "categoryLookUpEdit";
            this.categoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title")});
            this.categoryLookUpEdit.Size = new System.Drawing.Size(317, 20);
            this.categoryLookUpEdit.StyleController = this.layoutControlProductView;
            this.categoryLookUpEdit.TabIndex = 9;
            // 
            // productsGridControl
            // 
            this.productsGridControl.Location = new System.Drawing.Point(17, 67);
            this.productsGridControl.MainView = this.productsGridView;
            this.productsGridControl.MenuManager = this.mainRibbon;
            this.productsGridControl.Name = "productsGridControl";
            this.productsGridControl.Size = new System.Drawing.Size(980, 530);
            this.productsGridControl.TabIndex = 7;
            this.productsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGridView});
            // 
            // productsGridView
            // 
            this.productsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.skuGridColumn,
            this.titleGridColumn,
            this.categoryGridColumn,
            this.quantityGridColumn,
            this.priceGridColumn,
            this.productStateGridColumn});
            this.productsGridView.GridControl = this.productsGridControl;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.OptionsBehavior.Editable = false;
            this.productsGridView.DoubleClick += new System.EventHandler(this.productsGridView_DoubleClick);
            // 
            // skuGridColumn
            // 
            this.skuGridColumn.Caption = "SKU";
            this.skuGridColumn.FieldName = "SKU";
            this.skuGridColumn.Name = "skuGridColumn";
            this.skuGridColumn.Visible = true;
            this.skuGridColumn.VisibleIndex = 1;
            // 
            // titleGridColumn
            // 
            this.titleGridColumn.Caption = "Title";
            this.titleGridColumn.FieldName = "Title";
            this.titleGridColumn.Name = "titleGridColumn";
            this.titleGridColumn.Visible = true;
            this.titleGridColumn.VisibleIndex = 0;
            // 
            // categoryGridColumn
            // 
            this.categoryGridColumn.Caption = "Category";
            this.categoryGridColumn.FieldName = "Category.Title";
            this.categoryGridColumn.Name = "categoryGridColumn";
            this.categoryGridColumn.Visible = true;
            this.categoryGridColumn.VisibleIndex = 2;
            // 
            // quantityGridColumn
            // 
            this.quantityGridColumn.Caption = "Quantity";
            this.quantityGridColumn.FieldName = "Quantity";
            this.quantityGridColumn.Name = "quantityGridColumn";
            this.quantityGridColumn.Visible = true;
            this.quantityGridColumn.VisibleIndex = 3;
            // 
            // priceGridColumn
            // 
            this.priceGridColumn.Caption = "Price";
            this.priceGridColumn.DisplayFormat.FormatString = "n2";
            this.priceGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceGridColumn.FieldName = "Price";
            this.priceGridColumn.Name = "priceGridColumn";
            this.priceGridColumn.Visible = true;
            this.priceGridColumn.VisibleIndex = 4;
            // 
            // productStateGridColumn
            // 
            this.productStateGridColumn.Caption = "State";
            this.productStateGridColumn.FieldName = "IsActive";
            this.productStateGridColumn.Name = "productStateGridColumn";
            this.productStateGridColumn.Visible = true;
            this.productStateGridColumn.VisibleIndex = 5;
            // 
            // productTitleTextEdit
            // 
            this.productTitleTextEdit.Location = new System.Drawing.Point(349, 33);
            this.productTitleTextEdit.MenuManager = this.mainRibbon;
            this.productTitleTextEdit.Name = "productTitleTextEdit";
            this.productTitleTextEdit.Size = new System.Drawing.Size(317, 20);
            this.productTitleTextEdit.StyleController = this.layoutControlProductView;
            this.productTitleTextEdit.TabIndex = 5;
            this.productTitleTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productTitleTextEdit_KeyPress);
            // 
            // skuTextEdit
            // 
            this.skuTextEdit.Location = new System.Drawing.Point(17, 33);
            this.skuTextEdit.MenuManager = this.mainRibbon;
            this.skuTextEdit.Name = "skuTextEdit";
            this.skuTextEdit.Size = new System.Drawing.Size(318, 20);
            this.skuTextEdit.StyleController = this.layoutControlProductView;
            this.skuTextEdit.TabIndex = 4;
            this.skuTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skuTextEdit_KeyPress);
            // 
            // layoutControlGroupProductView
            // 
            this.layoutControlGroupProductView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupProductView.GroupBordersVisible = false;
            this.layoutControlGroupProductView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlSKUTextEdit,
            this.layoutControlProductTitleTextEdit,
            this.layoutControlProductsGridView,
            this.layoutControlCategoryLookUpEdit});
            this.layoutControlGroupProductView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupProductView.Name = "layoutControlGroupProductView";
            this.layoutControlGroupProductView.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroupProductView.TextVisible = false;
            // 
            // layoutControlSKUTextEdit
            // 
            this.layoutControlSKUTextEdit.Control = this.skuTextEdit;
            this.layoutControlSKUTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSKUTextEdit.Name = "layoutControlSKUTextEdit";
            this.layoutControlSKUTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlSKUTextEdit.Size = new System.Drawing.Size(332, 50);
            this.layoutControlSKUTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlSKUTextEdit.Text = "SKU";
            this.layoutControlSKUTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlSKUTextEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlProductTitleTextEdit
            // 
            this.layoutControlProductTitleTextEdit.Control = this.productTitleTextEdit;
            this.layoutControlProductTitleTextEdit.Location = new System.Drawing.Point(332, 0);
            this.layoutControlProductTitleTextEdit.Name = "layoutControlProductTitleTextEdit";
            this.layoutControlProductTitleTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductTitleTextEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlProductTitleTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductTitleTextEdit.Text = "Title";
            this.layoutControlProductTitleTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductTitleTextEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlProductsGridView
            // 
            this.layoutControlProductsGridView.Control = this.productsGridControl;
            this.layoutControlProductsGridView.Location = new System.Drawing.Point(0, 50);
            this.layoutControlProductsGridView.Name = "layoutControlProductsGridView";
            this.layoutControlProductsGridView.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductsGridView.Size = new System.Drawing.Size(994, 544);
            this.layoutControlProductsGridView.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductsGridView.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProductsGridView.TextVisible = false;
            // 
            // layoutControlCategoryLookUpEdit
            // 
            this.layoutControlCategoryLookUpEdit.Control = this.categoryLookUpEdit;
            this.layoutControlCategoryLookUpEdit.Location = new System.Drawing.Point(663, 0);
            this.layoutControlCategoryLookUpEdit.Name = "layoutControlCategoryLookUpEdit";
            this.layoutControlCategoryLookUpEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCategoryLookUpEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlCategoryLookUpEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCategoryLookUpEdit.Text = "Category";
            this.layoutControlCategoryLookUpEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlCategoryLookUpEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlProductView);
            this.Controls.Add(this.ribbonStatusBarProductView);
            this.Controls.Add(this.mainRibbon);
            this.Name = "ProductListView";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.ribbonStatusBarProductView;
            this.Text = "Product Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductListView_FormClosed);
            this.Load += new System.EventHandler(this.ProductListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductView)).EndInit();
            this.layoutControlProductView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSKUTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProductView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup productFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarProductView;
        private DevExpress.XtraBars.BarButtonItem searchProductBarButton;
        private DevExpress.XtraBars.BarButtonItem clearProductBarButton;
        private DevExpress.XtraLayout.LayoutControl layoutControlProductView;
        private DevExpress.XtraGrid.GridControl productsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGridView;
        private DevExpress.XtraEditors.TextEdit productTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit skuTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupProductView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSKUTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductTitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductsGridView;
        private DevExpress.XtraEditors.LookUpEdit categoryLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn skuGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn titleGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn categoryGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn priceGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productStateGridColumn;
    }
}