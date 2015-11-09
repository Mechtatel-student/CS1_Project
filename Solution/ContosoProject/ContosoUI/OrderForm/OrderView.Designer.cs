namespace ContosoUI.OrderForm
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.orderRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.orderSaveAndNewBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.orderSaveBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClearBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.barStateButton = new DevExpress.XtraBars.BarButtonItem();
            this.addOrderItemButton = new DevExpress.XtraBars.BarButtonItem();
            this.orderRibbonPageOrderView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.orderRibbonPageFileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderRibbonPageOrderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.orderViewLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.totalPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.newCommentTextBox = new System.Windows.Forms.TextBox();
            this.commentsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.gridSplitContainer = new DevExpress.XtraGrid.GridSplitContainer();
            this.orderGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderRepositoryProductLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryQuantitySpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderRepositoryPriceSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.orderRepositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.orderRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.orderRrepositoryPriceTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.orderDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.orderStatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderNumberTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlStatusComboBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDateEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.orderTabbedControlOrderAndCommentGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlDataGrid = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlTotalPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlClientLookUp = new DevExpress.XtraLayout.LayoutControlItem();
            this.orderSplitter = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlCommentListBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlNewCommentTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.orderRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).BeginInit();
            this.orderViewLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer)).BeginInit();
            this.gridSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryProductLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryQuantitySpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryPriceSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRrepositoryPriceTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabbedControlOrderAndCommentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // orderRibbon
            // 
            this.orderRibbon.ExpandCollapseItem.Id = 0;
            this.orderRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.orderRibbon.ExpandCollapseItem,
            this.orderSaveAndNewBarButton,
            this.orderSaveBarButton,
            this.ClearBarButton,
            this.barStateButton,
            this.addOrderItemButton});
            this.orderRibbon.Location = new System.Drawing.Point(0, 0);
            this.orderRibbon.MaxItemId = 6;
            this.orderRibbon.Name = "orderRibbon";
            this.orderRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.orderRibbonPageOrderView});
            this.orderRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.orderRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowCategoryInCaption = false;
            this.orderRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.orderRibbon.ShowQatLocationSelector = false;
            this.orderRibbon.ShowToolbarCustomizeItem = false;
            this.orderRibbon.Size = new System.Drawing.Size(1014, 122);
            this.orderRibbon.StatusBar = this.orderRibbonStatusBar;
            this.orderRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // orderSaveAndNewBarButton
            // 
            this.orderSaveAndNewBarButton.Caption = "Save and New";
            this.orderSaveAndNewBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("orderSaveAndNewBarButton.Glyph")));
            this.orderSaveAndNewBarButton.Id = 1;
            this.orderSaveAndNewBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("orderSaveAndNewBarButton.LargeGlyph")));
            this.orderSaveAndNewBarButton.Name = "orderSaveAndNewBarButton";
            this.orderSaveAndNewBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.orderSaveAndNewBarButton_ItemClick);
            // 
            // orderSaveBarButton
            // 
            this.orderSaveBarButton.Caption = "Save";
            this.orderSaveBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("orderSaveBarButton.Glyph")));
            this.orderSaveBarButton.Id = 2;
            this.orderSaveBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("orderSaveBarButton.LargeGlyph")));
            this.orderSaveBarButton.Name = "orderSaveBarButton";
            this.orderSaveBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.orderSaveBarButton_ItemClick);
            // 
            // ClearBarButton
            // 
            this.ClearBarButton.Caption = "New";
            this.ClearBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.Glyph")));
            this.ClearBarButton.Id = 3;
            this.ClearBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.LargeGlyph")));
            this.ClearBarButton.Name = "ClearBarButton";
            this.ClearBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearBarButton_ItemClick);
            // 
            // barStateButton
            // 
            this.barStateButton.Caption = "Remove";
            this.barStateButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barStateButton.Glyph")));
            this.barStateButton.Id = 4;
            this.barStateButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStateButton.LargeGlyph")));
            this.barStateButton.Name = "barStateButton";
            this.barStateButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStateButton_ItemClick);
            // 
            // addOrderItemButton
            // 
            this.addOrderItemButton.Caption = "Add order item";
            this.addOrderItemButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addOrderItemButton.Glyph")));
            this.addOrderItemButton.Id = 5;
            this.addOrderItemButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addOrderItemButton.LargeGlyph")));
            this.addOrderItemButton.Name = "addOrderItemButton";
            this.addOrderItemButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addOrderItemButton_ItemClick);
            // 
            // orderRibbonPageOrderView
            // 
            this.orderRibbonPageOrderView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.orderRibbonPageFileGroup,
            this.orderRibbonPageOrderGroup});
            this.orderRibbonPageOrderView.MergeOrder = 50;
            this.orderRibbonPageOrderView.Name = "orderRibbonPageOrderView";
            this.orderRibbonPageOrderView.Text = "RibbonMerge";
            // 
            // orderRibbonPageFileGroup
            // 
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.orderSaveBarButton);
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.orderSaveAndNewBarButton);
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.ClearBarButton);
            this.orderRibbonPageFileGroup.MergeOrder = 50;
            this.orderRibbonPageFileGroup.Name = "orderRibbonPageFileGroup";
            this.orderRibbonPageFileGroup.Text = "Order";
            // 
            // orderRibbonPageOrderGroup
            // 
            this.orderRibbonPageOrderGroup.ItemLinks.Add(this.barStateButton);
            this.orderRibbonPageOrderGroup.ItemLinks.Add(this.addOrderItemButton);
            this.orderRibbonPageOrderGroup.MergeOrder = 60;
            this.orderRibbonPageOrderGroup.Name = "orderRibbonPageOrderGroup";
            this.orderRibbonPageOrderGroup.Text = "Edit";
            // 
            // orderRibbonStatusBar
            // 
            this.orderRibbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.orderRibbonStatusBar.Name = "orderRibbonStatusBar";
            this.orderRibbonStatusBar.Ribbon = this.orderRibbon;
            this.orderRibbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // orderViewLayoutControl
            // 
            this.orderViewLayoutControl.Controls.Add(this.totalPriceTextEdit);
            this.orderViewLayoutControl.Controls.Add(this.clientLookUpEdit);
            this.orderViewLayoutControl.Controls.Add(this.addCommentButton);
            this.orderViewLayoutControl.Controls.Add(this.newCommentTextBox);
            this.orderViewLayoutControl.Controls.Add(this.commentsListBox);
            this.orderViewLayoutControl.Controls.Add(this.gridSplitContainer);
            this.orderViewLayoutControl.Controls.Add(this.orderDateEdit);
            this.orderViewLayoutControl.Controls.Add(this.orderNumberTextEdit);
            this.orderViewLayoutControl.Controls.Add(this.orderStatusLookUpEdit);
            this.orderViewLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderViewLayoutControl.Location = new System.Drawing.Point(0, 122);
            this.orderViewLayoutControl.Name = "orderViewLayoutControl";
            this.orderViewLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(586, 162, 405, 343);
            this.orderViewLayoutControl.Root = this.layoutControlGroup;
            this.orderViewLayoutControl.Size = new System.Drawing.Size(1014, 614);
            this.orderViewLayoutControl.TabIndex = 2;
            this.orderViewLayoutControl.Text = "layoutControl1";
            // 
            // totalPriceTextEdit
            // 
            this.totalPriceTextEdit.Location = new System.Drawing.Point(337, 570);
            this.totalPriceTextEdit.MenuManager = this.orderRibbon;
            this.totalPriceTextEdit.Name = "totalPriceTextEdit";
            this.totalPriceTextEdit.Properties.DisplayFormat.FormatString = "n2";
            this.totalPriceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalPriceTextEdit.Properties.Mask.EditMask = "n2";
            this.totalPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.totalPriceTextEdit.Properties.ReadOnly = true;
            this.totalPriceTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceTextEdit.Size = new System.Drawing.Size(653, 20);
            this.totalPriceTextEdit.StyleController = this.orderViewLayoutControl;
            this.totalPriceTextEdit.TabIndex = 14;
            // 
            // clientLookUpEdit
            // 
            this.clientLookUpEdit.Location = new System.Drawing.Point(15, 169);
            this.clientLookUpEdit.MenuManager = this.orderRibbon;
            this.clientLookUpEdit.Name = "clientLookUpEdit";
            this.clientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Person", "Name")});
            this.clientLookUpEdit.Properties.DataSource = this.clientBindingSource;
            this.clientLookUpEdit.Properties.DisplayMember = "Person";
            this.clientLookUpEdit.Properties.ValueMember = "Person";
            this.clientLookUpEdit.Size = new System.Drawing.Size(228, 20);
            this.clientLookUpEdit.StyleController = this.orderViewLayoutControl;
            this.clientLookUpEdit.TabIndex = 12;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Domain.Entities.Clients.Client);
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(170, 555);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(76, 47);
            this.addCommentButton.StyleController = this.orderViewLayoutControl;
            this.addCommentButton.TabIndex = 11;
            this.addCommentButton.Text = "Add comment";
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // newCommentTextBox
            // 
            this.newCommentTextBox.Location = new System.Drawing.Point(12, 555);
            this.newCommentTextBox.Name = "newCommentTextBox";
            this.newCommentTextBox.Size = new System.Drawing.Size(154, 47);
            this.newCommentTextBox.TabIndex = 10;
            // 
            // commentsListBox
            // 
            this.commentsListBox.Location = new System.Drawing.Point(12, 217);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(234, 334);
            this.commentsListBox.StyleController = this.orderViewLayoutControl;
            this.commentsListBox.TabIndex = 9;
            // 
            // gridSplitContainer
            // 
            this.gridSplitContainer.Grid = this.orderGridControl;
            this.gridSplitContainer.Location = new System.Drawing.Point(267, 46);
            this.gridSplitContainer.Name = "gridSplitContainer";
            this.gridSplitContainer.Panel1.Controls.Add(this.orderGridControl);
            this.gridSplitContainer.Size = new System.Drawing.Size(723, 520);
            this.gridSplitContainer.TabIndex = 13;
            // 
            // orderGridControl
            // 
            this.orderGridControl.DataSource = this.orderItembindingSource;
            this.orderGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridControl.Location = new System.Drawing.Point(0, 0);
            this.orderGridControl.MainView = this.orderGridView;
            this.orderGridControl.MenuManager = this.orderRibbon;
            this.orderGridControl.Name = "orderGridControl";
            this.orderGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.orderRepositoryItemSpinEdit,
            this.orderRepositoryItemButtonEdit,
            this.repositoryQuantitySpinEdit,
            this.orderRepositoryProductLookUpEdit,
            this.orderRrepositoryPriceTextEdit,
            this.orderRepositoryPriceSpinEdit});
            this.orderGridControl.Size = new System.Drawing.Size(723, 520);
            this.orderGridControl.TabIndex = 8;
            this.orderGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderGridView});
            // 
            // orderItembindingSource
            // 
            this.orderItembindingSource.DataSource = typeof(Domain.Entities.Orders.OrderItem);
            // 
            // orderGridView
            // 
            this.orderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIsActive,
            this.colProduct,
            this.colQuantity,
            this.colPrice});
            this.orderGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.orderGridView.GridControl = this.orderGridControl;
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.OptionsView.ShowGroupPanel = false;
            this.orderGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.orderGridView_CellValueChanged);
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
            // 
            // colProduct
            // 
            this.colProduct.ColumnEdit = this.orderRepositoryProductLookUpEdit;
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // orderRepositoryProductLookUpEdit
            // 
            this.orderRepositoryProductLookUpEdit.AutoHeight = false;
            this.orderRepositoryProductLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderRepositoryProductLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", "SKU"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 20, DevExpress.Utils.FormatType.None, "c", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity")});
            this.orderRepositoryProductLookUpEdit.Name = "orderRepositoryProductLookUpEdit";
            // 
            // colQuantity
            // 
            this.colQuantity.ColumnEdit = this.repositoryQuantitySpinEdit;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // repositoryQuantitySpinEdit
            // 
            this.repositoryQuantitySpinEdit.AutoHeight = false;
            this.repositoryQuantitySpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryQuantitySpinEdit.Name = "repositoryQuantitySpinEdit";
            this.repositoryQuantitySpinEdit.ValidateOnEnterKey = true;
            // 
            // colPrice
            // 
            this.colPrice.ColumnEdit = this.orderRepositoryPriceSpinEdit;
            this.colPrice.DisplayFormat.FormatString = "n2";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Product.Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // orderRepositoryPriceSpinEdit
            // 
            this.orderRepositoryPriceSpinEdit.AutoHeight = false;
            this.orderRepositoryPriceSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderRepositoryPriceSpinEdit.Name = "orderRepositoryPriceSpinEdit";
            this.orderRepositoryPriceSpinEdit.ReadOnly = true;
            // 
            // orderRepositoryItemSpinEdit
            // 
            this.orderRepositoryItemSpinEdit.AutoHeight = false;
            this.orderRepositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderRepositoryItemSpinEdit.Name = "orderRepositoryItemSpinEdit";
            // 
            // orderRepositoryItemButtonEdit
            // 
            this.orderRepositoryItemButtonEdit.AutoHeight = false;
            this.orderRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.orderRepositoryItemButtonEdit.Name = "orderRepositoryItemButtonEdit";
            // 
            // orderRrepositoryPriceTextEdit
            // 
            this.orderRrepositoryPriceTextEdit.AutoHeight = false;
            this.orderRrepositoryPriceTextEdit.Name = "orderRrepositoryPriceTextEdit";
            // 
            // orderDateEdit
            // 
            this.orderDateEdit.EditValue = null;
            this.orderDateEdit.Location = new System.Drawing.Point(15, 123);
            this.orderDateEdit.MenuManager = this.orderRibbon;
            this.orderDateEdit.Name = "orderDateEdit";
            this.orderDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Size = new System.Drawing.Size(228, 20);
            this.orderDateEdit.StyleController = this.orderViewLayoutControl;
            this.orderDateEdit.TabIndex = 6;
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(15, 31);
            this.orderNumberTextEdit.MenuManager = this.orderRibbon;
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(228, 20);
            this.orderNumberTextEdit.StyleController = this.orderViewLayoutControl;
            this.orderNumberTextEdit.TabIndex = 4;
            this.orderNumberTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderNumberTextEdit_KeyPress);
            // 
            // orderStatusLookUpEdit
            // 
            this.orderStatusLookUpEdit.EditValue = System.Drawing.Color.Empty;
            this.orderStatusLookUpEdit.Location = new System.Drawing.Point(15, 77);
            this.orderStatusLookUpEdit.MenuManager = this.orderRibbon;
            this.orderStatusLookUpEdit.Name = "orderStatusLookUpEdit";
            this.orderStatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderStatusLookUpEdit.Properties.NullText = "";
            this.orderStatusLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.orderStatusLookUpEdit.Size = new System.Drawing.Size(228, 20);
            this.orderStatusLookUpEdit.StyleController = this.orderViewLayoutControl;
            this.orderStatusLookUpEdit.TabIndex = 5;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderNumberTextEdit,
            this.layoutControlStatusComboBox,
            this.layoutControlDateEdit,
            this.orderTabbedControlOrderAndCommentGroup,
            this.layoutControlClientLookUp,
            this.orderSplitter,
            this.layoutControlCommentListBox,
            this.layoutControlNewCommentTextBox,
            this.layoutControlAddNewCommentButton});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlOrderNumberTextEdit
            // 
            this.layoutControlOrderNumberTextEdit.Control = this.orderNumberTextEdit;
            this.layoutControlOrderNumberTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderNumberTextEdit.MinSize = new System.Drawing.Size(77, 46);
            this.layoutControlOrderNumberTextEdit.Name = "layoutControlOrderNumberTextEdit";
            this.layoutControlOrderNumberTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderNumberTextEdit.Size = new System.Drawing.Size(238, 46);
            this.layoutControlOrderNumberTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlOrderNumberTextEdit.Text = "Order number";
            this.layoutControlOrderNumberTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderNumberTextEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlStatusComboBox
            // 
            this.layoutControlStatusComboBox.Control = this.orderStatusLookUpEdit;
            this.layoutControlStatusComboBox.Location = new System.Drawing.Point(0, 46);
            this.layoutControlStatusComboBox.MinSize = new System.Drawing.Size(77, 46);
            this.layoutControlStatusComboBox.Name = "layoutControlStatusComboBox";
            this.layoutControlStatusComboBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlStatusComboBox.Size = new System.Drawing.Size(238, 46);
            this.layoutControlStatusComboBox.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlStatusComboBox.Text = "Status";
            this.layoutControlStatusComboBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlStatusComboBox.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlDateEdit
            // 
            this.layoutControlDateEdit.Control = this.orderDateEdit;
            this.layoutControlDateEdit.Location = new System.Drawing.Point(0, 92);
            this.layoutControlDateEdit.MinSize = new System.Drawing.Size(77, 46);
            this.layoutControlDateEdit.Name = "layoutControlDateEdit";
            this.layoutControlDateEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlDateEdit.Size = new System.Drawing.Size(238, 46);
            this.layoutControlDateEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlDateEdit.Text = "Date";
            this.layoutControlDateEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlDateEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // orderTabbedControlOrderAndCommentGroup
            // 
            this.orderTabbedControlOrderAndCommentGroup.Location = new System.Drawing.Point(243, 0);
            this.orderTabbedControlOrderAndCommentGroup.Name = "orderTabbedControlOrderAndCommentGroup";
            this.orderTabbedControlOrderAndCommentGroup.SelectedTabPage = this.layoutControlDataGrid;
            this.orderTabbedControlOrderAndCommentGroup.SelectedTabPageIndex = 0;
            this.orderTabbedControlOrderAndCommentGroup.Size = new System.Drawing.Size(751, 594);
            this.orderTabbedControlOrderAndCommentGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlDataGrid});
            // 
            // layoutControlDataGrid
            // 
            this.layoutControlDataGrid.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderGrid,
            this.layoutControlTotalPrice});
            this.layoutControlDataGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlDataGrid.Name = "layoutControlDataGrid";
            this.layoutControlDataGrid.Size = new System.Drawing.Size(727, 548);
            this.layoutControlDataGrid.Text = "Order Items";
            // 
            // layoutControlOrderGrid
            // 
            this.layoutControlOrderGrid.Control = this.gridSplitContainer;
            this.layoutControlOrderGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderGrid.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlOrderGrid.Name = "layoutControlOrderGrid";
            this.layoutControlOrderGrid.Size = new System.Drawing.Size(727, 524);
            this.layoutControlOrderGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlOrderGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlOrderGrid.TextVisible = false;
            // 
            // layoutControlTotalPrice
            // 
            this.layoutControlTotalPrice.Control = this.totalPriceTextEdit;
            this.layoutControlTotalPrice.Location = new System.Drawing.Point(0, 524);
            this.layoutControlTotalPrice.Name = "layoutControlTotalPrice";
            this.layoutControlTotalPrice.Size = new System.Drawing.Size(727, 24);
            this.layoutControlTotalPrice.Text = "Total price:";
            this.layoutControlTotalPrice.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlClientLookUp
            // 
            this.layoutControlClientLookUp.Control = this.clientLookUpEdit;
            this.layoutControlClientLookUp.Location = new System.Drawing.Point(0, 138);
            this.layoutControlClientLookUp.MinSize = new System.Drawing.Size(77, 46);
            this.layoutControlClientLookUp.Name = "layoutControlClientLookUp";
            this.layoutControlClientLookUp.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLookUp.Size = new System.Drawing.Size(238, 51);
            this.layoutControlClientLookUp.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlClientLookUp.Text = "Client";
            this.layoutControlClientLookUp.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLookUp.TextSize = new System.Drawing.Size(67, 13);
            // 
            // orderSplitter
            // 
            this.orderSplitter.AllowHotTrack = true;
            this.orderSplitter.Location = new System.Drawing.Point(238, 0);
            this.orderSplitter.Name = "orderSplitter";
            this.orderSplitter.Size = new System.Drawing.Size(5, 594);
            // 
            // layoutControlCommentListBox
            // 
            this.layoutControlCommentListBox.Control = this.commentsListBox;
            this.layoutControlCommentListBox.Location = new System.Drawing.Point(0, 189);
            this.layoutControlCommentListBox.MinSize = new System.Drawing.Size(201, 4);
            this.layoutControlCommentListBox.Name = "layoutControlCommentListBox";
            this.layoutControlCommentListBox.Size = new System.Drawing.Size(238, 354);
            this.layoutControlCommentListBox.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlCommentListBox.Text = "Comments";
            this.layoutControlCommentListBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlCommentListBox.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlNewCommentTextBox
            // 
            this.layoutControlNewCommentTextBox.Control = this.newCommentTextBox;
            this.layoutControlNewCommentTextBox.Location = new System.Drawing.Point(0, 543);
            this.layoutControlNewCommentTextBox.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControlNewCommentTextBox.Name = "layoutControlNewCommentTextBox";
            this.layoutControlNewCommentTextBox.Size = new System.Drawing.Size(158, 51);
            this.layoutControlNewCommentTextBox.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlNewCommentTextBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlNewCommentTextBox.TextVisible = false;
            // 
            // layoutControlAddNewCommentButton
            // 
            this.layoutControlAddNewCommentButton.Control = this.addCommentButton;
            this.layoutControlAddNewCommentButton.Location = new System.Drawing.Point(158, 543);
            this.layoutControlAddNewCommentButton.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlAddNewCommentButton.Name = "layoutControlAddNewCommentButton";
            this.layoutControlAddNewCommentButton.Size = new System.Drawing.Size(80, 51);
            this.layoutControlAddNewCommentButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlAddNewCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCommentButton.TextVisible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.orderViewLayoutControl);
            this.Controls.Add(this.orderRibbonStatusBar);
            this.Controls.Add(this.orderRibbon);
            this.Name = "OrderForm";
            this.Ribbon = this.orderRibbon;
            this.StatusBar = this.orderRibbonStatusBar;
            this.Text = "Order View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderViewList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).EndInit();
            this.orderViewLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer)).EndInit();
            this.gridSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryProductLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryQuantitySpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryPriceSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRrepositoryPriceTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabbedControlOrderAndCommentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl orderRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage orderRibbonPageOrderView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderRibbonPageFileGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar orderRibbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem orderSaveAndNewBarButton;
        private DevExpress.XtraBars.BarButtonItem orderSaveBarButton;
        private DevExpress.XtraBars.BarButtonItem ClearBarButton;
        private DevExpress.XtraLayout.LayoutControl orderViewLayoutControl;
        private DevExpress.XtraGrid.GridControl orderGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderGridView;
        private DevExpress.XtraEditors.DateEdit orderDateEdit;
        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlStatusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDateEdit;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private System.Windows.Forms.TextBox newCommentTextBox;
        private DevExpress.XtraEditors.ListBoxControl commentsListBox;
        private DevExpress.XtraLayout.TabbedControlGroup orderTabbedControlOrderAndCommentGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCommentListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlNewCommentTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCommentButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlDataGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderGrid;
        private DevExpress.XtraEditors.LookUpEdit clientLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLookUp;
        private DevExpress.XtraBars.BarButtonItem barStateButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderRibbonPageOrderGroup;
        private DevExpress.XtraEditors.LookUpEdit orderStatusLookUpEdit;
        private DevExpress.XtraLayout.SplitterItem orderSplitter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit orderRepositoryProductLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryQuantitySpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit orderRrepositoryPriceTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit orderRepositoryItemSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit orderRepositoryItemButtonEdit;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit orderRepositoryPriceSpinEdit;
        private System.Windows.Forms.BindingSource orderItembindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraBars.BarButtonItem addOrderItemButton;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraEditors.TextEdit totalPriceTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlTotalPrice;
    }
}