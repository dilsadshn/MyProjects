namespace PerakendeApp.FORMS
{
    partial class StokTakip
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtStockName = new TextBox();
            txtBarcode = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSelectAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 206);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(618, 256);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 2;
            label1.Text = "STOK ADI:";
            // 
            // txtStockName
            // 
            txtStockName.Location = new Point(35, 51);
            txtStockName.Margin = new Padding(3, 2, 3, 2);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(183, 22);
            txtStockName.TabIndex = 3;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(35, 106);
            txtBarcode.Margin = new Padding(3, 2, 3, 2);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(183, 22);
            txtBarcode.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.Location = new Point(35, 88);
            label2.Name = "label2";
            label2.Size = new Size(128, 16);
            label2.TabIndex = 4;
            label2.Text = "STOK BARKODU:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(35, 161);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 22);
            txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label3.Location = new Point(35, 143);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 6;
            label3.Text = "STOK FİYATI:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(263, 43);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(187, 39);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Stok Ekle";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(466, 43);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 39);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Stok Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(263, 98);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 39);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Stok Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(354, 153);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(187, 39);
            btnClear.TabIndex = 1;
            btnClear.Text = "Vazgeç";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(466, 98);
            btnSelectAll.Margin = new Padding(3, 2, 3, 2);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(187, 39);
            btnSelectAll.TabIndex = 1;
            btnSelectAll.Text = "Tümünü Göster";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // StokTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(690, 489);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtBarcode);
            Controls.Add(label2);
            Controls.Add(txtStockName);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSelectAll);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StokTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STOK TAKİP FORMU";
            Load += StokTakip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtStockName;
        private TextBox txtBarcode;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button button1;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSelectAll;
    }
}