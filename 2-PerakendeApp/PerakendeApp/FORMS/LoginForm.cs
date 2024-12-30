using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PerakendeApp.FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            core.cli = new db_client();

            if (!core.cli.connect())
            {
                MessageBox.Show("Veritabanına bağlantı kurulamadı.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = "admin";
                string Password = "1234";

                if (string.IsNullOrWhiteSpace(txtUserName.Text)||string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre alanları boş bırakılamaz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtUserName.Text == UserName && txtPassword.Text == Password)
                {
                    MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
