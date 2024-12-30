using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static deneme_1.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace deneme_1
{
    public partial class PerakendeSatis : Form
    {
        Database database = null;
        string filePath = Application.StartupPath + "\\deneme1database\\db.dls";
        public List<CartItem> cart = new List<CartItem>();
        public PerakendeSatis()
        {
            InitializeComponent();
        }

        private void PerakendeSatis_Load(object sender, EventArgs e)
        {
            Database.DatabaseExists(filePath, out database);
            if (database == null)
            {
                database = new Database();
                if (!Database.SaveDatabase(filePath, database))
                {
                    MessageBox.Show("DOSYA YAZMA HATASI");
                }
            }

            dataGridViewCart.DataSource = cart;
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            double totalAmount = cart.Sum(item => item.Price * item.Quantity);
            lblTotalAmount.Text = $"Toplam: {totalAmount:C2}";
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text;
                Stock stockItem = database.stocklist.FirstOrDefault(item => item.Barcode == barcode);

                if(stockItem != null)
                {
                    CartItem existingCartItem = cart.FirstOrDefault(item => item.StockId == stockItem.StockId);

                    if (existingCartItem != null)
                    {
                        existingCartItem.Quantity += 1;
                    }
                    else
                    {
                        CartItem cartItem = new CartItem
                        {
                            StockId = stockItem.StockId,
                            ProductName = stockItem.StockName,
                            Quantity = 1,
                            Price = (double)stockItem.Price
                        };
                        cart.Add(cartItem);
                    }
                    
                    dataGridViewCart.DataSource = null;
                    dataGridViewCart.DataSource = cart;
                    UpdateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı!");
                }
                txtBarcode.Clear();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cart;
            UpdateTotalAmount();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            var perakende = new Database.Perakende
            {
                CartItems = new List<CartItem>(cart),
                ProcDate = DateTime.Now
            };
            database.perakendelist.Add(perakende);
            Database.SaveDatabase(filePath, database);
            double totalAmount = cart.Sum(item => item.Price * item.Quantity);
            MessageBox.Show($"Satış tamamlandı!\nToplam Tutar: {totalAmount:C2}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult paymentMethodResult = MessageBox.Show(
                 $"Toplam tutar: {totalAmount:C2}\nÖdeme yöntemi seçiniz.\n\nKredi Kartı (Evet)\nNakit (Hayır)",
                 "Ödeme Yöntemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (paymentMethodResult == DialogResult.Yes)
            {
                MessageBox.Show("Kredi Kartı ile ödeme seçildi.");
            }
            else if (paymentMethodResult == DialogResult.No)
            {
                MessageBox.Show("Nakit ödeme seçildi.");
            }
            else if (paymentMethodResult == DialogResult.Cancel)
            {
                MessageBox.Show("Ödeme işlemi iptal edildi.");
            }

            btnClearCart_Click(sender, e);
            UpdateTotalAmount();
        }

      
    }
}
