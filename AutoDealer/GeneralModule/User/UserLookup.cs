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
using AutoDealer.DB.DMS;
using DevExpress.Xpo;

namespace AutoDealer.GeneralModule.User
{
    public partial class UserLookup : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        public UserModel User;
        public UserLookup()
        {
            InitializeComponent();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            var selectedUser = gridView1.GetFocusedRowCellValue(colusername);
            User = user_coll.FirstOrDefault(u => u.username == selectedUser.ToString());
            DialogResult = DialogResult.OK;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}