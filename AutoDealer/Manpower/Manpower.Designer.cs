namespace AutoDealer.Manpower
{
    partial class Manpower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manpower));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DataKaryawan = new DevExpress.XtraBars.BarButtonItem();
            this.DataSales = new DevExpress.XtraBars.BarButtonItem();
            this.DataSaleshead = new DevExpress.XtraBars.BarButtonItem();
            this.DataCabang = new DevExpress.XtraBars.BarButtonItem();
            this.DataBranchManager = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Karyawan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.DataKaryawan,
            this.DataSales,
            this.DataSaleshead,
            this.DataCabang,
            this.DataBranchManager});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(813, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // DataKaryawan
            // 
            this.DataKaryawan.Caption = "Data Karyawan";
            this.DataKaryawan.Id = 1;
            this.DataKaryawan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DataKaryawan.ImageOptions.Image")));
            this.DataKaryawan.Name = "DataKaryawan";
            this.DataKaryawan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DataKaryawan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DataKaryawan_ItemClick);
            // 
            // DataSales
            // 
            this.DataSales.Caption = "Data Sales";
            this.DataSales.Id = 2;
            this.DataSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DataSales.ImageOptions.Image")));
            this.DataSales.Name = "DataSales";
            this.DataSales.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DataSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DataSales_ItemClick);
            // 
            // DataSaleshead
            // 
            this.DataSaleshead.Caption = "Data Saleshead";
            this.DataSaleshead.Id = 3;
            this.DataSaleshead.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DataSaleshead.ImageOptions.Image")));
            this.DataSaleshead.Name = "DataSaleshead";
            this.DataSaleshead.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DataSaleshead.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DataSaleshead_ItemClick);
            // 
            // DataCabang
            // 
            this.DataCabang.Caption = "Data Cabang";
            this.DataCabang.Id = 4;
            this.DataCabang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DataCabang.ImageOptions.Image")));
            this.DataCabang.Name = "DataCabang";
            this.DataCabang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DataCabang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DataCabang_ItemClick);
            // 
            // DataBranchManager
            // 
            this.DataBranchManager.Caption = "Data Branch Manager";
            this.DataBranchManager.Id = 5;
            this.DataBranchManager.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DataBranchManager.ImageOptions.Image")));
            this.DataBranchManager.Name = "DataBranchManager";
            this.DataBranchManager.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DataBranchManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DataBranchManager_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Karyawan});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Karyawan";
            // 
            // Karyawan
            // 
            this.Karyawan.ItemLinks.Add(this.DataKaryawan);
            this.Karyawan.ItemLinks.Add(this.DataSales);
            this.Karyawan.ItemLinks.Add(this.DataSaleshead);
            this.Karyawan.ItemLinks.Add(this.DataBranchManager);
            this.Karyawan.ItemLinks.Add(this.DataCabang);
            this.Karyawan.Name = "Karyawan";
            this.Karyawan.Text = "Karyawan";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Manpower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 494);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Manpower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manpower";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Karyawan;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem DataKaryawan;
        private DevExpress.XtraBars.BarButtonItem DataSales;
        private DevExpress.XtraBars.BarButtonItem DataSaleshead;
        private DevExpress.XtraBars.BarButtonItem DataCabang;
        private DevExpress.XtraBars.BarButtonItem DataBranchManager;
    }
}