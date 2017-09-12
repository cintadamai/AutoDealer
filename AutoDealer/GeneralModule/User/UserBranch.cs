using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using AutoDealer.DB.DMS;

namespace AutoDealer.GeneralModule.User
{
    public partial class UserBranch : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        XPQuery<UserHasBranchModel> user_has_branch_coll = Session.DefaultSession.Query<UserHasBranchModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        AutoDealer.Additional.Permission.UserAkses userAkses = new Additional.Permission.UserAkses();
        public UserBranch()
        {
            InitializeComponent();
            branchname.ButtonClick += Branchname_ButtonClick;
        }

        private void Branchname_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BranchLookup branchLookup = new BranchLookup();
            DialogResult dialog = branchLookup.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                BranchModel branch = branchLookup.branch;
                branchname.Text = branch.branch_name;
                alamat.Text = branch.alamat;
                no_telepon.Text = branch.no_telepon;
                active.Checked = branch.active;

                branchname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                no_telepon.Enabled = false;
                alamat.Enabled = false;
                active.Enabled = false;

                Edit.Enabled = true;
                Hapus.Enabled = true;
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            branchname.Enabled = true;
            branchname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            no_telepon.Enabled = true;
            alamat.Enabled = true;
            active.Enabled = true;

            branchname.ResetText();
            alamat.ResetText();
            no_telepon.ResetText();
            active.Checked = false;

            branchname.Focus();

            Edit.Enabled = false;
            Hapus.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!InputValidationProvider.Validate())
            {
                return;
            }

            BranchModel branch;
            if(branchname.Properties.TextEditStyle == DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
            {
                branch = new BranchModel(Session.DefaultSession);
            }
            else
            {
                branch = branch_coll.FirstOrDefault(b => b.branch_name == branchname.Text);
            }

            branch.branch_name = branchname.Text;
            branch.alamat = alamat.Text;
            branch.no_telepon = no_telepon.Text;
            branch.active = active.Checked;

            branch.Save();
            LoadBranchList();

            branchname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            no_telepon.Enabled = false;
            alamat.Enabled = false;
            active.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void UserBranch_Load(object sender, EventArgs e)
        {
            UserGridControl.DataSource = user_coll.Where(u => u.active == true);
            LoadBranchList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            branchname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            no_telepon.Enabled = true;
            alamat.Enabled = true;
            active.Enabled = true;

            branchname.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if(!HapusValidationProvider.Validate())
            {
                return;
            }

            BranchModel branch = branch_coll.FirstOrDefault(b => b.branch_name == branchname.Text);
            branch.Delete();
            LoadBranchList();

            Tambah.PerformClick();
        }

        public void LoadBranchList()
        {
            if(UserGridView.RowCount == 0)
            {
                return;
            }

            var selected = UserGridView.GetFocusedRowCellValue(colusername);
            UserModel user = user_coll.FirstOrDefault(u => u.username == selected.ToString());

            var UserBranches = user.UserHasBranches.Select(ub => ub.branch_name);

            var Branches = branch_coll.Where(b => UserBranches.Contains(b));
            var NotBranches = branch_coll.Where(b => !UserBranches.Contains(b));

            BranchGridControl.DataSource = Branches;

            BranchComboBoxEdit.Properties.Items.Clear();
            foreach(BranchModel branch in NotBranches)
            {
                BranchComboBoxEdit.Properties.Items.Add(branch.branch_name);
            }

            BranchGridControl.DataSource = Branches;
        }

        private void TambahBranch_Click(object sender, EventArgs e)
        {
            if(!AssignBranchValidationProvider.Validate())
            {
                return;
            }

            if (UserGridView.RowCount == 0)
            {
                return;
            }

            var selected = UserGridView.GetFocusedRowCellValue(colusername);
            UserModel user = user_coll.FirstOrDefault(u => u.username == selected.ToString());
            BranchModel branch = branch_coll.FirstOrDefault(b => b.branch_name == BranchComboBoxEdit.Text);
            userAkses.AddBranchForUser(user, branch);
            LoadBranchList();
        }

        private void HapusBranch_Click(object sender, EventArgs e)
        {
            if (!AssignBranchValidationProvider.Validate())
            {
                return;
            }

            if (UserGridView.RowCount == 0)
            {
                return;
            }

            var selected = UserGridView.GetFocusedRowCellValue(colusername);
            UserModel user = user_coll.FirstOrDefault(u => u.username == selected.ToString());
            var selectedBranch = BranchGridView.GetFocusedRowCellValue(colbranchname);
            BranchModel branch = branch_coll.FirstOrDefault(b => b.branch_name == selectedBranch.ToString());
            userAkses.RemoveBranchFromUser(user, branch);
            LoadBranchList();
        }
    }
}