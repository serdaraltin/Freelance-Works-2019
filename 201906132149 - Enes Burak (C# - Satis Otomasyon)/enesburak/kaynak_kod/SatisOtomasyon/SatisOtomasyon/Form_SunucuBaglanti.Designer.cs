namespace SatisOtomasyon
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
            this.txtVeriTabani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu";
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(93, 45);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(174, 20);
            this.txtSunucu.TabIndex = 1;
            // 
            // txtVeriTabani
            // 
            this.txtVeriTabani.Location = new System.Drawing.Point(93, 71);
            this.txtVeriTabani.Name = "txtVeriTabani";
            this.txtVeriTabani.Size = new System.Drawing.Size(174, 20);
            this.txtVeriTabani.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VeriTabanı";
            // 
            // btnTestEt
            // 
            this.btnTestEt.Location = new System.Drawing.Point(93, 112);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(65, 33);
            this.btnTestEt.TabIndex = 4;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(164, 112);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 33);
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
            this.ClientSize = new System.Drawing.Size(312, 182);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTestEt);
            this.Controls.Add(this.txtVeriTabani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_SunucuBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunucu Bağlantı";
            this.Load += new System.EventHandler(this.Form_SunucuBaglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtVeriTabani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Button btnKaydet;
    }
}