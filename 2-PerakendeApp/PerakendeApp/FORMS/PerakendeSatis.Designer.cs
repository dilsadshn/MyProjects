namespace PerakendeApp.FORMS
{
    partial class PerakendeSatis
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
            txtBarcode = new TextBox();
            label2 = new Label();
            lblTotalAmount = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnClearCart = new Button();
            btnCompleteSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Plum;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label1.Location = new Point(1, -2);
            label1.Margin = new Padding(50, 5, 50, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 15, 15, 60);
            label1.Size = new Size(365, 103);
            label1.TabIndex = 0;
            label1.Text = "BARKOD OKUTMA ALANI";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(26, 51);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(306, 22);
            txtBarcode.TabIndex = 1;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(22, 15, 21, 22);
            label2.Size = new Size(188, 145);
            label2.TabIndex = 4;
            label2.Text = "SEPET\r\nTOPLAMI\r\n\r\n";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = Color.Gray;
            lblTotalAmount.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(548, 0);
            lblTotalAmount.MaximumSize = new Size(100, 100);
            lblTotalAmount.MinimumSize = new Size(300, 103);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Padding = new Padding(55, 33, 50, 0);
            lblTotalAmount.Size = new Size(300, 103);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "Toplam: 0,00 TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumAquamarine;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 99);
            label3.Name = "label3";
            label3.Padding = new Padding(15, 15, 755, 15);
            label3.Size = new Size(848, 56);
            label3.TabIndex = 7;
            label3.Text = "SEPET";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(848, 246);
            dataGridView1.TabIndex = 8;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.RoyalBlue;
            btnClearCart.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            btnClearCart.ForeColor = SystemColors.ButtonFace;
            btnClearCart.Location = new Point(447, 409);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Padding = new Padding(5);
            btnClearCart.Size = new Size(177, 47);
            btnClearCart.TabIndex = 9;
            btnClearCart.Text = "SEPETİ TEMİZLE";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.RoyalBlue;
            btnCompleteSale.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            btnCompleteSale.ForeColor = SystemColors.ButtonFace;
            btnCompleteSale.Location = new Point(642, 409);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Padding = new Padding(5);
            btnCompleteSale.Size = new Size(177, 47);
            btnCompleteSale.TabIndex = 9;
            btnCompleteSale.Text = "SATIŞI TAMAMLA";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // PerakendeSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 477);
            Controls.Add(btnCompleteSale);
            Controls.Add(btnClearCart);
            Controls.Add(label3);
            Controls.Add(lblTotalAmount);
            Controls.Add(txtBarcode);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PerakendeSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PERAKENDE SATIŞ FORMU";
            Load += PerakendeSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBarcode;
        private Label label2;
        private Label lblTotalAmount;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnClearCart;
        private Button btnCompleteSale;
    }
}