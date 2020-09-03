namespace Sabri_Gozdag_Sozluk
{
    partial class Form_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ayarlar));
            this.btnKapat = new System.Windows.Forms.Button();
            this.chbSonAranan = new System.Windows.Forms.CheckBox();
            this.chbVeritabaniKontrol = new System.Windows.Forms.CheckBox();
            this.brnVeritabaniYapilandir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Maroon;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(246, 14);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 35);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // chbSonAranan
            // 
            this.chbSonAranan.AutoSize = true;
            this.chbSonAranan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbSonAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chbSonAranan.Location = new System.Drawing.Point(34, 84);
            this.chbSonAranan.Margin = new System.Windows.Forms.Padding(4);
            this.chbSonAranan.Name = "chbSonAranan";
            this.chbSonAranan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbSonAranan.Size = new System.Drawing.Size(240, 24);
            this.chbSonAranan.TabIndex = 4;
            this.chbSonAranan.Text = "Son aranan 10 kelimeyi kaydet";
            this.chbSonAranan.UseVisualStyleBackColor = true;
            this.chbSonAranan.CheckedChanged += new System.EventHandler(this.chbSonAranan_CheckedChanged);
            // 
            // chbVeritabaniKontrol
            // 
            this.chbVeritabaniKontrol.AutoSize = true;
            this.chbVeritabaniKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbVeritabaniKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chbVeritabaniKontrol.Location = new System.Drawing.Point(34, 125);
            this.chbVeritabaniKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.chbVeritabaniKontrol.Name = "chbVeritabaniKontrol";
            this.chbVeritabaniKontrol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbVeritabaniKontrol.Size = new System.Drawing.Size(158, 24);
            this.chbVeritabaniKontrol.TabIndex = 5;
            this.chbVeritabaniKontrol.Text = "Veritabanı kontrolü";
            this.chbVeritabaniKontrol.UseVisualStyleBackColor = true;
            this.chbVeritabaniKontrol.CheckedChanged += new System.EventHandler(this.chbVeritabaniKontrol_CheckedChanged);
            // 
            // brnVeritabaniYapilandir
            // 
            this.brnVeritabaniYapilandir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brnVeritabaniYapilandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnVeritabaniYapilandir.Location = new System.Drawing.Point(25, 230);
            this.brnVeritabaniYapilandir.Margin = new System.Windows.Forms.Padding(5);
            this.brnVeritabaniYapilandir.Name = "brnVeritabaniYapilandir";
            this.brnVeritabaniYapilandir.Size = new System.Drawing.Size(299, 35);
            this.brnVeritabaniYapilandir.TabIndex = 6;
            this.brnVeritabaniYapilandir.Text = "VERİTABANI YAPILANDIR";
            this.brnVeritabaniYapilandir.UseVisualStyleBackColor = false;
            this.brnVeritabaniYapilandir.Click += new System.EventHandler(this.brnVeritabaniYapilandir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "AYARLAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(38, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Arka Plan Rengi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(167, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Location = new System.Drawing.Point(201, 160);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(87, 27);
            this.btnDegistir.TabIndex = 13;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(347, 284);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brnVeritabaniYapilandir);
            this.Controls.Add(this.chbVeritabaniKontrol);
            this.Controls.Add(this.chbSonAranan);
            this.Controls.Add(this.btnKapat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1_Ayarlar";
            this.Load += new System.EventHandler(this.Form_Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.CheckBox chbSonAranan;
        private System.Windows.Forms.CheckBox chbVeritabaniKontrol;
        private System.Windows.Forms.Button brnVeritabaniYapilandir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDegistir;
    }
}