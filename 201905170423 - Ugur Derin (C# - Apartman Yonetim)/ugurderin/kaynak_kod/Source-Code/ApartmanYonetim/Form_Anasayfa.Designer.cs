namespace ApartmanYonetim
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
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Location = new System.Drawing.Point(46, 50);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(191, 50);
            this.btnKullaniciGiris.TabIndex = 0;
            this.btnKullaniciGiris.Text = "KULLANICI GİRİŞ";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Location = new System.Drawing.Point(46, 115);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(191, 50);
            this.btnYoneticiGiris.TabIndex = 1;
            this.btnYoneticiGiris.Text = "YÖNETİCİ GİRİŞ";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // Form_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Controls.Add(this.btnKullaniciGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form_Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnYoneticiGiris;
    }
}