using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_1
{
    public partial class AnaMenü : Form
    {

        public AnaMenü()
        {
            InitializeComponent();
        }

        private void BtnOpenKullaniciTakipForm_Click(object sender, EventArgs e)
        {
            KullaniciTakip kullaniciTakip = new KullaniciTakip();
            kullaniciTakip.ShowDialog();
        }

        private void btnOpenStokTakipForm_Click(object sender, EventArgs e)
        {
            StokTakip stokTakip = new StokTakip();
            stokTakip.ShowDialog();
        }
        private void btnPerakendeSatis_Click(object sender, EventArgs e)
        {
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
