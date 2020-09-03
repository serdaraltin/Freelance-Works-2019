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
    public partial class Form_KullaniciDuzenle : Form
    {
        public Form_KullaniciDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int KullaniciId;
        string ResimYol;
        private void VerileriListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("KullaniciCek", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAdSoyad.Text = oku["AdSoyad"].ToString();
                txtMailAdres.Text = oku["MailAdres"].ToString();
                txtTelefon.Text = oku["Telefon"].ToString();
                txtSifre.Text = oku["Sifre"].ToString();
                cbCinsiyet.Text = oku["Cinsiyet"].ToString();
                cbMedeniDurum.Text = oku["MedeniDurum"].ToString();
                dtDogumTarih.Text = oku["DogumTarih"].ToString();

            }
            oku.Close();
            baglanti.Close();

            try
            {
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(KullaniciId).ToString());

            }
            catch
            {
                pbResim.Image = Properties.Resources.Kullanici;
            }
        }
        private void Form_KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            
            VerileriListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(veritabani.KullaniciGuncelle(KullaniciId, txtSifre.Text, txtAdSoyad.Text, txtMailAdres.Text, txtTelefon.Text, dtDogumTarih.Value, cbCinsiyet.Text, cbMedeniDurum.Text,ResimYol, Application.StartupPath))
            {
                MessageBox.Show("Günceleme İşlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Title = "Resim Seç";
            DosyaSec.FileName = "Resim.jpg";
            DosyaSec.Filter = "Jpg Dosyaları|*.jpg|Png Dosyaları|*.png";

            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                ResimYol = DosyaSec.FileName;
                pbResim.Image = Image.FromFile(DosyaSec.FileName);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
