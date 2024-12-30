using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerakendeApp.DAL.Model
{
    public class Satis
    {
        public int SatisId { get; set; } 
        public DateTime ProcDate { get; set; } = DateTime.Now;
        public string ProcType { get; set; } // İşlem Türü (Satış, İade, vb.)
        public List<CartItem> CartItems { get; set; } = new List<CartItem>(); // Satıştaki ürünler
        public int UserId { get; set; }
        public User User { get; set; } // Satışı yapan kullanıcı
        public double TotalAmount => CartItems.Sum(item => item.TotalPrice);

        public override string ToString()
        {
            return $"Toplam: {TotalAmount}";
        }
    }
}
