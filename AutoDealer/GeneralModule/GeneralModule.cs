﻿using System;
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
using DevExpress.Xpo;
using AutoDealer.DB.DMS;

namespace AutoDealer.GeneralModule
{
    public partial class GeneralModule : DevExpress.XtraEditors.XtraForm
    {
        UserAkses userAkses;
        public GeneralModule()
        {
            InitializeComponent();
            userAkses = new UserAkses();
        }

        private void GeneralModule_Load(object sender, EventArgs e)
        {
            ClockBarStaticItem.Caption = DateTime.Now.ToLongDateString();
            GeneralModuleRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            CekMenu();
        }

        private void CekMenu()
        {
            // Userpage
            if (userAkses.Can("ManageUser")) UserRibbonPageGroup.Enabled = true; else UserRibbonPageGroup.Enabled = false;
            if (userAkses.Can("InputUser")) InputUser.Enabled = true; else InputUser.Enabled = false;
            if (userAkses.Can("UserRoles")) UserRoles.Enabled = true; else UserRoles.Enabled = false;
            if (userAkses.Can("UserBranch")) UserBranch.Enabled = true; else UserBranch.Enabled = false;
        }
    }
}