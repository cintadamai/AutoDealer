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
        }

        private void ModelGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(ModelGridView.RowCount < 1)
            {
                return;
            }

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
            ModelXpCollection.Reload();
            ModelGridControl.DataSource = ModelXpCollection;
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
    }
}