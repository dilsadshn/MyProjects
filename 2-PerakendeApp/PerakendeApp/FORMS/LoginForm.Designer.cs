namespace PerakendeApp.FORMS
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnClear = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(59, 36);
            label1.Name = "label1";
            label1.Size = new Size(311, 52);
            label1.TabIndex = 0;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(92, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(92, 170);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(92, 126);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 27);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "admin";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 198);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "1234";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.AliceBlue;
            btnClear.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.MidnightBlue;
            btnClear.Location = new Point(92, 254);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AliceBlue;
            btnLogin.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.MidnightBlue;
            btnLogin.Location = new Point(219, 254);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 38);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.AliceBlue;
            btnExit.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.MidnightBlue;
            btnExit.Location = new Point(42, 322);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıkış Yap";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(432, 384);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KULLANICI GİRİŞ FORMU";
            Shown += LoginForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnClear;
        private Button btnLogin;
        private Button btnExit;
    }
}