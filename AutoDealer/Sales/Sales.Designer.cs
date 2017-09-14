namespace AutoDealer.Sales
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.UnitModel = new DevExpress.XtraBars.BarButtonItem();
            this.UnitAccessory = new DevExpress.XtraBars.BarButtonItem();
            this.PembelianUnit = new DevExpress.XtraBars.BarButtonItem();
            this.ReturPembelian = new DevExpress.XtraBars.BarButtonItem();
            this.UnitSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Unit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Pembelian = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.UnitModel,
            this.UnitAccessory,
            this.PembelianUnit,
            this.ReturPembelian,
            this.UnitSupplier});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(737, 141);
            // 
            // UnitModel
            // 
            this.UnitModel.Caption = "Unit Model";
            this.UnitModel.Enabled = false;
            this.UnitModel.Id = 1;
            this.UnitModel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UnitModel.ImageOptions.Image")));
            this.UnitModel.Name = "UnitModel";
            this.UnitModel.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.UnitModel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UnitModel_ItemClick);
            // 
            // UnitAccessory
            // 
            this.UnitAccessory.Caption = "Unit Accessory";
            this.UnitAccessory.Enabled = false;
            this.UnitAccessory.Id = 2;
            this.UnitAccessory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UnitAccessory.ImageOptions.Image")));
            this.UnitAccessory.Name = "UnitAccessory";
            this.UnitAccessory.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.UnitAccessory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UnitAccessory_ItemClick);
            // 
            // PembelianUnit
            // 
            this.PembelianUnit.Caption = "Pembelian";
            this.PembelianUnit.Enabled = false;
            this.PembelianUnit.Id = 3;
            this.PembelianUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PembelianUnit.ImageOptions.Image")));
            this.PembelianUnit.Name = "PembelianUnit";
            this.PembelianUnit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ReturPembelian
            // 
            this.ReturPembelian.Caption = "Retur Pembelian";
            this.ReturPembelian.Enabled = false;
            this.ReturPembelian.Id = 4;
            this.ReturPembelian.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReturPembelian.ImageOptions.Image")));
            this.ReturPembelian.Name = "ReturPembelian";
            this.ReturPembelian.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // UnitSupplier
            // 
            this.UnitSupplier.Caption = "Supplier";
            this.UnitSupplier.Enabled = false;
            this.UnitSupplier.Id = 5;
            this.UnitSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UnitSupplier.ImageOptions.Image")));
            this.UnitSupplier.Name = "UnitSupplier";
            this.UnitSupplier.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.UnitSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UnitSupplier_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Unit});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Unit";
            // 
            // Unit
            // 
            this.Unit.Enabled = false;
            this.Unit.ItemLinks.Add(this.UnitModel);
            this.Unit.ItemLinks.Add(this.UnitAccessory);
            this.Unit.Name = "Unit";
            this.Unit.Text = "Unit";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Pembelian});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Pembelian";
            // 
            // Pembelian
            // 
            this.Pembelian.Enabled = false;
            this.Pembelian.ItemLinks.Add(this.UnitSupplier);
            this.Pembelian.ItemLinks.Add(this.PembelianUnit);
            this.Pembelian.ItemLinks.Add(this.ReturPembelian);
            this.Pembelian.Name = "Pembelian";
            this.Pembelian.Text = "Pembelian";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 482);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Unit;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem UnitModel;
        private DevExpress.XtraBars.BarButtonItem UnitAccessory;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Pembelian;
        private DevExpress.XtraBars.BarButtonItem PembelianUnit;
        private DevExpress.XtraBars.BarButtonItem ReturPembelian;
        private DevExpress.XtraBars.BarButtonItem UnitSupplier;
    }
}