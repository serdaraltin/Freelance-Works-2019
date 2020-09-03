namespace SatisOtomasyon
{
    partial class Form_Sepet
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAdet = new System.Windows.Forms.Label();
            this.lbStok = new System.Windows.Forms.Label();
            this.rcUrunAd = new System.Windows.Forms.RichTextBox();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbOlcu = new System.Windows.Forms.Label();
            this.lbMiktar = new System.Windows.Forms.Label();
            this.lbMarka = new System.Windows.Forms.Label();
            this.lbKategori = new System.Windows.Forms.Label();
            this.pbUrunResim = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KATEGORİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MİKTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FİYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.Button();
            this.btnUrunuSil = new System.Windows.Forms.Button();
            this.ndAdet = new System.Windows.Forms.NumericUpDown();
            this.btnAdetDegistir = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbAdet);
            this.panel3.Controls.Add(this.lbStok);
            this.panel3.Controls.Add(this.rcUrunAd);
            this.panel3.Controls.Add(this.lbFiyat);
            this.panel3.Controls.Add(this.lbOlcu);
            this.panel3.Controls.Add(this.lbMiktar);
            this.panel3.Controls.Add(this.lbMarka);
            this.panel3.Controls.Add(this.lbKategori);
            this.panel3.Controls.Add(this.pbUrunResim);
            this.panel3.Location = new System.Drawing.Point(554, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 420);
            this.panel3.TabIndex = 3;
            // 
            // lbAdet
            // 
            this.lbAdet.AutoSize = true;
            this.lbAdet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAdet.Location = new System.Drawing.Point(19, 390);
            this.lbAdet.Name = "lbAdet";
            this.lbAdet.Size = new System.Drawing.Size(29, 13);
            this.lbAdet.TabIndex = 15;
            this.lbAdet.Text = "Adet";
            // 
            // lbStok
            // 
            this.lbStok.AutoSize = true;
            this.lbStok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbStok.Location = new System.Drawing.Point(19, 372);
            this.lbStok.Name = "lbStok";
            this.lbStok.Size = new System.Drawing.Size(29, 13);
            this.lbStok.TabIndex = 13;
            this.lbStok.Text = "Stok";
            // 
            // rcUrunAd
            // 
            this.rcUrunAd.BackColor = System.Drawing.SystemColors.Menu;
            this.rcUrunAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcUrunAd.Location = new System.Drawing.Point(17, 220);
            this.rcUrunAd.Name = "rcUrunAd";
            this.rcUrunAd.ReadOnly = true;
            this.rcUrunAd.Size = new System.Drawing.Size(200, 50);
            this.rcUrunAd.TabIndex = 12;
            this.rcUrunAd.Text = "";
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFiyat.Location = new System.Drawing.Point(19, 354);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(29, 13);
            this.lbFiyat.TabIndex = 11;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbOlcu
            // 
            this.lbOlcu.AutoSize = true;
            this.lbOlcu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbOlcu.Location = new System.Drawing.Point(19, 336);
            this.lbOlcu.Name = "lbOlcu";
            this.lbOlcu.Size = new System.Drawing.Size(29, 13);
            this.lbOlcu.TabIndex = 9;
            this.lbOlcu.Text = "Olcu";
            // 
            // lbMiktar
            // 
            this.lbMiktar.AutoSize = true;
            this.lbMiktar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMiktar.Location = new System.Drawing.Point(19, 318);
            this.lbMiktar.Name = "lbMiktar";
            this.lbMiktar.Size = new System.Drawing.Size(36, 13);
            this.lbMiktar.TabIndex = 8;
            this.lbMiktar.Text = "Miktar";
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMarka.Location = new System.Drawing.Point(19, 300);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(37, 13);
            this.lbMarka.TabIndex = 7;
            this.lbMarka.Text = "Marka";
            // 
            // lbKategori
            // 
            this.lbKategori.AutoSize = true;
            this.lbKategori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbKategori.Location = new System.Drawing.Point(19, 282);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(46, 13);
            this.lbKategori.TabIndex = 6;
            this.lbKategori.Text = "Kategori";
            // 
            // pbUrunResim
            // 
            this.pbUrunResim.BackColor = System.Drawing.Color.White;
            this.pbUrunResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrunResim.Location = new System.Drawing.Point(17, 11);
            this.pbUrunResim.Name = "pbUrunResim";
            this.pbUrunResim.Size = new System.Drawing.Size(200, 200);
            this.pbUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrunResim.TabIndex = 5;
            this.pbUrunResim.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgUrunler);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 420);
            this.panel2.TabIndex = 2;
            // 
            // dgUrunler
            // 
            this.dgUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.KATEGORİ,
            this.MARKA,
            this.MİKTAR,
            this.FİYAT,
            this.ADET});
            this.dgUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgUrunler.MultiSelect = false;
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.ReadOnly = true;
            this.dgUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUrunler.Size = new System.Drawing.Size(532, 416);
            this.dgUrunler.TabIndex = 0;
            this.dgUrunler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUrunler_RowEnter);
            this.dgUrunler.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUrunler_RowLeave);
            // 
            // Ad
            // 
            this.Ad.HeaderText = "AD";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // KATEGORİ
            // 
            this.KATEGORİ.HeaderText = "KATEGORİ";
            this.KATEGORİ.Name = "KATEGORİ";
            this.KATEGORİ.ReadOnly = true;
            // 
            // MARKA
            // 
            this.MARKA.HeaderText = "MARKA";
            this.MARKA.Name = "MARKA";
            this.MARKA.ReadOnly = true;
            // 
            // MİKTAR
            // 
            this.MİKTAR.HeaderText = "MİKTAR";
            this.MİKTAR.Name = "MİKTAR";
            this.MİKTAR.ReadOnly = true;
            // 
            // FİYAT
            // 
            this.FİYAT.HeaderText = "FİYAT";
            this.FİYAT.Name = "FİYAT";
            this.FİYAT.ReadOnly = true;
            // 
            // ADET
            // 
            this.ADET.HeaderText = "ADET";
            this.ADET.Name = "ADET";
            this.ADET.ReadOnly = true;
            // 
            // b
            // 
            this.b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b.Location = new System.Drawing.Point(648, 438);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(141, 35);
            this.b.TabIndex = 4;
            this.b.Text = "Sipariş Ver";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // btnUrunuSil
            // 
            this.btnUrunuSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunuSil.Location = new System.Drawing.Point(445, 438);
            this.btnUrunuSil.Name = "btnUrunuSil";
            this.btnUrunuSil.Size = new System.Drawing.Size(103, 35);
            this.btnUrunuSil.TabIndex = 5;
            this.btnUrunuSil.Text = "Ürünü Sil";
            this.btnUrunuSil.UseVisualStyleBackColor = true;
            this.btnUrunuSil.Click += new System.EventHandler(this.btnUrunuSil_Click);
            // 
            // ndAdet
            // 
            this.ndAdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ndAdet.Location = new System.Drawing.Point(14, 447);
            this.ndAdet.Name = "ndAdet";
            this.ndAdet.Size = new System.Drawing.Size(84, 20);
            this.ndAdet.TabIndex = 6;
            this.ndAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndAdet.ValueChanged += new System.EventHandler(this.ndAdet_ValueChanged);
            // 
            // btnAdetDegistir
            // 
            this.btnAdetDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdetDegistir.Location = new System.Drawing.Point(104, 444);
            this.btnAdetDegistir.Name = "btnAdetDegistir";
            this.btnAdetDegistir.Size = new System.Drawing.Size(46, 26);
            this.btnAdetDegistir.TabIndex = 7;
            this.btnAdetDegistir.Text = "→";
            this.btnAdetDegistir.UseVisualStyleBackColor = true;
            this.btnAdetDegistir.Click += new System.EventHandler(this.btnAdetDegistir_Click);
            // 
            // Form_Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(799, 485);
            this.Controls.Add(this.btnAdetDegistir);
            this.Controls.Add(this.ndAdet);
            this.Controls.Add(this.btnUrunuSil);
            this.Controls.Add(this.b);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Form_Sepet_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAdet;
        private System.Windows.Forms.Label lbStok;
        private System.Windows.Forms.RichTextBox rcUrunAd;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbOlcu;
        private System.Windows.Forms.Label lbMiktar;
        private System.Windows.Forms.Label lbMarka;
        private System.Windows.Forms.Label lbKategori;
        private System.Windows.Forms.PictureBox pbUrunResim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KATEGORİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MİKTAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FİYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button btnUrunuSil;
        private System.Windows.Forms.NumericUpDown ndAdet;
        private System.Windows.Forms.Button btnAdetDegistir;
    }
}