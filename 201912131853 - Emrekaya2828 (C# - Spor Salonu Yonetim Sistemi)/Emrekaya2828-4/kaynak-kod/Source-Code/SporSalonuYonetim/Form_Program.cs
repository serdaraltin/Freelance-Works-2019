using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Program : Form
    {
        //müşteri id bilgisi için değişken
        int MusteriId;
        //müşteri güncelleme bilgisi için değişken
        bool Guncelleme;

        //form(pencere) yaratma(oluşturma) işlemi
        public Form_Program(int MId)
        {
            InitializeComponent();
            //müşteri id bilgisi atama
            MusteriId = MId;
        }

        //form(pencere) yaratma(oluşturma) işlemi ikinci varyant
        //burada müşterinin programının güncellenmesi durumu
        public Form_Program(int MId,bool Gun)
        {
            InitializeComponent();
            //müşteri id bilgisi atama
            MusteriId = MId;
            //müşteri gün verisi var ise güncelleme işlemi söz konusu olduğu için güncelleme değişkenine atama
            Guncelleme = Gun;
        }

        //veritabanı sınıfından yeni nesne üretme
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();


        //müşteriye ait bilgileri listelemek için fonksiyon
        private void Listele()
        {
            //-> müşteri bilgilerini gerekli alanlara doldurma
            txt_Id.Text = MusteriId.ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(MusteriId)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(MusteriId)[2].ToString();
            //<- müşteri bilgilerini gerekli alanlara doldurma
        }

        //program bilgisi listelemek için fonksiyon
        private void Program_Bilgi(int MusteriId)
        {
            //-> müşteriye ait çalışma programı bilgilerini gerekli alanlara doldurma
            txt_Alan.Text = veritabani.Program_Bilgi(MusteriId)[0].ToString();
            txt_Antrenman.Text = veritabani.Program_Bilgi(MusteriId)[1].ToString();
            txt_Diyet.Text = veritabani.Program_Bilgi(MusteriId)[2].ToString();
            chb_Pazartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[3]);
            chb_Sali.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[4]);
            chb_Carsamba.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[5]);
            chb_Persembe.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[6]);
            chb_Cuma.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[7]);
            chb_Cumartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[8]);
            //<- müşteriye ait çalışma programı bilgilerini gerekli alanlara doldurma

        }

        //program formu(pencere) yüklendiği(açılma) anında yapılacak işlemler
        private void Form_Program_Load(object sender, EventArgs e)
        {
            //müşteri bilgisi listeleme
            Listele();
            //eğer güncelleme işlemi ise
            if (Guncelleme)
            {
                //program bilgisi listeleme
                Program_Bilgi(MusteriId);
                //kaydet butonu metni değiştirme
                btn_Kaydet.Text = "GÜNCELLE";
                //başlık label metni değiştirme
                lb_Title.Text = "GÜNCELLEME";
            }
                
        }

        //kapat butonu tıklama
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            //bu form(pencere) kapatma
            this.Close();
        }
        //program ekleme fonksiyonu
        private void Ekle()
        {
            //program ekleme işlemi başarılı ise
            if (veritabani.Program_Ekle(MusteriId, txt_Alan.Text, txt_Antrenman.Text, txt_Diyet.Text, chb_Pazartesi.Checked, chb_Sali.Checked,
               chb_Carsamba.Checked, chb_Persembe.Checked, chb_Cuma.Checked, chb_Cumartesi.Checked))
            {
                //bilgilendirme mesaj kutusu
                MessageBox.Show("Program eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bu form(pencere) kapatma
                this.Close();
            }
            //hata durumu ise
            else
            {
                //bilgi vermek için mesaj kutusu oluşturma
                MessageBox.Show("Program kaydı başarısız !!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //program güncelleme işlemi için fonksiyon
        private void Guncelle()
        {
            //program güncelleme işlemi başarılı ise
            if (veritabani.Program_Guncelle(MusteriId, txt_Alan.Text, txt_Antrenman.Text, txt_Diyet.Text, chb_Pazartesi.Checked, chb_Sali.Checked,
             chb_Carsamba.Checked, chb_Persembe.Checked, chb_Cuma.Checked, chb_Cumartesi.Checked))
            {
                //bilgilendirme için mesaj kutusu
                MessageBox.Show("Program güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bu fomr(pencere) kapatma
                this.Close();
                
            }
            //hata durumu ise
            else
            {
                //bilgilendirme amaçlı mesaj kutusu oluşturma
                MessageBox.Show("Program güncelleme başarısız !!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kaydet butonu tıklama 
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //eğer gerekli alanlar doldurulmamış ise
            if(!(txt_Alan.Text != "" && txt_Antrenman.Text != "" && txt_Diyet.Text != ""))
            {
                //uyarı amaçlı mesaj kutusu
                MessageBox.Show("Gerekli alanları doldurunuz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //işlem sonlandırma
                return;
            }
            //güncelleme yapılacaksa
            if (Guncelleme)
                //güncelleme fonksiyonu çağırma
                Guncelle();
            //ekleme işlemi yapılacaksa
            else
                //ekleme fonkssiyonu çağırma
                Ekle();
           
        }
    }
}
