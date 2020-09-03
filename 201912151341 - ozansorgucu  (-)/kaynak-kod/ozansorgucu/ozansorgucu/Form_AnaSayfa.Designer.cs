namespace ozansorgucu
{
    partial class Form_AnaSayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Panel();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Panel();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnOnay1 = new System.Windows.Forms.Button();
            this.btnOnay2 = new System.Windows.Forms.Button();
            this.btnOnay3 = new System.Windows.Forms.Button();
            this.btnOnay4 = new System.Windows.Forms.Button();
            this.btnOnay5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.p3.SuspendLayout();
            this.p4.SuspendLayout();
            this.p5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(673, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.p5);
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 558);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefonlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorular";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Controls.Add(this.btnOnay1);
            this.p1.Controls.Add(this.cb1);
            this.p1.Controls.Add(this.label4);
            this.p1.Location = new System.Drawing.Point(3, 7);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(287, 80);
            this.p1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bütçemizin korunması sizin için ne kadar önemli?";
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Kesinlikle Değil",
            "Pek Değil",
            "Kısmen",
            "Bir Yere Kadar",
            "Fazlasıyla"});
            this.cb1.Location = new System.Drawing.Point(16, 45);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(148, 21);
            this.cb1.TabIndex = 1;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Controls.Add(this.btnOnay2);
            this.p2.Controls.Add(this.cb2);
            this.p2.Controls.Add(this.label5);
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(3, 93);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(287, 80);
            this.p2.TabIndex = 2;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Kesinlikle Değil",
            "Pek Değil",
            "Kısmen",
            "Bir Yere Kadar",
            "Fazlasıyla"});
            this.cb2.Location = new System.Drawing.Point(16, 45);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(148, 21);
            this.cb2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Batarya kapasitesi sizin için ne kadar önemli?";
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Controls.Add(this.btnOnay3);
            this.p3.Controls.Add(this.cb3);
            this.p3.Controls.Add(this.label6);
            this.p3.Enabled = false;
            this.p3.Location = new System.Drawing.Point(2, 179);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(287, 80);
            this.p3.TabIndex = 2;
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "Kesinlikle Değil",
            "Pek Değil",
            "Kısmen",
            "Bir Yere Kadar",
            "Fazlasıyla"});
            this.cb3.Location = new System.Drawing.Point(16, 45);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(148, 21);
            this.cb3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fotoğraf ve Video çekim kalitesi sizin için ne kadar önemli?";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Controls.Add(this.btnOnay4);
            this.p4.Controls.Add(this.cb4);
            this.p4.Controls.Add(this.label7);
            this.p4.Enabled = false;
            this.p4.Location = new System.Drawing.Point(2, 265);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(287, 80);
            this.p4.TabIndex = 2;
            // 
            // cb4
            // 
            this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "Kesinlikle Değil",
            "Pek Değil",
            "Kısmen",
            "Bir Yere Kadar",
            "Fazlasıyla"});
            this.cb4.Location = new System.Drawing.Point(16, 45);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(148, 21);
            this.cb4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cep telefonunuzda Office, Photosop vb. yoğun \r\nprogramların düzgün çalışması sizi" +
    "n için ne kadar önemli?";
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p5.Controls.Add(this.btnOnay5);
            this.p5.Controls.Add(this.cb5);
            this.p5.Controls.Add(this.label8);
            this.p5.Enabled = false;
            this.p5.Location = new System.Drawing.Point(2, 351);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(287, 80);
            this.p5.TabIndex = 2;
            // 
            // cb5
            // 
            this.cb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb5.FormattingEnabled = true;
            this.cb5.Items.AddRange(new object[] {
            "Kesinlikle Değil",
            "Pek Değil",
            "Kısmen",
            "Bir Yere Kadar",
            "Fazlasıyla"});
            this.cb5.Location = new System.Drawing.Point(16, 45);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(148, 21);
            this.cb5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cep telefonunuzun estetik görünümü sizin için ne kadar \r\nönemli?";
            // 
            // btnYenile
            // 
            this.btnYenile.Enabled = false;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnYenile.Location = new System.Drawing.Point(3, 440);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(286, 32);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "SORULARI YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnOnay1
            // 
            this.btnOnay1.Location = new System.Drawing.Point(170, 44);
            this.btnOnay1.Name = "btnOnay1";
            this.btnOnay1.Size = new System.Drawing.Size(102, 23);
            this.btnOnay1.TabIndex = 2;
            this.btnOnay1.Text = "Onayla";
            this.btnOnay1.UseVisualStyleBackColor = true;
            this.btnOnay1.Click += new System.EventHandler(this.btnOnay1_Click);
            // 
            // btnOnay2
            // 
            this.btnOnay2.Location = new System.Drawing.Point(170, 43);
            this.btnOnay2.Name = "btnOnay2";
            this.btnOnay2.Size = new System.Drawing.Size(102, 23);
            this.btnOnay2.TabIndex = 3;
            this.btnOnay2.Text = "Onayla";
            this.btnOnay2.UseVisualStyleBackColor = true;
            this.btnOnay2.Click += new System.EventHandler(this.btnOnay2_Click);
            // 
            // btnOnay3
            // 
            this.btnOnay3.Location = new System.Drawing.Point(171, 43);
            this.btnOnay3.Name = "btnOnay3";
            this.btnOnay3.Size = new System.Drawing.Size(102, 23);
            this.btnOnay3.TabIndex = 4;
            this.btnOnay3.Text = "Onayla";
            this.btnOnay3.UseVisualStyleBackColor = true;
            this.btnOnay3.Click += new System.EventHandler(this.btnOnay3_Click);
            // 
            // btnOnay4
            // 
            this.btnOnay4.Location = new System.Drawing.Point(171, 43);
            this.btnOnay4.Name = "btnOnay4";
            this.btnOnay4.Size = new System.Drawing.Size(102, 23);
            this.btnOnay4.TabIndex = 5;
            this.btnOnay4.Text = "Onayla";
            this.btnOnay4.UseVisualStyleBackColor = true;
            this.btnOnay4.Click += new System.EventHandler(this.btnOnay4_Click);
            // 
            // btnOnay5
            // 
            this.btnOnay5.Location = new System.Drawing.Point(171, 43);
            this.btnOnay5.Name = "btnOnay5";
            this.btnOnay5.Size = new System.Drawing.Size(102, 23);
            this.btnOnay5.TabIndex = 6;
            this.btnOnay5.Text = "Onayla";
            this.btnOnay5.UseVisualStyleBackColor = true;
            this.btnOnay5.Click += new System.EventHandler(this.btnOnay5_Click);
            // 
            // Form_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form_AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.p5.ResumeLayout(false);
            this.p5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnOnay5;
        private System.Windows.Forms.Button btnOnay4;
        private System.Windows.Forms.Button btnOnay3;
        private System.Windows.Forms.Button btnOnay1;
        private System.Windows.Forms.Button btnOnay2;
    }
}