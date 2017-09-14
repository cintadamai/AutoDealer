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
using AutoDealer.DB.DMS;

namespace AutoDealer.Sales.Unit
{
    public partial class UnitAccessory : DevExpress.XtraEditors.XtraForm
    {
        public UnitAccessory()
        {
            InitializeComponent();
            AccessoryBindingSource.CurrentChanged += AccessoryBindingSource_CurrentChanged;
        }

        private void AccessoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(AccessoryBindingSource.Count <= 0)
            {
                id.Text = "";
                kode_accessory.Text = "";
                nama_accessory.Text = "";

                Edit.Enabled = false;
                Hapus.Enabled = false;

                return;
            }

            var current = AccessoryBindingSource.IndexOf(AccessoryBindingSource.Current);
            UnitAccessoryModel accessoryModel = ((UnitAccessoryModel)AccessoryXpCollection[current]);
            id.Text = accessoryModel.id.ToString();
            kode_accessory.Text = accessoryModel.kode_accessory;
            nama_accessory.Text = accessoryModel.nama_accessory;

            Edit.Enabled = true;
            Hapus.Enabled = true;

            kode_accessory.Enabled = false;
            nama_accessory.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!Validator.Validate())
            {
                return;
            }

            UnitAccessoryModel accessoryModel;

            if(id.Text == "")
            {
                accessoryModel = new UnitAccessoryModel(AccessoryUnitOfWork)
                {
                    kode_accessory = kode_accessory.Text,
                    nama_accessory = nama_accessory.Text
                };

                AccessoryXpCollection.Add(accessoryModel);
                AccessoryUnitOfWork.CommitChanges();
            } else
            {
                XPQuery<UnitAccessoryModel> acc_coll = AccessoryUnitOfWork.Query<UnitAccessoryModel>();
                accessoryModel = acc_coll.FirstOrDefault(a => a.id == Convert.ToInt64(id.Text));
                accessoryModel.kode_accessory = kode_accessory.Text;
                accessoryModel.nama_accessory = nama_accessory.Text;
                accessoryModel.Save();
                AccessoryUnitOfWork.CommitChanges();
            }

            id.Text = accessoryModel.id.ToString();

            AccessoryBindingSource.Position = AccessoryXpCollection.IndexOf(accessoryModel);

            kode_accessory.Enabled = false;
            nama_accessory.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            id.ResetText();
            kode_accessory.ResetText();
            nama_accessory.ResetText();

            Edit.Enabled = false;
            Hapus.Enabled = false;

            kode_accessory.Enabled = true;
            nama_accessory.Enabled = true;
            kode_accessory.Focus();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            kode_accessory.Enabled = true;
            nama_accessory.Enabled = true;

            kode_accessory.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            var current = AccessoryBindingSource.IndexOf(AccessoryBindingSource.Current);
            UnitAccessoryModel accessoryModel = ((UnitAccessoryModel)AccessoryXpCollection[current]);
            AccessoryXpCollection.Remove(accessoryModel);
            AccessoryUnitOfWork.CommitChanges();

            if(AccessoryBindingSource.Count <= 0)
            {
                Tambah.PerformClick();
            }
        }
    }
}