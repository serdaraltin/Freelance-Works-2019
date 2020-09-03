namespace SporSalonuYonetim
{
    partial class Form_VeritabaniBaglanti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VeritabaniBaglanti));
            this.txt_Dosya = new System.Windows.Forms.TextBox();
            this.lb_Veritabani = new System.Windows.Forms.Label();
            this.btn_DosyaSec = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lb_Baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Dosya
            // 
            this.txt_Dosya.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Dosya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Dosya.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Dosya.Location = new System.Drawing.Point(105, 94);
            this.txt_Dosya.Name = "txt_Dosya";
            this.txt_Dosya.ReadOnly = true;
            this.txt_Dosya.Size = new System.Drawing.Size(315, 26);
            this.txt_Dosya.TabIndex = 3;
            this.txt_Dosya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_Veritabani
            // 
            this.lb_Veritabani.AutoSize = true;
            this.lb_Veritabani.BackColor = System.Drawing.Color.Transparent;
            this.lb_Veritabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_Veritabani.ForeColor = System.Drawing.Color.White;
            this.lb_Veritabani.Location = new System.Drawing.Point(14, 96);
            this.lb_Veritabani.Name = "lb_Veritabani";
            this.lb_Veritabani.Size = new System.Drawing.Size(85, 20);
            this.lb_Veritabani.TabIndex = 1;
            this.lb_Veritabani.Text = "VeriTabanı";
            // 
            // btn_DosyaSec
            // 
            this.btn_DosyaSec.BackColor = System.Drawing.Color.Black;
            this.btn_DosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DosyaSec.ForeColor = System.Drawing.Color.White;
            this.btn_DosyaSec.Location = new System.Drawing.Point(426, 94);
            this.btn_DosyaSec.Name = "btn_DosyaSec";
            this.btn_DosyaSec.Size = new System.Drawing.Size(43, 25);
            this.btn_DosyaSec.TabIndex = 0;
            this.btn_DosyaSec.Text = "...";
            this.btn_DosyaSec.UseVisualStyleBackColor = false;
            this.btn_DosyaSec.Click += new System.EventHandler(this.btn_DosyaSec_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Black;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(366, 135);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(103, 38);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Black;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(418, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(51, 33);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lb_Baslik
            // 
            this.lb_Baslik.AutoSize = true;
            this.lb_Baslik.BackColor = System.Drawing.Color.Transparent;
            this.lb_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_Baslik.ForeColor = System.Drawing.Color.White;
            this.lb_Baslik.Location = new System.Drawing.Point(12, 9);
            this.lb_Baslik.Name = "lb_Baslik";
            this.lb_Baslik.Size = new System.Drawing.Size(177, 31);
            this.lb_Baslik.TabIndex = 17;
            this.lb_Baslik.Text = "VERİTABANI";
            // 
            // Form_VeritabaniBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 239);
            this.Controls.Add(this.lb_Baslik);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_DosyaSec);
            this.Controls.Add(this.lb_Veritabani);
            this.Controls.Add(this.txt_Dosya);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_VeritabaniBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantı";
            this.Load += new System.EventHandler(this.Form_VeritabaniBaglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Dosya;
        private System.Windows.Forms.Label lb_Veritabani;
        private System.Windows.Forms.Button btn_DosyaSec;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lb_Baslik;
    }
}