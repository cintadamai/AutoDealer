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
    public partial class UnitModel : DevExpress.XtraEditors.XtraForm
    {
        public UnitModel()
        {
            InitializeComponent();
            ModelGridView.FocusedRowChanged += ModelGridView_FocusedRowChanged;
            VariantGridView.FocusedRowChanged += VariantGridView_FocusedRowChanged;
        }

        private void VariantGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadDataGrid();
        }

        private void ModelGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(ModelGridView.RowCount < 1)
            {
                return;
            }

            ModelGridChange();

            if((merk.Text != "" || tipe_model.Text != "") && merk.Enabled == true && tipe_model.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Data Belum Tersimpan, Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog != DialogResult.Yes)
                {
                    return;
                }
            }

            XPQuery <UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            var selectedID = ModelGridView.GetFocusedRowCellValue(colid_model);
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(selectedID));

            id.Text = model.id_model.ToString();
            merk.Text = model.merk;
            tipe_model.Text = model.tipe_model;

            merk.Enabled = false;
            tipe_model.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            id.ResetText();
            merk.ResetText();
            tipe_model.ResetText();

            merk.Focus();

            merk.Enabled = true;
            tipe_model.Enabled = true;

            Edit.Enabled = false;
            Hapus.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!InputValidator.Validate())
            {
                return;
            }

            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();

            UnitModelModel model;
            if(id.Text == "")
            {
                model = new UnitModelModel(ModelUnitOfWork);
            } else
            {
                model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(id.Text));
            }

            model.merk = merk.Text;
            model.tipe_model = tipe_model.Text;
            ModelUnitOfWork.Save(model);
            ModelUnitOfWork.CommitChanges();
            LoadDataGrid();

            id.Text = model.id_model.ToString();

            merk.Enabled = false;
            tipe_model.Enabled = false;

            Edit.Enabled = true;
            Hapus.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            merk.Enabled = true;
            tipe_model.Enabled = true;

            merk.Focus();
        }

        private void LoadDataGrid()
        {
            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            XPQuery<UnitModelVariantModel> variant_coll = ModelUnitOfWork.Query<UnitModelVariantModel>();

            if (VariantGridView.RowCount <= 0)
            {
                panelControlTransmisi.Enabled = false;
                panelControlWarna.Enabled = false;
            } else
            {
                panelControlTransmisi.Enabled = true;
                panelControlWarna.Enabled = true;
            }

            var SelectedVariant = VariantGridView.GetFocusedRowCellValue(colvariant);
            UnitModelVariantModel variant = variant_coll.FirstOrDefault(v => v.nama_variant == SelectedVariant.ToString() && v.id_model == model);

            XPQuery<UnitModelTransmisiModel> transmisi_coll = ModelUnitOfWork.Query<UnitModelTransmisiModel>();
            TransmisiGridControl.DataSource = transmisi_coll.Where(t => t.id_model == model && t.id_variant == variant);

            XPQuery<UnitModelWarnaModel> warna_coll = ModelUnitOfWork.Query<UnitModelWarnaModel>();
            WarnaGridControl.DataSource = warna_coll.Where(w => w.id_model == model && w.id_variant == variant);
        }

        private void ModelGridChange()
        {
            ModelXpCollection.Reload();
            ModelGridControl.DataSource = ModelXpCollection;

            if (ModelGridView.RowCount == 0)
            {
                panelControlVariant.Enabled = false;
            }
            else
            {
                panelControlVariant.Enabled = true;
            }

            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            XPQuery<UnitModelVariantModel> variant_coll = ModelUnitOfWork.Query<UnitModelVariantModel>();
            VariantGridControl.DataSource = variant_coll.Where(v => v.id_model == model);

            LoadDataGrid();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if(!InputValidator.Validate())
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin akan menghapus data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
            {
                return;
            }

            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(id.Text));
            ModelUnitOfWork.Delete(model);
            ModelUnitOfWork.CommitChanges();
            LoadDataGrid();
            Tambah.PerformClick();
        }

        private void UnitModel_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void TambahVariant_Click(object sender, EventArgs e)
        {
            if (!VariantValidator.Validate())
            {
                return;
            }

            UnitModelVariantModel variantModel = new UnitModelVariantModel(ModelUnitOfWork);
            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            variantModel.id_model = model;
            variantModel.created_by = Login.User.username;
            variantModel.nama_variant = nama_variant.Text;
            variantModel.Save();
            ModelUnitOfWork.CommitChanges();

            nama_variant.ResetText();
            LoadDataGrid();
        }

        private void HapusVariant_Click(object sender, EventArgs e)
        {
            if(VariantGridView.RowCount <= 0)
            {
                return;
            }

            var Selected = VariantGridView.GetFocusedRowCellValue(colvariant);
            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = Session.DefaultSession.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            XPQuery<UnitModelVariantModel> variant_coll = Session.DefaultSession.Query<UnitModelVariantModel>();
            UnitModelVariantModel variantModel = variant_coll.FirstOrDefault(v => v.nama_variant == Selected.ToString() && v.id_model == model);
            variantModel.Delete();

            LoadDataGrid();
        }

        private void TambahTransmisi_Click(object sender, EventArgs e)
        {
            if(!TransmisiValidator.Validate())
            {
                return;
            }

            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            var SelectedVariant = VariantGridView.GetFocusedRowCellValue(colvariant);

            XPQuery<UnitModelVariantModel> variant_coll = ModelUnitOfWork.Query<UnitModelVariantModel>();
            UnitModelVariantModel variantModel = variant_coll.FirstOrDefault(v => v.nama_variant == SelectedVariant.ToString() && v.id_model == model);

            UnitModelTransmisiModel unitModelTransmisi = new UnitModelTransmisiModel(ModelUnitOfWork)
            {
                id_model = model,
                id_variant = variantModel,
                nama_tarnsmisi = nama_transmisi.Text
            };
            unitModelTransmisi.Save();
            ModelUnitOfWork.CommitChanges();

            nama_transmisi.ResetText();
            LoadDataGrid();
        }

        private void HapusTransmisi_Click(object sender, EventArgs e)
        {
            if(TransmisiGridView.RowCount <= 0)
            {
                return;
            }

            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            var SelectedVariant = VariantGridView.GetFocusedRowCellValue(colvariant);

            XPQuery<UnitModelVariantModel> variant_coll = Session.DefaultSession.Query<UnitModelVariantModel>();
            UnitModelVariantModel variantModel = variant_coll.FirstOrDefault(v => v.nama_variant == SelectedVariant.ToString() && v.id_model == model);

            var Selected = TransmisiGridView.GetFocusedRowCellValue(coltransmisi);
            XPQuery<UnitModelTransmisiModel> transmisi_coll = Session.DefaultSession.Query<UnitModelTransmisiModel>();
            UnitModelTransmisiModel transmisiModel = transmisi_coll.FirstOrDefault(t => t.id_model == model && t.id_variant == variantModel && t.nama_tarnsmisi == Selected.ToString());
            transmisiModel.Delete();

            LoadDataGrid();
        }

        private void TambahWarna_Click(object sender, EventArgs e)
        {
            if (!WarnaValidator.Validate())
            {
                return;
            }

            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            var SelectedVariant = VariantGridView.GetFocusedRowCellValue(colvariant);

            XPQuery<UnitModelVariantModel> variant_coll = ModelUnitOfWork.Query<UnitModelVariantModel>();
            UnitModelVariantModel variantModel = variant_coll.FirstOrDefault(v => v.nama_variant == SelectedVariant.ToString() && v.id_model == model);

            UnitModelWarnaModel warnaModel = new UnitModelWarnaModel(ModelUnitOfWork)
            {
                id_model = model,
                id_variant = variantModel,
                nama_warna = nama_warna.Text
            };
            ModelUnitOfWork.CommitChanges();

            nama_warna.ResetText();
            LoadDataGrid();
        }

        private void HapusWarna_Click(object sender, EventArgs e)
        {
            if (WarnaGridView.RowCount <= 0)
            {
                return;
            }

            var SelectedModel = ModelGridView.GetFocusedRowCellValue(colid_model);
            XPQuery<UnitModelModel> model_coll = ModelUnitOfWork.Query<UnitModelModel>();
            UnitModelModel model = model_coll.FirstOrDefault(m => m.id_model == Convert.ToInt64(SelectedModel));

            var SelectedVariant = VariantGridView.GetFocusedRowCellValue(colvariant);

            XPQuery<UnitModelVariantModel> variant_coll = Session.DefaultSession.Query<UnitModelVariantModel>();
            UnitModelVariantModel variantModel = variant_coll.FirstOrDefault(v => v.nama_variant == SelectedVariant.ToString() && v.id_model == model);

            var Selected = WarnaGridView.GetFocusedRowCellValue(colwarna);
            XPQuery<UnitModelWarnaModel> warna_coll = Session.DefaultSession.Query<UnitModelWarnaModel>();
            UnitModelWarnaModel warnaModel= warna_coll.FirstOrDefault(w => w.id_model == model && w.id_variant == variantModel && w.nama_warna == Selected.ToString());
            warnaModel.Delete();

            LoadDataGrid();
        }
    }
}