namespace PerakendeApp.FORMS
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenKullaniciTakipForm = new Button();
            btnOpenStokTakipForm = new Button();
            btnOpenPerakendeSatisForm = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnOpenKullaniciTakipForm
            // 
            btnOpenKullaniciTakipForm.BackColor = Color.LightSeaGreen;
            btnOpenKullaniciTakipForm.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnOpenKullaniciTakipForm.ForeColor = Color.WhiteSmoke;
            btnOpenKullaniciTakipForm.Location = new Point(101, 33);
            btnOpenKullaniciTakipForm.Name = "btnOpenKullaniciTakipForm";
            btnOpenKullaniciTakipForm.Size = new Size(156, 57);
            btnOpenKullaniciTakipForm.TabIndex = 0;
            btnOpenKullaniciTakipForm.Text = "Kullanıcı Takip";
            btnOpenKullaniciTakipForm.UseVisualStyleBackColor = false;
            btnOpenKullaniciTakipForm.Click += btnOpenKullaniciTakipForm_Click_1;
            // 
            // btnOpenStokTakipForm
            // 
            btnOpenStokTakipForm.BackColor = Color.PaleVioletRed;
            btnOpenStokTakipForm.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnOpenStokTakipForm.ForeColor = Color.WhiteSmoke;
            btnOpenStokTakipForm.Location = new Point(101, 106);
            btnOpenStokTakipForm.Name = "btnOpenStokTakipForm";
            btnOpenStokTakipForm.Size = new Size(156, 57);
            btnOpenStokTakipForm.TabIndex = 0;
            btnOpenStokTakipForm.Text = "Stok Takip";
            btnOpenStokTakipForm.UseVisualStyleBackColor = false;
            btnOpenStokTakipForm.Click += btnOpenStokTakipForm_Click_1;
            // 
            // btnOpenPerakendeSatisForm
            // 
            btnOpenPerakendeSatisForm.BackColor = Color.MediumPurple;
            btnOpenPerakendeSatisForm.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnOpenPerakendeSatisForm.ForeColor = Color.WhiteSmoke;
            btnOpenPerakendeSatisForm.Location = new Point(101, 180);
            btnOpenPerakendeSatisForm.Name = "btnOpenPerakendeSatisForm";
            btnOpenPerakendeSatisForm.Size = new Size(156, 57);
            btnOpenPerakendeSatisForm.TabIndex = 0;
            btnOpenPerakendeSatisForm.Text = "Perakende Satış";
            btnOpenPerakendeSatisForm.UseVisualStyleBackColor = false;
            btnOpenPerakendeSatisForm.Click += btnOpenPerakendeSatisForm_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Coral;
            btnCikis.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnCikis.ForeColor = Color.WhiteSmoke;
            btnCikis.Location = new Point(101, 253);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(156, 57);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(360, 341);
            Controls.Add(btnCikis);
            Controls.Add(btnOpenStokTakipForm);
            Controls.Add(btnOpenPerakendeSatisForm);
            Controls.Add(btnOpenKullaniciTakipForm);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANA MENÜ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenKullaniciTakipForm;
        private Button btnOpenStokTakipForm;
        private Button btnOpenPerakendeSatisForm;
        private Button btnCikis;
    }
}