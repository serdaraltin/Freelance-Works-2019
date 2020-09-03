namespace ApartmanYonetim
{
    partial class Form_UyeGuncelle
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
            this.cbDaireNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKatNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbApartmanAd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKullaniciAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(166, 160);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(69, 37);
            this.btnIptal.TabIndex = 19;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(70, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 37);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbDaireNo
            // 
            this.cbDaireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireNo.FormattingEnabled = true;
            this.cbDaireNo.Location = new System.Drawing.Point(98, 115);
            this.cbDaireNo.Name = "cbDaireNo";
            this.cbDaireNo.Size = new System.Drawing.Size(137, 21);
            this.cbDaireNo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Daire No";
            // 
            // cbKatNo
            // 
            this.cbKatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKatNo.FormattingEnabled = true;
            this.cbKatNo.Location = new System.Drawing.Point(98, 88);
            this.cbKatNo.Name = "cbKatNo";
            this.cbKatNo.Size = new System.Drawing.Size(137, 21);
            this.cbKatNo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kat No";
            // 
            // cbApartmanAd
            // 
            this.cbApartmanAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartmanAd.FormattingEnabled = true;
            this.cbApartmanAd.Location = new System.Drawing.Point(98, 61);
            this.cbApartmanAd.Name = "cbApartmanAd";
            this.cbApartmanAd.Size = new System.Drawing.Size(137, 21);
            this.cbApartmanAd.TabIndex = 13;
            this.cbApartmanAd.SelectedIndexChanged += new System.EventHandler(this.cbApartmanAd_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apartman";
            // 
            // cbKullaniciAd
            // 
            this.cbKullaniciAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciAd.Enabled = false;
            this.cbKullaniciAd.FormattingEnabled = true;
            this.cbKullaniciAd.Location = new System.Drawing.Point(98, 34);
            this.cbKullaniciAd.Name = "cbKullaniciAd";
            this.cbKullaniciAd.Size = new System.Drawing.Size(137, 21);
            this.cbKullaniciAd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanını Adı";
            // 
            // Form_UyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 228);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbDaireNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKatNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbApartmanAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKullaniciAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_UyeGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Güncelle";
            this.Load += new System.EventHandler(this.Form_UyeGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbDaireNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKatNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbApartmanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKullaniciAd;
        private System.Windows.Forms.Label label1;
    }
}