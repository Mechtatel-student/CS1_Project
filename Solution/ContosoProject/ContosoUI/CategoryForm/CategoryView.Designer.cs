namespace ContosoUI.CategoryForm
{
    partial class CategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.addCategoryBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.newCategoryPopupControlContainer = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.newCategoryLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.addNewCategorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.newCategoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupNewCategory = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlAddNewCategoryTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCategoryButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.categoryRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.categoryRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.categoryEditRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.categoryLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.addNewCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.addNewCommentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryCommentsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.categoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.categoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.titleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.activityCollumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupCategories = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlCategoryGridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCommentsListBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCommentTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryPopupControlContainer)).BeginInit();
            this.newCategoryPopupControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryLayoutControl)).BeginInit();
            this.newCategoryLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupNewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControl)).BeginInit();
            this.categoryLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCommentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCommentsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.saveBarButton,
            this.addCategoryBarButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.categoryRibbonPage});
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
            // saveBarButton
            // 
            this.saveBarButton.Caption = "Save";
            this.saveBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("saveBarButton.Glyph")));
            this.saveBarButton.Id = 1;
            this.saveBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("saveBarButton.LargeGlyph")));
            this.saveBarButton.Name = "saveBarButton";
            this.saveBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButton_ItemClick);
            // 
            // addCategoryBarButton
            // 
            this.addCategoryBarButton.ActAsDropDown = true;
            this.addCategoryBarButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.addCategoryBarButton.Caption = "Add category";
            this.addCategoryBarButton.DropDownControl = this.newCategoryPopupControlContainer;
            this.addCategoryBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addCategoryBarButton.Glyph")));
            this.addCategoryBarButton.Id = 5;
            this.addCategoryBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCategoryBarButton.LargeGlyph")));
            this.addCategoryBarButton.Name = "addCategoryBarButton";
            // 
            // newCategoryPopupControlContainer
            // 
            this.newCategoryPopupControlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.newCategoryPopupControlContainer.Controls.Add(this.newCategoryLayoutControl);
            this.newCategoryPopupControlContainer.Location = new System.Drawing.Point(407, 25);
            this.newCategoryPopupControlContainer.Name = "newCategoryPopupControlContainer";
            this.newCategoryPopupControlContainer.Ribbon = this.ribbon;
            this.newCategoryPopupControlContainer.Size = new System.Drawing.Size(201, 91);
            this.newCategoryPopupControlContainer.TabIndex = 5;
            this.newCategoryPopupControlContainer.Visible = false;
            // 
            // newCategoryLayoutControl
            // 
            this.newCategoryLayoutControl.Controls.Add(this.addNewCategorySimpleButton);
            this.newCategoryLayoutControl.Controls.Add(this.newCategoryTextEdit);
            this.newCategoryLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCategoryLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.newCategoryLayoutControl.Name = "newCategoryLayoutControl";
            this.newCategoryLayoutControl.Root = this.layoutControlGroupNewCategory;
            this.newCategoryLayoutControl.Size = new System.Drawing.Size(201, 91);
            this.newCategoryLayoutControl.TabIndex = 0;
            this.newCategoryLayoutControl.Text = "layoutControl1";
            // 
            // addNewCategorySimpleButton
            // 
            this.addNewCategorySimpleButton.Location = new System.Drawing.Point(17, 51);
            this.addNewCategorySimpleButton.Name = "addNewCategorySimpleButton";
            this.addNewCategorySimpleButton.Size = new System.Drawing.Size(167, 22);
            this.addNewCategorySimpleButton.StyleController = this.newCategoryLayoutControl;
            this.addNewCategorySimpleButton.TabIndex = 8;
            this.addNewCategorySimpleButton.Text = "Add category";
            this.addNewCategorySimpleButton.Click += new System.EventHandler(this.addNewCategorySimpleButton_Click);
            // 
            // newCategoryTextEdit
            // 
            this.newCategoryTextEdit.Location = new System.Drawing.Point(17, 17);
            this.newCategoryTextEdit.MenuManager = this.ribbon;
            this.newCategoryTextEdit.Name = "newCategoryTextEdit";
            this.newCategoryTextEdit.Size = new System.Drawing.Size(167, 20);
            this.newCategoryTextEdit.StyleController = this.newCategoryLayoutControl;
            this.newCategoryTextEdit.TabIndex = 7;
            // 
            // layoutControlGroupNewCategory
            // 
            this.layoutControlGroupNewCategory.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupNewCategory.GroupBordersVisible = false;
            this.layoutControlGroupNewCategory.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlAddNewCategoryTextEdit,
            this.layoutControlAddNewCategoryButton});
            this.layoutControlGroupNewCategory.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupNewCategory.Name = "layoutControlGroupNewCategory";
            this.layoutControlGroupNewCategory.Size = new System.Drawing.Size(201, 91);
            this.layoutControlGroupNewCategory.TextVisible = false;
            // 
            // layoutControlAddNewCategoryTextEdit
            // 
            this.layoutControlAddNewCategoryTextEdit.Control = this.newCategoryTextEdit;
            this.layoutControlAddNewCategoryTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlAddNewCategoryTextEdit.Name = "layoutControlAddNewCategoryTextEdit";
            this.layoutControlAddNewCategoryTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlAddNewCategoryTextEdit.Size = new System.Drawing.Size(181, 34);
            this.layoutControlAddNewCategoryTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlAddNewCategoryTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCategoryTextEdit.TextVisible = false;
            // 
            // layoutControlAddNewCategoryButton
            // 
            this.layoutControlAddNewCategoryButton.Control = this.addNewCategorySimpleButton;
            this.layoutControlAddNewCategoryButton.Location = new System.Drawing.Point(0, 34);
            this.layoutControlAddNewCategoryButton.Name = "layoutControlAddNewCategoryButton";
            this.layoutControlAddNewCategoryButton.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlAddNewCategoryButton.Size = new System.Drawing.Size(181, 37);
            this.layoutControlAddNewCategoryButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlAddNewCategoryButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCategoryButton.TextVisible = false;
            // 
            // categoryRibbonPage
            // 
            this.categoryRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.categoryRibbonPageGroup,
            this.categoryEditRibbonPageGroup});
            this.categoryRibbonPage.MergeOrder = 50;
            this.categoryRibbonPage.Name = "categoryRibbonPage";
            this.categoryRibbonPage.Text = "RibbonMerge";
            // 
            // categoryRibbonPageGroup
            // 
            this.categoryRibbonPageGroup.ItemLinks.Add(this.saveBarButton);
            this.categoryRibbonPageGroup.MergeOrder = 50;
            this.categoryRibbonPageGroup.Name = "categoryRibbonPageGroup";
            this.categoryRibbonPageGroup.Text = "Category";
            // 
            // categoryEditRibbonPageGroup
            // 
            this.categoryEditRibbonPageGroup.ItemLinks.Add(this.addCategoryBarButton);
            this.categoryEditRibbonPageGroup.MergeOrder = 60;
            this.categoryEditRibbonPageGroup.Name = "categoryEditRibbonPageGroup";
            this.categoryEditRibbonPageGroup.Text = "Edit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // categoryLayoutControl
            // 
            this.categoryLayoutControl.Controls.Add(this.addNewCommentButton);
            this.categoryLayoutControl.Controls.Add(this.addNewCommentTextEdit);
            this.categoryLayoutControl.Controls.Add(this.categoryCommentsListBoxControl);
            this.categoryLayoutControl.Controls.Add(this.categoryGridControl);
            this.categoryLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLayoutControl.Location = new System.Drawing.Point(0, 122);
            this.categoryLayoutControl.Name = "categoryLayoutControl";
            this.categoryLayoutControl.Root = this.layoutControlGroupCategories;
            this.categoryLayoutControl.Size = new System.Drawing.Size(1014, 614);
            this.categoryLayoutControl.TabIndex = 2;
            this.categoryLayoutControl.Text = "layoutControl1";
            // 
            // addNewCommentButton
            // 
            this.addNewCommentButton.Location = new System.Drawing.Point(866, 575);
            this.addNewCommentButton.Name = "addNewCommentButton";
            this.addNewCommentButton.Size = new System.Drawing.Size(131, 22);
            this.addNewCommentButton.StyleController = this.categoryLayoutControl;
            this.addNewCommentButton.TabIndex = 3;
            this.addNewCommentButton.Text = "Add comment";
            this.addNewCommentButton.Click += new System.EventHandler(this.addNewCommentButton_Click);
            // 
            // addNewCommentTextEdit
            // 
            this.addNewCommentTextEdit.Location = new System.Drawing.Point(17, 575);
            this.addNewCommentTextEdit.MenuManager = this.ribbon;
            this.addNewCommentTextEdit.Name = "addNewCommentTextEdit";
            this.addNewCommentTextEdit.Size = new System.Drawing.Size(835, 20);
            this.addNewCommentTextEdit.StyleController = this.categoryLayoutControl;
            this.addNewCommentTextEdit.TabIndex = 6;
            this.addNewCommentTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNewCommentTextEdit_KeyPress);
            // 
            // categoryCommentsListBoxControl
            // 
            this.categoryCommentsListBoxControl.Location = new System.Drawing.Point(17, 415);
            this.categoryCommentsListBoxControl.Name = "categoryCommentsListBoxControl";
            this.categoryCommentsListBoxControl.Size = new System.Drawing.Size(980, 146);
            this.categoryCommentsListBoxControl.StyleController = this.categoryLayoutControl;
            this.categoryCommentsListBoxControl.TabIndex = 5;
            // 
            // categoryGridControl
            // 
            this.categoryGridControl.Location = new System.Drawing.Point(17, 17);
            this.categoryGridControl.MainView = this.categoryGridView;
            this.categoryGridControl.MenuManager = this.ribbon;
            this.categoryGridControl.Name = "categoryGridControl";
            this.categoryGridControl.Size = new System.Drawing.Size(980, 368);
            this.categoryGridControl.TabIndex = 4;
            this.categoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoryGridView});
            // 
            // categoryGridView
            // 
            this.categoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.titleColumn,
            this.dateColumn,
            this.activityCollumn});
            this.categoryGridView.GridControl = this.categoryGridControl;
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.categoryGridView_FocusedRowChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.Caption = "Title";
            this.titleColumn.FieldName = "Title";
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.Visible = true;
            this.titleColumn.VisibleIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.Caption = "Date";
            this.dateColumn.FieldName = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.Visible = true;
            this.dateColumn.VisibleIndex = 1;
            // 
            // activityCollumn
            // 
            this.activityCollumn.Caption = "State";
            this.activityCollumn.FieldName = "IsActive";
            this.activityCollumn.Name = "activityCollumn";
            this.activityCollumn.Visible = true;
            this.activityCollumn.VisibleIndex = 2;
            // 
            // layoutControlGroupCategories
            // 
            this.layoutControlGroupCategories.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupCategories.GroupBordersVisible = false;
            this.layoutControlGroupCategories.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCategoryGridControl,
            this.layoutControlCommentsListBox,
            this.layoutControlAddNewCommentTextEdit,
            this.layoutControlAddNewCommentButton});
            this.layoutControlGroupCategories.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupCategories.Name = "layoutControlGroupCategories";
            this.layoutControlGroupCategories.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroupCategories.TextVisible = false;
            // 
            // layoutControlCategoryGridControl
            // 
            this.layoutControlCategoryGridControl.Control = this.categoryGridControl;
            this.layoutControlCategoryGridControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCategoryGridControl.Name = "layoutControlCategoryGridControl";
            this.layoutControlCategoryGridControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCategoryGridControl.Size = new System.Drawing.Size(994, 382);
            this.layoutControlCategoryGridControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCategoryGridControl.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCategoryGridControl.TextVisible = false;
            // 
            // layoutControlCommentsListBox
            // 
            this.layoutControlCommentsListBox.Control = this.categoryCommentsListBoxControl;
            this.layoutControlCommentsListBox.Location = new System.Drawing.Point(0, 382);
            this.layoutControlCommentsListBox.Name = "layoutControlCommentsListBox";
            this.layoutControlCommentsListBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCommentsListBox.Size = new System.Drawing.Size(994, 176);
            this.layoutControlCommentsListBox.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCommentsListBox.Text = "Comments";
            this.layoutControlCommentsListBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlCommentsListBox.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlAddNewCommentTextEdit
            // 
            this.layoutControlAddNewCommentTextEdit.Control = this.addNewCommentTextEdit;
            this.layoutControlAddNewCommentTextEdit.Location = new System.Drawing.Point(0, 558);
            this.layoutControlAddNewCommentTextEdit.Name = "layoutControlAddNewCommentTextEdit";
            this.layoutControlAddNewCommentTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlAddNewCommentTextEdit.Size = new System.Drawing.Size(849, 36);
            this.layoutControlAddNewCommentTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlAddNewCommentTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCommentTextEdit.TextVisible = false;
            // 
            // layoutControlAddNewCommentButton
            // 
            this.layoutControlAddNewCommentButton.Control = this.addNewCommentButton;
            this.layoutControlAddNewCommentButton.Location = new System.Drawing.Point(849, 558);
            this.layoutControlAddNewCommentButton.Name = "layoutControlAddNewCommentButton";
            this.layoutControlAddNewCommentButton.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlAddNewCommentButton.Size = new System.Drawing.Size(145, 36);
            this.layoutControlAddNewCommentButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlAddNewCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCommentButton.TextVisible = false;
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.categoryLayoutControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.newCategoryPopupControlContainer);
            this.Controls.Add(this.ribbon);
            this.Name = "CategoryView";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Categories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoryView_FormClosed);
            this.Load += new System.EventHandler(this.CategoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryPopupControlContainer)).EndInit();
            this.newCategoryPopupControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryLayoutControl)).EndInit();
            this.newCategoryLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupNewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControl)).EndInit();
            this.categoryLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addNewCommentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCommentsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage categoryRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup categoryRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl categoryLayoutControl;
        private DevExpress.XtraGrid.GridControl categoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView categoryGridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCategories;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryGridControl;
        private DevExpress.XtraEditors.ListBoxControl categoryCommentsListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCommentsListBox;
        private DevExpress.XtraBars.BarButtonItem saveBarButton;
        private DevExpress.XtraBars.BarButtonItem addCategoryBarButton;
        private DevExpress.XtraEditors.SimpleButton addNewCommentButton;
        private DevExpress.XtraEditors.TextEdit addNewCommentTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCommentTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCommentButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup categoryEditRibbonPageGroup;
        private DevExpress.XtraBars.PopupControlContainer newCategoryPopupControlContainer;
        private DevExpress.XtraLayout.LayoutControl newCategoryLayoutControl;
        private DevExpress.XtraEditors.SimpleButton addNewCategorySimpleButton;
        private DevExpress.XtraEditors.TextEdit newCategoryTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupNewCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCategoryTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCategoryButton;
        private DevExpress.XtraGrid.Columns.GridColumn titleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn dateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn activityCollumn;
    }
}