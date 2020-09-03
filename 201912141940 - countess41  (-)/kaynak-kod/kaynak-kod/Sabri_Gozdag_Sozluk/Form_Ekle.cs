using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sabri_Gozdag_Sozluk
{
    public partial class Form_Ekle : Form
    {
        public Form_Ekle()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

        public void Ekle(string tablo, string terim, string anlam)
        {
            if (veritabani.Ekle(tablo, terim, anlam))
            {
                MessageBox.Show(terim + " verisi " + tablo + " kategorisine başarıyla eklendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;    
            }
            
        }
        public void Ekle(string dil, string ingilizce, string turkce, string anlam)
        {
            if (veritabani.Ekle(dil,ingilizce,turkce,anlam))
            {
                MessageBox.Show("Veri başarıyla eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ekle_Load(object sender, EventArgs e)
        {
            cbTerimKategori.SelectedIndex = 0;
        }

        private void btnKaydetTe_Click(object sender, EventArgs e)
        {
            Ekle(cbTerimKategori.Text, txtTerimTe.Text, txtAnlamTe.Text);
        }

        private void btnEkleTI_Click(object sender, EventArgs e)
        {
            Ekle("turkce", txtIngilizceTI.Text, txtTurkceTI.Text, txtAnlamTI.Text);
        }

        private void btnEkleIT_Click(object sender, EventArgs e)
        {
            Ekle("ingilizce", txtIngiliceIT.Text, txtTurkceIT.Text, txtAnlamIT.Text);
        }

        private void btnTemizleTI_Click(object sender, EventArgs e)
        {
            txtTurkceTI.Clear();
            txtIngilizceTI.Clear();
            txtAnlamTI.Clear();
        }

        private void btnTemizleIT_Click(object sender, EventArgs e)
        {
            txtTurkceIT.Clear();
            txtIngiliceIT.Clear();
            txtAnlamIT.Clear();
        }

        private void btnTemizleTe_Click(object sender, EventArgs e)
        {
            cbTerimKategori.SelectedIndex = 0;
            txtTerimTe.Clear();
            txtAnlamTe.Clear();
        }
    }
}
