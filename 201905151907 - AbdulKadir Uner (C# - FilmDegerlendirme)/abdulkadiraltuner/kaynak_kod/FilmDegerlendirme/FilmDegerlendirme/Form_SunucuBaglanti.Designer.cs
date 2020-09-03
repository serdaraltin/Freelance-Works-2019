namespace FilmDegerlendirme
{
    partial class Form_SunucuBaglanti
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
            this.txt_SunucuAdi = new System.Windows.Forms.TextBox();
            this.txt_VeriTabaniAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu";
            // 
            // txt_SunucuAdi
            // 
            this.txt_SunucuAdi.Location = new System.Drawing.Point(84, 34);
            this.txt_SunucuAdi.Name = "txt_SunucuAdi";
            this.txt_SunucuAdi.Size = new System.Drawing.Size(169, 20);
            this.txt_SunucuAdi.TabIndex = 1;
            // 
            // txt_VeriTabaniAdi
            // 
            this.txt_VeriTabaniAdi.Location = new System.Drawing.Point(84, 60);
            this.txt_VeriTabaniAdi.Name = "txt_VeriTabaniAdi";
            this.txt_VeriTabaniAdi.Size = new System.Drawing.Size(169, 20);
            this.txt_VeriTabaniAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VeriTabani";
            // 
            // btnTestEt
            // 
            this.btnTestEt.Location = new System.Drawing.Point(84, 86);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(75, 31);
            this.btnTestEt.TabIndex = 4;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(165, 86);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 31);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "* Program bu veritabani uzerinden calisacaktir";
            // 
            // Form_SunucuBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(296, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTestEt);
            this.Controls.Add(this.txt_VeriTabaniAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SunucuAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SunucuBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunucu Baglanti";
            this.Load += new System.EventHandler(this.Form_SunucuBaglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SunucuAdi;
        private System.Windows.Forms.TextBox txt_VeriTabaniAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
    }
}