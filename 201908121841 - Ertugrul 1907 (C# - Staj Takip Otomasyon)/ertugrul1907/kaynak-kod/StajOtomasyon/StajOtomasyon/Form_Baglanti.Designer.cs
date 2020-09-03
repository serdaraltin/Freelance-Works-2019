namespace StajOtomasyon
{
    partial class Form_Baglanti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeritabani = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veri Tabanı";
            // 
            // txtVeritabani
            // 
            this.txtVeritabani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVeritabani.Location = new System.Drawing.Point(98, 59);
            this.txtVeritabani.Name = "txtVeritabani";
            this.txtVeritabani.ReadOnly = true;
            this.txtVeritabani.Size = new System.Drawing.Size(214, 21);
            this.txtVeritabani.TabIndex = 3;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(318, 58);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(55, 23);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "...";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnTestEt
            // 
            this.btnTestEt.Location = new System.Drawing.Point(205, 106);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(81, 31);
            this.btnTestEt.TabIndex = 1;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(292, 106);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form_Baglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 177);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTestEt);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtVeritabani);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Baglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantı";
            this.Load += new System.EventHandler(this.Form_Baglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeritabani;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Button btnKaydet;
    }
}