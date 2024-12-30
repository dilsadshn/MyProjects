using PerakendeApp.DAL.Context;
using PerakendeApp.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PerakendeApp.FORMS
{
    public partial class PerakendeSatis : Form
    {
        //DataTable dt = new DataTable();
        public List<CartItem> cart = new List<CartItem>();
        public PerakendeSatis()
        {
            InitializeComponent();
            //cart ??= new List<CartItem>();
        }

        void load_dgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cart;
            UpdateTotalAmount();
        }

        private void PerakendeSatis_Load(object sender, EventArgs e)
        {
            load_dgv();
        }

        private void UpdateTotalAmount()
        {
            double totalAmount = cart.Sum(item => item.Price * item.Quantity);
            lblTotalAmount.Text = $"Toplam: {totalAmount:C2}";
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Lütfen bir barkod girin!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                using(var db= new AppDbContext())
                {
                    var stock = db.Stocks.FirstOrDefault(s=>s.Barcode == barcode);
                    if (stock == null)
                    {
                        MessageBox.Show("Ürün bulunamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    var existingItem = cart.FirstOrDefault(c => c.ProductName == stock.StockName);
                    if (existingItem != null)
                    {
                        existingItem.Quantity++;
                    }
                    else
                    {
                        cart.Add(new CartItem
                        {
                            ProductName = stock.StockName,
                            Price = (double)stock.Price,
                            Quantity = 1
                        });
                    }

                    load_dgv();
                    txtBarcode.Clear();
                    txtBarcode.Focus();
                }
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sepeti temizlemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cart.Clear();
                load_dgv();
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (cart.Count==0)
            {
                MessageBox.Show("Sepet boş, satış yapılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new AppDbContext())
            {
                var satis = new Satis
                {
                    ProcType = "Satış",
                    ProcDate = DateTime.Now,
                    CartItems = cart.Select(c => new CartItem
                    {
                        ProductName= c.ProductName,
                        Price = c.Price,
                        Quantity = c.Quantity,
                        SatisId = 0
                    }).ToList(),
                };

                db.Satislar.Add(satis);
                db.SaveChanges();

                MessageBox.Show("Satış başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Clear();
                load_dgv();
            }
        }
    }
}
