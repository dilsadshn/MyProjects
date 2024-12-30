using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace deneme_1
{
    public partial class StokTakip : Form
    {
        Database database = null;
        string filePath = Application.StartupPath + "\\deneme1database\\db.dls";
        public StokTakip()
        {
            InitializeComponent();
        }

        private void StokTakip_Load(object sender, EventArgs e)
        {

            if (!Database.DatabaseExists(filePath, out database))
            {
                database = new Database();
                if (!Database.SaveDatabase(filePath, database))
                {
                    MessageBox.Show("DOSYA YAZMA HATASI");
                }
            }

            gridControl1.DataSource = database.stocklist;
            gridView1.Columns["StockId"].Caption = "ID";
            gridView1.Columns["StockName"].Caption = "Stok Adı";
            gridView1.Columns["Barcode"].Caption = "Barkod";
            gridView1.Columns["Price"].Caption = "Fiyat";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var stock = new deneme_1.Database.Stock()
            {
                StockName = txtStockName.Text,
                Barcode = txtBarcode.Text,
                Price = decimal.Parse(txtPrice.Text)
            };
            database.stocklist.Add(stock);
            Database.SaveDatabase(filePath, database);
            gridControl1.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string stockname = gridView1.GetFocusedRowCellValue("StockName")?.ToString();

            if (string.IsNullOrEmpty(stockname))
            {
                MessageBox.Show("Geçerli bir stok adı seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stock = database.stocklist.FirstOrDefault(s => s.StockName == stockname);

            if (stock == null)
            {
                MessageBox.Show("Stok Bulunamadı!");
                return;
            }

            database.stocklist.Remove(stock);
            gridControl1.RefreshDataSource();
            Database.SaveDatabase(filePath, database);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedStockName = txtStockName.Text;
            string updatedBarcode = txtBarcode.Text;
            decimal updatedPrice = decimal.Parse(txtPrice.Text);

            //MessageBox.Show("Stok bilgileri güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStockName.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtPrice.Text = string.Empty;

            //MessageBox.Show("Form temizlendi.", "Temizleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            Database.SaveDatabase(filePath, database);
        }
    }
}
