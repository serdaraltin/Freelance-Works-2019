namespace SatisOtomasyon
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
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Location = new System.Drawing.Point(12, 12);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(260, 42);
            this.btnYoneticiGiris.TabIndex = 0;
            this.btnYoneticiGiris.Text = "Yönetici Giriş";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Location = new System.Drawing.Point(12, 60);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(260, 42);
            this.btnKullaniciGiris.TabIndex = 1;
            this.btnKullaniciGiris.Text = "Kullanıcı Giriş";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(12, 108);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(260, 42);
            this.btnKayitOl.TabIndex = 2;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // Form_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.btnYoneticiGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form_Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnKayitOl;
    }
}