using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace deneme_1
{
    public partial class KullaniciTakip : Form
    {
        Database database = null;
        string filePath = Application.StartupPath + "\\deneme1database\\db.dls";

        public KullaniciTakip()
        {
            InitializeComponent();
        }

        private void KullaniciTakip_Load(object sender, EventArgs e)
        {
            if (!Database.DatabaseExists(filePath, out database))
            {
                database = new Database();
                if (!Database.SaveDatabase(filePath, database))
                {
                    MessageBox.Show("DOSYA YAZMA HATASI");
                }
            }

            gridControl1.DataSource = database.userlist;
            gridView1.Columns["UserId"].Caption = "ID";
            gridView1.Columns["UserName"].Caption = "Kullanıcı Adı";
            gridView1.Columns["Password"].Caption = "Şifre";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var user = new deneme_1.Database.User()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            database.userlist.Add(user);
            Database.SaveDatabase(filePath, database);
            gridControl1.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = gridView1.GetFocusedRowCellValue("UserName")?.ToString();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Geçerli bir kullanıcı adı seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = database.userlist.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
                return;
            }

            database.userlist.Remove(user);
            gridControl1.RefreshDataSource();  
            Database.SaveDatabase(filePath, database);
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            Database.SaveDatabase(filePath, database);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedUserId = (Guid)gridView1.GetFocusedRowCellValue("UserId");

            string updatedUsername = txtUserName.Text;
            string updatedPassword = txtPassword.Text;

            var user = database.userlist.FirstOrDefault(u => u.UserId == selectedUserId);

            if (user != null)
            {
                user.UserName = updatedUsername;
                user.Password = updatedPassword;
                Database.SaveDatabase(filePath, database);
                MessageBox.Show("Kullanıcı bilgileri güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            MessageBox.Show("Form temizlendi.", "Temizleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
