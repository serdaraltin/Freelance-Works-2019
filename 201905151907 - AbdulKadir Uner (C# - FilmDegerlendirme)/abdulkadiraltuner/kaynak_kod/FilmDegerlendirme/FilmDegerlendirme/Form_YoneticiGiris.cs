using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmDegerlendirme
{
    
    public partial class Form_YoneticiGiris : Form
    {
        public Form_YoneticiGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.SunucuAd + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        VeriTabaniFonskiyon veritabani = new VeriTabaniFonskiyon();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (veritabani.YoneticiGiris(txtKullaniciAdi.Text, txtSifre.Text))
            {
                //MessageBox.Show("Giris Basarili", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_YonetimPanel YonetimPanel = new Form_YonetimPanel();
                YonetimPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya Sifre hatali","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form_YoneticiGiris_Load(object sender, EventArgs e)
        {
            if(SunucuBilgi.Default.SunucuAd == "")
            {
                Form_SunucuBaglanti SunucuBaglanti = new Form_SunucuBaglanti();
                SunucuBaglanti.ShowDialog();
            }
        }
    }
}
