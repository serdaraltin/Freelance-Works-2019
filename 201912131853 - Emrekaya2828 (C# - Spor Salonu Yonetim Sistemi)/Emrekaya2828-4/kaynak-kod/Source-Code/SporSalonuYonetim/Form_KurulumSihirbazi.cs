using System;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_KurulumSihirbazi : Form
    {
        public Form_KurulumSihirbazi()
        {
            InitializeComponent();
        }
        
        //veritabanı sınıfından yeni bir nesne üretiliyor
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        //müşteri id bilgisini tutmak için değişken
        int MusteriId;

        //küçült butonu tıklama
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            //pencere küçültme işlemi
            this.WindowState = FormWindowState.Minimized;
        }

        //boş
        private void Form_KurulumSihirbazi_Load(object sender, EventArgs e)
        {          
        }

        //devam et butonu tıklama
        private void btn_DevamEt_Click(object sender, EventArgs e)
        {
            //veritabanına Tc No,Ad gibi bilgiler ekleniyor
            if (veritabani.Musteri_Ekle(txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text, 
                txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value),txt_Adres.Text))
            {
                //ekleme işlemi sonrasında müşteri id bilgisi değişkene atanıyor
                MusteriId = veritabani.Musteri_GetirId(txt_TcNo.Text);
                //ikinci aşama için birinci bölme gizleniyor ve ikinci bölme görünür yapılıyor
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                //hata durumunda bilgi kutucuğu oluşturuluyor
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bitir butonu tıklama
        private void btn_Bitir_Click(object sender, EventArgs e)
        {
            //parola bilgisi iki kere doğru girilmiş ise
            if(txt_Parola.Text == txt_ParolaTekrar.Text)
            {
                //kullanıcıya ait id bilgisi alınıyor
                int kullaniciId = veritabani.Kullanici_GetirId(txt_KullaniciAd.Text);

                //eğer kullanıcı id bilgisi 0 ise
                if (kullaniciId == 0)
                {
                    //veritabanına kullanıcı ekleniyor
                    if (veritabani.Kullanici_Ekle(MusteriId, txt_KullaniciAd.Text, txt_Parola.Text))
                    {
                        //kullanıcı id bilgisi alınıyor
                        kullaniciId = veritabani.Kullanici_GetirId(txt_KullaniciAd.Text);
                        //eklenen kullanıcı yonetici olarak kayıt ediliyor
                        veritabani.Yonetici_Ekle(kullaniciId);
                        //bilgilendirme için mesaj kutusu oluşturuluyor
                        MessageBox.Show("Kurulum işlemi tamamlandı\nYeninden başlatılacak...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //program yeniden başlatılıyor
                        Application.Restart();
                    }
                    else
                    {
                        //hata durumunda bilgi için mesaj kutusu oluşturuluyor
                        MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //aynı kullanıcı adı varsa bilgi veriliyor
                    MessageBox.Show("Kullanıcı adı alınmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //parola hatalı ise bilgi veriliyor
                MessageBox.Show("Parola uyuşmuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
