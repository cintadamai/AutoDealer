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
    public partial class BranchLookup : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        public BranchModel branch;
        public BranchLookup()
        {
            InitializeComponent();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            var selectedID = gridView1.GetFocusedRowCellValue(colbranch_name);
            branch = branch_coll.FirstOrDefault(b => b.branch_name == selectedID.ToString());
            DialogResult = DialogResult.OK;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BranchLookup_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = branch_coll;
        }
    }
}