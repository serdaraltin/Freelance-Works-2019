using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form_SoruEkle : Form
    {
        public Form_SoruEkle()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        int DogruCevap = 0;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(veritabani.Soru_Ekle(rctxt_Soru.Text, txt_A.Text, txt_B.Text, txt_C.Text, txt_D.Text, DogruCevap))
                MessageBox.Show("Ekleme işlemi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ekleme işlemi başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void rdb_A_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_A.Checked)
                DogruCevap = 1;
        }

        private void rdb_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_B.Checked)
                DogruCevap = 2;
        }

        private void rdb_C_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_C.Checked)
                DogruCevap = 3;
        }

        private void rdb_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_D.Checked)
                DogruCevap = 4;
        }

        private void Form_SoruEkle_Load(object sender, EventArgs e)
        {
            rdb_A.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                    ((TextBox)nesne).Clear();
            }
            rctxt_Soru.Clear();
            rdb_A.Checked = true;
        }
    }
}
