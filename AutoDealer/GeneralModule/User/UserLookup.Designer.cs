namespace AutoDealer.GeneralModule.User
{
    partial class UserLookup
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SalesXpView = new DevExpress.Xpo.XPView(this.components);
            this.SalesUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_branch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperson_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(658, 365);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SalesXpView;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 361);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SalesXpView
            // 
            this.SalesXpView.ObjectType = typeof(AutoDealer.DB.DMS.UserModel);
            this.SalesXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("username", DevExpress.Xpo.SortDirection.None, "[username]", false, true),
            new DevExpress.Xpo.ViewProperty("password", DevExpress.Xpo.SortDirection.None, "[password]", false, true),
            new DevExpress.Xpo.ViewProperty("active", DevExpress.Xpo.SortDirection.None, "[active]", false, true),
            new DevExpress.Xpo.ViewProperty("current_branch", DevExpress.Xpo.SortDirection.None, "[current_branch]", false, true),
            new DevExpress.Xpo.ViewProperty("created_by", DevExpress.Xpo.SortDirection.None, "[created_by]", false, true),
            new DevExpress.Xpo.ViewProperty("created_at", DevExpress.Xpo.SortDirection.None, "[created_at]", false, true),
            new DevExpress.Xpo.ViewProperty("person_name", DevExpress.Xpo.SortDirection.None, "[person_name]", false, true)});
            this.SalesXpView.Session = this.SalesUnitOfWork;
            this.SalesXpView.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[username]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // SalesUnitOfWork
            // 
            this.SalesUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SalesUnitOfWork.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusername,
            this.colactive,
            this.colcurrent_branch,
            this.colcreated_by,
            this.colcreated_at,
            this.colperson_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 0;
            // 
            // colactive
            // 
            this.colactive.Caption = "Active";
            this.colactive.FieldName = "active";
            this.colactive.Name = "colactive";
            this.colactive.Visible = true;
            this.colactive.VisibleIndex = 2;
            // 
            // colcurrent_branch
            // 
            this.colcurrent_branch.Caption = "Current Branch";
            this.colcurrent_branch.FieldName = "current_branch";
            this.colcurrent_branch.Name = "colcurrent_branch";
            this.colcurrent_branch.Visible = true;
            this.colcurrent_branch.VisibleIndex = 3;
            // 
            // colcreated_by
            // 
            this.colcreated_by.Caption = "Dibuat Oleh";
            this.colcreated_by.FieldName = "created_by";
            this.colcreated_by.Name = "colcreated_by";
            this.colcreated_by.Visible = true;
            this.colcreated_by.VisibleIndex = 4;
            // 
            // colcreated_at
            // 
            this.colcreated_at.Caption = "Dibuat Pada";
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            this.colcreated_at.Visible = true;
            this.colcreated_at.VisibleIndex = 5;
            // 
            // colperson_name
            // 
            this.colperson_name.Caption = "Nama Karyawan";
            this.colperson_name.FieldName = "person_name";
            this.colperson_name.Name = "colperson_name";
            this.colperson_name.Visible = true;
            this.colperson_name.VisibleIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::AutoDealer.Properties.Resources.apply_32x321;
            this.simpleButton2.Location = new System.Drawing.Point(408, 383);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 42);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "OK";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::AutoDealer.Properties.Resources.cancel_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(542, 383);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 42);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // UserLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 438);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLookup";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPView SalesXpView;
        private DevExpress.Xpo.UnitOfWork SalesUnitOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colactive;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_branch;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_by;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraGrid.Columns.GridColumn colperson_name;
    }
}