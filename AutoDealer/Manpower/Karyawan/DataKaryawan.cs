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
    public partial class DataKaryawan : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<DivisisModel> d_coll;
        XPQuery<JabatansModel> j_coll;
        XPQuery<BranchesModel> b_coll;
        public DataKaryawan()
        {
            InitializeComponent();
            KaryawanBS.PositionChanged += KaryawanBS_PositionChanged;
            d_coll = KaryawanUnitOfWork.Query<DivisisModel>();
            j_coll = KaryawanUnitOfWork.Query<JabatansModel>();
            b_coll = KaryawanUnitOfWork.Query<BranchesModel>();
        }

        private void KaryawanBS_PositionChanged(object sender, EventArgs e)
        {
            KaryawansModel karyawans = (KaryawansModel)KaryawanBS.Current;
            if(karyawans.divisiId != null)
            {
                divisi.EditValue = karyawans.divisiId.id;
            }

            if(karyawans.jabatanId != null)
            {
                jabatan.EditValue = karyawans.jabatanId.id;
            }

            if(karyawans.branchId != null)
            {
                branch.EditValue = karyawans.branchId.id;
            }

            if(karyawans != null)
            {
                Edit.Enabled = true;
                Hapus.Enabled = true;
            }
        }

        private void DataKaryawan_Load(object sender, EventArgs e)
        {
            KaryawansModel karyawans = (KaryawansModel)KaryawanBS.Current;
            divisi.EditValue = karyawans.divisiId.id;
            jabatan.EditValue = karyawans.jabatanId.id;
            branch.EditValue = karyawans.branchId.id;
            if (karyawans != null)
            {
                Edit.Enabled = true;
                Hapus.Enabled = true;
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            KaryawanBS.AddNew();
            divisi.EditValue = "";
            jabatan.EditValue = "";
            branch.EditValue = "";

            Tambah.Enabled = false;
            Simpan.Enabled = true;
            Batal.Enabled = true;

            nama_karyawan.Properties.ReadOnly = false;
            alamat.Properties.ReadOnly = false;
            tanggal_masuk.Properties.ReadOnly = false;
            tanggal_resign.Properties.ReadOnly = false;
            keterangan_resign.Properties.ReadOnly = false;
            divisi.Properties.ReadOnly = false;
            jabatan.Properties.ReadOnly = false;
            branch.Properties.ReadOnly = false;

            gridControl1.Enabled = false;
            Edit.Enabled = false;
            Hapus.Enabled = false;
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            nama_karyawan.Properties.ReadOnly = true;
            alamat.Properties.ReadOnly = true;
            tanggal_masuk.Properties.ReadOnly = true;
            tanggal_resign.Properties.ReadOnly = true;
            keterangan_resign.Properties.ReadOnly = true;
            divisi.Properties.ReadOnly = true;
            jabatan.Properties.ReadOnly = true;
            branch.Properties.ReadOnly = true;

            KaryawanBS.CancelEdit();

            Tambah.Enabled = true;
            Simpan.Enabled = false;
            Batal.Enabled = false;
            Edit.Enabled = true;
            gridControl1.Enabled = true;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            KaryawansModel karyawans = (KaryawansModel)KaryawanBS.Current;
            karyawans.divisiId = d_coll.FirstOrDefault(d => d.id == Convert.ToInt64(divisi.EditValue));
            karyawans.jabatanId = j_coll.FirstOrDefault(j => j.id == Convert.ToInt64(jabatan.EditValue));
            karyawans.branchId = b_coll.FirstOrDefault(b => b.id == Convert.ToInt64(branch.EditValue));
            karyawans.createdAt = DateTime.Now;
            karyawans.updatedAt = DateTime.Now;
            karyawans.Save();
            KaryawanXpCollection.Add(karyawans);
            KaryawanUnitOfWork.CommitChanges();
            KaryawanBS.EndEdit();

            Simpan.Enabled = false;
            Batal.Enabled = false;
            Tambah.Enabled = true;
            gridControl1.Enabled = true;

            nama_karyawan.Properties.ReadOnly = true;
            alamat.Properties.ReadOnly = true;
            tanggal_masuk.Properties.ReadOnly = true;
            tanggal_resign.Properties.ReadOnly = true;
            keterangan_resign.Properties.ReadOnly = true;
            divisi.Properties.ReadOnly = true;
            jabatan.Properties.ReadOnly = true;
            branch.Properties.ReadOnly = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nama_karyawan.Properties.ReadOnly = false;
            alamat.Properties.ReadOnly = false;
            tanggal_masuk.Properties.ReadOnly = false;
            tanggal_resign.Properties.ReadOnly = false;
            keterangan_resign.Properties.ReadOnly = false;
            divisi.Properties.ReadOnly = false;
            jabatan.Properties.ReadOnly = false;
            branch.Properties.ReadOnly = false;

            Tambah.Enabled = false;
            Simpan.Enabled = true;
            Batal.Enabled = true;
            Edit.Enabled = false;

            gridControl1.Enabled = false;
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                KaryawansModel karyawansModel = (KaryawansModel)KaryawanBS.Current;
                KaryawanXpCollection.Remove(karyawansModel);
                karyawansModel.Delete();
                KaryawanUnitOfWork.CommitChanges();
            }
        }
    }
}