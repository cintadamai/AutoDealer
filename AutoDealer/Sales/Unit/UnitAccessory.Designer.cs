namespace AutoDealer.Sales.Unit
{
    partial class UnitAccessory
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
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.AccessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessoryXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.AccessoryUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkode_accessory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_accessory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nama_accessory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.kode_accessory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_accessory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_accessory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).BeginInit();
            this.SuspendLayout();
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 19;
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
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 17;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 16;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(447, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(495, 287);
            this.panelControl1.TabIndex = 20;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.AccessoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(491, 283);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // AccessoryBindingSource
            // 
            this.AccessoryBindingSource.DataSource = this.AccessoryXpCollection;
            // 
            // AccessoryXpCollection
            // 
            this.AccessoryXpCollection.DeleteObjectOnRemove = true;
            this.AccessoryXpCollection.ObjectType = typeof(AutoDealer.DB.DMS.UnitAccessoryModel);
            this.AccessoryXpCollection.Session = this.AccessoryUnitOfWork;
            // 
            // AccessoryUnitOfWork
            // 
            this.AccessoryUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.AccessoryUnitOfWork.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colkode_accessory,
            this.colnama_accessory});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 81;
            // 
            // colkode_accessory
            // 
            this.colkode_accessory.Caption = "Kode Accessory";
            this.colkode_accessory.FieldName = "kode_accessory";
            this.colkode_accessory.Name = "colkode_accessory";
            this.colkode_accessory.Visible = true;
            this.colkode_accessory.VisibleIndex = 1;
            this.colkode_accessory.Width = 195;
            // 
            // colnama_accessory
            // 
            this.colnama_accessory.Caption = "Nama Accessory";
            this.colnama_accessory.FieldName = "nama_accessory";
            this.colnama_accessory.Name = "colnama_accessory";
            this.colnama_accessory.Visible = true;
            this.colnama_accessory.VisibleIndex = 2;
            this.colnama_accessory.Width = 792;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nama Accessory";
            // 
            // nama_accessory
            // 
            this.nama_accessory.Location = new System.Drawing.Point(117, 74);
            this.nama_accessory.Name = "nama_accessory";
            this.nama_accessory.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_accessory.Properties.Appearance.Options.UseBackColor = true;
            this.nama_accessory.Size = new System.Drawing.Size(264, 20);
            this.nama_accessory.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.nama_accessory, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kode Accessory";
            // 
            // kode_accessory
            // 
            this.kode_accessory.Location = new System.Drawing.Point(117, 48);
            this.kode_accessory.Name = "kode_accessory";
            this.kode_accessory.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.kode_accessory.Properties.Appearance.Options.UseBackColor = true;
            this.kode_accessory.Size = new System.Drawing.Size(171, 20);
            this.kode_accessory.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.kode_accessory, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(117, 22);
            this.id.Name = "id";
            this.id.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.id.Properties.Appearance.Options.UseBackColor = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.nama_accessory);
            this.panelControl2.Controls.Add(this.id);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.kode_accessory);
            this.panelControl2.Location = new System.Drawing.Point(12, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(429, 289);
            this.panelControl2.TabIndex = 21;
            // 
            // UnitAccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 493);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Name = "UnitAccessory";
            this.Text = "UnitAccessory";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_accessory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_accessory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).EndInit();
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
        private DevExpress.Xpo.UnitOfWork AccessoryUnitOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colkode_accessory;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_accessory;
        private DevExpress.XtraEditors.TextEdit id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit nama_accessory;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit kode_accessory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Validator;
        private System.Windows.Forms.BindingSource AccessoryBindingSource;
        private DevExpress.Xpo.XPCollection AccessoryXpCollection;
    }
}