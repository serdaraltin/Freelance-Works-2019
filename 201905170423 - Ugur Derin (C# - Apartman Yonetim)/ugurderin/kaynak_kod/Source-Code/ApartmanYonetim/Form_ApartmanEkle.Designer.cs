namespace ApartmanYonetim
{
    partial class Form_ApartmanEkle
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
            this.cbYonetici = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBlok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ndKatSayi = new System.Windows.Forms.NumericUpDown();
            this.ndDaireSayisi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAidatTL = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndKatSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndDaireSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici";
            // 
            // cbYonetici
            // 
            this.cbYonetici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYonetici.FormattingEnabled = true;
            this.cbYonetici.Location = new System.Drawing.Point(84, 32);
            this.cbYonetici.Name = "cbYonetici";
            this.cbYonetici.Size = new System.Drawing.Size(158, 21);
            this.cbYonetici.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(84, 59);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(158, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtBlok
            // 
            this.txtBlok.Location = new System.Drawing.Point(84, 85);
            this.txtBlok.Name = "txtBlok";
            this.txtBlok.Size = new System.Drawing.Size(158, 20);
            this.txtBlok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kat Sayısı";
            // 
            // ndKatSayi
            // 
            this.ndKatSayi.Location = new System.Drawing.Point(149, 111);
            this.ndKatSayi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ndKatSayi.Name = "ndKatSayi";
            this.ndKatSayi.Size = new System.Drawing.Size(93, 20);
            this.ndKatSayi.TabIndex = 7;
            this.ndKatSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndKatSayi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ndDaireSayisi
            // 
            this.ndDaireSayisi.Location = new System.Drawing.Point(149, 137);
            this.ndDaireSayisi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ndDaireSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ndDaireSayisi.Name = "ndDaireSayisi";
            this.ndDaireSayisi.Size = new System.Drawing.Size(93, 20);
            this.ndDaireSayisi.TabIndex = 9;
            this.ndDaireSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndDaireSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Daire Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aidat";
            // 
            // txtAidatTL
            // 
            this.txtAidatTL.Location = new System.Drawing.Point(149, 163);
            this.txtAidatTL.Name = "txtAidatTL";
            this.txtAidatTL.Size = new System.Drawing.Size(93, 20);
            this.txtAidatTL.TabIndex = 11;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(168, 209);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(74, 37);
            this.btnIptal.TabIndex = 22;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(75, 209);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 37);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form_ApartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 279);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAidatTL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ndDaireSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ndKatSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBlok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbYonetici);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ApartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartman Ekle";
            this.Load += new System.EventHandler(this.Form_ApartmanEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndKatSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndDaireSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYonetici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBlok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ndKatSayi;
        private System.Windows.Forms.NumericUpDown ndDaireSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAidatTL;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
    }
}