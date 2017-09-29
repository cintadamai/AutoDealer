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
using AutoDealer.DB.its_honda;

namespace AutoDealer.Manpower.Karyawan
{
    public partial class DataSalesHead : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<KaryawansModel> k_coll;
        XPQuery<BranchmanagersModel> b_coll;
        public DataSalesHead()
        {
            InitializeComponent();
            SHBS.PositionChanged += SHBS_PositionChanged;
            k_coll = SHUOW.Query<KaryawansModel>();
            b_coll = SHUOW.Query<BranchmanagersModel>();
        }

        private void SHBS_PositionChanged(object sender, EventArgs e)
        {
            SalesheadsModel salesheads = (SalesheadsModel)SHBS.Current;
            if(salesheads.karyawanId != null)
            {
                karyawanid.EditValue = salesheads.karyawanId.id;
            }

            if(salesheads.branchManagerId != null)
            {
                branchmanagerid.EditValue = salesheads.branchManagerId.id;
            }
        }

        private void DataSalesHead_Load(object sender, EventArgs e)
        {
            SetDisabled();
            SalesheadsModel salesheads = (SalesheadsModel)SHBS.Current;
            if (salesheads.karyawanId != null)
            {
                karyawanid.EditValue = salesheads.karyawanId.id;
            }

            if (salesheads.branchManagerId != null)
            {
                branchmanagerid.EditValue = salesheads.branchManagerId.id;
            }

            ViewState();
        }

        void SetEnabled()
        {
            nama_sh.Properties.ReadOnly = false;
            karyawanid.Properties.ReadOnly = false;
            branchmanagerid.Properties.ReadOnly = false;
        }

        void SetDisabled()
        {
            nama_sh.Properties.ReadOnly = true;
            karyawanid.Properties.ReadOnly = true;
            branchmanagerid.Properties.ReadOnly = true;
        }

        void ViewState()
        {
            Tambah.Enabled = true;
            Simpan.Enabled = false;
            Batal.Enabled = false;
            Edit.Enabled = true;
            Hapus.Enabled = true;

            SetDisabled();

            gridControl1.Enabled = true;
        }

        void EditState()
        {
            Tambah.Enabled = false;
            Simpan.Enabled = true;
            Batal.Enabled = true;
            Edit.Enabled = false;
            Hapus.Enabled = false;

            SetEnabled();

            gridControl1.Enabled = false;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            EditState();
            SHBS.AddNew();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            SalesheadsModel salesheads = (SalesheadsModel)SHBS.Current;
            salesheads.karyawanId = k_coll.FirstOrDefault(k => k.id == Convert.ToInt64(karyawanid.EditValue));
            salesheads.branchManagerId = b_coll.FirstOrDefault(b => b.id == Convert.ToInt64(branchmanagerid.EditValue));
            if(salesheads.createdAt == null)
            {
                salesheads.createdAt = DateTime.Now;
            }
            salesheads.updatedAt = DateTime.Now;
            salesheads.Save();
            SHXpCollection.Add(salesheads);
            SHUOW.CommitChanges();
            SHBS.EndEdit();

            ViewState();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            SHBS.CancelEdit();
            ViewState();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditState();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                SalesheadsModel salesheads = (SalesheadsModel)SHBS.Current;
                SHXpCollection.Remove(salesheads);
                salesheads.Delete();
                SHUOW.CommitChanges();
            }
        }
    }
}