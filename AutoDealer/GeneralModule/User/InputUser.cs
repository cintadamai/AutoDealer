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
    public partial class InputUser : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        public InputUser()
        {
            InitializeComponent();
            username.ButtonClick += Username_ButtonClick;
            foreach(BranchModel b in branch_coll)
            {
                branch.Properties.Items.Add(b.branch_name);
            }
        }

        private void Username_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UserLookup f = new UserLookup();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                UserModel user = f.User;
                username.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                username.Text = user.username;
                person_name.Text = user.person_name;
                branch.Text = user.current_branch;
                active.Checked = user.active;
                Edit.Enabled = true;
                Hapus.Enabled = true;

                username.Enabled = false;
                person_name.Enabled = false;
                branch.Enabled = false;
                active.Enabled = false;
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            username.Enabled = true;
            person_name.Enabled = true;
            branch.Enabled = true;
            active.Enabled = true;
            username.Focus();

            username.ResetText();
            person_name.ResetText();
            branch.ResetText();
            active.Checked = false;

            username.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            Edit.Enabled = false;
            Hapus.Enabled = false;
        }

        private void InputUser_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            username.Enabled = true;
            person_name.Enabled = true;
            branch.Enabled = true;
            active.Enabled = true;

            username.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Menghapus User?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                UserModel user = user_coll.FirstOrDefault(u => u.username == username.Text);
            }
        }
    }
}