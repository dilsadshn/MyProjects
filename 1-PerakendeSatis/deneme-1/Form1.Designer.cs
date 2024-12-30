namespace deneme_1
{
    partial class AnaMenü
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenKullaniciTakipForm = new System.Windows.Forms.Button();
            this.btnOpenStokTakipForm = new System.Windows.Forms.Button();
            this.btnPerakendeSatis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenKullaniciTakipForm
            // 
            this.btnOpenKullaniciTakipForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOpenKullaniciTakipForm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenKullaniciTakipForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenKullaniciTakipForm.Location = new System.Drawing.Point(28, 48);
            this.btnOpenKullaniciTakipForm.Name = "btnOpenKullaniciTakipForm";
            this.btnOpenKullaniciTakipForm.Size = new System.Drawing.Size(146, 52);
            this.btnOpenKullaniciTakipForm.TabIndex = 0;
            this.btnOpenKullaniciTakipForm.Text = "Kullanıcı Takip";
            this.btnOpenKullaniciTakipForm.UseVisualStyleBackColor = false;
            this.btnOpenKullaniciTakipForm.Click += new System.EventHandler(this.BtnOpenKullaniciTakipForm_Click);
            // 
            // btnOpenStokTakipForm
            // 
            this.btnOpenStokTakipForm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenStokTakipForm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenStokTakipForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenStokTakipForm.Location = new System.Drawing.Point(198, 48);
            this.btnOpenStokTakipForm.Name = "btnOpenStokTakipForm";
            this.btnOpenStokTakipForm.Size = new System.Drawing.Size(146, 52);
            this.btnOpenStokTakipForm.TabIndex = 0;
            this.btnOpenStokTakipForm.Text = "Stok Takip";
            this.btnOpenStokTakipForm.UseVisualStyleBackColor = false;
            this.btnOpenStokTakipForm.Click += new System.EventHandler(this.btnOpenStokTakipForm_Click);
            // 
            // btnPerakendeSatis
            // 
            this.btnPerakendeSatis.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPerakendeSatis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerakendeSatis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerakendeSatis.Location = new System.Drawing.Point(28, 139);
            this.btnPerakendeSatis.Name = "btnPerakendeSatis";
            this.btnPerakendeSatis.Size = new System.Drawing.Size(146, 52);
            this.btnPerakendeSatis.TabIndex = 0;
            this.btnPerakendeSatis.Text = "Perakende Satış";
            this.btnPerakendeSatis.UseVisualStyleBackColor = false;
            this.btnPerakendeSatis.Click += new System.EventHandler(this.btnPerakendeSatis_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Coral;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCikis.Location = new System.Drawing.Point(198, 139);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(146, 52);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.btnOpenStokTakipForm);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnPerakendeSatis);
            this.Controls.Add(this.btnOpenKullaniciTakipForm);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA MENÜ";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenKullaniciTakipForm;
        private System.Windows.Forms.Button btnOpenStokTakipForm;
        private System.Windows.Forms.Button btnPerakendeSatis;
        private System.Windows.Forms.Button btnCikis;
    }
}

