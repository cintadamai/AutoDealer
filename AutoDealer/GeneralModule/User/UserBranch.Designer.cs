namespace AutoDealer.GeneralModule.User
{
    partial class UserBranch
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
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.active = new DevExpress.XtraEditors.CheckEdit();
            this.no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.branchname = new DevExpress.XtraEditors.ButtonEdit();
            this.alamat = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.UserGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperson_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.hapusBranch = new DevExpress.XtraEditors.SimpleButton();
            this.tambahBranch = new DevExpress.XtraEditors.SimpleButton();
            this.BranchComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BranchGridControl = new DevExpress.XtraGrid.GridControl();
            this.BranchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbranchname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InputValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.HapusValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.AssignBranchValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.active.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HapusValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBranchValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 11;
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
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 9;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 8;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.active);
            this.panelControl1.Controls.Add(this.no_telepon);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.branchname);
            this.panelControl1.Controls.Add(this.alamat);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(715, 137);
            this.panelControl1.TabIndex = 12;
            // 
            // active
            // 
            this.active.Enabled = false;
            this.active.Location = new System.Drawing.Point(119, 69);
            this.active.Name = "active";
            this.active.Properties.Caption = "Active";
            this.active.Size = new System.Drawing.Size(75, 19);
            this.active.TabIndex = 6;
            // 
            // no_telepon
            // 
            this.no_telepon.Enabled = false;
            this.no_telepon.Location = new System.Drawing.Point(119, 43);
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.no_telepon.Properties.Appearance.Options.UseBackColor = true;
            this.no_telepon.Size = new System.Drawing.Size(156, 20);
            this.no_telepon.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.InputValidationProvider.SetValidationRule(this.no_telepon, conditionValidationRule1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "No Telepon";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(333, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Alamat";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Branch Name";
            // 
            // branchname
            // 
            this.branchname.Enabled = false;
            this.branchname.Location = new System.Drawing.Point(119, 17);
            this.branchname.Name = "branchname";
            this.branchname.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.branchname.Properties.Appearance.Options.UseBackColor = true;
            this.branchname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.branchname.Size = new System.Drawing.Size(185, 20);
            this.branchname.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Tidak Boleh Kosong.";
            this.HapusValidationProvider.SetValidationRule(this.branchname, conditionValidationRule2);
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.InputValidationProvider.SetValidationRule(this.branchname, conditionValidationRule3);
            // 
            // alamat
            // 
            this.alamat.Enabled = false;
            this.alamat.Location = new System.Drawing.Point(430, 17);
            this.alamat.Name = "alamat";
            this.alamat.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.alamat.Properties.Appearance.Options.UseBackColor = true;
            this.alamat.Size = new System.Drawing.Size(152, 57);
            this.alamat.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Harus di isi.";
            this.InputValidationProvider.SetValidationRule(this.alamat, conditionValidationRule4);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.UserGridControl);
            this.panelControl2.Location = new System.Drawing.Point(12, 199);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(356, 308);
            this.panelControl2.TabIndex = 13;
            // 
            // UserGridControl
            // 
            this.UserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridControl.Location = new System.Drawing.Point(2, 2);
            this.UserGridControl.MainView = this.UserGridView;
            this.UserGridControl.Name = "UserGridControl";
            this.UserGridControl.Size = new System.Drawing.Size(352, 304);
            this.UserGridControl.TabIndex = 1;
            this.UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            // 
            // UserGridView
            // 
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusername,
            this.colperson_name});
            this.UserGridView.GridControl = this.UserGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.Editable = false;
            this.UserGridView.OptionsBehavior.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 0;
            // 
            // colperson_name
            // 
            this.colperson_name.Caption = "Nama Karyawan";
            this.colperson_name.FieldName = "person_name";
            this.colperson_name.Name = "colperson_name";
            this.colperson_name.Visible = true;
            this.colperson_name.VisibleIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.BranchGridControl);
            this.panelControl3.Location = new System.Drawing.Point(374, 199);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(353, 308);
            this.panelControl3.TabIndex = 14;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.hapusBranch);
            this.panelControl4.Controls.Add(this.tambahBranch);
            this.panelControl4.Controls.Add(this.BranchComboBoxEdit);
            this.panelControl4.Location = new System.Drawing.Point(5, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(343, 65);
            this.panelControl4.TabIndex = 2;
            // 
            // hapusBranch
            // 
            this.hapusBranch.Location = new System.Drawing.Point(169, 31);
            this.hapusBranch.Name = "hapusBranch";
            this.hapusBranch.Size = new System.Drawing.Size(169, 23);
            this.hapusBranch.TabIndex = 2;
            this.hapusBranch.Text = "Hapus Branch";
            this.hapusBranch.Click += new System.EventHandler(this.HapusBranch_Click);
            // 
            // tambahBranch
            // 
            this.tambahBranch.Location = new System.Drawing.Point(5, 31);
            this.tambahBranch.Name = "tambahBranch";
            this.tambahBranch.Size = new System.Drawing.Size(158, 23);
            this.tambahBranch.TabIndex = 1;
            this.tambahBranch.Text = "Tambah Branch";
            this.tambahBranch.Click += new System.EventHandler(this.TambahBranch_Click);
            // 
            // BranchComboBoxEdit
            // 
            this.BranchComboBoxEdit.Location = new System.Drawing.Point(5, 5);
            this.BranchComboBoxEdit.Name = "BranchComboBoxEdit";
            this.BranchComboBoxEdit.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.BranchComboBoxEdit.Properties.Appearance.Options.UseBackColor = true;
            this.BranchComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchComboBoxEdit.Size = new System.Drawing.Size(333, 20);
            this.BranchComboBoxEdit.TabIndex = 0;
            // 
            // BranchGridControl
            // 
            this.BranchGridControl.Location = new System.Drawing.Point(5, 76);
            this.BranchGridControl.MainView = this.BranchGridView;
            this.BranchGridControl.Name = "BranchGridControl";
            this.BranchGridControl.Size = new System.Drawing.Size(343, 227);
            this.BranchGridControl.TabIndex = 1;
            this.BranchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BranchGridView});
            // 
            // BranchGridView
            // 
            this.BranchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbranchname});
            this.BranchGridView.GridControl = this.BranchGridControl;
            this.BranchGridView.Name = "BranchGridView";
            this.BranchGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.BranchGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.BranchGridView.OptionsBehavior.Editable = false;
            this.BranchGridView.OptionsBehavior.ReadOnly = true;
            // 
            // colbranchname
            // 
            this.colbranchname.Caption = "Branch Name";
            this.colbranchname.FieldName = "branch_name";
            this.colbranchname.Name = "colbranchname";
            this.colbranchname.Visible = true;
            this.colbranchname.VisibleIndex = 0;
            // 
            // UserBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 533);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Name = "UserBranch";
            this.Text = "UserBranch";
            this.Load += new System.EventHandler(this.UserBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.active.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HapusValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBranchValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl BranchGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BranchGridView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit no_telepon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit active;
        private DevExpress.XtraEditors.ButtonEdit branchname;
        private DevExpress.XtraEditors.MemoEdit alamat;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton hapusBranch;
        private DevExpress.XtraEditors.SimpleButton tambahBranch;
        private DevExpress.XtraEditors.ComboBoxEdit BranchComboBoxEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider InputValidationProvider;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider HapusValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colperson_name;
        private DevExpress.XtraGrid.Columns.GridColumn colbranchname;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider AssignBranchValidationProvider;
    }
}