namespace AutoDealer.Manpower.Karyawan
{
    partial class DataBranchManager
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
            this.nama_branchmanager = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.karyawanid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.branchid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_branchmanager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.ImageOptions.Image = global::AutoDealer.Properties.Resources.editname_32x32;
            this.Edit.Location = new System.Drawing.Point(246, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 38);
            this.Edit.TabIndex = 28;
            this.Edit.Text = "Edit";
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 27;
            this.Simpan.Text = "Simpan";
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 26;
            this.Tambah.Text = "Tambah";
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 29;
            this.Hapus.Text = "Hapus";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.nama_branchmanager);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.id);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.karyawanid);
            this.panelControl1.Controls.Add(this.branchid);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(305, 375);
            this.panelControl1.TabIndex = 30;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(323, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(374, 375);
            this.panelControl2.TabIndex = 31;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(370, 371);
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
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(116, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 20);
            this.id.TabIndex = 1;
            // 
            // nama_branchmanager
            // 
            this.nama_branchmanager.Location = new System.Drawing.Point(116, 38);
            this.nama_branchmanager.Name = "nama_branchmanager";
            this.nama_branchmanager.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_branchmanager.Properties.Appearance.Options.UseBackColor = true;
            this.nama_branchmanager.Size = new System.Drawing.Size(164, 20);
            this.nama_branchmanager.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama BM";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Branch";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "KaryawanID";
            // 
            // karyawanid
            // 
            this.karyawanid.Location = new System.Drawing.Point(116, 90);
            this.karyawanid.Name = "karyawanid";
            this.karyawanid.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.karyawanid.Properties.Appearance.Options.UseBackColor = true;
            this.karyawanid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karyawanid.Properties.NullText = "";
            this.karyawanid.Properties.View = this.gridLookUpEdit1View;
            this.karyawanid.Size = new System.Drawing.Size(164, 20);
            this.karyawanid.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // branchid
            // 
            this.branchid.Location = new System.Drawing.Point(116, 64);
            this.branchid.Name = "branchid";
            this.branchid.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.branchid.Properties.Appearance.Options.UseBackColor = true;
            this.branchid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branchid.Properties.NullText = "";
            this.branchid.Properties.View = this.gridView2;
            this.branchid.Size = new System.Drawing.Size(164, 20);
            this.branchid.TabIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // DataBranchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 476);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Hapus);
            this.Name = "DataBranchManager";
            this.Text = "DataBranchManager";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_branchmanager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit nama_branchmanager;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit karyawanid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit branchid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}