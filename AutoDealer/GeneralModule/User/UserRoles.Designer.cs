namespace AutoDealer.GeneralModule.User
{
    partial class UserRoles
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Roles");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("User Branch");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("User", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("General Module", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Unit Model");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Unit Accessory");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Unit", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sales", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Sparepart");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Service");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Body Repair");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Finance");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Tax");
            this.Hapus = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.UserGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.RemoveUser = new DevExpress.XtraEditors.SimpleButton();
            this.AddUser = new DevExpress.XtraEditors.SimpleButton();
            this.RolesComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PermissionTreeView = new System.Windows.Forms.TreeView();
            this.UserRolesUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserRolesUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // Hapus
            // 
            this.Hapus.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x321;
            this.Hapus.Location = new System.Drawing.Point(363, 12);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(111, 38);
            this.Hapus.TabIndex = 7;
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
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            // 
            // Simpan
            // 
            this.Simpan.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x322;
            this.Simpan.Location = new System.Drawing.Point(129, 12);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(111, 38);
            this.Simpan.TabIndex = 5;
            this.Simpan.Text = "Simpan";
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Tambah
            // 
            this.Tambah.ImageOptions.Image = global::AutoDealer.Properties.Resources.add_32x32;
            this.Tambah.Location = new System.Drawing.Point(12, 12);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(111, 38);
            this.Tambah.TabIndex = 4;
            this.Tambah.Text = "Tambah";
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.UserGridControl);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(255, 441);
            this.panelControl1.TabIndex = 8;
            // 
            // UserGridControl
            // 
            this.UserGridControl.Location = new System.Drawing.Point(10, 74);
            this.UserGridControl.MainView = this.UserGridView;
            this.UserGridControl.Name = "UserGridControl";
            this.UserGridControl.Size = new System.Drawing.Size(240, 362);
            this.UserGridControl.TabIndex = 1;
            this.UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            // 
            // UserGridView
            // 
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusername});
            this.UserGridView.GridControl = this.UserGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.Editable = false;
            this.UserGridView.OptionsBehavior.ReadOnly = true;
            this.UserGridView.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.RemoveUser);
            this.panelControl3.Controls.Add(this.AddUser);
            this.panelControl3.Controls.Add(this.RolesComboBoxEdit);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(245, 63);
            this.panelControl3.TabIndex = 0;
            // 
            // RemoveUser
            // 
            this.RemoveUser.Location = new System.Drawing.Point(124, 31);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(116, 23);
            this.RemoveUser.TabIndex = 2;
            this.RemoveUser.Text = "Hapus User";
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(5, 31);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(113, 23);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Tambah User";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // RolesComboBoxEdit
            // 
            this.RolesComboBoxEdit.Location = new System.Drawing.Point(5, 5);
            this.RolesComboBoxEdit.Name = "RolesComboBoxEdit";
            this.RolesComboBoxEdit.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.RolesComboBoxEdit.Properties.Appearance.Options.UseBackColor = true;
            this.RolesComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RolesComboBoxEdit.Size = new System.Drawing.Size(235, 20);
            this.RolesComboBoxEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Tidak Boleh Kosong.";
            this.validator.SetValidationRule(this.RolesComboBoxEdit, conditionValidationRule1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.PermissionTreeView);
            this.panelControl2.Location = new System.Drawing.Point(273, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(420, 441);
            this.panelControl2.TabIndex = 9;
            // 
            // PermissionTreeView
            // 
            this.PermissionTreeView.CheckBoxes = true;
            this.PermissionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PermissionTreeView.Enabled = false;
            this.PermissionTreeView.Location = new System.Drawing.Point(2, 2);
            this.PermissionTreeView.Name = "PermissionTreeView";
            treeNode1.Name = "InputUser";
            treeNode1.Text = "Input User";
            treeNode2.Name = "UserRoles";
            treeNode2.Text = "User Roles";
            treeNode3.Name = "UserBranch";
            treeNode3.Text = "User Branch";
            treeNode4.Name = "ManageUser";
            treeNode4.Text = "User";
            treeNode5.Name = "GeneralModule";
            treeNode5.Text = "General Module";
            treeNode6.Name = "UnitModel";
            treeNode6.Text = "Unit Model";
            treeNode7.Name = "UnitAccessory";
            treeNode7.Text = "Unit Accessory";
            treeNode8.Name = "Unit";
            treeNode8.Text = "Unit";
            treeNode9.Name = "Sales";
            treeNode9.Text = "Sales";
            treeNode10.Name = "Sparepart";
            treeNode10.Text = "Sparepart";
            treeNode11.Name = "Service";
            treeNode11.Text = "Service";
            treeNode12.Name = "BodyRepair";
            treeNode12.Text = "Body Repair";
            treeNode13.Name = "Finance";
            treeNode13.Text = "Finance";
            treeNode14.Name = "Tax";
            treeNode14.Text = "Tax";
            this.PermissionTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.PermissionTreeView.Size = new System.Drawing.Size(416, 437);
            this.PermissionTreeView.TabIndex = 0;
            // 
            // UserRolesUnitOfWork
            // 
            this.UserRolesUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UserRolesUnitOfWork.TrackPropertiesModifications = false;
            // 
            // UserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Tambah);
            this.Name = "UserRoles";
            this.Text = "UserRoles";
            this.Load += new System.EventHandler(this.UserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RolesComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserRolesUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit RolesComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton RemoveUser;
        private DevExpress.XtraEditors.SimpleButton AddUser;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private System.Windows.Forms.TreeView PermissionTreeView;
        private DevExpress.Xpo.UnitOfWork UserRolesUnitOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}