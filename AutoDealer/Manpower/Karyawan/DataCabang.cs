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
    public partial class DataCabang : DevExpress.XtraEditors.XtraForm
    {
        public DataCabang()
        {
            InitializeComponent();
        }

        private void DataCabang_Load(object sender, EventArgs e)
        {
            ViewState();
        }

        void SetEnabled()
        {
            branch_name.Properties.ReadOnly = false;
            alamat.Properties.ReadOnly = false;
            no_telepon.Properties.ReadOnly = false;
            email.Properties.ReadOnly = false;
            fax.Properties.ReadOnly = false;
        }

        void SetDisabled()
        {
            branch_name.Properties.ReadOnly = true;
            alamat.Properties.ReadOnly = true;
            no_telepon.Properties.ReadOnly = true;
            email.Properties.ReadOnly = true;
            fax.Properties.ReadOnly = true;
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
            BranchBS.AddNew();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            BranchesModel branch = (BranchesModel)BranchBS.Current;
            branch.Save();
            BranchXpCollection.Add(branch);
            BranchUOW.CommitChanges();
            BranchBS.EndEdit();

            ViewState();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            BranchBS.CancelEdit();
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
                BranchesModel branch = (BranchesModel)BranchBS.Current;
                BranchXpCollection.Remove(branch);
                branch.Delete();
                BranchUOW.CommitChanges();
            }
        }
    }
}