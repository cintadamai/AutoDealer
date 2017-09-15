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
    public partial class Pembelian : DevExpress.XtraEditors.XtraForm
    {
        public Pembelian()
        {
            InitializeComponent();
            detail_model.ButtonClick += Detail_model_ButtonClick;
            kode_supplier.TextChanged += Kode_supplier_TextChanged;
            PembelianBindingSource.AddingNew += PembelianBindingSource_AddingNew;
            PembelianBindingSource.Position = 0;
        }

        private void PembelianBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            XPQuery<BranchModel> branch_coll = PembelianUnitOfWork.Query<BranchModel>();

            UnitPurchaseModel unitPurchase = new UnitPurchaseModel(PembelianUnitOfWork)
            {
                branchid = branch_coll.FirstOrDefault(b => b.id == Login.User.current_branch.id),
                tanggal_pembelian = DateTime.Now,
                created_at = DateTime.Now,
                created_by = Login.User.username
            };

            e.NewObject = unitPurchase;
        }

        private void Kode_supplier_TextChanged(object sender, EventArgs e)
        {
            if(kode_supplier.Text != "")
            {
                UnitSupplierModel DRow = (UnitSupplierModel)kode_supplier.GetSelectedDataRow();
                nama_supplier.Text = DRow.nama_supplier;
            }
        }

        private void Detail_model_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AutoDealer.Sales.Unit.UnitModelLookup f = new Unit.UnitModelLookup();
            DialogResult dialog = f.ShowDialog(this);

            if(dialog == DialogResult.OK)
            {
                UnitmodelviewModel model = (UnitmodelviewModel)f.ModelBindingSource.Current;
                detail_model.Text = model.tipe_model;
                detail_variant.Text = model.nama_variant;
                detail_transmisi.Text = model.nama_tarnsmisi;
            }
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            tanggal_pembelian.EditValue = DateTime.Now;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            kode_pembelian.Enabled = true;
            no_referensi.Enabled = true;
            tanggal_pembelian.Enabled = true;
            kode_supplier.Enabled = true;
            no_faktur_pajak.Enabled = true;
            nilai.Enabled = true;
            potongan.Enabled = true;
            dpp.Enabled = true;
            ppn.Enabled = true;
            total.Enabled = true;

            PembelianBindingSource.AddNew();
            no_referensi.Focus();

            Tambah.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!HeaderValidator.Validate())
            {
                return;
            }

            UnitPurchaseModel unitPurchase = (UnitPurchaseModel)PembelianBindingSource.Current;
            unitPurchase.updated_by = Login.User.username;
            unitPurchase.updated_at = DateTime.Now;

            PembelianUnitOfWork.CommitChanges();

            string kode = "PB/" + DateTime.Now.Year.ToString() + "/" + AutoDealer.Additional.DB.GetColumnName((int)Login.User.current_branch.id) + "/";

            kode_pembelian.Text = AutoDealer.Additional.DB.AutoIncrement(kode, unitPurchase.id);
            PembelianBindingSource.EndEdit();
            PembelianUnitOfWork.CommitChanges();

            DetailXtraTabControl.Visible = true;
        }
    }
}