using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerakendeApp.DAL.Model
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }
    }
}

