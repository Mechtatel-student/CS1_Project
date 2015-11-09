using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;

namespace ContosoUI
{
    partial class MainForm
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
            DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonClientsGroup;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraSplashScreen.SplashScreenManager chairsSplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ContosoUI.ChairsSplashScreen), true, true);
            this.ClientsListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClientBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.OrdersListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.UserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.OrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.UsersListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ProductsListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.RolesBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.CategoriesBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonMerge = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonUserGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonOrdersGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonProductsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.systemRibbonGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ribbonClientsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientsGroup
            // 
            ribbonClientsGroup.ItemLinks.Add(this.ClientsListBarButton);
            ribbonClientsGroup.ItemLinks.Add(this.ClientBarButton);
            ribbonClientsGroup.MergeOrder = 200;
            ribbonClientsGroup.Name = "ribbonClientsGroup";
            ribbonClientsGroup.Text = "Clients";
            // 
            // ClientsListBarButton
            // 
            this.ClientsListBarButton.Caption = "Clients";
            this.ClientsListBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClientsListBarButton.Glyph")));
            this.ClientsListBarButton.Id = 1;
            this.ClientsListBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClientsListBarButton.LargeGlyph")));
            this.ClientsListBarButton.Name = "ClientsListBarButton";
            this.ClientsListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClientsListBarButton_ItemClick);
            // 
            // ClientBarButton
            // 
            this.ClientBarButton.Caption = "Client";
            this.ClientBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClientBarButton.Glyph")));
            this.ClientBarButton.Id = 6;
            this.ClientBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClientBarButton.LargeGlyph")));
            this.ClientBarButton.Name = "ClientBarButton";
            this.ClientBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClientBarButtonItem_ItemClick);
            // 
            // chairsSplashScreenManager
            // 
            chairsSplashScreenManager.ClosingDelay = 500;
            // 
            // mainRibbon
            // 
            this.mainRibbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.ClientsListBarButton,
            this.OrdersListBarButton,
            this.ExitBarButton,
            this.UserBarButton,
            this.OrderBarButton,
            this.UsersListBarButton,
            this.ProductsListBarButton,
            this.ProductBarButton,
            this.ClientBarButton,
            this.RolesBarButton,
            this.CategoriesBarButton});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 4;
            this.mainRibbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonMerge});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(764, 143);
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // OrdersListBarButton
            // 
            this.OrdersListBarButton.Caption = "Orders";
            this.OrdersListBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("OrdersListBarButton.Glyph")));
            this.OrdersListBarButton.Id = 2;
            this.OrdersListBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("OrdersListBarButton.LargeGlyph")));
            this.OrdersListBarButton.Name = "OrdersListBarButton";
            this.OrdersListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OrdersListBarButton_ItemClick);
            // 
            // ExitBarButton
            // 
            this.ExitBarButton.Caption = "Exit";
            this.ExitBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButton.Glyph")));
            this.ExitBarButton.Id = 3;
            this.ExitBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButton.LargeGlyph")));
            this.ExitBarButton.Name = "ExitBarButton";
            this.ExitBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBarButton_ItemClick);
            // 
            // UserBarButton
            // 
            this.UserBarButton.Caption = "User";
            this.UserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("UserBarButton.Glyph")));
            this.UserBarButton.Id = 1;
            this.UserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UserBarButton.LargeGlyph")));
            this.UserBarButton.Name = "UserBarButton";
            this.UserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserBarButton_ItemClick);
            // 
            // OrderBarButton
            // 
            this.OrderBarButton.Caption = "Order";
            this.OrderBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("OrderBarButton.Glyph")));
            this.OrderBarButton.Id = 2;
            this.OrderBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("OrderBarButton.LargeGlyph")));
            this.OrderBarButton.Name = "OrderBarButton";
            this.OrderBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OrderBarButton_ItemClick);
            // 
            // UsersListBarButton
            // 
            this.UsersListBarButton.Caption = "Users";
            this.UsersListBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("UsersListBarButton.Glyph")));
            this.UsersListBarButton.Id = 3;
            this.UsersListBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UsersListBarButton.LargeGlyph")));
            this.UsersListBarButton.Name = "UsersListBarButton";
            this.UsersListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UsersListBarButtonItem_ItemClick);
            // 
            // ProductsListBarButton
            // 
            this.ProductsListBarButton.Caption = "Products";
            this.ProductsListBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ProductsListBarButton.Glyph")));
            this.ProductsListBarButton.Id = 4;
            this.ProductsListBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ProductsListBarButton.LargeGlyph")));
            this.ProductsListBarButton.Name = "ProductsListBarButton";
            this.ProductsListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductsBarButtonItem_ItemClick);
            // 
            // ProductBarButton
            // 
            this.ProductBarButton.Caption = "Product";
            this.ProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ProductBarButton.Glyph")));
            this.ProductBarButton.Id = 5;
            this.ProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ProductBarButton.LargeGlyph")));
            this.ProductBarButton.Name = "ProductBarButton";
            this.ProductBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductBarButtonItem_ItemClick);
            // 
            // RolesBarButton
            // 
            this.RolesBarButton.Caption = "Roles";
            this.RolesBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("RolesBarButton.Glyph")));
            this.RolesBarButton.Id = 1;
            this.RolesBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("RolesBarButton.LargeGlyph")));
            this.RolesBarButton.Name = "RolesBarButton";
            this.RolesBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RolesBarButton_ItemClick);
            // 
            // CategoriesBarButton
            // 
            this.CategoriesBarButton.Caption = "Categories";
            this.CategoriesBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("CategoriesBarButton.Glyph")));
            this.CategoriesBarButton.Id = 2;
            this.CategoriesBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("CategoriesBarButton.LargeGlyph")));
            this.CategoriesBarButton.Name = "CategoriesBarButton";
            this.CategoriesBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CategoriesBarButton_ItemClick);
            // 
            // RibbonMerge
            // 
            this.RibbonMerge.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonUserGroup,
            ribbonClientsGroup,
            this.ribbonOrdersGroup,
            this.ribbonProductsGroup,
            this.systemRibbonGroup});
            this.RibbonMerge.Name = "RibbonMerge";
            this.RibbonMerge.Text = "RibbonMerge";
            // 
            // ribbonUserGroup
            // 
            this.ribbonUserGroup.ItemLinks.Add(this.UsersListBarButton);
            this.ribbonUserGroup.ItemLinks.Add(this.UserBarButton);
            this.ribbonUserGroup.ItemLinks.Add(this.RolesBarButton);
            this.ribbonUserGroup.MergeOrder = 100;
            this.ribbonUserGroup.Name = "ribbonUserGroup";
            this.ribbonUserGroup.Text = "Users";
            // 
            // ribbonOrdersGroup
            // 
            this.ribbonOrdersGroup.ItemLinks.Add(this.OrdersListBarButton, "З");
            this.ribbonOrdersGroup.ItemLinks.Add(this.OrderBarButton);
            this.ribbonOrdersGroup.KeyTip = "Р";
            this.ribbonOrdersGroup.MergeOrder = 300;
            this.ribbonOrdersGroup.Name = "ribbonOrdersGroup";
            this.ribbonOrdersGroup.Text = "Orders";
            // 
            // ribbonProductsGroup
            // 
            this.ribbonProductsGroup.ItemLinks.Add(this.ProductsListBarButton);
            this.ribbonProductsGroup.ItemLinks.Add(this.ProductBarButton);
            this.ribbonProductsGroup.ItemLinks.Add(this.CategoriesBarButton, true);
            this.ribbonProductsGroup.MergeOrder = 400;
            this.ribbonProductsGroup.Name = "ribbonProductsGroup";
            this.ribbonProductsGroup.Text = "Products";
            // 
            // systemRibbonGroup
            // 
            this.systemRibbonGroup.ItemLinks.Add(this.ExitBarButton, "В");
            this.systemRibbonGroup.KeyTip = "0";
            this.systemRibbonGroup.Name = "systemRibbonGroup";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 632);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAIRS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl mainRibbon;
        private RibbonPage RibbonMerge;
        private RibbonPageGroup ribbonOrdersGroup;
        private BarButtonItem ClientsListBarButton;
        private BarButtonItem OrdersListBarButton;
        private BarButtonItem ExitBarButton;
        private RibbonPageGroup systemRibbonGroup;
        private XtraTabbedMdiManager xtraTabbedMdiManager;
        private BarButtonItem UserBarButton;
        private BarButtonItem OrderBarButton;
        private BarButtonItem UsersListBarButton;
        private BarButtonItem ProductsListBarButton;
        private BarButtonItem ProductBarButton;
        private BarButtonItem ClientBarButton;
        private RibbonPageGroup ribbonUserGroup;
        private RibbonPageGroup ribbonProductsGroup;
        private BarButtonItem RolesBarButton;
        private BarButtonItem CategoriesBarButton;
    }
}

