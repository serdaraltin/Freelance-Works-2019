using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_YeniMusteri : Form
    {
        int Id;
        public Form_YeniMusteri()
        {
            InitializeComponent();
        }
        public Form_YeniMusteri(int MId)
        {
            InitializeComponent();
            Id = MId;
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        string Resim;
        int MusteriId;

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Filter = "Fotoğraf Dosyaları|*.jpg|Resim Dosyaları|*.png|Tüm Dosyalar|*.*";
            DosyaSec.Title = "Resim Dosyası Seç";
            DosyaSec.FileName = "Resim.jpg";

            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb_Resim.Image = Image.FromFile(DosyaSec.FileName);
                    Resim = DosyaSec.FileName;
                }
                catch
                {
                    MessageBox.Show("Format desteklenmiyor !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Ekle()
        {
            if (veritabani.Musteri_Ekle(txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text,
              txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value), txt_Adres.Text))
            {
                MusteriId = veritabani.Musteri_GetirId(txt_TcNo.Text);
                string yol = Application.StartupPath + "/musteri";
                if (!Directory.Exists(yol))
                    Directory.CreateDirectory(yol);
                File.Copy(Resim, yol + "/" + MusteriId.ToString() + ".png");
            /*    DialogResult soru = MessageBox.Show("Müşteri için program hazırlamak ister misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {

                }
                else
                {
                    this.Close();
                }*/
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Guncelle()
        {
            if (veritabani.Musteri_Guncelle(Id,txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text,
              txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value), txt_Adres.Text))
            {
                MusteriId = veritabani.Musteri_GetirId(txt_TcNo.Text);
                MessageBox.Show("Müşteri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(!(txt_TcNo.Text != "" && txt_Ad.Text != "" && txt_Soyad.Text != "" && txt_Telefon.Text != "" && txt_Meslek.Text != "" && txt_Adres.Text != ""))
            {
                MessageBox.Show("Gerekli alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Id > 0)
                Guncelle();
            else
                Ekle();
           
        }
        private void Musteri_Bilgi(int Id)
        {
            if (!(Id > 0))
                return;
            txt_TcNo.Text = veritabani.Musteri_Bilgi(Id)[0].ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(Id)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(Id)[2].ToString();
            txt_Telefon.Text = veritabani.Musteri_Bilgi(Id)[3].ToString();
            txt_Meslek.Text = veritabani.Musteri_Bilgi(Id)[4].ToString();
            dt_DogumTarih.Value = Convert.ToDateTime(veritabani.Musteri_Bilgi(Id)[5]);
            nud_Boy.Value = Convert.ToInt32(veritabani.Musteri_Bilgi(Id)[6]);
            nud_Kilo.Value = Convert.ToInt32(veritabani.Musteri_Bilgi(Id)[7]);
            txt_Adres.Text = veritabani.Musteri_Bilgi(Id)[8].ToString();
            string Resim = Application.StartupPath + "/musteri/" + Id.ToString() + ".png";
            if (File.Exists(Resim))
                pb_Resim.Image = Image.FromFile(Resim);
            else
                pb_Resim.Image = null;
        }
        private void Form_YeniMusteri_Load(object sender, EventArgs e)
        {
            if(Id > 0)
            {
                btn_ResimSec.Visible = false;
                lb_Baslik.Text = Id.ToString() + " Nolu Müşteri";
                Musteri_Bilgi(Id);
                btn_Ekle.Text = "GÜNCELLE";
            }
        }
    }
}
