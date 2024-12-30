namespace PerakendeApp.FORMS
{
    partial class KullaniciTakip
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 0;
            label2.Text = "ŞİFRE:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(36, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(212, 22);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(212, 22);
            txtPassword.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(516, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 38);
            btnClear.TabIndex = 2;
            btnClear.Text = "Vazgeç";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(516, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Kullanıcı Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(307, 108);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Kullanıcı Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(307, 50);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 38);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Kullanıcı Ekle";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(660, 239);
            dataGridView1.TabIndex = 3;
            // 
            // KullaniciTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(732, 425);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KULLANICI TAKİP FORMU";
            Load += KullaniciTakip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dataGridView1;
    }
}