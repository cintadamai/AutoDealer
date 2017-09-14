namespace AutoDealer.Sales.Pembelian
{
    partial class Supplier
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nama_npwp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.npwp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nama_supplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.kode_supplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.alamat = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.SupplierUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkode_supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_telepon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnpwp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_npwp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_npwp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npwp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 23;
            this.Hapus.Text = "Hapus";
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.ImageOptions.Image = global::AutoDealer.Properties.Resources.editname_32x32;
            this.Edit.Location = new System.Drawing.Point(246, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 38);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 21;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 20;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.nama_npwp);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.npwp);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.no_telepon);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.nama_supplier);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.kode_supplier);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.alamat);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(390, 290);
            this.panelControl1.TabIndex = 24;
            // 
            // nama_npwp
            // 
            this.nama_npwp.Enabled = false;
            this.nama_npwp.Location = new System.Drawing.Point(117, 176);
            this.nama_npwp.Name = "nama_npwp";
            this.nama_npwp.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_npwp.Properties.Appearance.Options.UseBackColor = true;
            this.nama_npwp.Size = new System.Drawing.Size(231, 20);
            this.nama_npwp.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.nama_npwp, conditionValidationRule1);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 179);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Nama NPWP";
            // 
            // npwp
            // 
            this.npwp.Enabled = false;
            this.npwp.Location = new System.Drawing.Point(117, 150);
            this.npwp.Name = "npwp";
            this.npwp.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.npwp.Properties.Appearance.Options.UseBackColor = true;
            this.npwp.Size = new System.Drawing.Size(153, 20);
            this.npwp.TabIndex = 9;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.npwp, conditionValidationRule2);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "NPWP";
            // 
            // no_telepon
            // 
            this.no_telepon.Enabled = false;
            this.no_telepon.Location = new System.Drawing.Point(117, 66);
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.no_telepon.Properties.Appearance.Options.UseBackColor = true;
            this.no_telepon.Size = new System.Drawing.Size(153, 20);
            this.no_telepon.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.no_telepon, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "No Telepon";
            // 
            // nama_supplier
            // 
            this.nama_supplier.Enabled = false;
            this.nama_supplier.Location = new System.Drawing.Point(117, 40);
            this.nama_supplier.Name = "nama_supplier";
            this.nama_supplier.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_supplier.Properties.Appearance.Options.UseBackColor = true;
            this.nama_supplier.Size = new System.Drawing.Size(231, 20);
            this.nama_supplier.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.nama_supplier, conditionValidationRule4);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nama Supplier";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Alamat";
            // 
            // kode_supplier
            // 
            this.kode_supplier.Enabled = false;
            this.kode_supplier.Location = new System.Drawing.Point(117, 14);
            this.kode_supplier.Name = "kode_supplier";
            this.kode_supplier.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.kode_supplier.Properties.Appearance.Options.UseBackColor = true;
            this.kode_supplier.Size = new System.Drawing.Size(126, 20);
            this.kode_supplier.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kode Supplier";
            // 
            // alamat
            // 
            this.alamat.Enabled = false;
            this.alamat.Location = new System.Drawing.Point(117, 92);
            this.alamat.Name = "alamat";
            this.alamat.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.alamat.Properties.Appearance.Options.UseBackColor = true;
            this.alamat.Size = new System.Drawing.Size(202, 52);
            this.alamat.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.alamat, conditionValidationRule5);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(408, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(804, 290);
            this.panelControl2.TabIndex = 25;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SupplierBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 286);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataSource = this.SupplierXpCollection;
            // 
            // SupplierXpCollection
            // 
            this.SupplierXpCollection.DeleteObjectOnRemove = true;
            this.SupplierXpCollection.DisplayableProperties = "kode_supplier;nama_supplier;alamat;no_telepon;npwp;nama_npwp;created_by;updated_b" +
    "y;created_at;updated_at";
            this.SupplierXpCollection.ObjectType = typeof(AutoDealer.DB.DMS.UnitSupplierModel);
            this.SupplierXpCollection.Session = this.SupplierUnitOfWork;
            // 
            // SupplierUnitOfWork
            // 
            this.SupplierUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SupplierUnitOfWork.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkode_supplier,
            this.colnama_supplier,
            this.colalamat1,
            this.colno_telepon,
            this.colnpwp,
            this.colnama_npwp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colalamat1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colkode_supplier
            // 
            this.colkode_supplier.Caption = "Kode Supplier";
            this.colkode_supplier.FieldName = "kode_supplier";
            this.colkode_supplier.Name = "colkode_supplier";
            this.colkode_supplier.Visible = true;
            this.colkode_supplier.VisibleIndex = 0;
            this.colkode_supplier.Width = 178;
            // 
            // colnama_supplier
            // 
            this.colnama_supplier.Caption = "Nama Supplier";
            this.colnama_supplier.FieldName = "nama_supplier";
            this.colnama_supplier.Name = "colnama_supplier";
            this.colnama_supplier.Visible = true;
            this.colnama_supplier.VisibleIndex = 1;
            this.colnama_supplier.Width = 214;
            // 
            // colalamat1
            // 
            this.colalamat1.Caption = "Alamat";
            this.colalamat1.FieldName = "alamat";
            this.colalamat1.Name = "colalamat1";
            this.colalamat1.Visible = true;
            this.colalamat1.VisibleIndex = 2;
            this.colalamat1.Width = 167;
            // 
            // colno_telepon
            // 
            this.colno_telepon.Caption = "No Telepon";
            this.colno_telepon.FieldName = "no_telepon";
            this.colno_telepon.Name = "colno_telepon";
            this.colno_telepon.Visible = true;
            this.colno_telepon.VisibleIndex = 3;
            this.colno_telepon.Width = 167;
            // 
            // colnpwp
            // 
            this.colnpwp.Caption = "NPWP";
            this.colnpwp.FieldName = "npwp";
            this.colnpwp.Name = "colnpwp";
            this.colnpwp.Visible = true;
            this.colnpwp.VisibleIndex = 4;
            this.colnpwp.Width = 167;
            // 
            // colnama_npwp
            // 
            this.colnama_npwp.Caption = "Nama NPWP";
            this.colnama_npwp.FieldName = "nama_npwp";
            this.colnama_npwp.Name = "colnama_npwp";
            this.colnama_npwp.Visible = true;
            this.colnama_npwp.VisibleIndex = 5;
            this.colnama_npwp.Width = 175;
            // 
            // colalamat
            // 
            this.colalamat.FieldName = "alamat";
            this.colalamat.Name = "colalamat";
            this.colalamat.Visible = true;
            this.colalamat.VisibleIndex = 2;
            this.colalamat.Width = 115;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.Tambah);
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.Simpan);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.Edit);
            this.xtraScrollableControl1.Controls.Add(this.Hapus);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1225, 490);
            this.xtraScrollableControl1.TabIndex = 26;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 490);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_npwp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npwp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_supplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_supplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection SupplierXpCollection;
        private DevExpress.Xpo.UnitOfWork SupplierUnitOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat;
        private DevExpress.XtraGrid.Columns.GridColumn colkode_supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat1;
        private DevExpress.XtraGrid.Columns.GridColumn colno_telepon;
        private DevExpress.XtraGrid.Columns.GridColumn colnpwp;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_npwp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit kode_supplier;
        private DevExpress.XtraEditors.TextEdit nama_supplier;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit no_telepon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit alamat;
        private DevExpress.XtraEditors.TextEdit npwp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit nama_npwp;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Validator;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}