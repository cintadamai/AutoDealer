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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBranchManager));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nama_branchmanager = new DevExpress.XtraEditors.TextEdit();
            this.BMBS = new System.Windows.Forms.BindingSource(this.components);
            this.BMXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.BMUOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.karyawanid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.KaryawanXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.branchid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.BranchXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_branchmanager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Batal = new DevExpress.XtraEditors.SimpleButton();
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_branch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_karyawan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_branchmanager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMUOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaryawanXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(485, 375);
            this.panelControl1.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "KaryawanID";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Branch";
            // 
            // nama_branchmanager
            // 
            this.nama_branchmanager.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BMBS, "nama_branchmanager", true));
            this.nama_branchmanager.Location = new System.Drawing.Point(116, 38);
            this.nama_branchmanager.Name = "nama_branchmanager";
            this.nama_branchmanager.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_branchmanager.Properties.Appearance.Options.UseBackColor = true;
            this.nama_branchmanager.Size = new System.Drawing.Size(164, 20);
            this.nama_branchmanager.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.nama_branchmanager, conditionValidationRule1);
            // 
            // BMBS
            // 
            this.BMBS.DataSource = this.BMXpCollection;
            // 
            // BMXpCollection
            // 
            this.BMXpCollection.DisplayableProperties = "id;nama_branchmanager;createdAt;updatedAt;deletedAt;version;karyawanId;branchId;g" +
    "eneralmanagerId;ProspeksModelCollection;SalesheadsModelCollection";
            this.BMXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.BranchmanagersModel);
            this.BMXpCollection.Session = this.BMUOW;
            // 
            // BMUOW
            // 
            this.BMUOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.BMUOW.TrackPropertiesModifications = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama BM";
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BMBS, "id", true));
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(116, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 20);
            this.id.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // karyawanid
            // 
            this.karyawanid.Location = new System.Drawing.Point(116, 90);
            this.karyawanid.Name = "karyawanid";
            this.karyawanid.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.karyawanid.Properties.Appearance.Options.UseBackColor = true;
            this.karyawanid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karyawanid.Properties.DataSource = this.KaryawanXpCollection;
            this.karyawanid.Properties.DisplayMember = "nama_karyawan";
            this.karyawanid.Properties.NullText = "";
            this.karyawanid.Properties.PopupFormMinSize = new System.Drawing.Size(500, 0);
            this.karyawanid.Properties.ValueMember = "id";
            this.karyawanid.Properties.View = this.gridLookUpEdit1View;
            this.karyawanid.Size = new System.Drawing.Size(174, 20);
            this.karyawanid.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.karyawanid, conditionValidationRule2);
            // 
            // KaryawanXpCollection
            // 
            this.KaryawanXpCollection.DisplayableProperties = resources.GetString("KaryawanXpCollection.DisplayableProperties");
            this.KaryawanXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.KaryawansModel);
            this.KaryawanXpCollection.Session = this.BMUOW;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colnama_karyawan});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
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
            this.branchid.Properties.DataSource = this.BranchXpCollection;
            this.branchid.Properties.DisplayMember = "nama_branch";
            this.branchid.Properties.NullText = "";
            this.branchid.Properties.PopupFormMinSize = new System.Drawing.Size(500, 0);
            this.branchid.Properties.ValueMember = "id";
            this.branchid.Properties.View = this.gridView2;
            this.branchid.Size = new System.Drawing.Size(295, 20);
            this.branchid.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.branchid, conditionValidationRule3);
            // 
            // BranchXpCollection
            // 
            this.BranchXpCollection.DisplayableProperties = "id;nama_branch;alamat;no_telepon;lat;long1;email;fax;createdAt;updatedAt;deletedA" +
    "t;version;BranchmanagersModelCollection;KaryawansModelCollection";
            this.BranchXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.BranchesModel);
            this.BranchXpCollection.Session = this.BMUOW;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colnama_branch});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(503, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(374, 375);
            this.panelControl2.TabIndex = 31;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.BMBS;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnama_branchmanager});
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
            this.colid.Width = 217;
            // 
            // colnama_branchmanager
            // 
            this.colnama_branchmanager.Caption = "Nama Branch Manager";
            this.colnama_branchmanager.FieldName = "nama_branchmanager";
            this.colnama_branchmanager.Name = "colnama_branchmanager";
            this.colnama_branchmanager.Visible = true;
            this.colnama_branchmanager.VisibleIndex = 1;
            this.colnama_branchmanager.Width = 851;
            // 
            // Batal
            // 
            this.Batal.Enabled = false;
            this.Batal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Batal.ImageOptions.Image")));
            this.Batal.Location = new System.Drawing.Point(246, 12);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(111, 38);
            this.Batal.TabIndex = 36;
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
            this.Hapus.TabIndex = 35;
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
            this.Edit.TabIndex = 34;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 32;
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
            this.Simpan.TabIndex = 33;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // colid1
            // 
            this.colid1.Caption = "ID";
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            this.colid1.Width = 156;
            // 
            // colnama_branch
            // 
            this.colnama_branch.Caption = "Nama Branch";
            this.colnama_branch.FieldName = "nama_branch";
            this.colnama_branch.Name = "colnama_branch";
            this.colnama_branch.Visible = true;
            this.colnama_branch.VisibleIndex = 1;
            this.colnama_branch.Width = 912;
            // 
            // colid2
            // 
            this.colid2.Caption = "ID";
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            this.colid2.Visible = true;
            this.colid2.VisibleIndex = 0;
            this.colid2.Width = 270;
            // 
            // colnama_karyawan
            // 
            this.colnama_karyawan.Caption = "Nama Karyawan";
            this.colnama_karyawan.FieldName = "nama_karyawan";
            this.colnama_karyawan.Name = "colnama_karyawan";
            this.colnama_karyawan.Visible = true;
            this.colnama_karyawan.VisibleIndex = 1;
            this.colnama_karyawan.Width = 798;
            // 
            // DataBranchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 476);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DataBranchManager";
            this.Text = "DataBranchManager";
            this.Load += new System.EventHandler(this.DataBranchManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_branchmanager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMUOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaryawanXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit nama_branchmanager;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit karyawanid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit branchid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton Batal;
        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.Xpo.XPCollection BMXpCollection;
        private DevExpress.Xpo.UnitOfWork BMUOW;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_branchmanager;
        private System.Windows.Forms.BindingSource BMBS;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.Xpo.XPCollection BranchXpCollection;
        private DevExpress.Xpo.XPCollection KaryawanXpCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_karyawan;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_branch;
    }
}