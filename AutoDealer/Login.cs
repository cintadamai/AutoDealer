using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using AutoDealer.DB.DMS;
using AutoDealer.Additional.Permission;
using System.Linq;

namespace AutoDealer
{
    public partial class Login : SplashScreen
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();

        UserAkses userAkses;
        public static UserModel User;
        public Login()
        {
            InitializeComponent();
            password.KeyDown += Password_KeyDown;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Masuk.PerformClick();
            }
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Masuk_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }

            var Finds = user_coll.Where(u => u.username == username.Text && u.password == password.Text && u.active == true);
            var Count = Finds.Count();

            if(Count < 1)
            {
                MessageBox.Show("Username atau password tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Count == 1)
            {
                User = Finds.First();
                username.Enabled = false;
                password.Enabled = false;
                Masuk.Enabled = false;
                groupControl1.Enabled = true;
                Afterlogin();
            }
        }

        private void Afterlogin()
        {
            userAkses = new UserAkses();

            if(userAkses.Can("GeneralModule"))
            {
                GeneralModule.Enabled = true;
            }

            if(userAkses.Can("Sales"))
            {
                Sales.Enabled = true;
            }

            if (userAkses.Can("Sparepart"))
            {
                Sparepart.Enabled = true;
            }

            if (userAkses.Can("Service"))
            {
                Service.Enabled = true;
            }

            if (userAkses.Can("Finance"))
            {
                Finance.Enabled = true;
            }

            if (userAkses.Can("BodyRepair"))
            {
                BodyRepair.Enabled = true;
            }

            if (userAkses.Can("Tax"))
            {
                Tax.Enabled = true;
            }
        }

        private void GeneralModule_Click(object sender, EventArgs e)
        {
            AutoDealer.GeneralModule.GeneralModule f = new AutoDealer.GeneralModule.GeneralModule();
            f.Show();
            f.Focus();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            AutoDealer.Sales.Sales f = new AutoDealer.Sales.Sales();
            f.Show();
            f.Focus();
        }
    }
}