namespace VeriTabanıproje
{
    partial class Form_AdminLogin
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
            this.btnFirmaGiris = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYoneticiId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFirmaGiris
            // 
            this.btnFirmaGiris.Location = new System.Drawing.Point(87, 141);
            this.btnFirmaGiris.Name = "btnFirmaGiris";
            this.btnFirmaGiris.Size = new System.Drawing.Size(100, 25);
            this.btnFirmaGiris.TabIndex = 10;
            this.btnFirmaGiris.Text = "Firma Giriş";
            this.btnFirmaGiris.UseVisualStyleBackColor = true;
            this.btnFirmaGiris.Click += new System.EventHandler(this.btnFirmaGiris_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(193, 93);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 25);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(87, 66);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(181, 21);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "123456";
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // txtYoneticiId
            // 
            this.txtYoneticiId.Location = new System.Drawing.Point(87, 39);
            this.txtYoneticiId.Name = "txtYoneticiId";
            this.txtYoneticiId.Size = new System.Drawing.Size(181, 21);
            this.txtYoneticiId.TabIndex = 6;
            this.txtYoneticiId.Text = "Y1545";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yönetici ID :";
            // 
            // Form_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(303, 184);
            this.Controls.Add(this.btnFirmaGiris);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYoneticiId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimizeBox = false;
            this.Name = "Form_AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.Load += new System.EventHandler(this.Form_AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFirmaGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYoneticiId;
        private System.Windows.Forms.Label label1;
    }
}