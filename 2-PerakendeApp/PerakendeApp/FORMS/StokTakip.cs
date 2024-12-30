using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerakendeApp.FORMS
{
    public partial class StokTakip : Form
    {
        DataTable dt = new DataTable();

        public StokTakip()
        {
            InitializeComponent();
        }

        void load_dgv()
        {
            string sql = "SELECT StockId, StockName, Barcode, Price FROM stocks";

            if (!core.cli.run_query(dt, sql, "StokTakip_Load()"))
            {
                MessageBox.Show("Bir Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.DataSource=dt;
        }

        void load_dgv2()
        {
            string sql = "SELECT StockId, StockName, Barcode, Price, CONCAT(StockName,Price) NamePrice FROM stocks";

            if (!core.cli.run_query(dt, sql, "StokTakip_Load()"))
            {
                MessageBox.Show("Bir Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.DataSource=dt;

        }

        private void StokTakip_Load(object sender, EventArgs e)
        {
            load_dgv();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string StockName = txtStockName.Text.Trim();
            string Barcode = txtBarcode.Text.Trim();
            string PriceText = txtPrice.Text.Trim();
            if (string.IsNullOrWhiteSpace(StockName))
            {
                MessageBox.Show("Stok adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Barcode))
            {
                MessageBox.Show("Barkod boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(PriceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Geçerli bir fiyat giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"INSERT INTO stocks (StockName, Barcode, Price) " +
               $"values('{txtStockName.Text}', '{txtBarcode.Text}', {double.Parse(txtPrice.Text)})";

            if (!core.cli.run_query(sql, "StokTakip_Load()"))
            {
                MessageBox.Show("Bir Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            load_dgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int StockId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StockId"].Value);
                string StockName = txtStockName.Text;
                string Barcode = txtBarcode.Text;
                decimal Price;

                if (!decimal.TryParse(txtPrice.Text, out Price))
                {
                    MessageBox.Show("Geçerli bir fiyat giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = $"UPDATE stocks SET StockName = '{StockName}', Barcode = '{Barcode}', Price = {Price} WHERE StockId = {StockId}";

                if (!core.cli.run_query(sql, "btnUpdate_Click"))
                {
                    MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Kayıt başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgv();
            }
            else { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                int StockId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StockId"].Value);
                string sql = $"DELETE FROM Stocks WHERE StockId = {StockId}";
                if (!core.cli.run_query(sql, "btnDelete_Click"))
                {
                    MessageBox.Show("Kayıt silinirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgv();
            }
            else
            {
                MessageBox.Show("Silmek için bir stok seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            load_dgv2();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStockName.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtPrice.Text = string.Empty;

            MessageBox.Show("Tüm alanlar temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
