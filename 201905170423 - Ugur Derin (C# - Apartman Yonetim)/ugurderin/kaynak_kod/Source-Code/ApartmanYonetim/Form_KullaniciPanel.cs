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
    public partial class Form_KullaniciPanel : Form
    {
        public Form_KullaniciPanel()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");


        public int KullaniciId,UyeId,BorcId;

        DataSet datasetBUye;
        DataSet datasetBBorc;
        DataSet datasetBDogalGaz;
        DataSet datasetBElektrik;
        DataSet datasetBSu;
        DataSet datasetAidat;

        private void AidatListele(int UyeId)
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From AIDAT Where UyeId='" + UyeId + "'", baglanti);
            datasetAidat = new DataSet();
            dataAdapter.Fill(datasetAidat, "AIDAT");
            dgBorcAidat.DataSource = datasetAidat.Tables[0];
            baglanti.Close();
        }
        private void BorcDogalGazListele(int BorcId)
        {
            dgBorcDogalGaz.DataSource = null;

            baglanti.Close();
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From DOGALGAZ Where BorcId='" + BorcId + "'", baglanti);
            datasetBDogalGaz = new DataSet();
            dataAdapter.Fill(datasetBDogalGaz, "DOGALGAZ");
            dgBorcDogalGaz.DataSource = datasetBDogalGaz.Tables[0];
            baglanti.Close();
        }
        private void BorcElektrikListele(int BorcId)
        {
            dgBorcElektrik.DataSource = null;
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From ELEKTRIK Where BorcId='" + BorcId + "'", baglanti);
            datasetBElektrik = new DataSet();
            dataAdapter.Fill(datasetBElektrik, "ELEKTRIK");
            dgBorcElektrik.DataSource = datasetBElektrik.Tables[0];
            baglanti.Close();
        }
        private void BorcSuListele(int BorcId)
        {
            dgBorcSu.DataSource = null;
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From SU Where BorcId='" + BorcId + "'", baglanti);
            datasetBSu = new DataSet();
            dataAdapter.Fill(datasetBSu, "SU");
            dgBorcSu.DataSource = datasetBSu.Tables[0];
            baglanti.Close();
        }
        private void BorcBorcListele(int UyeId)
        {
            dgBorc.DataSource = null;

            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From BORC Where UyeId='" + UyeId + "'", baglanti);
            datasetBBorc = new DataSet();
            dataAdapter.Fill(datasetBBorc, "BORC");
            dgBorc.DataSource = datasetBBorc.Tables[0];
            baglanti.Close();
        }
        private void KullaniciBilgiListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From KULLANICI Where Id='"+KullaniciId+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtKisiselAdSoyad.Text = oku["AdSoyad"].ToString();
                txtKisiselMailAdres.Text = oku["MailAdres"].ToString();
                txtKisiselTelefon.Text = oku["Telefon"].ToString();
                dtKisiselDogumTarih.Text = oku["DogumTarih"].ToString();
                txtKisiselCinsiyet.Text = oku["Cinsiyet"].ToString();
                txtKisiselMedeniDurum.Text = oku["MedeniDurum"].ToString();
                txtKisiselKullaniciAd.Text = oku["KullaniciAd"].ToString();
            }
            baglanti.Close();
            try
            {
                pbKisiselResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(KullaniciId).ToString());
            }
            catch { pbKisiselResim.Image = Properties.Resources.Kullanici; }
        }
        private void ApartmanBilgiListele()
        {

            int ApartmanId = Convert.ToInt32(veritabani.UyeCekApartman(UyeId));
           
            
            try
            {

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Select *From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
                SqlDataReader oku1 = komut1.ExecuteReader();
                while (oku1.Read())
                {
                    txtApartmanYonetici.Text = veritabani.KullaniciCekAd(veritabani.YoneticiCekKullaniciId(Convert.ToInt32(oku1["YoneticiId"].ToString())));

                    txtApartmanAd.Text = oku1["Ad"].ToString();
                    txtApartmanBlok.Text = oku1["ApartmanBlok"].ToString();
                    ndApartmanKatSayisi.Value = Convert.ToInt32(oku1["KatSayi"].ToString());
                     ndApartmanDaireSayisi.Value = Convert.ToInt32(oku1["DaireSayi"].ToString());
                    txtApartmanAidat.Text = oku1["Aidat"].ToString();
                }

                baglanti.Close();
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Select * From GUVENLIK Where ApartmanId='" + ApartmanId + "'", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        txtApartmanGuvenlikAdSoyad.Text = oku["AdSoyad"].ToString();
                        txtapartmanGuvenlikTelefon.Text = oku["Telefon"].ToString();
                    }
                    baglanti.Close();
                }
                catch { }

            }
            catch { }



        }
        private void DuyuruListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From DUYURU", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtDuyuruBaslik.Text = oku["Baslik"].ToString();
                rcDuyuruMetin.Text = oku["Metin"].ToString();
            }
            baglanti.Close();
        }
        private void Form_KullaniciPanel_Load(object sender, EventArgs e)
        {
            lbKullanici.Text = "HOŞGELDİNİZ " + veritabani.KullaniciCekAdSoyad(KullaniciId);
            try
            {
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(KullaniciId).ToString());
            }
            catch{  pbResim.Image = Properties.Resources.Kullanici;}
            KullaniciBilgiListele();
            DuyuruListele();

            UyeId = veritabani.UyeCekId(KullaniciId);
            BorcBorcListele(UyeId);
            AidatListele(UyeId);
            ApartmanBilgiListele();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void dgBorc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BorcId = Convert.ToInt32(datasetBBorc.Tables[0].Rows[e.RowIndex]["Id"]);
                // BorcElektrikListele(BorcId);
                BorcDogalGazListele(BorcId);
                BorcElektrikListele(BorcId);
                BorcSuListele(BorcId);
            }
            catch { }

        }

        private void btnHesapAyarlari_Click(object sender, EventArgs e)
        {
            Form_KullaniciDuzenle KullaniciDuzenle = new Form_KullaniciDuzenle();
            KullaniciDuzenle.KullaniciId = KullaniciId;
            KullaniciDuzenle.ShowDialog();
        }
    }
}
