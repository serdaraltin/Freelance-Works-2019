namespace Sabri_Gozdag_Sozluk
{
    partial class Form_Sozluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sozluk));
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lstBulunan = new System.Windows.Forms.ListBox();
            this.cbAranan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbTamKelime = new System.Windows.Forms.CheckBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTeknik = new System.Windows.Forms.RadioButton();
            this.rdbElektronik = new System.Windows.Forms.RadioButton();
            this.rdbtip = new System.Windows.Forms.RadioButton();
            this.rdbBilgisayar = new System.Windows.Forms.RadioButton();
            this.rdbTurkceIngilizce = new System.Windows.Forms.RadioButton();
            this.rdbIngilizceTurkce = new System.Windows.Forms.RadioButton();
            this.rcAnlam = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rdbBilisim = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Maroon;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(836, 20);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(115, 37);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, -9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 667);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(967, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 657);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(-18, 594);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1019, 30);
            this.panel4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(30, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(767, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Bu program Sabri Gözdağ tarafından kodlanmıştır. İzinsiz kopyalanması veya satılm" +
    "ası yasaktır. Tüm hakları saklıdır.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(-7, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1031, 12);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(817, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 12);
            this.panel6.TabIndex = 16;
            // 
            // lstBulunan
            // 
            this.lstBulunan.BackColor = System.Drawing.Color.DarkGray;
            this.lstBulunan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBulunan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lstBulunan.FormattingEnabled = true;
            this.lstBulunan.ItemHeight = 18;
            this.lstBulunan.Location = new System.Drawing.Point(30, 239);
            this.lstBulunan.Name = "lstBulunan";
            this.lstBulunan.Size = new System.Drawing.Size(176, 344);
            this.lstBulunan.TabIndex = 17;
            this.lstBulunan.SelectedIndexChanged += new System.EventHandler(this.lstBulunan_SelectedIndexChanged);
            // 
            // cbAranan
            // 
            this.cbAranan.BackColor = System.Drawing.Color.DimGray;
            this.cbAranan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cbAranan.ForeColor = System.Drawing.Color.White;
            this.cbAranan.FormattingEnabled = true;
            this.cbAranan.Location = new System.Drawing.Point(30, 111);
            this.cbAranan.Name = "cbAranan";
            this.cbAranan.Size = new System.Drawing.Size(176, 28);
            this.cbAranan.TabIndex = 18;
            this.cbAranan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ARANACAK KELİME";
            // 
            // chbTamKelime
            // 
            this.chbTamKelime.AutoSize = true;
            this.chbTamKelime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbTamKelime.Location = new System.Drawing.Point(60, 145);
            this.chbTamKelime.Name = "chbTamKelime";
            this.chbTamKelime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbTamKelime.Size = new System.Drawing.Size(143, 21);
            this.chbTamKelime.TabIndex = 20;
            this.chbTamKelime.Text = "Tam Kelime Arama";
            this.chbTamKelime.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Khaki;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(30, 172);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(176, 31);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBilisim);
            this.groupBox1.Controls.Add(this.rdbTeknik);
            this.groupBox1.Controls.Add(this.rdbElektronik);
            this.groupBox1.Controls.Add(this.rdbtip);
            this.groupBox1.Controls.Add(this.rdbBilgisayar);
            this.groupBox1.Controls.Add(this.rdbTurkceIngilizce);
            this.groupBox1.Controls.Add(this.rdbIngilizceTurkce);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(225, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÜR";
            // 
            // rdbTeknik
            // 
            this.rdbTeknik.AutoSize = true;
            this.rdbTeknik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTeknik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbTeknik.ForeColor = System.Drawing.Color.Black;
            this.rdbTeknik.Location = new System.Drawing.Point(562, 25);
            this.rdbTeknik.Name = "rdbTeknik";
            this.rdbTeknik.Size = new System.Drawing.Size(132, 21);
            this.rdbTeknik.TabIndex = 5;
            this.rdbTeknik.TabStop = true;
            this.rdbTeknik.Text = "TEKNİK TERİM";
            this.rdbTeknik.UseVisualStyleBackColor = true;
            this.rdbTeknik.CheckedChanged += new System.EventHandler(this.rdbTeknik_CheckedChanged);
            // 
            // rdbElektronik
            // 
            this.rdbElektronik.AutoSize = true;
            this.rdbElektronik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbElektronik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbElektronik.ForeColor = System.Drawing.Color.Black;
            this.rdbElektronik.Location = new System.Drawing.Point(20, 52);
            this.rdbElektronik.Name = "rdbElektronik";
            this.rdbElektronik.Size = new System.Drawing.Size(174, 21);
            this.rdbElektronik.TabIndex = 4;
            this.rdbElektronik.TabStop = true;
            this.rdbElektronik.Text = "ELEKTRONİK TERİM";
            this.rdbElektronik.UseVisualStyleBackColor = true;
            this.rdbElektronik.CheckedChanged += new System.EventHandler(this.rdbElektronik_CheckedChanged);
            // 
            // rdbtip
            // 
            this.rdbtip.AutoSize = true;
            this.rdbtip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbtip.ForeColor = System.Drawing.Color.Black;
            this.rdbtip.Location = new System.Drawing.Point(204, 52);
            this.rdbtip.Name = "rdbtip";
            this.rdbtip.Size = new System.Drawing.Size(101, 21);
            this.rdbtip.TabIndex = 3;
            this.rdbtip.TabStop = true;
            this.rdbtip.Text = "TIP TERİM";
            this.rdbtip.UseVisualStyleBackColor = true;
            this.rdbtip.CheckedChanged += new System.EventHandler(this.rdbtip_CheckedChanged);
            // 
            // rdbBilgisayar
            // 
            this.rdbBilgisayar.AutoSize = true;
            this.rdbBilgisayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbBilgisayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbBilgisayar.ForeColor = System.Drawing.Color.Black;
            this.rdbBilgisayar.Location = new System.Drawing.Point(388, 25);
            this.rdbBilgisayar.Name = "rdbBilgisayar";
            this.rdbBilgisayar.Size = new System.Drawing.Size(167, 21);
            this.rdbBilgisayar.TabIndex = 2;
            this.rdbBilgisayar.TabStop = true;
            this.rdbBilgisayar.Text = "BİLGİSAYAR TERİM";
            this.rdbBilgisayar.UseVisualStyleBackColor = true;
            this.rdbBilgisayar.CheckedChanged += new System.EventHandler(this.rdbTerim_CheckedChanged);
            // 
            // rdbTurkceIngilizce
            // 
            this.rdbTurkceIngilizce.AutoSize = true;
            this.rdbTurkceIngilizce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTurkceIngilizce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbTurkceIngilizce.ForeColor = System.Drawing.Color.Black;
            this.rdbTurkceIngilizce.Location = new System.Drawing.Point(204, 25);
            this.rdbTurkceIngilizce.Name = "rdbTurkceIngilizce";
            this.rdbTurkceIngilizce.Size = new System.Drawing.Size(177, 21);
            this.rdbTurkceIngilizce.TabIndex = 1;
            this.rdbTurkceIngilizce.TabStop = true;
            this.rdbTurkceIngilizce.Text = "TÜRKÇE - İNGİLİZCE";
            this.rdbTurkceIngilizce.UseVisualStyleBackColor = true;
            this.rdbTurkceIngilizce.CheckedChanged += new System.EventHandler(this.rdbTurkceIngilizce_CheckedChanged);
            // 
            // rdbIngilizceTurkce
            // 
            this.rdbIngilizceTurkce.AutoSize = true;
            this.rdbIngilizceTurkce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbIngilizceTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbIngilizceTurkce.ForeColor = System.Drawing.Color.Black;
            this.rdbIngilizceTurkce.Location = new System.Drawing.Point(20, 25);
            this.rdbIngilizceTurkce.Name = "rdbIngilizceTurkce";
            this.rdbIngilizceTurkce.Size = new System.Drawing.Size(177, 21);
            this.rdbIngilizceTurkce.TabIndex = 0;
            this.rdbIngilizceTurkce.TabStop = true;
            this.rdbIngilizceTurkce.Text = "İNGİLİZCE - TÜRKÇE";
            this.rdbIngilizceTurkce.UseVisualStyleBackColor = true;
            this.rdbIngilizceTurkce.CheckedChanged += new System.EventHandler(this.rdbIngilizceTurkce_CheckedChanged);
            // 
            // rcAnlam
            // 
            this.rcAnlam.BackColor = System.Drawing.Color.DarkGray;
            this.rcAnlam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcAnlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rcAnlam.Location = new System.Drawing.Point(225, 111);
            this.rcAnlam.Name = "rcAnlam";
            this.rcAnlam.ReadOnly = true;
            this.rcAnlam.Size = new System.Drawing.Size(726, 383);
            this.rcAnlam.TabIndex = 23;
            this.rcAnlam.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(891, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "ANLAM";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Location = new System.Drawing.Point(713, 28);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(115, 29);
            this.btnAyarlar.TabIndex = 25;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Location = new System.Drawing.Point(590, 28);
            this.btnHakkinda.Margin = new System.Windows.Forms.Padding(4);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(115, 29);
            this.btnHakkinda.TabIndex = 26;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.UseVisualStyleBackColor = false;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Eşleşen Kelimeler :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(648, 65);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 29);
            this.btnEkle.TabIndex = 29;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rdbBilisim
            // 
            this.rdbBilisim.AutoSize = true;
            this.rdbBilisim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbBilisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rdbBilisim.ForeColor = System.Drawing.Color.Black;
            this.rdbBilisim.Location = new System.Drawing.Point(311, 52);
            this.rdbBilisim.Name = "rdbBilisim";
            this.rdbBilisim.Size = new System.Drawing.Size(130, 21);
            this.rdbBilisim.TabIndex = 6;
            this.rdbBilisim.TabStop = true;
            this.rdbBilisim.Text = "BİLİŞİM TERİM";
            this.rdbBilisim.UseVisualStyleBackColor = true;
            this.rdbBilisim.CheckedChanged += new System.EventHandler(this.rdbBilisim_CheckedChanged);
            // 
            // Form_Sozluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(980, 623);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rcAnlam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.chbTamKelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAranan);
            this.Controls.Add(this.lstBulunan);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnKapat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Sozluk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlük";
            this.Load += new System.EventHandler(this.Form_Sozluk_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lstBulunan;
        private System.Windows.Forms.ComboBox cbAranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbTamKelime;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBilgisayar;
        private System.Windows.Forms.RadioButton rdbTurkceIngilizce;
        private System.Windows.Forms.RadioButton rdbIngilizceTurkce;
        private System.Windows.Forms.RichTextBox rcAnlam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbTeknik;
        private System.Windows.Forms.RadioButton rdbElektronik;
        private System.Windows.Forms.RadioButton rdbtip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rdbBilisim;
    }
}