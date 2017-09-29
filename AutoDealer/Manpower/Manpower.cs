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

namespace AutoDealer.Manpower
{
    public partial class Manpower : DevExpress.XtraEditors.XtraForm
    {
        public Manpower()
        {
            InitializeComponent();
        }

        private void DataKaryawan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Manpower.Karyawan.DataKaryawan f = new AutoDealer.Manpower.Karyawan.DataKaryawan
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void DataSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Manpower.Karyawan.DataSales f = new AutoDealer.Manpower.Karyawan.DataSales
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void DataSaleshead_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Manpower.Karyawan.DataSalesHead f = new AutoDealer.Manpower.Karyawan.DataSalesHead
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void DataBranchManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Manpower.Karyawan.DataBranchManager f = new AutoDealer.Manpower.Karyawan.DataBranchManager
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void DataCabang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Manpower.Karyawan.DataCabang f = new AutoDealer.Manpower.Karyawan.DataCabang
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }
    }
}