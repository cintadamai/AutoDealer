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
    public partial class DataBranchManager : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchesModel> b_coll;
        XPQuery<KaryawansModel> k_coll;
        public DataBranchManager()
        {
            InitializeComponent();
            BMBS.PositionChanged += BMBS_PositionChanged;
            b_coll = BMUOW.Query<BranchesModel>();
            k_coll = BMUOW.Query<KaryawansModel>();
        }

        private void BMBS_PositionChanged(object sender, EventArgs e)
        {
            BranchmanagersModel branchmanagers = (BranchmanagersModel)BMBS.Current;
            if(branchmanagers.karyawanId != null)
            {
                karyawanid.EditValue = branchmanagers.karyawanId.id;
            }

            if(branchmanagers.branchId != null)
            {
                branchid.EditValue = branchmanagers.branchId.id;
            }
        }

        private void DataBranchManager_Load(object sender, EventArgs e)
        {
            ViewState();

            BranchmanagersModel branchmanagers = (BranchmanagersModel)BMBS.Current;
            if (branchmanagers.karyawanId != null)
            {
                karyawanid.EditValue = branchmanagers.karyawanId.id;
            }

            if (branchmanagers.branchId != null)
            {
                branchid.EditValue = branchmanagers.branchId.id;
            }
        }

        void SetEnabled()
        {
            nama_branchmanager.Properties.ReadOnly = false;
            branchid.Properties.ReadOnly = false;
            karyawanid.Properties.ReadOnly = false;
        }

        void SetDisabled()
        {
            nama_branchmanager.Properties.ReadOnly = true;
            branchid.Properties.ReadOnly = true;
            karyawanid.Properties.ReadOnly = true;
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
            BMBS.AddNew();
            EditState();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            BranchmanagersModel branchmanagers = (BranchmanagersModel)BMBS.Current;
            branchmanagers.karyawanId = 
                (
                    from c in k_coll
                    where c.id == Convert.ToInt64(karyawanid.EditValue)
                    select c
                ).FirstOrDefault();
            branchmanagers.branchId =
                (
                    from c in b_coll
                    where c.id == Convert.ToInt64(branchid.EditValue)
                    select c
                ).FirstOrDefault();
            if(branchmanagers.createdAt == null)
            {
                branchmanagers.createdAt = DateTime.Now;
            }
            branchmanagers.updatedAt = DateTime.Now;
            branchmanagers.Save();
            BMXpCollection.Add(branchmanagers);
            BMUOW.CommitChanges();
            BMBS.EndEdit();

            ViewState();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            BMBS.CancelEdit();
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
                BranchmanagersModel branchmanagers = (BranchmanagersModel)BMBS.Current;
                BMXpCollection.Remove(branchmanagers);
                branchmanagers.Delete();
                BMUOW.CommitChanges();
            }
        }
    }
}