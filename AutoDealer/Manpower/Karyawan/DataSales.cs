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
    public partial class DataSales : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<SalesheadsModel> sh_coll;
        public DataSales()
        {
            InitializeComponent();
            SalesBS.PositionChanged += SalesBS_PositionChanged;
            sh_coll = SalesUOW.Query<SalesheadsModel>();
        }

        private void SalesBS_PositionChanged(object sender, EventArgs e)
        {
            SalesModel sales = (SalesModel)SalesBS.Current;
            if(sales.salesheadId != null)
            {
                salesheadid.EditValue = sales.salesheadId.id;
            }
        }

        private void DataSales_Load(object sender, EventArgs e)
        {
            SetDisabled();
            SalesModel sales = (SalesModel)SalesBS.Current;
            if (sales != null)
            {
                salesheadid.EditValue = sales.salesheadId.id;
                Edit.Enabled = true;
                Hapus.Enabled = true;
            }
        }

        void SetEnabled()
        {
            nama_sales.Properties.ReadOnly = false;
            karyawanid.Properties.ReadOnly = false;
            salesgradeid.Properties.ReadOnly = false;
            salesheadid.Properties.ReadOnly = false;
        }

        void SetDisabled()
        {
            nama_sales.Properties.ReadOnly = true;
            karyawanid.Properties.ReadOnly = true;
            salesgradeid.Properties.ReadOnly = true;
            salesheadid.Properties.ReadOnly = true;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            SalesBS.AddNew();
            SetEnabled();

            Tambah.Enabled = false;
            Simpan.Enabled = true;
            Batal.Enabled = true;
            Edit.Enabled = false;
            Hapus.Enabled = false;

            gridControl1.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            SalesModel sales = (SalesModel)SalesBS.Current;
            sales.salesheadId = sh_coll.First(sh => sh.id == Convert.ToInt64(salesheadid.EditValue));
            sales.createdAt = DateTime.Now;
            sales.updatedAt = DateTime.Now;
            sales.Save();
            SalesXpCollection.Add(sales);
            SalesUOW.CommitChanges();
            SalesBS.EndEdit();

            SetDisabled();

            Tambah.Enabled = true;
            Simpan.Enabled = false;
            Batal.Enabled = false;
            Edit.Enabled = true;
            Hapus.Enabled = true;

            gridControl1.Enabled = true;
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            SalesBS.CancelEdit();
            SetDisabled();

            Tambah.Enabled = true;
            Simpan.Enabled = false;
            Batal.Enabled = false;
            Edit.Enabled = true;
            Hapus.Enabled = true;

            gridControl1.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SetEnabled();

            Tambah.Enabled = false;
            Simpan.Enabled = true;
            Batal.Enabled = true;
            Edit.Enabled = false;
            Hapus.Enabled = false;

            gridControl1.Enabled = false;
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                SalesModel sales = (SalesModel)SalesBS.Current;
                sales.Delete();
                SalesXpCollection.Remove(sales);
                SalesUOW.CommitChanges();
            }
        }
    }
}