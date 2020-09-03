namespace ApartmanYonetim
{
    partial class Form_KullaniciDuzenle
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
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(101, 185);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(167, 28);
            this.btnResimSec.TabIndex = 43;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(194, 412);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(74, 37);
            this.btnIptal.TabIndex = 41;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(101, 412);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 37);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "GÜNCELLE";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbMedeniDurum
            // 
            this.cbMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedeniDurum.FormattingEnabled = true;
            this.cbMedeniDurum.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.cbMedeniDurum.Location = new System.Drawing.Point(101, 350);
            this.cbMedeniDurum.Name = "cbMedeniDurum";
            this.cbMedeniDurum.Size = new System.Drawing.Size(167, 21);
            this.cbMedeniDurum.TabIndex = 39;
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Location = new System.Drawing.Point(101, 297);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(167, 20);
            this.dtDogumTarih.TabIndex = 38;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.cbCinsiyet.Location = new System.Drawing.Point(101, 323);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(167, 21);
            this.cbCinsiyet.TabIndex = 37;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(101, 377);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 20);
            this.txtSifre.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Sifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Medeni Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dogum Tarihi";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(101, 271);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(167, 20);
            this.txtTelefon.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefon";
            // 
            // txtMailAdres
            // 
            this.txtMailAdres.Location = new System.Drawing.Point(101, 245);
            this.txtMailAdres.Name = "txtMailAdres";
            this.txtMailAdres.Size = new System.Drawing.Size(167, 20);
            this.txtMailAdres.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mail Adresi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(101, 219);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(167, 20);
            this.txtAdSoyad.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ad Soyad";
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(101, 12);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(167, 167);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 42;
            this.pbResim.TabStop = false;
            // 
            // Form_KullaniciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(306, 473);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbMedeniDurum);
            this.Controls.Add(this.dtDogumTarih);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMailAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_KullaniciDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Düzenle";
            this.Load += new System.EventHandler(this.Form_KullaniciDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbMedeniDurum;
        private System.Windows.Forms.DateTimePicker dtDogumTarih;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
    }
}