using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PerakendeApp.FORMS
{
    public partial class KullaniciTakip : Form
    {
        DataTable dt = new DataTable();

        public KullaniciTakip()
        {
            InitializeComponent();
        }

        void load_dgv()
        {
            string sql = "SELECT UserId, UserName, Password FROM Users";

            if (!core.cli.run_query(dt, sql, "KullaniciTakp_Load()"))
            {
                MessageBox.Show("Bir Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.DataSource=dt;
        }
        private void KullaniciTakip_Load(object sender, EventArgs e)
        {
            load_dgv();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"INSERT INTO Users (UserName, Password) VALUES ('{UserName}', '{Password}')";

            if (!core.cli.run_query(sql, "btnCreate_Click"))
            {
                MessageBox.Show("Kullanıcı eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Kullanıcı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            load_dgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int UserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserId"].Value);
                string UserName = txtUserName.Text.Trim();
                string Password = txtPassword.Text.Trim();

                string sql = $"UPDATE Users SET UserName = '{UserName}', Password = '{Password}' WHERE UserId = {UserId}";

                if (!core.cli.run_query(sql, "btnUpdate_Click"))
                {
                    MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                load_dgv();
            }
            else
            {
                MessageBox.Show("Güncellemek için bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int UserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserId"].Value);

                string sql = $"DELETE FROM Users WHERE UserId = {UserId}";

                if (!core.cli.run_query(sql, "btnDelete_Click"))
                {
                    MessageBox.Show("Kullanıcı silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Kullanıcı başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                load_dgv();
            }
            else
            {
                MessageBox.Show("Silmek için bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();
        }
    }
}
