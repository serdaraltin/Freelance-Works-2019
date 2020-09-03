namespace ApartmanYonetim
{
    partial class Form_FaturaEkle
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
            this.txtUye = new System.Windows.Forms.TextBox();
            this.txtFaturaId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.dtSonOdeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye";
            // 
            // txtUye
            // 
            this.txtUye.Location = new System.Drawing.Point(84, 58);
            this.txtUye.Name = "txtUye";
            this.txtUye.ReadOnly = true;
            this.txtUye.Size = new System.Drawing.Size(155, 20);
            this.txtUye.TabIndex = 1;
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(84, 84);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.Size = new System.Drawing.Size(155, 20);
            this.txtFaturaId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatura Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(84, 110);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(155, 20);
            this.dtTarih.TabIndex = 6;
            // 
            // dtSonOdeme
            // 
            this.dtSonOdeme.Location = new System.Drawing.Point(84, 136);
            this.dtSonOdeme.Name = "dtSonOdeme";
            this.dtSonOdeme.Size = new System.Drawing.Size(155, 20);
            this.dtSonOdeme.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Son Ödeme";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(84, 162);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(155, 20);
            this.txtTutar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar";
            // 
            // cbDurum
            // 
            this.cbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "Ödendi",
            "Ödenmedi"});
            this.cbDurum.Location = new System.Drawing.Point(84, 188);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(155, 21);
            this.cbDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durum";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(84, 221);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(77, 34);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(167, 221);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(72, 34);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // Form_FaturaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 293);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDurum);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSonOdeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFaturaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUye);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_FaturaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ekle";
            this.Load += new System.EventHandler(this.Form_FaturaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUye;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.DateTimePicker dtSonOdeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
    }
}