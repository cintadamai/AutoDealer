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
    }
}