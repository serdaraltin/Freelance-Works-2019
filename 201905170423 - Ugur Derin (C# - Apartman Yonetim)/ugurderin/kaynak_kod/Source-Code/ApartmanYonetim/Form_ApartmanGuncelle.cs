using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ApartmanYonetim
{
    public partial class Form_ApartmanGuncelle : Form
    {
        public Form_ApartmanGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int ApartmanId = 1;

        private void BilgileriListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("ApartmanCekTekli", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbYonetici.Text = veritabani.KullaniciCekAd(Convert.ToInt32(oku["YoneticiId"].ToString()));
                txtAd.Text = oku["Ad"].ToString();
                txtBlok.Text = oku["ApartmanBlok"].ToString();
                ndKatSayi.Value = Convert.ToInt32(oku["KatSayi"].ToString());
                ndDaireSayisi.Value = Convert.ToInt32(oku["DaireSayi"].ToString());
                txtAidatTL.Text = oku["Aidat"].ToString();
            }
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtBlok.Text != "" && txtAidatTL.Text != "")
            {
                float Aidat = (float)Convert.ToDouble(txtAidatTL.Text);
                if (veritabani.ApartmanGuncelle(ApartmanId,veritabani.YoneticiCekId(veritabani.KullaniciCekId(cbYonetici.Text)), txtAd.Text, txtBlok.Text, (int)ndKatSayi.Value, (int)ndDaireSayisi.Value, Aidat))
                {
                    MessageBox.Show("Apartman güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncellenemedi !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_ApartmanGuncelle_Load(object sender, EventArgs e)
        {
            foreach (int Id in veritabani.YoneticiListeleAd())
            {
                cbYonetici.Items.Add(veritabani.KullaniciCekAd(Id));
            }

            BilgileriListele();


        }
    }
}
