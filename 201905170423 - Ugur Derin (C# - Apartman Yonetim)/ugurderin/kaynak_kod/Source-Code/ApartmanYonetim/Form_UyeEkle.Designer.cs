namespace ApartmanYonetim
{
    partial class Form_UyeEkle
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
            this.cbKullaniciAd = new System.Windows.Forms.ComboBox();
            this.cbApartmanAd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKatNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDaireNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanını Adı";
            // 
            // cbKullaniciAd
            // 
            this.cbKullaniciAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciAd.FormattingEnabled = true;
            this.cbKullaniciAd.Location = new System.Drawing.Point(102, 51);
            this.cbKullaniciAd.Name = "cbKullaniciAd";
            this.cbKullaniciAd.Size = new System.Drawing.Size(137, 21);
            this.cbKullaniciAd.TabIndex = 1;
            // 
            // cbApartmanAd
            // 
            this.cbApartmanAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartmanAd.FormattingEnabled = true;
            this.cbApartmanAd.Location = new System.Drawing.Point(102, 78);
            this.cbApartmanAd.Name = "cbApartmanAd";
            this.cbApartmanAd.Size = new System.Drawing.Size(137, 21);
            this.cbApartmanAd.TabIndex = 3;
            this.cbApartmanAd.SelectedIndexChanged += new System.EventHandler(this.cbApartmanAd_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apartman";
            // 
            // cbKatNo
            // 
            this.cbKatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKatNo.FormattingEnabled = true;
            this.cbKatNo.Location = new System.Drawing.Point(102, 105);
            this.cbKatNo.Name = "cbKatNo";
            this.cbKatNo.Size = new System.Drawing.Size(137, 21);
            this.cbKatNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kat No";
            // 
            // cbDaireNo
            // 
            this.cbDaireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireNo.FormattingEnabled = true;
            this.cbDaireNo.Location = new System.Drawing.Point(102, 132);
            this.cbDaireNo.Name = "cbDaireNo";
            this.cbDaireNo.Size = new System.Drawing.Size(137, 21);
            this.cbDaireNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Daire No";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(74, 177);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 37);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(170, 177);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(69, 37);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // Form_UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(293, 264);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ekle";
            this.Load += new System.EventHandler(this.Form_UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKullaniciAd;
        private System.Windows.Forms.ComboBox cbApartmanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKatNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDaireNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}