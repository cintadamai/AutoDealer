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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCabang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fax = new DevExpress.XtraEditors.TextEdit();
            this.BranchBS = new System.Windows.Forms.BindingSource(this.components);
            this.BranchXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.BranchUOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.branch_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.alamat = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_branch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.Batal = new DevExpress.XtraEditors.SimpleButton();
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchUOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(462, 390);
            this.panelControl1.TabIndex = 34;
            // 
            // fax
            // 
            this.fax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "fax", true));
            this.fax.Location = new System.Drawing.Point(105, 196);
            this.fax.Name = "fax";
            this.fax.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.fax.Properties.Appearance.Options.UseBackColor = true;
            this.fax.Size = new System.Drawing.Size(138, 20);
            this.fax.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is Harus di isi.valid";
            this.validator.SetValidationRule(this.fax, conditionValidationRule1);
            // 
            // BranchBS
            // 
            this.BranchBS.DataSource = this.BranchXpCollection;
            // 
            // BranchXpCollection
            // 
            this.BranchXpCollection.DisplayableProperties = "id;nama_branch;alamat;no_telepon;lat;long1;email;fax;createdAt;updatedAt;deletedA" +
    "t;version;BranchmanagersModelCollection;KaryawansModelCollection";
            this.BranchXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.BranchesModel);
            this.BranchXpCollection.Session = this.BranchUOW;
            // 
            // BranchUOW
            // 
            this.BranchUOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.BranchUOW.TrackPropertiesModifications = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Fax";
            // 
            // email
            // 
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "email", true));
            this.email.Location = new System.Drawing.Point(105, 170);
            this.email.Name = "email";
            this.email.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.email.Properties.Appearance.Options.UseBackColor = true;
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 9;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.email, conditionValidationRule2);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Email";
            // 
            // no_telepon
            // 
            this.no_telepon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "no_telepon", true));
            this.no_telepon.Location = new System.Drawing.Point(105, 144);
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.no_telepon.Properties.Appearance.Options.UseBackColor = true;
            this.no_telepon.Size = new System.Drawing.Size(138, 20);
            this.no_telepon.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.no_telepon, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "No Telepon";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Alamat";
            // 
            // branch_name
            // 
            this.branch_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "nama_branch", true));
            this.branch_name.Location = new System.Drawing.Point(105, 40);
            this.branch_name.Name = "branch_name";
            this.branch_name.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.branch_name.Properties.Appearance.Options.UseBackColor = true;
            this.branch_name.Size = new System.Drawing.Size(272, 20);
            this.branch_name.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.branch_name, conditionValidationRule4);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama Cabang";
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "id", true));
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(105, 14);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(138, 20);
            this.id.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // alamat
            // 
            this.alamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BranchBS, "alamat", true));
            this.alamat.Location = new System.Drawing.Point(105, 66);
            this.alamat.Name = "alamat";
            this.alamat.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.alamat.Properties.Appearance.Options.UseBackColor = true;
            this.alamat.Size = new System.Drawing.Size(291, 72);
            this.alamat.TabIndex = 5;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.alamat, conditionValidationRule5);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(486, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(345, 390);
            this.panelControl2.TabIndex = 35;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.BranchBS;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnama_branch});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 77;
            // 
            // colnama_branch
            // 
            this.colnama_branch.Caption = "Nama Branch";
            this.colnama_branch.FieldName = "nama_branch";
            this.colnama_branch.Name = "colnama_branch";
            this.colnama_branch.Visible = true;
            this.colnama_branch.VisibleIndex = 1;
            this.colnama_branch.Width = 246;
            // 
            // Batal
            // 
            this.Batal.Enabled = false;
            this.Batal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Batal.ImageOptions.Image")));
            this.Batal.Location = new System.Drawing.Point(246, 12);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(111, 38);
            this.Batal.TabIndex = 41;
            this.Batal.Text = "Batal";
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(480, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 40;
            this.Hapus.Text = "Hapus";
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.ImageOptions.Image = global::AutoDealer.Properties.Resources.editname_32x32;
            this.Edit.Location = new System.Drawing.Point(363, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 38);
            this.Edit.TabIndex = 39;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 37;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Simpan
            // 
            this.Simpan.Enabled = false;
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 38;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // DataCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 487);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DataCabang";
            this.Text = "DataCabang";
            this.Load += new System.EventHandler(this.DataCabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchUOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private DevExpress.Xpo.XPCollection BranchXpCollection;
        private DevExpress.Xpo.UnitOfWork BranchUOW;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_branch;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private System.Windows.Forms.BindingSource BranchBS;
        private DevExpress.XtraEditors.SimpleButton Batal;
        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.SimpleButton Simpan;
    }
}