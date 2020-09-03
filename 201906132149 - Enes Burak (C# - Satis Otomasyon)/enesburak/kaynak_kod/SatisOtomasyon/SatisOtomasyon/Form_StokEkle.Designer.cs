namespace SatisOtomasyon
{
    partial class Form_StokEkle
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
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ndAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // cbUrun
            // 
            this.cbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(85, 43);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(181, 21);
            this.cbUrun.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // ndAdet
            // 
            this.ndAdet.Location = new System.Drawing.Point(85, 74);
            this.ndAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndAdet.Name = "ndAdet";
            this.ndAdet.Size = new System.Drawing.Size(181, 20);
            this.ndAdet.TabIndex = 2;
            this.ndAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndAdet.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(85, 109);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 37);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form_StokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 185);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.ndAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUrun);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_StokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.Form_StokEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndAdet;
        private System.Windows.Forms.Button btnEkle;
    }
}