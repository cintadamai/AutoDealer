namespace AutoDealer.Manpower.Karyawan
{
    partial class DataSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSales));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_grade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_karyawan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SalesBS = new System.Windows.Forms.BindingSource(this.components);
            this.SalesXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.SalesUOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_sales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_saleshead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.nama_sales = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.salesheadid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.SHXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.karyawanid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.KaryawanXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.salesgradeid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.SalesGradeXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Batal = new DevExpress.XtraEditors.SimpleButton();
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesheadid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaryawanXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesgradeid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGradeXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colnama_grade});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.Caption = "ID";
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            this.colid2.Visible = true;
            this.colid2.VisibleIndex = 0;
            this.colid2.Width = 192;
            // 
            // colnama_grade
            // 
            this.colnama_grade.Caption = "Nama Grade";
            this.colnama_grade.FieldName = "nama_grade";
            this.colnama_grade.Name = "colnama_grade";
            this.colnama_grade.Visible = true;
            this.colnama_grade.VisibleIndex = 1;
            this.colnama_grade.Width = 876;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colnama_karyawan});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.Caption = "ID";
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            this.colid1.Width = 344;
            // 
            // colnama_karyawan
            // 
            this.colnama_karyawan.Caption = "Nama Karyawan";
            this.colnama_karyawan.FieldName = "nama_karyawan";
            this.colnama_karyawan.Name = "colnama_karyawan";
            this.colnama_karyawan.Visible = true;
            this.colnama_karyawan.VisibleIndex = 1;
            this.colnama_karyawan.Width = 724;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(455, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(403, 461);
            this.panelControl2.TabIndex = 27;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SalesBS;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(399, 457);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SalesBS
            // 
            this.SalesBS.DataSource = this.SalesXpCollection;
            // 
            // SalesXpCollection
            // 
            this.SalesXpCollection.DisplayableProperties = "id;nama_sales;createdAt;updatedAt;deletedAt;version;karyawanId;salesgradeId;sales" +
    "headId;ProspeksModelCollection";
            this.SalesXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.SalesModel);
            this.SalesXpCollection.Session = this.SalesUOW;
            // 
            // SalesUOW
            // 
            this.SalesUOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SalesUOW.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnama_sales,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 99;
            // 
            // colnama_sales
            // 
            this.colnama_sales.Caption = "Nama Sales";
            this.colnama_sales.FieldName = "nama_sales";
            this.colnama_sales.Name = "colnama_sales";
            this.colnama_sales.Visible = true;
            this.colnama_sales.VisibleIndex = 1;
            this.colnama_sales.Width = 282;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sales Head";
            this.gridColumn1.FieldName = "salesheadId.nama_saleshead";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colnama_saleshead});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.Caption = "ID";
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            this.colid3.Visible = true;
            this.colid3.VisibleIndex = 0;
            this.colid3.Width = 154;
            // 
            // colnama_saleshead
            // 
            this.colnama_saleshead.Caption = "Nama Sales Head";
            this.colnama_saleshead.FieldName = "nama_saleshead";
            this.colnama_saleshead.Name = "colnama_saleshead";
            this.colnama_saleshead.Visible = true;
            this.colnama_saleshead.VisibleIndex = 1;
            this.colnama_saleshead.Width = 914;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(15, 72);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "KaryawanID";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Sales Head";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Sales Grade";
            // 
            // nama_sales
            // 
            this.nama_sales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesBS, "nama_sales", true));
            this.nama_sales.Location = new System.Drawing.Point(126, 43);
            this.nama_sales.Name = "nama_sales";
            this.nama_sales.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_sales.Properties.Appearance.Options.UseBackColor = true;
            this.nama_sales.Size = new System.Drawing.Size(233, 20);
            this.nama_sales.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.nama_sales, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama Sales";
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesBS, "id", true));
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(126, 17);
            this.id.Name = "id";
            this.id.Properties.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(120, 20);
            this.id.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // salesheadid
            // 
            this.salesheadid.Location = new System.Drawing.Point(126, 121);
            this.salesheadid.Name = "salesheadid";
            this.salesheadid.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.salesheadid.Properties.Appearance.Options.UseBackColor = true;
            this.salesheadid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.salesheadid.Properties.DataSource = this.SHXpCollection;
            this.salesheadid.Properties.DisplayMember = "nama_saleshead";
            this.salesheadid.Properties.NullText = "";
            this.salesheadid.Properties.PopupFormMinSize = new System.Drawing.Size(500, 0);
            this.salesheadid.Properties.ValueMember = "id";
            this.salesheadid.Properties.View = this.gridView2;
            this.salesheadid.Size = new System.Drawing.Size(219, 20);
            this.salesheadid.TabIndex = 15;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.salesheadid, conditionValidationRule2);
            // 
            // SHXpCollection
            // 
            this.SHXpCollection.DisplayableProperties = "id;nama_saleshead;createdAt;updatedAt;deletedAt;version;karyawanId;salesHeadGrade" +
    "Id;branchManagerId;ProspeksModelCollection";
            this.SHXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.SalesheadsModel);
            this.SHXpCollection.Session = this.SalesUOW;
            // 
            // karyawanid
            // 
            this.karyawanid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SalesBS, "karyawanId", true));
            this.karyawanid.Location = new System.Drawing.Point(126, 69);
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
            this.karyawanid.Properties.View = this.gridView3;
            this.karyawanid.Size = new System.Drawing.Size(219, 20);
            this.karyawanid.TabIndex = 17;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.karyawanid, conditionValidationRule3);
            // 
            // KaryawanXpCollection
            // 
            this.KaryawanXpCollection.DisplayableProperties = resources.GetString("KaryawanXpCollection.DisplayableProperties");
            this.KaryawanXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.KaryawansModel);
            this.KaryawanXpCollection.Session = this.SalesUOW;
            // 
            // salesgradeid
            // 
            this.salesgradeid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SalesBS, "salesgradeId", true));
            this.salesgradeid.Location = new System.Drawing.Point(126, 95);
            this.salesgradeid.Name = "salesgradeid";
            this.salesgradeid.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.salesgradeid.Properties.Appearance.Options.UseBackColor = true;
            this.salesgradeid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.salesgradeid.Properties.DataSource = this.SalesGradeXpCollection;
            this.salesgradeid.Properties.DisplayMember = "nama_grade";
            this.salesgradeid.Properties.NullText = "";
            this.salesgradeid.Properties.PopupFormMinSize = new System.Drawing.Size(500, 0);
            this.salesgradeid.Properties.ValueMember = "id";
            this.salesgradeid.Properties.View = this.gridLookUpEdit1View;
            this.salesgradeid.Size = new System.Drawing.Size(219, 20);
            this.salesgradeid.TabIndex = 13;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Harus di isi.";
            this.validator.SetValidationRule(this.salesgradeid, conditionValidationRule4);
            // 
            // SalesGradeXpCollection
            // 
            this.SalesGradeXpCollection.DisplayableProperties = "id;nama_grade;createdAt;updatedAt;deletedAt;version";
            this.SalesGradeXpCollection.ObjectType = typeof(AutoDealer.DB.its_honda.SalesgradesModel);
            this.SalesGradeXpCollection.Session = this.SalesUOW;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.nama_sales);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.id);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.salesgradeid);
            this.panelControl1.Controls.Add(this.salesheadid);
            this.panelControl1.Controls.Add(this.karyawanid);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(437, 461);
            this.panelControl1.TabIndex = 26;
            // 
            // Batal
            // 
            this.Batal.Enabled = false;
            this.Batal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Batal.ImageOptions.Image")));
            this.Batal.Location = new System.Drawing.Point(246, 12);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(111, 38);
            this.Batal.TabIndex = 27;
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
            this.Hapus.TabIndex = 26;
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
            this.Edit.TabIndex = 25;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Simpan
            // 
            this.Simpan.Enabled = false;
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 24;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 23;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // DataSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Simpan);
            this.Name = "DataSales";
            this.Text = "DataSales";
            this.Load += new System.EventHandler(this.DataSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesheadid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaryawanXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesgradeid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGradeXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit nama_sales;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit salesheadid;
        private DevExpress.XtraEditors.GridLookUpEdit karyawanid;
        private DevExpress.XtraEditors.GridLookUpEdit salesgradeid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Xpo.XPCollection SalesXpCollection;
        private DevExpress.Xpo.UnitOfWork SalesUOW;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_sales;
        private System.Windows.Forms.BindingSource SalesBS;
        private DevExpress.Xpo.XPCollection KaryawanXpCollection;
        private DevExpress.Xpo.XPCollection SalesGradeXpCollection;
        private DevExpress.Xpo.XPCollection SHXpCollection;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton Batal;
        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_karyawan;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_grade;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_saleshead;
    }
}