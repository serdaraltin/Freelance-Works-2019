namespace Bilgi_Yarismasi
{
    partial class Form_SoruEkle
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
            this.rctxt_Soru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.rdb_A = new System.Windows.Forms.RadioButton();
            this.rdb_C = new System.Windows.Forms.RadioButton();
            this.rdb_B = new System.Windows.Forms.RadioButton();
            this.rdb_D = new System.Windows.Forms.RadioButton();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rctxt_Soru
            // 
            this.rctxt_Soru.Location = new System.Drawing.Point(72, 27);
            this.rctxt_Soru.Margin = new System.Windows.Forms.Padding(4);
            this.rctxt_Soru.Name = "rctxt_Soru";
            this.rctxt_Soru.Size = new System.Drawing.Size(580, 134);
            this.rctxt_Soru.TabIndex = 0;
            this.rctxt_Soru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(72, 184);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(246, 23);
            this.txt_A.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(386, 184);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(246, 23);
            this.txt_B.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "D";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(386, 213);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(246, 23);
            this.txt_D.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "C";
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(72, 213);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(246, 23);
            this.txt_C.TabIndex = 6;
            // 
            // rdb_A
            // 
            this.rdb_A.AutoSize = true;
            this.rdb_A.Location = new System.Drawing.Point(324, 189);
            this.rdb_A.Name = "rdb_A";
            this.rdb_A.Size = new System.Drawing.Size(14, 13);
            this.rdb_A.TabIndex = 10;
            this.rdb_A.TabStop = true;
            this.rdb_A.UseVisualStyleBackColor = true;
            this.rdb_A.CheckedChanged += new System.EventHandler(this.rdb_A_CheckedChanged);
            // 
            // rdb_C
            // 
            this.rdb_C.AutoSize = true;
            this.rdb_C.Location = new System.Drawing.Point(324, 218);
            this.rdb_C.Name = "rdb_C";
            this.rdb_C.Size = new System.Drawing.Size(14, 13);
            this.rdb_C.TabIndex = 11;
            this.rdb_C.TabStop = true;
            this.rdb_C.UseVisualStyleBackColor = true;
            this.rdb_C.CheckedChanged += new System.EventHandler(this.rdb_C_CheckedChanged);
            // 
            // rdb_B
            // 
            this.rdb_B.AutoSize = true;
            this.rdb_B.Location = new System.Drawing.Point(638, 189);
            this.rdb_B.Name = "rdb_B";
            this.rdb_B.Size = new System.Drawing.Size(14, 13);
            this.rdb_B.TabIndex = 12;
            this.rdb_B.TabStop = true;
            this.rdb_B.UseVisualStyleBackColor = true;
            this.rdb_B.CheckedChanged += new System.EventHandler(this.rdb_B_CheckedChanged);
            // 
            // rdb_D
            // 
            this.rdb_D.AutoSize = true;
            this.rdb_D.Location = new System.Drawing.Point(638, 218);
            this.rdb_D.Name = "rdb_D";
            this.rdb_D.Size = new System.Drawing.Size(14, 13);
            this.rdb_D.TabIndex = 13;
            this.rdb_D.TabStop = true;
            this.rdb_D.UseVisualStyleBackColor = true;
            this.rdb_D.CheckedChanged += new System.EventHandler(this.rdb_D_CheckedChanged);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(72, 251);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(132, 44);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.rdb_D);
            this.Controls.Add(this.rdb_B);
            this.Controls.Add(this.rdb_C);
            this.Controls.Add(this.rdb_A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rctxt_Soru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_SoruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Ekle";
            this.Load += new System.EventHandler(this.Form_SoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctxt_Soru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.RadioButton rdb_A;
        private System.Windows.Forms.RadioButton rdb_C;
        private System.Windows.Forms.RadioButton rdb_B;
        private System.Windows.Forms.RadioButton rdb_D;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button button1;
    }
}