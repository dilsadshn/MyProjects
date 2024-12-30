using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerakendeApp.FORMS
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnOpenKullaniciTakipForm_Click_1(object sender, EventArgs e)
        {
            KullaniciTakip kullaniciTakip = new KullaniciTakip();
            kullaniciTakip.ShowDialog();
        }
        private void btnOpenStokTakipForm_Click_1(object sender, EventArgs e)
        {
            StokTakip stokTakip = new StokTakip();
            stokTakip.ShowDialog();
        }
        private void btnOpenPerakendeSatisForm_Click(object sender, EventArgs e)
        {
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.ShowDialog();
        }
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
