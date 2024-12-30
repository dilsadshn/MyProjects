using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerakendeApp.DAL.Model
{
    public class CartItem
    {
        public int CartItemId { get; set; } 
        public string ProductName { get; set; } 
        public double Quantity { get; set; } = 0; 
        public double Price { get; set; } = 0; 
        public double TotalPrice => Quantity * Price; 
        public int SatisId { get; set; }
        public Satis Satis { get; set; } 
    }
}
