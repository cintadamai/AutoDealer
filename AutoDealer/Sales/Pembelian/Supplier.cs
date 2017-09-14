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

namespace AutoDealer.Sales.Pembelian
{
    public partial class Supplier : DevExpress.XtraEditors.XtraForm
    {
        public Supplier()
        {
            InitializeComponent();
            SupplierBindingSource.CurrentChanged += SupplierBindingSource_CurrentChanged;
        }

        private void SupplierBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(SupplierBindingSource.Count <= 0)
            {
                kode_supplier.Text = "";
                nama_supplier.Text = "";
                no_telepon.Text = "";
                alamat.Text = "";
                npwp.Text = "";
                nama_npwp.Text = "";

                return;
            }

            var index = SupplierBindingSource.IndexOf(SupplierBindingSource.Current);
            UnitSupplierModel unitSupplier = ((UnitSupplierModel)SupplierXpCollection[index]);
            kode_supplier.Text = unitSupplier.kode_supplier;
            nama_supplier.Text = unitSupplier.nama_supplier;
            no_telepon.Text = unitSupplier.no_telepon;
            alamat.Text = unitSupplier.alamat;
            npwp.Text = unitSupplier.npwp;
            nama_npwp.Text = unitSupplier.nama_npwp;

            nama_supplier.Enabled = false;
            no_telepon.Enabled = false;
            alamat.Enabled = false;
            npwp.Enabled = false;
            nama_npwp.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            nama_supplier.Enabled = true;
            no_telepon.Enabled = true;
            alamat.Enabled = true;
            npwp.Enabled = true;
            nama_npwp.Enabled = true;

            kode_supplier.Text = "";
            nama_supplier.Text = "";
            no_telepon.Text = "";
            alamat.Text = "";
            npwp.Text = "";
            nama_npwp.Text = "";

            nama_supplier.Focus();

            Edit.Enabled = false;
            Hapus.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!Validator.Validate())
            {
                return;
            }

            if(kode_supplier.Text == "")
            {
                UnitSupplierModel unitSupplier = new UnitSupplierModel(SupplierUnitOfWork)
                {
                    nama_supplier = nama_supplier.Text,
                    no_telepon = no_telepon.Text,
                    alamat = alamat.Text,
                    npwp = npwp.Text,
                    nama_npwp = nama_npwp.Text
                };

                unitSupplier.Save();
                SupplierUnitOfWork.CommitChanges();
                unitSupplier.kode_supplier = Additional.DB.AutoIncrement("SUP/S/", unitSupplier.id);
                unitSupplier.Save();
                SupplierXpCollection.Add(unitSupplier);
                SupplierUnitOfWork.CommitChanges();

                kode_supplier.Text = unitSupplier.kode_supplier;
            }
            else
            {
                XPQuery<UnitSupplierModel> supps = SupplierUnitOfWork.Query<UnitSupplierModel>();
                UnitSupplierModel unitSupplier = supps.FirstOrDefault(s => s.kode_supplier == kode_supplier.Text);
                unitSupplier.nama_supplier = nama_supplier.Text;
                unitSupplier.no_telepon = no_telepon.Text;
                unitSupplier.alamat = alamat.Text;
                unitSupplier.npwp = npwp.Text;
                unitSupplier.nama_npwp = nama_npwp.Text;
                unitSupplier.Save();
                SupplierUnitOfWork.CommitChanges();
            }

            nama_supplier.Enabled = false;
            no_telepon.Enabled = false;
            alamat.Enabled = false;
            npwp.Enabled = false;
            nama_npwp.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nama_supplier.Enabled = true;
            no_telepon.Enabled = true;
            alamat.Enabled = true;
            npwp.Enabled = true;
            nama_npwp.Enabled = true;

            nama_supplier.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            XPQuery<UnitSupplierModel> supps = SupplierUnitOfWork.Query<UnitSupplierModel>();
            UnitSupplierModel unitSupplier = supps.FirstOrDefault(s => s.kode_supplier == kode_supplier.Text);
            SupplierXpCollection.Remove(unitSupplier);
            SupplierUnitOfWork.CommitChanges();
        }
    }
}