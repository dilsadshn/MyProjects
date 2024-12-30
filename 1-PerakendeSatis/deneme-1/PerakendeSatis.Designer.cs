namespace deneme_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 5, 50, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 60);
            this.label1.Size = new System.Drawing.Size(365, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARKOD OKUTMA ALANI";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(35, 60);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(298, 22);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCompleteSale.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCompleteSale.Location = new System.Drawing.Point(621, 401);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Padding = new System.Windows.Forms.Padding(5);
            this.btnCompleteSale.Size = new System.Drawing.Size(166, 45);
            this.btnCompleteSale.TabIndex = 2;
            this.btnCompleteSale.Text = "SATIŞI TAMAMLA";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(22, 21, 21, 22);
            this.label2.Size = new System.Drawing.Size(164, 103);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEPET\r\nTOPLAMI\r\n";
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearCart.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearCart.Location = new System.Drawing.Point(449, 401);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearCart.Size = new System.Drawing.Size(166, 45);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "SEPETİ TEMİZLE";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 146);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.Size = new System.Drawing.Size(835, 240);
            this.dataGridViewCart.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 111);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 762, 5);
            this.label3.Size = new System.Drawing.Size(833, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEPET";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Gray;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(538, 5);
            this.lblTotalAmount.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblTotalAmount.MinimumSize = new System.Drawing.Size(300, 103);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Padding = new System.Windows.Forms.Padding(55, 33, 50, 0);
            this.lblTotalAmount.Size = new System.Drawing.Size(300, 103);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Toplam: 0,00 TL";
            // 
            // PerakendeSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 462);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "PerakendeSatis";
            this.Text = "PERAKENDE SATIŞ FORMU";
            this.Load += new System.EventHandler(this.PerakendeSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}