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
    public partial class Form_UyeEkle : Form
    {
        public Form_UyeEkle()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        private void KullaniciListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From KULLANICI",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                cbKullaniciAd.Items.Add(oku["KullaniciAd"].ToString());
            baglanti.Close();
            cbKullaniciAd.SelectedIndex = 0;
        }
        private void ApartmanListele()
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbApartmanAd.Items.Add(oku["Ad"].ToString());
            }
            baglanti.Close();
            cbApartmanAd.SelectedIndex = 0;
        }
        private void KatListele(int ApartmanId)
        {
            cbKatNo.Items.Clear();
            int KatSayi=0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='"+ApartmanId+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                KatSayi = Convert.ToInt32(oku["KatSayi"].ToString());
            baglanti.Close();
            for (int i = 0; i <= KatSayi; i++)
                cbKatNo.Items.Add(i.ToString());
            cbKatNo.SelectedIndex = 0;
        }
        private void DaireListele(int ApartmanId)
        {
            cbDaireNo.Items.Clear();
            int DaireSayi = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                DaireSayi = Convert.ToInt32(oku["DaireSayi"].ToString());
            baglanti.Close();
            for (int i = 1; i <= DaireSayi; i++)
                cbDaireNo.Items.Add(i.ToString());
            cbDaireNo.SelectedIndex = 0;
        }
    
        private void Form_UyeEkle_Load(object sender, EventArgs e)
        {
            KullaniciListele();
            ApartmanListele();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbApartmanAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            KatListele(veritabani.ApartmanCekId(cbApartmanAd.Text));
            DaireListele(veritabani.ApartmanCekId(cbApartmanAd.Text));

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!veritabani.UyeSorgula(veritabani.KullaniciCekId(cbKullaniciAd.Text)))
            {
                if (veritabani.UyeEkle(veritabani.KullaniciCekId(cbKullaniciAd.Text), veritabani.ApartmanCekId(cbApartmanAd.Text), Convert.ToInt32(cbKatNo.Text), Convert.ToInt32(cbDaireNo.Text)))
                {
                    MessageBox.Show("Uye Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kullanici zaten uye", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
