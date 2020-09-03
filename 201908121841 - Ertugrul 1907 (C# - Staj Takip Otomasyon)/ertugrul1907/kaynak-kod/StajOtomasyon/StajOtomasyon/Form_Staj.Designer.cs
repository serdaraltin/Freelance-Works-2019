namespace StajOtomasyon
{
    partial class Form_Staj
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
            this.dataGridStaj = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cbOgrenci = new System.Windows.Forms.ComboBox();
            this.cbVeli = new System.Windows.Forms.ComboBox();
            this.cbOgretmen = new System.Windows.Forms.ComboBox();
            this.cbIsyeri = new System.Windows.Forms.ComboBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGunYeni = new System.Windows.Forms.Button();
            this.btnGunSil = new System.Windows.Forms.Button();
            this.btnGunKaydet = new System.Windows.Forms.Button();
            this.chDurum = new System.Windows.Forms.CheckBox();
            this.dtStajGun = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDefter = new System.Windows.Forms.DataGridView();
            this.dataGridOgrenci = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridIsyeri = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridOgretmen = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridVeli = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIsyeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeli)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridStaj
            // 
            this.dataGridStaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaj.Location = new System.Drawing.Point(313, 41);
            this.dataGridStaj.MultiSelect = false;
            this.dataGridStaj.Name = "dataGridStaj";
            this.dataGridStaj.ReadOnly = true;
            this.dataGridStaj.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStaj.Size = new System.Drawing.Size(470, 209);
            this.dataGridStaj.TabIndex = 5;
            this.dataGridStaj.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStaj_CellDoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(708, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Location = new System.Drawing.Point(582, 14);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(120, 20);
            this.txtAra.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Öğrenci Numara";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(313, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtBitis);
            this.panel1.Controls.Add(this.dtBaslangic);
            this.panel1.Controls.Add(this.cbOgrenci);
            this.panel1.Controls.Add(this.cbVeli);
            this.panel1.Controls.Add(this.cbOgretmen);
            this.panel1.Controls.Add(this.cbIsyeri);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 238);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Bitiş";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Başlangıç";
            // 
            // dtBitis
            // 
            this.dtBitis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBitis.Location = new System.Drawing.Point(92, 164);
            this.dtBitis.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(177, 20);
            this.dtBitis.TabIndex = 6;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBaslangic.Location = new System.Drawing.Point(92, 138);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(177, 20);
            this.dtBaslangic.TabIndex = 5;
            // 
            // cbOgrenci
            // 
            this.cbOgrenci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgrenci.FormattingEnabled = true;
            this.cbOgrenci.Location = new System.Drawing.Point(92, 30);
            this.cbOgrenci.Name = "cbOgrenci";
            this.cbOgrenci.Size = new System.Drawing.Size(177, 21);
            this.cbOgrenci.TabIndex = 1;
            // 
            // cbVeli
            // 
            this.cbVeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVeli.FormattingEnabled = true;
            this.cbVeli.Location = new System.Drawing.Point(92, 111);
            this.cbVeli.Name = "cbVeli";
            this.cbVeli.Size = new System.Drawing.Size(177, 21);
            this.cbVeli.TabIndex = 4;
            // 
            // cbOgretmen
            // 
            this.cbOgretmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOgretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgretmen.FormattingEnabled = true;
            this.cbOgretmen.Location = new System.Drawing.Point(92, 84);
            this.cbOgretmen.Name = "cbOgretmen";
            this.cbOgretmen.Size = new System.Drawing.Size(177, 21);
            this.cbOgretmen.TabIndex = 3;
            // 
            // cbIsyeri
            // 
            this.cbIsyeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIsyeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsyeri.FormattingEnabled = true;
            this.cbIsyeri.Location = new System.Drawing.Point(92, 57);
            this.cbIsyeri.Name = "cbIsyeri";
            this.cbIsyeri.Size = new System.Drawing.Size(177, 21);
            this.cbIsyeri.TabIndex = 2;
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeni.Location = new System.Drawing.Point(23, 193);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(49, 36);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Öğrenci";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(89, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "STAJ BİLGİLERİ";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.Location = new System.Drawing.Point(197, 193);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 36);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.Location = new System.Drawing.Point(78, 193);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 36);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Veli";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğretmen";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşyeri";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.txtSinif);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtNumara);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtTc);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.pbResim);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btnGunYeni);
            this.panel2.Controls.Add(this.btnGunSil);
            this.panel2.Controls.Add(this.btnGunKaydet);
            this.panel2.Controls.Add(this.chDurum);
            this.panel2.Controls.Add(this.dtStajGun);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(510, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 320);
            this.panel2.TabIndex = 10;
            // 
            // txtSinif
            // 
            this.txtSinif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSinif.Location = new System.Drawing.Point(72, 176);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.ReadOnly = true;
            this.txtSinif.Size = new System.Drawing.Size(191, 20);
            this.txtSinif.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "Sınıf";
            // 
            // txtNumara
            // 
            this.txtNumara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumara.Location = new System.Drawing.Point(72, 70);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.ReadOnly = true;
            this.txtNumara.Size = new System.Drawing.Size(70, 20);
            this.txtNumara.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Numara";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.Location = new System.Drawing.Point(72, 96);
            this.txtTc.Name = "txtTc";
            this.txtTc.ReadOnly = true;
            this.txtTc.Size = new System.Drawing.Size(191, 20);
            this.txtTc.TabIndex = 44;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.Location = new System.Drawing.Point(72, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(191, 20);
            this.txtAd.TabIndex = 40;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyad.Location = new System.Drawing.Point(72, 150);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(191, 20);
            this.txtSoyad.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "T.C. No";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Soyad";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Ad";
            // 
            // pbResim
            // 
            this.pbResim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(203, 30);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(60, 60);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 39;
            this.pbResim.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Staj Durumu";
            // 
            // btnGunYeni
            // 
            this.btnGunYeni.Location = new System.Drawing.Point(17, 267);
            this.btnGunYeni.Name = "btnGunYeni";
            this.btnGunYeni.Size = new System.Drawing.Size(49, 36);
            this.btnGunYeni.TabIndex = 36;
            this.btnGunYeni.Text = "Yeni";
            this.btnGunYeni.UseVisualStyleBackColor = true;
            this.btnGunYeni.Click += new System.EventHandler(this.btnGunYeni_Click);
            // 
            // btnGunSil
            // 
            this.btnGunSil.Location = new System.Drawing.Point(191, 267);
            this.btnGunSil.Name = "btnGunSil";
            this.btnGunSil.Size = new System.Drawing.Size(72, 36);
            this.btnGunSil.TabIndex = 35;
            this.btnGunSil.Text = "Sil";
            this.btnGunSil.UseVisualStyleBackColor = true;
            this.btnGunSil.Click += new System.EventHandler(this.btnGunSil_Click);
            // 
            // btnGunKaydet
            // 
            this.btnGunKaydet.Location = new System.Drawing.Point(72, 267);
            this.btnGunKaydet.Name = "btnGunKaydet";
            this.btnGunKaydet.Size = new System.Drawing.Size(113, 36);
            this.btnGunKaydet.TabIndex = 34;
            this.btnGunKaydet.Text = "Kaydet";
            this.btnGunKaydet.UseVisualStyleBackColor = true;
            this.btnGunKaydet.Click += new System.EventHandler(this.btnGunKaydet_Click);
            // 
            // chDurum
            // 
            this.chDurum.AutoSize = true;
            this.chDurum.Location = new System.Drawing.Point(89, 236);
            this.chDurum.Name = "chDurum";
            this.chDurum.Size = new System.Drawing.Size(113, 17);
            this.chDurum.TabIndex = 33;
            this.chDurum.Text = "Yapıldı / Yapılmadı";
            this.chDurum.UseVisualStyleBackColor = true;
            // 
            // dtStajGun
            // 
            this.dtStajGun.Location = new System.Drawing.Point(72, 202);
            this.dtStajGun.Name = "dtStajGun";
            this.dtStajGun.Size = new System.Drawing.Size(191, 20);
            this.dtStajGun.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "STAJ GÜN KAYIT";
            // 
            // dataGridDefter
            // 
            this.dataGridDefter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDefter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDefter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefter.Location = new System.Drawing.Point(789, 41);
            this.dataGridDefter.MultiSelect = false;
            this.dataGridDefter.Name = "dataGridDefter";
            this.dataGridDefter.ReadOnly = true;
            this.dataGridDefter.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDefter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDefter.Size = new System.Drawing.Size(330, 538);
            this.dataGridDefter.TabIndex = 15;
            this.dataGridDefter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefter_CellDoubleClick);
            // 
            // dataGridOgrenci
            // 
            this.dataGridOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgrenci.Location = new System.Drawing.Point(2, 30);
            this.dataGridOgrenci.MultiSelect = false;
            this.dataGridOgrenci.Name = "dataGridOgrenci";
            this.dataGridOgrenci.ReadOnly = true;
            this.dataGridOgrenci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridOgrenci.Size = new System.Drawing.Size(489, 45);
            this.dataGridOgrenci.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Öğrenci Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "İşyeri Bilgileri";
            // 
            // dataGridIsyeri
            // 
            this.dataGridIsyeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIsyeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIsyeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIsyeri.Location = new System.Drawing.Point(2, 109);
            this.dataGridIsyeri.MultiSelect = false;
            this.dataGridIsyeri.Name = "dataGridIsyeri";
            this.dataGridIsyeri.ReadOnly = true;
            this.dataGridIsyeri.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIsyeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridIsyeri.Size = new System.Drawing.Size(489, 45);
            this.dataGridIsyeri.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Öğretmen Bilgileri";
            // 
            // dataGridOgretmen
            // 
            this.dataGridOgretmen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOgretmen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgretmen.Location = new System.Drawing.Point(2, 188);
            this.dataGridOgretmen.MultiSelect = false;
            this.dataGridOgretmen.Name = "dataGridOgretmen";
            this.dataGridOgretmen.ReadOnly = true;
            this.dataGridOgretmen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOgretmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridOgretmen.Size = new System.Drawing.Size(489, 45);
            this.dataGridOgretmen.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Veli Bilgileri";
            // 
            // dataGridVeli
            // 
            this.dataGridVeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeli.Location = new System.Drawing.Point(2, 267);
            this.dataGridVeli.MultiSelect = false;
            this.dataGridVeli.Name = "dataGridVeli";
            this.dataGridVeli.ReadOnly = true;
            this.dataGridVeli.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridVeli.Size = new System.Drawing.Size(489, 45);
            this.dataGridVeli.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(789, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Staj Defteri";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1044, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Yenile";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridVeli);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dataGridOgretmen);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridIsyeri);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridOgrenci);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(10, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 320);
            this.panel3.TabIndex = 16;
            // 
            // Form_Staj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridDefter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridStaj);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Staj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staj Yönetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Staj_FormClosing);
            this.Load += new System.EventHandler(this.Form_StajEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIsyeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeli)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStaj;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbVeli;
        private System.Windows.Forms.ComboBox cbOgretmen;
        private System.Windows.Forms.ComboBox cbIsyeri;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDefter;
        private System.Windows.Forms.DataGridView dataGridOgrenci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridIsyeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridOgretmen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridVeli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbOgrenci;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtStajGun;
        private System.Windows.Forms.Button btnGunYeni;
        private System.Windows.Forms.Button btnGunSil;
        private System.Windows.Forms.Button btnGunKaydet;
        private System.Windows.Forms.CheckBox chDurum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label21;
    }
}