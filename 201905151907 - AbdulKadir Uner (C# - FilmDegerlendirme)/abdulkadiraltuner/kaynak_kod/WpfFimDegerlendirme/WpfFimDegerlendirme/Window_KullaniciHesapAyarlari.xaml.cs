using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfFimDegerlendirme
{
    /// <summary>
    /// Interaction logic for Window_KullaniciHesapAyarlari.xaml
    /// </summary>
    public partial class Window_KullaniciHesapAyarlari : Window
    {
        public Window_KullaniciHesapAyarlari()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        public int KullaniciId;
        private void btnKayitOl_Click(object sender, RoutedEventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtEpostaAdresi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Sifreler Uyusmuyor", "UYARI");
                }
                else
                {
                   
                        if (veritabani.KullaniciGuncelle(KullaniciId,txtAdSoyad.Text, txtEpostaAdresi.Text, dtDogumTarihi.Text, txtSifre.Text, cbCinsiyet.Text))
                        {
                            MessageBox.Show("Güncelleme Basarili");
                            Window_KullaniciGiris giris = new Window_KullaniciGiris();
                          // giris.Show();
                        this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hata");
                        }
                   
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanlari doldurunuz", "UYARI");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Kullanici Where Id='"+KullaniciId+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAdSoyad.Text = oku["AdSoyad"].ToString();
                txtEpostaAdresi.Text = oku["EpostaAdresi"].ToString();
                dtDogumTarihi.Text = oku["DogumTarihi"].ToString();
                cbCinsiyet.Text = oku["Cinsiyet"].ToString();
            }
            baglanti.Close();
        }
    }
}
