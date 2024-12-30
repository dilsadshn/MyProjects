using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_1
{
    [Serializable]
    public class Database
    {

        public string userName { get; set; } = "";
        public string StockName { get; set; } = "";
        public List<User> userlist { get; set; } = new List<User>();
        public List<Stock> stocklist { get; set; } = new List<Stock>();
        public List<Perakende> perakendelist { get; set; } = new List<Perakende>();
        public List<CartItem> cartitemlist { get; set; } = new List<CartItem>();
       
        public static bool DatabaseExists(string path, out Database database)
        {
            database = null;
            if (!System.IO.File.Exists(path))
            {
                return false;
            }
            try
            {
                using (FileStream FS = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter BF = new BinaryFormatter();
                    database = (Database)BF.Deserialize(FS);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
                return false;
            }
        }

        public static bool SaveDatabase(string path, Database database)
        {
            FileInfo FINF = new FileInfo(path);
            if (!Directory.Exists(FINF.DirectoryName))
            {
                Directory.CreateDirectory(FINF.DirectoryName);
            }
            try
            {
                using (FileStream FS = new FileStream(path, FileMode.Create))
                {
                    BinaryFormatter BF = new BinaryFormatter();
                    BF.Serialize(FS, database);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya yazma hatası: " + ex.Message);
                return false;
            }
        }

        [Serializable]
        public class User
        {
            public Guid UserId { get; set; } = Guid.NewGuid();
            public string UserName { get; set; } = "";
            public string Password { get; set; } = "";
        }

        [Serializable]
        public class Stock
        {
            public Guid StockId { get; set; } = Guid.NewGuid();
            public string StockName { get; set; } = "";
            public string Barcode { get; set; } = "";
            public decimal Price { get; set; } = 0;
        }

        [Serializable]
        public class CartItem
        {
            public Guid StockId { get; set; }
            public string ProductName { get; set; }
            public double Quantity { get; set; } = 0;
            public double Price { get; set; } = 0;
            public double TotalPrice => Quantity * Price; 
        }

        [Serializable]
        public class Perakende
        {
            public Guid ProcGuid { get; set; } = Guid.NewGuid(); //Yapılan satışın işlem guidi
            public DateTime ProcDate { get; set; } = DateTime.Now;
            public string ProcType { get; set; } = "Nakit Satış"; //Satış tipi

            public List<CartItem> CartItems { get; set; } = new List<CartItem>();
            public double TotalAmount => CartItems.Sum(item => item.TotalPrice);

            public override string ToString()
            {
                return $"Toplam: {TotalAmount}";
            }
        }

    }
}
