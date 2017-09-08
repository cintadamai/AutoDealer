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

namespace AutoDealer.GeneralModule.User
{
    public partial class AddRoleDialog : DevExpress.XtraEditors.XtraForm
    {
        public AddRoleDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(validator.Validate())
            {
                DialogResult = DialogResult.OK;
            } else
            {
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}