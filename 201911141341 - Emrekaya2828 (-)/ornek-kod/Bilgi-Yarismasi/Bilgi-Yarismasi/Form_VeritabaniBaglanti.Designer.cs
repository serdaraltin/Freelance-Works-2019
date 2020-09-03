namespace Bilgi_Yarismasi
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
            this.txt_veritabani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_TestEt = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_veritabani
            // 
            this.txt_veritabani.Location = new System.Drawing.Point(119, 67);
            this.txt_veritabani.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veritabani.Name = "txt_veritabani";
            this.txt_veritabani.ReadOnly = true;
            this.txt_veritabani.Size = new System.Drawing.Size(258, 23);
            this.txt_veritabani.TabIndex = 0;
            this.txt_veritabani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veritabanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(119, 98);
            this.txt_Parola.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(304, 23);
            this.txt_Parola.TabIndex = 2;
            this.txt_Parola.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_TestEt
            // 
            this.btn_TestEt.Location = new System.Drawing.Point(119, 143);
            this.btn_TestEt.Name = "btn_TestEt";
            this.btn_TestEt.Size = new System.Drawing.Size(142, 43);
            this.btn_TestEt.TabIndex = 3;
            this.btn_TestEt.Text = "Test Et";
            this.btn_TestEt.UseVisualStyleBackColor = true;
            this.btn_TestEt.Click += new System.EventHandler(this.btn_TestEt_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(281, 143);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(142, 43);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // Form_VeritabaniBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 243);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_TestEt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_veritabani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_VeritabaniBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantı";
            this.Load += new System.EventHandler(this.Form_VeritabaniBaglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_veritabani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_TestEt;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}