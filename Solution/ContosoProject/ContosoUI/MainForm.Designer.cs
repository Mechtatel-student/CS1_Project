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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.clientsMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ordersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.exitMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Р = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.workRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.systemRibbonGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.clientsMenuBtn,
            this.ordersMenuBtn,
            this.exitMenuBtn});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 1;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Р});
            this.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(890, 79);
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // clientsMenuBtn
            // 
            this.clientsMenuBtn.Caption = "Клиенты";
            this.clientsMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("clientsMenuBtn.Glyph")));
            this.clientsMenuBtn.Id = 1;
            this.clientsMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clientsMenuBtn.LargeGlyph")));
            this.clientsMenuBtn.Name = "clientsMenuBtn";
            this.clientsMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clientsMenuBtn_ItemClick);
            // 
            // ordersMenuBtn
            // 
            this.ordersMenuBtn.Caption = "Заказы";
            this.ordersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.Glyph")));
            this.ordersMenuBtn.Id = 2;
            this.ordersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.LargeGlyph")));
            this.ordersMenuBtn.Name = "ordersMenuBtn";
            this.ordersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ordersMenuBtn_ItemClick);
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Caption = "Выход";
            this.exitMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exitMenuBtn.Glyph")));
            this.exitMenuBtn.Id = 3;
            this.exitMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exitMenuBtn.LargeGlyph")));
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitMenuBtn_ItemClick);
            // 
            // Р
            // 
            this.Р.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.workRibbonPageGroup,
            this.systemRibbonGroup});
            this.Р.Name = "Р";
            this.Р.Text = "Работа";
            // 
            // workRibbonPageGroup
            // 
            this.workRibbonPageGroup.ItemLinks.Add(this.clientsMenuBtn, "К");
            this.workRibbonPageGroup.ItemLinks.Add(this.ordersMenuBtn, "З");
            this.workRibbonPageGroup.KeyTip = "Р";
            this.workRibbonPageGroup.Name = "workRibbonPageGroup";
            this.workRibbonPageGroup.Text = "Работа";
            // 
            // systemRibbonGroup
            // 
            this.systemRibbonGroup.ItemLinks.Add(this.exitMenuBtn, "В");
            this.systemRibbonGroup.KeyTip = "0";
            this.systemRibbonGroup.MergeOrder = 999;
            this.systemRibbonGroup.Name = "systemRibbonGroup";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.ordersMenuBtn);
            this.applicationMenu1.ItemLinks.Add(this.clientsMenuBtn);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.mainRibbon;
            // 
            // MainForm
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 421);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.mainRibbon.SetPopupContextMenu(this, this.applicationMenu1);
            this.Ribbon = this.mainRibbon;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl mainRibbon;
        private RibbonPage Р;
        private RibbonPageGroup workRibbonPageGroup;
        private BarButtonItem clientsMenuBtn;
        private BarButtonItem ordersMenuBtn;
        private BarButtonItem exitMenuBtn;
        private RibbonPageGroup systemRibbonGroup;
        private XtraTabbedMdiManager xtraTabbedMdiManager1;
        private ApplicationMenu applicationMenu1;
    }
}

