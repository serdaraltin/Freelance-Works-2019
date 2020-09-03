using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ApartmanYonetim
{
    public partial class Form_YonetimPanel : Form
    {
        public Form_YonetimPanel()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        DataSet datasetKullanici;
        DataSet datasetApartman;
        DataSet datasetUye;
        DataSet datasetDuyuru;
        DataSet datasetBirey;
        DataSet datasetAidat;
        DataSet datasetBUye;
        DataSet datasetBBorc;
        DataSet datasetBDogalGaz;
        DataSet datasetBElektrik;
        DataSet datasetBSu;


        public int YKullaniciId;
        int ApartmanId,DuyuruId,BireyId, AidatId,UyeId,BorcId;

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
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From BORC Where UyeId='"+ UyeId + "'", baglanti);
            datasetBBorc = new DataSet();
            dataAdapter.Fill(datasetBBorc, "BORC");
            dgBorc.DataSource = datasetBBorc.Tables[0];
            baglanti.Close();
        }
        private void BorcUyeListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From UYE", baglanti);
            datasetBUye = new DataSet();
            dataAdapter.Fill(datasetBUye, "UYE");
            dgBorcUye.DataSource = datasetBUye.Tables[0];
            baglanti.Close();
        }
        private void AidatListele(int UyeId)
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From AIDAT Where UyeId='" + UyeId + "'", baglanti);
            datasetAidat = new DataSet();
            dataAdapter.Fill(datasetAidat, "AIDAT");
            dgBorcAidat.DataSource = datasetAidat.Tables[0];
            baglanti.Close();
        }
        private void ApartmanAdListele()
        {
            lsApartman.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lsApartman.Items.Add(oku["Ad"].ToString());
            }
            baglanti.Close();
            lsApartman.SelectedIndex = 0;
        }
        private void KatListele(int ApartmanId)
        {
            cbBireyKatNo.Items.Clear();
            int KatSayi = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                KatSayi = Convert.ToInt32(oku["KatSayi"].ToString());
            baglanti.Close();
            for (int i = 0; i <= KatSayi; i++)
                cbBireyKatNo.Items.Add(i.ToString());
            cbBireyKatNo.SelectedIndex = 0;
        }
        private void DaireListele(int ApartmanId)
        {
            cbBireyDaireNo.Items.Clear();
            int DaireSayi = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                DaireSayi = Convert.ToInt32(oku["DaireSayi"].ToString());
            baglanti.Close();
            for (int i = 1; i <= DaireSayi; i++)
                cbBireyDaireNo.Items.Add(i.ToString());
            cbBireyDaireNo.SelectedIndex = 0;
        }

        private void BireyListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From BIREY", baglanti);
            datasetBirey = new DataSet();
            dataAdapter.Fill(datasetBirey, "BIREY");
            dgBirey.DataSource = datasetBirey.Tables[0];
            baglanti.Close();
        }
        private void BireyUyeListele(int UyeId)
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From BIREY Where UyeId='"+UyeId+"'", baglanti);
            datasetBirey = new DataSet();
            dataAdapter.Fill(datasetBirey, "BIREY");
            dgBirey.DataSource = datasetBirey.Tables[0];
            baglanti.Close();
        }
        private void KullaniciListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From KULLANICI",baglanti);
            datasetKullanici = new DataSet();
            dataAdapter.Fill(datasetKullanici, "KULLANICI");
            dGKullanici.DataSource = datasetKullanici.Tables[0];
            baglanti.Close();
        }

        private void ApartmanListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From APARTMAN", baglanti);
            datasetApartman = new DataSet();
            dataAdapter.Fill(datasetApartman, "APARTMAN");
            dgApartman.DataSource = datasetApartman.Tables[0];
            baglanti.Close();
        }

        private void UyeListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From UYE", baglanti);
            datasetUye = new DataSet();
            dataAdapter.Fill(datasetUye, "UYE");
            dgUye.DataSource = datasetUye.Tables[0];
            dgBorcUye.DataSource = datasetUye.Tables[0];

            baglanti.Close();
        }
        private void DuyuruListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From DUYURU", baglanti);
            datasetDuyuru = new DataSet();
            dataAdapter.Fill(datasetDuyuru, "UYE");
            dgDuyuru.DataSource = datasetDuyuru.Tables[0];
            baglanti.Close();
        }

        private void KisiselListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From KULLANICI Id='"+ YKullaniciId+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtKisiselAdSoyad.Text = oku["AdSoyad"].ToString();
                txtKisiselCinsiyet.Text = oku["Cinsiyet"].ToString();
                txtKisiselKullaniciAd.Text = oku["KullaniciAd"].ToString();
                txtKisiselMailAdres.Text = oku["MailAdres"].ToString();
                txtKisiselMedeniDurum.Text = oku["MedeniDurum"].ToString();
                txtKisiselSifre.Text = oku["Sifre"].ToString();
                txtKisiselTelefon.Text= oku["Telefon"].ToString();
                
            }
            baglanti.Close();

            try
            {

                pbKullaniciResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(YKullaniciId).ToString());
            }
            catch { pbKullaniciResim.Image = Properties.Resources.Kullanici; }
        }
        private void KullaniciBilgiListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From KULLANICI Where Id='" + YKullaniciId + "'", baglanti);
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
                txtKisiselSifre.Text = oku["Sifre"].ToString();
            }
            baglanti.Close();
            try
            {
                pbKisiselResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(YKullaniciId).ToString());
            }
            catch { pbKisiselResim.Image = Properties.Resources.Kullanici; }
        }
        private void Form_YonetimPanel_Load(object sender, EventArgs e)
        {
           
            lbKullanici.Text = "HOŞGELDİNİZ " + veritabani.KullaniciCekAdSoyad(YKullaniciId);
            try
            {
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(YKullaniciId).ToString());
           

            }
            catch
            {
                pbResim.Image = Properties.Resources.Kullanici;
            }

            KullaniciListele();
            ApartmanListele();
            UyeListele();
            DuyuruListele();
            BireyListele();
            ApartmanAdListele();
            BorcUyeListele();
            KullaniciBilgiListele();
        }

        private void btnKullaniciYenile_Click(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void dGKullanici_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dGKullanici_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           
            try
            {
                txtKullaniciAdSoyad.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["AdSoyad"].ToString();
                txtKullaniciMailAdres.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["MailAdres"].ToString();
                txtKullaniciTelefon.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["Telefon"].ToString();
                txtKullaniciKullaniciAd.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["KullaniciAd"].ToString();
                txtKullaniciSifre.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["Sifre"].ToString();
                dtKullaniciDogumTarih.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["DogumTarih"].ToString();
                cbKullaniciCinsiyet.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["Cinsiyet"].ToString();
                cbKullaniciMedeniDurum.Text = datasetKullanici.Tables[0].Rows[e.RowIndex]["MedeniDurum"].ToString();

                if (veritabani.YoneticiGiris(Convert.ToInt32(datasetKullanici.Tables[0].Rows[e.RowIndex]["Id"])))
                {
                    chKullaniciYoneticiKullanici.Checked = true;
                }
                else
                {
                    chKullaniciYoneticiKullanici.Checked = false;
                }
                try
                {

                    pbKullaniciResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(Convert.ToInt32(datasetKullanici.Tables[0].Rows[e.RowIndex]["Id"])).ToString());
                }
                catch { pbKullaniciResim.Image = Properties.Resources.Kullanici; }
            }
            catch { }
        }

        private void btnKullaniciYeniEkle_Click(object sender, EventArgs e)
        {
            Form_KullaniciEkle kullaniciEkle = new Form_KullaniciEkle();
            kullaniciEkle.ShowDialog();
        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            Form_KullaniciDuzenle KullaniciDuzenle = new Form_KullaniciDuzenle();
            KullaniciDuzenle.KullaniciId = veritabani.KullaniciCekId(txtKullaniciKullaniciAd.Text);
            KullaniciDuzenle.ShowDialog();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Kullaniciyi Silmek istediğinize emin misiniz ? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(soru == DialogResult.Yes)
            {
                if (veritabani.KullaniciSil(veritabani.KullaniciCekId(txtKullaniciKullaniciAd.Text)))
                {
                    KullaniciListele();
                }else
                {
                    MessageBox.Show("Kullanici Silinemedi !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnApartmanYenile_Click(object sender, EventArgs e)
        {
            ApartmanListele();
        }

        private void btnApartmanYeniEkle_Click(object sender, EventArgs e)
        {
            Form_ApartmanEkle ApartmanEkle = new Form_ApartmanEkle();
            ApartmanEkle.ShowDialog();
        }

        private void btnApartmanDuzenle_Click(object sender, EventArgs e)
        {
            Form_ApartmanGuncelle ApartmanGuncelle = new Form_ApartmanGuncelle();
            ApartmanGuncelle.ApartmanId = ApartmanId;
            ApartmanGuncelle.ShowDialog();
        }

        private void dgApartman_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtApartmanGuvenlikAdSoyad.Text = "";
            txtapartmanGuvenlikTelefon.Text = "";
            try
            {
                foreach (int Id in veritabani.YoneticiListeleAd())
                {
                    cbApartmanYonetici.Items.Add(veritabani.KullaniciCekAd(Id));
                }
                cbApartmanYonetici.SelectedIndex = 0;

                ApartmanId = Convert.ToInt32(datasetApartman.Tables[0].Rows[e.RowIndex]["Id"].ToString());
                cbApartmanYonetici.Text = veritabani.KullaniciCekAd(veritabani.YoneticiCekKullaniciId(Convert.ToInt32(datasetApartman.Tables[0].Rows[e.RowIndex]["YoneticiId"].ToString()))).ToString();

                txtApartmanAd.Text = datasetApartman.Tables[0].Rows[e.RowIndex]["Ad"].ToString();
                txtApartmanBlok.Text = datasetApartman.Tables[0].Rows[e.RowIndex]["ApartmanBlok"].ToString();
                ndApartmanKatSayisi.Value = Convert.ToInt32(datasetApartman.Tables[0].Rows[e.RowIndex]["KatSayi"].ToString());
                ndApartmanDaireSayisi.Value = Convert.ToInt32(datasetApartman.Tables[0].Rows[e.RowIndex]["DaireSayi"].ToString());
                txtApartmanAidat.Text = datasetApartman.Tables[0].Rows[e.RowIndex]["Aidat"].ToString();

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

        private void btnApartmanSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Apartmanı Silmek istediğinize emin misiniz ? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                if (veritabani.ApartmanSil(ApartmanId))
                {
                    ApartmanListele();
                }
                else
                {
                    MessageBox.Show("Apartman Silinemedi !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void dgUye_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            int Id = Convert.ToInt32(datasetUye.Tables[0].Rows[e.RowIndex]["KullaniciId"].ToString());
            int ApartmanId = Convert.ToInt32(datasetUye.Tables[0].Rows[e.RowIndex]["ApartmanId"].ToString());


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From KULLANICI Where Id='" + Id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtUyeAdSoyad.Text = oku["AdSoyad"].ToString();
                txtUyeKullaniciAd.Text = oku["KullaniciAd"].ToString();
                txtUyeMailAdres.Text = oku["MailAdres"].ToString();
                txtUyeSifre.Text = oku["Sifre"].ToString();
                txtUyeTelefon.Text = oku["Telefon"].ToString();
                cbUyeCinsiyet.Text = oku["Cinsiyet"].ToString();
                cbUyeMedeniDurum.Text = oku["MedeniDurum"].ToString();
            }
            baglanti.Close();
            try
            {

                pbUyeResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(Convert.ToInt32(datasetUye.Tables[0].Rows[e.RowIndex]["KullaniciId"])).ToString());
            }
            catch
            {
                pbUyeResim.Image = Properties.Resources.Kullanici;
            }
            if (veritabani.YoneticiGiris(Convert.ToInt32(datasetUye.Tables[0].Rows[e.RowIndex]["KullaniciId"])))
            {
                chKullaniciYoneticiKullanici.Checked = true;
            }
            else
            {
                chKullaniciYoneticiKullanici.Checked = false;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select *From APARTMAN Where Id='" + ApartmanId + "'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                txtUyeApartman.Text = oku2["Ad"].ToString();
            }
            baglanti.Close();

            txtUyeKat.Text = datasetUye.Tables[0].Rows[e.RowIndex]["KatNo"].ToString();
            txtUyeDaire.Text = datasetUye.Tables[0].Rows[e.RowIndex]["DaireNo"].ToString();
            }
            catch { }

        }

        private void btnDuyuruYenile_Click(object sender, EventArgs e)
        {
            DuyuruListele();

        }

        private void dgDuyuru_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DuyuruId = Convert.ToInt32(datasetDuyuru.Tables[0].Rows[e.RowIndex]["Id"].ToString());
                txtDuyuruBaslik.Text = datasetDuyuru.Tables[0].Rows[e.RowIndex]["Baslik"].ToString();
                rcDuyuruMetin.Text = datasetDuyuru.Tables[0].Rows[e.RowIndex]["Metin"].ToString();
            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtApartmanGuvenlikAdSoyad.Text != "")
            {
                MessageBox.Show("Apartman için zaten güvenlik görevlisi kaydı var", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                Form_GuvenlikEkle GuvenlikEkle = new Form_GuvenlikEkle();
                GuvenlikEkle.ApartmanId = ApartmanId;
                GuvenlikEkle.ShowDialog();
            }
        }

        private void btnGuvenlikSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Güvenlik Görevlisi kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(soru == DialogResult.Yes)
            {
                veritabani.GuvenlikSil(ApartmanId);
                ApartmanListele();
            }
        }

        private void btnUyeYeniEkle_Click(object sender, EventArgs e)
        {
            Form_UyeEkle UyeEkle = new Form_UyeEkle();
            UyeEkle.ShowDialog();
        }

        private void btnUyeYenile_Click(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Üye kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.UyeSil(veritabani.UyeCekId(veritabani.KullaniciCekId(txtUyeKullaniciAd.Text)));
                UyeListele();
            }
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            Form_UyeGuncelle UyeGuncelle = new Form_UyeGuncelle();
            UyeGuncelle.UyeId = veritabani.UyeCekId(veritabani.KullaniciCekId(txtUyeKullaniciAd.Text));
            UyeGuncelle.ShowDialog();
        }

        private void btnDuyuruYeniEkle_Click(object sender, EventArgs e)
        {
            Form_DuyuruEkle DuyuruEkle = new Form_DuyuruEkle();
            DuyuruEkle.YoneticiId = 1003;
            DuyuruEkle.ShowDialog();
        }

        private void btnBireyYenile_Click(object sender, EventArgs e)
        {
            BireyListele();
        }

        private void lsApartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            KatListele(veritabani.ApartmanCekId(lsApartman.Items[lsApartman.SelectedIndex].ToString()));
            DaireListele(veritabani.ApartmanCekId(lsApartman.Items[lsApartman.SelectedIndex].ToString()));

        }

        private void btnBireyListele_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            int UyeId = 0;
            int sApartmanId = veritabani.ApartmanCekId(lsApartman.Items[lsApartman.SelectedIndex].ToString());
            SqlCommand komut = new SqlCommand("Select * From UYE Where ApartmanId='" + sApartmanId + "' AND KatNo='" + Convert.ToInt32(cbBireyKatNo.Text) + "' AND DaireNo='" + Convert.ToInt32(cbBireyDaireNo.Text) + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            SqlDataAdapter dataAdapter =null;
            while (oku.Read())
            {
                UyeId = Convert.ToInt32(oku["Id"].ToString());
            }
          
            baglanti.Close();
            BireyUyeListele(UyeId);




        }

        private void btnBireyYeniEkle_Click(object sender, EventArgs e)
        {
            Form_BireyEkle BireyEkle = new Form_BireyEkle();
            BireyEkle.ShowDialog();
        }

        private void dgBirey_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            BireyId = Convert.ToInt32(datasetBirey.Tables[0].Rows[e.RowIndex]["Id"].ToString());

            txtBireyAdSoyad.Text = datasetBirey.Tables[0].Rows[e.RowIndex]["AdSoyad"].ToString();
            txtBireyUye.Text = veritabani.KullaniciCekAd(veritabani.UyeCekKullaniciId(Convert.ToInt32(datasetBirey.Tables[0].Rows[e.RowIndex]["UyeId"].ToString())));
            txtBireyYas.Text = datasetBirey.Tables[0].Rows[e.RowIndex]["Yas"].ToString();
            txtBireyApartman.Text = veritabani.ApartmanCekAd(veritabani.UyeCekApartman(Convert.ToInt32(datasetBirey.Tables[0].Rows[e.RowIndex]["UyeId"].ToString())));
            txtBireyKatNo.Text = veritabani.UyeCekKatNo(Convert.ToInt32(datasetBirey.Tables[0].Rows[e.RowIndex]["UyeId"].ToString())).ToString();
            txtBireyDaireNo.Text = veritabani.UyeCekDaireNo(Convert.ToInt32(datasetBirey.Tables[0].Rows[e.RowIndex]["UyeId"].ToString())).ToString();

        }

        private void btnBireySil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Birey kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.BireySil(BireyId);
                BireyListele();
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnAidatEkle_Click(object sender, EventArgs e)
        {
            Form_AidatEkle AidatEkle = new Form_AidatEkle();
            AidatEkle.ShowDialog();
        }

        private void dgBorcUye_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UyeId = Convert.ToInt32(datasetBUye.Tables[0].Rows[e.RowIndex]["Id"].ToString());

                AidatListele(UyeId);
                BorcBorcListele(UyeId);

                txtBorcAdSoyad.Text = veritabani.KullaniciCekAd(Convert.ToInt32(datasetBUye.Tables[0].Rows[e.RowIndex]["KullaniciId"].ToString()));

                try
                {

                    pbBorcResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(Convert.ToInt32(datasetBUye.Tables[0].Rows[e.RowIndex]["KullaniciId"])).ToString());
                }
                catch
                {
                    pbBorcResim.Image = Properties.Resources.Kullanici;
                }
            }
            catch { }
        }

        private void btnAidatYenile_Click(object sender, EventArgs e)
        {
            AidatListele(UyeId);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            Form_BorcEkle BorcEkle = new Form_BorcEkle();
            BorcEkle.UyeId = UyeId;
            BorcEkle.ShowDialog();
        }

        private void btnDogalGazEkle_Click(object sender, EventArgs e)
        {
            Form_FaturaEkle FaturaEkle = new Form_FaturaEkle();
            FaturaEkle.Tur = "DogalGaz";
            FaturaEkle.UyeId = UyeId;
            FaturaEkle.BorcId = BorcId;
            FaturaEkle.ShowDialog();
        }

        private void btnElektrikEkle_Click(object sender, EventArgs e)
        {
            Form_FaturaEkle FaturaEkle = new Form_FaturaEkle();
            FaturaEkle.Tur = "Elektrik";
            FaturaEkle.UyeId = UyeId;
            FaturaEkle.BorcId = BorcId;
            FaturaEkle.ShowDialog();
        }

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            Form_FaturaEkle FaturaEkle = new Form_FaturaEkle();
            FaturaEkle.Tur = "Su";
            FaturaEkle.UyeId = UyeId;
            FaturaEkle.BorcId = BorcId;
            FaturaEkle.ShowDialog();
        }

        private void btnDogalGazSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Fatura kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.DogalGazSil(BorcId);
                BorcDogalGazListele(BorcId);
            }
        }

        private void btnElektririkSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Fatura kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.ElektrikSil(BorcId);
                BorcElektrikListele(BorcId);
            }
        }

        private void btnSuSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Fatura kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.SuSil(BorcId);
                BorcSuListele(BorcId);
            }
        }

        private void btnDogalGazDuzenle_Click(object sender, EventArgs e)
        {
           // Form_FaturaGuncelle FaturaGuncelle = new Form_FaturaGuncelle();
           
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

        private void btnAidatSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Aidat kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.AidatSil(AidatId);
                AidatListele(UyeId);

            }
        }

        private void btnAidatDuzenle_Click(object sender, EventArgs e)
        {
            Form_AidatGuncelle AidatGuncelle = new Form_AidatGuncelle();
            AidatGuncelle.AidatId = AidatId;
            AidatGuncelle.ShowDialog();
        }

        private void btnBireyDuzenle_Click(object sender, EventArgs e)
        {
            Form_BireyGuncelle BireyGuncelle = new Form_BireyGuncelle();
            BireyGuncelle.BireyId = BireyId;
            BireyGuncelle.ShowDialog();
        }

        private void btnDuyuruSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Duyuru kaydını silmek istediğinizden emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                veritabani.DuyuruSil(DuyuruId);
                DuyuruListele();
            }
        }

        private void btnHesapAyarlari_Click(object sender, EventArgs e)
        {
            Form_KullaniciDuzenle KullaniciDuzenle = new Form_KullaniciDuzenle();
            KullaniciDuzenle.KullaniciId = YKullaniciId;
            KullaniciDuzenle.ShowDialog();
        }
    }
}
