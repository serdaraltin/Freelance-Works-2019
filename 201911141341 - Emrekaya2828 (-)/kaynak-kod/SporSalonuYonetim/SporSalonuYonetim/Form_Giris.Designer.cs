namespace SporSalonuYonetim
{
    partial class Form_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Giris));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_KullaniciAd = new System.Windows.Forms.TextBox();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Black;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(292, 180);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(103, 36);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "PAROLA";
            // 
            // txt_Parola
            // 
            this.txt_Parola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Parola.ForeColor = System.Drawing.Color.White;
            this.txt_Parola.Location = new System.Drawing.Point(183, 138);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(212, 26);
            this.txt_Parola.TabIndex = 1;
            this.txt_Parola.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "KULLANICI ADI";
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_KullaniciAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciAd.ForeColor = System.Drawing.Color.White;
            this.txt_KullaniciAd.Location = new System.Drawing.Point(183, 106);
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.Size = new System.Drawing.Size(212, 26);
            this.txt_KullaniciAd.TabIndex = 0;
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.Black;
            this.btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.ForeColor = System.Drawing.Color.White;
            this.btn_Kapat.Location = new System.Drawing.Point(419, 12);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(61, 32);
            this.btn_Kapat.TabIndex = 3;
            this.btn_Kapat.Text = "X";
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 329);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_KullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Giris";
            this.Load += new System.EventHandler(this.Form_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_KullaniciAd;
        private System.Windows.Forms.Button btn_Kapat;
    }
}