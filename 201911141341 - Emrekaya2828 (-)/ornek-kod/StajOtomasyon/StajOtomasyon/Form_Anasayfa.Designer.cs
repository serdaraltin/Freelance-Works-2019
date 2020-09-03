namespace StajOtomasyon
{
    partial class Form_Anasayfa
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnVeli = new System.Windows.Forms.Button();
            this.btnIsyeri = new System.Windows.Forms.Button();
            this.btnStaj = new System.Windows.Forms.Button();
            this.btnVeritabani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(39, 21);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(128, 44);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Location = new System.Drawing.Point(173, 21);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(128, 44);
            this.btnOgretmen.TabIndex = 1;
            this.btnOgretmen.Text = "Öğretmen İşlemleri";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnVeli
            // 
            this.btnVeli.Location = new System.Drawing.Point(39, 71);
            this.btnVeli.Name = "btnVeli";
            this.btnVeli.Size = new System.Drawing.Size(128, 44);
            this.btnVeli.TabIndex = 2;
            this.btnVeli.Text = "Veli İşlemleri";
            this.btnVeli.UseVisualStyleBackColor = true;
            this.btnVeli.Click += new System.EventHandler(this.btnVeli_Click);
            // 
            // btnIsyeri
            // 
            this.btnIsyeri.Location = new System.Drawing.Point(39, 121);
            this.btnIsyeri.Name = "btnIsyeri";
            this.btnIsyeri.Size = new System.Drawing.Size(128, 44);
            this.btnIsyeri.TabIndex = 3;
            this.btnIsyeri.Text = "İşyeri İşlemleri";
            this.btnIsyeri.UseVisualStyleBackColor = true;
            this.btnIsyeri.Click += new System.EventHandler(this.btnIsyeri_Click);
            // 
            // btnStaj
            // 
            this.btnStaj.Location = new System.Drawing.Point(173, 71);
            this.btnStaj.Name = "btnStaj";
            this.btnStaj.Size = new System.Drawing.Size(128, 44);
            this.btnStaj.TabIndex = 4;
            this.btnStaj.Text = "Staj İşlemleri";
            this.btnStaj.UseVisualStyleBackColor = true;
            this.btnStaj.Click += new System.EventHandler(this.btnStaj_Click);
            // 
            // btnVeritabani
            // 
            this.btnVeritabani.Location = new System.Drawing.Point(173, 121);
            this.btnVeritabani.Name = "btnVeritabani";
            this.btnVeritabani.Size = new System.Drawing.Size(128, 44);
            this.btnVeritabani.TabIndex = 5;
            this.btnVeritabani.Text = "Veritabanı";
            this.btnVeritabani.UseVisualStyleBackColor = true;
            this.btnVeritabani.Click += new System.EventHandler(this.btnVeritabani_Click);
            // 
            // Form_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 184);
            this.Controls.Add(this.btnVeritabani);
            this.Controls.Add(this.btnStaj);
            this.Controls.Add(this.btnIsyeri);
            this.Controls.Add(this.btnVeli);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnOgrenci);
            this.MaximizeBox = false;
            this.Name = "Form_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Anasayfa_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnVeli;
        private System.Windows.Forms.Button btnIsyeri;
        private System.Windows.Forms.Button btnStaj;
        private System.Windows.Forms.Button btnVeritabani;
    }
}