namespace AutoDealer.GeneralModule
{
    partial class GeneralModule
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
            this.GeneralModuleRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.InputUser = new DevExpress.XtraBars.BarButtonItem();
            this.UserRoles = new DevExpress.XtraBars.BarButtonItem();
            this.UserBranch = new DevExpress.XtraBars.BarButtonItem();
            this.ClockBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.UserRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.UserRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GeneralModuleRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GeneralModuleXtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralModuleRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralModuleXtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralModuleRibbonControl
            // 
            this.GeneralModuleRibbonControl.ExpandCollapseItem.Id = 0;
            this.GeneralModuleRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.GeneralModuleRibbonControl.ExpandCollapseItem,
            this.InputUser,
            this.UserRoles,
            this.UserBranch,
            this.ClockBarStaticItem});
            this.GeneralModuleRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.GeneralModuleRibbonControl.MaxItemId = 6;
            this.GeneralModuleRibbonControl.Name = "GeneralModuleRibbonControl";
            this.GeneralModuleRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.UserRibbonPage});
            this.GeneralModuleRibbonControl.Size = new System.Drawing.Size(833, 141);
            this.GeneralModuleRibbonControl.StatusBar = this.GeneralModuleRibbonStatusBar;
            // 
            // InputUser
            // 
            this.InputUser.Caption = "Input User";
            this.InputUser.Enabled = false;
            this.InputUser.Id = 1;
            this.InputUser.ImageOptions.Image = global::AutoDealer.Properties.Resources.bocustomer_32x32;
            this.InputUser.Name = "InputUser";
            this.InputUser.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.InputUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InputUser_ItemClick);
            // 
            // UserRoles
            // 
            this.UserRoles.Caption = "User Roles";
            this.UserRoles.Enabled = false;
            this.UserRoles.Id = 2;
            this.UserRoles.ImageOptions.Image = global::AutoDealer.Properties.Resources.borole_32x32;
            this.UserRoles.Name = "UserRoles";
            this.UserRoles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // UserBranch
            // 
            this.UserBranch.Caption = "User Branch";
            this.UserBranch.Enabled = false;
            this.UserBranch.Id = 3;
            this.UserBranch.ImageOptions.Image = global::AutoDealer.Properties.Resources.boposition2_32x32;
            this.UserBranch.Name = "UserBranch";
            this.UserBranch.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ClockBarStaticItem
            // 
            this.ClockBarStaticItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ClockBarStaticItem.Caption = "Jam";
            this.ClockBarStaticItem.Id = 5;
            this.ClockBarStaticItem.Name = "ClockBarStaticItem";
            // 
            // UserRibbonPage
            // 
            this.UserRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.UserRibbonPageGroup});
            this.UserRibbonPage.Name = "UserRibbonPage";
            this.UserRibbonPage.Text = "User";
            // 
            // UserRibbonPageGroup
            // 
            this.UserRibbonPageGroup.Enabled = false;
            this.UserRibbonPageGroup.ItemLinks.Add(this.InputUser);
            this.UserRibbonPageGroup.ItemLinks.Add(this.UserRoles);
            this.UserRibbonPageGroup.ItemLinks.Add(this.UserBranch);
            this.UserRibbonPageGroup.Name = "UserRibbonPageGroup";
            this.UserRibbonPageGroup.Text = "User";
            // 
            // GeneralModuleRibbonStatusBar
            // 
            this.GeneralModuleRibbonStatusBar.ItemLinks.Add(this.ClockBarStaticItem);
            this.GeneralModuleRibbonStatusBar.Location = new System.Drawing.Point(0, 511);
            this.GeneralModuleRibbonStatusBar.Name = "GeneralModuleRibbonStatusBar";
            this.GeneralModuleRibbonStatusBar.Ribbon = this.GeneralModuleRibbonControl;
            this.GeneralModuleRibbonStatusBar.Size = new System.Drawing.Size(833, 27);
            // 
            // GeneralModuleXtraTabbedMdiManager
            // 
            this.GeneralModuleXtraTabbedMdiManager.MdiParent = this;
            // 
            // GeneralModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 538);
            this.Controls.Add(this.GeneralModuleRibbonStatusBar);
            this.Controls.Add(this.GeneralModuleRibbonControl);
            this.IsMdiContainer = true;
            this.Name = "GeneralModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeneralModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralModuleRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralModuleXtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl GeneralModuleRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage UserRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem InputUser;
        private DevExpress.XtraBars.BarButtonItem UserRoles;
        private DevExpress.XtraBars.BarButtonItem UserBranch;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager GeneralModuleXtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar GeneralModuleRibbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem ClockBarStaticItem;
    }
}