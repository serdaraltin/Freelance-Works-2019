namespace ApartmanYonetim
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
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.txtVeritabani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu";
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(93, 44);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(174, 20);
            this.txtSunucu.TabIndex = 1;
            // 
            // txtVeritabani
            // 
            this.txtVeritabani.Location = new System.Drawing.Point(93, 70);
            this.txtVeritabani.Name = "txtVeritabani";
            this.txtVeritabani.Size = new System.Drawing.Size(174, 20);
            this.txtVeritabani.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VeriTabanı";
            // 
            // btnTestEt
            // 
            this.btnTestEt.Location = new System.Drawing.Point(93, 108);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(84, 33);
            this.btnTestEt.TabIndex = 4;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(183, 108);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 33);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form_SunucuBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 184);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTestEt);
            this.Controls.Add(this.txtVeritabani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_SunucuBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunucu Bağlantı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtVeritabani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Button btnKaydet;
    }
}