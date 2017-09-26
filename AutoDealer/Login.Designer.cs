namespace AutoDealer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SPKManagement = new DevExpress.XtraEditors.SimpleButton();
            this.Manpower = new DevExpress.XtraEditors.SimpleButton();
            this.BodyRepair = new DevExpress.XtraEditors.SimpleButton();
            this.About = new DevExpress.XtraEditors.SimpleButton();
            this.Tax = new DevExpress.XtraEditors.SimpleButton();
            this.Finance = new DevExpress.XtraEditors.SimpleButton();
            this.Service = new DevExpress.XtraEditors.SimpleButton();
            this.Sparepart = new DevExpress.XtraEditors.SimpleButton();
            this.Sales = new DevExpress.XtraEditors.SimpleButton();
            this.GeneralModule = new DevExpress.XtraEditors.SimpleButton();
            this.username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Keluar = new DevExpress.XtraEditors.SimpleButton();
            this.Masuk = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.LoginUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUnitOfWork)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SPKManagement);
            this.groupControl1.Controls.Add(this.Manpower);
            this.groupControl1.Controls.Add(this.BodyRepair);
            this.groupControl1.Controls.Add(this.About);
            this.groupControl1.Controls.Add(this.Tax);
            this.groupControl1.Controls.Add(this.Finance);
            this.groupControl1.Controls.Add(this.Service);
            this.groupControl1.Controls.Add(this.Sparepart);
            this.groupControl1.Controls.Add(this.Sales);
            this.groupControl1.Controls.Add(this.GeneralModule);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(59, 320);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 163);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Menu";
            // 
            // SPKManagement
            // 
            this.SPKManagement.Enabled = false;
            this.SPKManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SPKManagement.ImageOptions.Image")));
            this.SPKManagement.Location = new System.Drawing.Point(279, 24);
            this.SPKManagement.Name = "SPKManagement";
            this.SPKManagement.Size = new System.Drawing.Size(126, 36);
            this.SPKManagement.TabIndex = 10;
            this.SPKManagement.Text = "SPKManagement";
            // 
            // Manpower
            // 
            this.Manpower.Enabled = false;
            this.Manpower.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Manpower.ImageOptions.Image")));
            this.Manpower.Location = new System.Drawing.Point(147, 24);
            this.Manpower.Name = "Manpower";
            this.Manpower.Size = new System.Drawing.Size(126, 36);
            this.Manpower.TabIndex = 9;
            this.Manpower.Text = "Manpower (ITS)";
            this.Manpower.Click += new System.EventHandler(this.Manpower_Click);
            // 
            // BodyRepair
            // 
            this.BodyRepair.Enabled = false;
            this.BodyRepair.ImageOptions.Image = global::AutoDealer.Properties.Resources.pagecolor_32x32;
            this.BodyRepair.Location = new System.Drawing.Point(17, 108);
            this.BodyRepair.Name = "BodyRepair";
            this.BodyRepair.Size = new System.Drawing.Size(126, 36);
            this.BodyRepair.TabIndex = 8;
            this.BodyRepair.Text = "Body Repair";
            // 
            // About
            // 
            this.About.ImageOptions.Image = global::AutoDealer.Properties.Resources.tag_32x32;
            this.About.Location = new System.Drawing.Point(413, 108);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(126, 36);
            this.About.TabIndex = 7;
            this.About.Text = "About";
            // 
            // Tax
            // 
            this.Tax.Enabled = false;
            this.Tax.ImageOptions.Image = global::AutoDealer.Properties.Resources.currency2_32x32;
            this.Tax.Location = new System.Drawing.Point(280, 108);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(126, 36);
            this.Tax.TabIndex = 5;
            this.Tax.Text = "Tax";
            // 
            // Finance
            // 
            this.Finance.Enabled = false;
            this.Finance.ImageOptions.Image = global::AutoDealer.Properties.Resources.calculatesheet_32x32;
            this.Finance.Location = new System.Drawing.Point(148, 108);
            this.Finance.Name = "Finance";
            this.Finance.Size = new System.Drawing.Size(126, 36);
            this.Finance.TabIndex = 4;
            this.Finance.Text = "Finance";
            // 
            // Service
            // 
            this.Service.Enabled = false;
            this.Service.ImageOptions.Image = global::AutoDealer.Properties.Resources.showtestreport_32x32;
            this.Service.Location = new System.Drawing.Point(413, 66);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(126, 36);
            this.Service.TabIndex = 3;
            this.Service.Text = "Service";
            // 
            // Sparepart
            // 
            this.Sparepart.Enabled = false;
            this.Sparepart.ImageOptions.Image = global::AutoDealer.Properties.Resources.ide_32x32;
            this.Sparepart.Location = new System.Drawing.Point(281, 66);
            this.Sparepart.Name = "Sparepart";
            this.Sparepart.Size = new System.Drawing.Size(126, 36);
            this.Sparepart.TabIndex = 2;
            this.Sparepart.Text = "Sparepart";
            // 
            // Sales
            // 
            this.Sales.Enabled = false;
            this.Sales.ImageOptions.Image = global::AutoDealer.Properties.Resources.bosale_32x32;
            this.Sales.Location = new System.Drawing.Point(149, 66);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(126, 36);
            this.Sales.TabIndex = 1;
            this.Sales.Text = "Sales";
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // GeneralModule
            // 
            this.GeneralModule.Enabled = false;
            this.GeneralModule.ImageOptions.Image = global::AutoDealer.Properties.Resources.home_32x32;
            this.GeneralModule.Location = new System.Drawing.Point(17, 66);
            this.GeneralModule.Name = "GeneralModule";
            this.GeneralModule.Size = new System.Drawing.Size(126, 36);
            this.GeneralModule.TabIndex = 0;
            this.GeneralModule.Text = "General Module";
            this.GeneralModule.Click += new System.EventHandler(this.GeneralModule_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(311, 183);
            this.username.Name = "username";
            this.username.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.username.Properties.Appearance.Options.UseBackColor = true;
            this.username.Size = new System.Drawing.Size(137, 20);
            this.username.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.dxValidationProvider1.SetValidationRule(this.username, conditionValidationRule1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(232, 185);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(232, 212);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(311, 209);
            this.password.Name = "password";
            this.password.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.password.Properties.Appearance.Options.UseBackColor = true;
            this.password.Properties.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(137, 20);
            this.password.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.dxValidationProvider1.SetValidationRule(this.password, conditionValidationRule2);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(257, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(160, 40);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "AutoDealer";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::AutoDealer.Properties.Resources.home;
            this.pictureEdit1.Location = new System.Drawing.Point(296, 21);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(83, 79);
            this.pictureEdit1.TabIndex = 8;
            // 
            // Keluar
            // 
            this.Keluar.ImageOptions.Image = global::AutoDealer.Properties.Resources.close_32x32;
            this.Keluar.Location = new System.Drawing.Point(349, 254);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(112, 38);
            this.Keluar.TabIndex = 1;
            this.Keluar.Text = "Keluar";
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // Masuk
            // 
            this.Masuk.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x321;
            this.Masuk.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Masuk.ImageOptions.SvgImageSize = new System.Drawing.Size(63, 63);
            this.Masuk.Location = new System.Drawing.Point(224, 254);
            this.Masuk.Name = "Masuk";
            this.Masuk.Size = new System.Drawing.Size(112, 38);
            this.Masuk.TabIndex = 0;
            this.Masuk.Text = "Masuk";
            this.Masuk.Click += new System.EventHandler(this.Masuk_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // LoginUnitOfWork
            // 
            this.LoginUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.LoginUnitOfWork.TrackPropertiesModifications = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 541);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Masuk);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUnitOfWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Masuk;
        private DevExpress.XtraEditors.SimpleButton Keluar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit username;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton GeneralModule;
        private DevExpress.XtraEditors.SimpleButton Sparepart;
        private DevExpress.XtraEditors.SimpleButton Sales;
        private DevExpress.XtraEditors.SimpleButton Finance;
        private DevExpress.XtraEditors.SimpleButton Service;
        private DevExpress.XtraEditors.SimpleButton Tax;
        private DevExpress.XtraEditors.SimpleButton About;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SimpleButton BodyRepair;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton SPKManagement;
        private DevExpress.XtraEditors.SimpleButton Manpower;
        private DevExpress.Xpo.UnitOfWork LoginUnitOfWork;
    }
}
