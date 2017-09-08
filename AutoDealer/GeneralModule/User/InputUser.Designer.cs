namespace AutoDealer.GeneralModule.User
{
    partial class InputUser
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.person_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.branch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.active = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.username = new DevExpress.XtraEditors.ButtonEdit();
            this.Validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.person_name);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.branch);
            this.panelControl1.Controls.Add(this.active);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.username);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(684, 398);
            this.panelControl1.TabIndex = 4;
            // 
            // person_name
            // 
            this.person_name.Enabled = false;
            this.person_name.Location = new System.Drawing.Point(125, 40);
            this.person_name.Name = "person_name";
            this.person_name.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.person_name.Properties.Appearance.Options.UseBackColor = true;
            this.person_name.Size = new System.Drawing.Size(144, 20);
            this.person_name.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Nama Karyawan";
            // 
            // branch
            // 
            this.branch.Enabled = false;
            this.branch.Location = new System.Drawing.Point(125, 66);
            this.branch.Name = "branch";
            this.branch.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.branch.Properties.Appearance.Options.UseBackColor = true;
            this.branch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branch.Size = new System.Drawing.Size(174, 20);
            this.branch.TabIndex = 7;
            // 
            // active
            // 
            this.active.Enabled = false;
            this.active.Location = new System.Drawing.Point(125, 92);
            this.active.Name = "active";
            this.active.Properties.Caption = "Active";
            this.active.Size = new System.Drawing.Size(75, 19);
            this.active.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Default Branch";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(125, 14);
            this.username.Name = "username";
            this.username.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.username.Properties.Appearance.Options.UseBackColor = true;
            this.username.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.username.Size = new System.Drawing.Size(110, 20);
            this.username.TabIndex = 1;
            // 
            // Hapus
            // 
            this.Hapus.Enabled = false;
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 3;
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
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 1;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 0;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // InputUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 495);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Name = "InputUser";
            this.Text = "InputUser";
            this.Load += new System.EventHandler(this.InputUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Tambah;
        private DevExpress.XtraEditors.SimpleButton Simpan;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Hapus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit active;
        private DevExpress.XtraEditors.ComboBoxEdit branch;
        private DevExpress.XtraEditors.TextEdit person_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Validator;
        private DevExpress.XtraEditors.ButtonEdit username;
    }
}