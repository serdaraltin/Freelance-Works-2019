namespace ApartmanYonetim
{
    partial class Form_ApartmanGuncelle
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAidatTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ndDaireSayisi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ndKatSayi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbYonetici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndDaireSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndKatSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(165, 201);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(74, 37);
            this.btnIptal.TabIndex = 36;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(72, 201);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 37);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "GÜNCELLE";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAidatTL
            // 
            this.txtAidatTL.Location = new System.Drawing.Point(146, 155);
            this.txtAidatTL.Name = "txtAidatTL";
            this.txtAidatTL.Size = new System.Drawing.Size(93, 20);
            this.txtAidatTL.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Aidat";
            // 
            // ndDaireSayisi
            // 
            this.ndDaireSayisi.Location = new System.Drawing.Point(146, 129);
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
            this.ndDaireSayisi.TabIndex = 32;
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
            this.label5.Location = new System.Drawing.Point(78, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Daire Sayısı";
            // 
            // ndKatSayi
            // 
            this.ndKatSayi.Location = new System.Drawing.Point(146, 103);
            this.ndKatSayi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ndKatSayi.Name = "ndKatSayi";
            this.ndKatSayi.Size = new System.Drawing.Size(93, 20);
            this.ndKatSayi.TabIndex = 30;
            this.ndKatSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndKatSayi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kat Sayısı";
            // 
            // txtBlok
            // 
            this.txtBlok.Location = new System.Drawing.Point(81, 77);
            this.txtBlok.Name = "txtBlok";
            this.txtBlok.Size = new System.Drawing.Size(158, 20);
            this.txtBlok.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Blok";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(81, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(158, 20);
            this.txtAd.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ad";
            // 
            // cbYonetici
            // 
            this.cbYonetici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYonetici.FormattingEnabled = true;
            this.cbYonetici.Location = new System.Drawing.Point(81, 24);
            this.cbYonetici.Name = "cbYonetici";
            this.cbYonetici.Size = new System.Drawing.Size(158, 21);
            this.cbYonetici.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Yönetici";
            // 
            // Form_ApartmanGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
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
            this.Name = "Form_ApartmanGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartman Guncelle";
            this.Load += new System.EventHandler(this.Form_ApartmanGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndDaireSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndKatSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAidatTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ndDaireSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ndKatSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbYonetici;
        private System.Windows.Forms.Label label1;
    }
}