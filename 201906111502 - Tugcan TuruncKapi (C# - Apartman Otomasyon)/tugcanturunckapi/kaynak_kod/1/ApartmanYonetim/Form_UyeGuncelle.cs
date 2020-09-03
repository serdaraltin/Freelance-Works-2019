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
    public partial class Form_UyeGuncelle : Form
    {
        public Form_UyeGuncelle()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        public int UyeId;
        private void KullaniciListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From KULLANICI", baglanti);
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

                if (veritabani.UyeCekApartman(UyeId).ToString() == oku["Id"].ToString())
                {
                    cbApartmanAd.Text = oku["Ad"].ToString();
                 
                }
            }
            baglanti.Close();
            KatListele(veritabani.ApartmanCekId(cbApartmanAd.Text));
            DaireListele(veritabani.ApartmanCekId(cbApartmanAd.Text));
        }
        private void KatListele(int ApartmanId)
        {
            try
            {
                cbKatNo.Items.Clear();
                int KatSayi = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KatSayi = Convert.ToInt32(oku["KatSayi"].ToString());
                baglanti.Close();
                for (int i = 0; i <= KatSayi; i++)
                    cbKatNo.Items.Add(i.ToString());
                cbKatNo.Text = veritabani.UyeCekKatNo(UyeId).ToString();
            }
            catch { }

        }
        private void DaireListele(int ApartmanId)
        {
            try
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
                cbDaireNo.Text = veritabani.UyeCekDaireNo(UyeId).ToString();
            }
            catch { }
        }
        private void Form_UyeGuncelle_Load(object sender, EventArgs e)
        {
            KullaniciListele();
            ApartmanListele();
        }

        private void cbApartmanAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            KatListele(veritabani.ApartmanCekId(cbApartmanAd.Text));
            DaireListele(veritabani.ApartmanCekId(cbApartmanAd.Text));
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (veritabani.UyeGuncelle(UyeId, veritabani.ApartmanCekId(cbApartmanAd.Text), Convert.ToInt32(cbKatNo.Text), Convert.ToInt32(cbDaireNo.Text)))
            {
                MessageBox.Show("Uye Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncellenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
