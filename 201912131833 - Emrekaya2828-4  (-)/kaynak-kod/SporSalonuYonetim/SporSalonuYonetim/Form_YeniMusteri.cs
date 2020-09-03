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
        // müşteri id bilgisi için değişken
        int Id;
        public Form_YeniMusteri()
        {
            InitializeComponent();
        }

        //form(pencere) yaratma(oluşturm) işlemi ikinci durum yani müşteri güncelleme durumu
        public Form_YeniMusteri(int MId)
        {
            InitializeComponent();
            //müşteri id bilgisi atama
            Id = MId;
        }

        //veritabanı sınıfından yeni bir nesne üretme
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        //resim dosyası bilgisi için değişken
        string Resim;
        //müşteri id bilgisi için değişken
        int MusteriId;

        //kapat butonu tıklama
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //bu form(pencere) kapatma
            this.Close();
        }

        //resim seç butonu tıklama
        private void btn_ResimSec_Click(object sender, EventArgs e)
        {

            //dosya seçimi için pencere oluşturma
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Filter = "Fotoğraf Dosyaları|*.jpg|Resim Dosyaları|*.png|Tüm Dosyalar|*.*";
            DosyaSec.Title = "Resim Dosyası Seç";
            DosyaSec.FileName = "Resim.jpg";


            //dosya seçme durumu tamam ise
            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                //seçilen dosya türü doğru ise
                try
                {
                    //resim kutusunda seçilen dosya görüntülenir
                    pb_Resim.Image = Image.FromFile(DosyaSec.FileName);
                    //resim değişkeni içerisindeki bilgi seçilen resim yolu olarak ayarlanır
                    Resim = DosyaSec.FileName;
                }
                //seçilen bir resim değilse
                catch
                {
                    //uyarı amaçlı mesaj kutusu oluşturma
                    MessageBox.Show("Format desteklenmiyor !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //müşteri ekleme fonksiyonu (yeni müşteri ekler)
        private void Ekle()
        {
            //veritabanına müşteri ekleme işlemi başarılı ise
            if (veritabani.Musteri_Ekle(txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text,
              txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value), txt_Adres.Text))
            {
                //müşteri id veritabanından alınır (yeni eklenen müşteri)
                MusteriId = veritabani.Musteri_GetirId(txt_TcNo.Text);

                //resim kaydetmek için yol belirleme
                string yol = Application.StartupPath + "/musteri";
                //eğer resmin kaydedileceği klasör(dizin) yoksa
                if (!Directory.Exists(yol))
                    //dizin(klasör) yaratılır(oluştur)
                    Directory.CreateDirectory(yol);
                //daha önceden seçilen resim kopyalanır
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
            //hata durumu var ise
            else
            {
                //hata için mesaj kutusu oluşturma
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //müşteri bilgileri güncellemek için fonksiyon
        private void Guncelle()
        {
            //müşteri güncelleme durumu başarılı ise
            if (veritabani.Musteri_Guncelle(Id,txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text,
              txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value), txt_Adres.Text))
            {
                //bilgilendirme mesaj kutusu oluşturulur
                MessageBox.Show("Müşteri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bu form(pencere) kapatılır
                this.Close();

            }
            //müşteri güncellenemez ise , hata oluşursa
            else
            {
                //hata mesajı kutusu oluşturma
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ekle butonu tıklama
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            //gerekli alanlar kontrol edilir tamam değilse
            if (!(txt_TcNo.Text != "" && txt_Ad.Text != "" && txt_Soyad.Text != "" && txt_Telefon.Text != "" && txt_Meslek.Text != "" && txt_Adres.Text != ""))
            {
                //uyarı amaçlı mesaj kutusu oluşturma
                MessageBox.Show("Gerekli alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //işlemi sonlandırma
                return;
            }
            //güncelleme işlemi durumu varsa
            if (Id > 0)
                //güncelleme fonksiyonu çağrılır
                Guncelle();
            //ekleme işlemi durumu varsa
            else
                //ekleme fonksiyonu çağrılır
                Ekle();

        }
        //müşteri güncelleme durumu için müşteri bilgilerini çekme fonksiyonu
        private void Musteri_Bilgi(int Id)
        {
            //eğer müşteri id bilgisi yanlış işe
            if (!(Id > 0))
                //işlem sonlandırma
                return;

            //-> müşteri bilgileri gerekli alanlanara doldurulur
            txt_TcNo.Text = veritabani.Musteri_Bilgi(Id)[0].ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(Id)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(Id)[2].ToString();
            txt_Telefon.Text = veritabani.Musteri_Bilgi(Id)[3].ToString();
            txt_Meslek.Text = veritabani.Musteri_Bilgi(Id)[4].ToString();
            dt_DogumTarih.Value = Convert.ToDateTime(veritabani.Musteri_Bilgi(Id)[5]);
            nud_Boy.Value = Convert.ToInt32(veritabani.Musteri_Bilgi(Id)[6]);
            nud_Kilo.Value = Convert.ToInt32(veritabani.Musteri_Bilgi(Id)[7]);
            txt_Adres.Text = veritabani.Musteri_Bilgi(Id)[8].ToString();
            //<- müşteri bilgileri gerekli alanlanara dolduruldu

            //resim yolu belirleme
            string Resim = Application.StartupPath + "/musteri/" + Id.ToString() + ".png";

            //resim varsa
            if (File.Exists(Resim))
                //resim kutusu içeriği müşteri resmi ile değiştirilir
                pb_Resim.Image = Image.FromFile(Resim);
            //resim bilgisi yok ise
            else
                //resim kutusu boş yapılır
                pb_Resim.Image = null;
        }

        //formun(pencere) açılma durumu
        private void Form_YeniMusteri_Load(object sender, EventArgs e)
        {
            //id bilgisi varsa (güncelleme işlemi yapılacaksa)
            if(Id > 0)
            {
                //resim seçme butonu gizlenir
                btn_ResimSec.Visible = false;
                //başlık değiştirilir
                lb_Baslik.Text = Id.ToString() + " Nolu Müşteri";
                //müşteri bilgileri veritabanından alınır
                Musteri_Bilgi(Id);
                //ekle butonu metni değiştirilir
                btn_Ekle.Text = "GÜNCELLE";
            }
        }
    }
}
