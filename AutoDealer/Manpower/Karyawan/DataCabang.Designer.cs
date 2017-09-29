namespace AutoDealer.Manpower.Karyawan
{
    partial class DataCabang
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
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.branch_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.fax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.alamat = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.ImageOptions.Image = global::AutoDealer.Properties.Resources.editname_32x32;
            this.Edit.Location = new System.Drawing.Point(246, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 38);
            this.Edit.TabIndex = 32;
            this.Edit.Text = "Edit";
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 31;
            this.Simpan.Text = "Simpan";
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 30;
            this.Tambah.Text = "Tambah";
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 33;
            this.Hapus.Text = "Hapus";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fax);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.email);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.no_telepon);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.branch_name);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.id);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.alamat);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(345, 390);
            this.panelControl1.TabIndex = 34;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(363, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(345, 390);
            this.panelControl2.TabIndex = 35;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(341, 386);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(105, 14);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(138, 20);
            this.id.TabIndex = 1;
            // 
            // branch_name
            // 
            this.branch_name.Location = new System.Drawing.Point(105, 40);
            this.branch_name.Name = "branch_name";
            this.branch_name.Size = new System.Drawing.Size(211, 20);
            this.branch_name.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama Cabang";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Alamat";
            // 
            // no_telepon
            // 
            this.no_telepon.Location = new System.Drawing.Point(105, 144);
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Size = new System.Drawing.Size(138, 20);
            this.no_telepon.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "No Telepon";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(105, 170);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Email";
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(105, 196);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(138, 20);
            this.fax.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Fax";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(105, 66);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(211, 72);
            this.alamat.TabIndex = 5;
            // 
            // DataCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 487);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Hapus);
            this.Name = "DataCabang";
            this.Text = "DataCabang";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit id;
        private DevExpress.XtraEditors.TextEdit fax;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit email;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit no_telepon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit branch_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit alamat;
    }
}