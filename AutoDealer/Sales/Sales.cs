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
using AutoDealer.Additional.Permission;

namespace AutoDealer.Sales
{
    public partial class Sales : DevExpress.XtraEditors.XtraForm
    {
        UserAkses userAkses = new UserAkses();
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;

            if(userAkses.Can("Unit"))
            {
                Unit.Enabled = true;
            }

            if(userAkses.Can("UnitModel"))
            {
                Unit.Enabled = true;
                UnitModel.Enabled = true;
            }

            if (userAkses.Can("UnitAccessory"))
            {
                Unit.Enabled = true;
                UnitAccessory.Enabled = true;
            }
        }

        private void UnitModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoDealer.Sales.Unit.UnitModel f = new AutoDealer.Sales.Unit.UnitModel
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void UnitAccessory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unit.UnitAccessory f = new AutoDealer.Sales.Unit.UnitAccessory
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }
    }
}