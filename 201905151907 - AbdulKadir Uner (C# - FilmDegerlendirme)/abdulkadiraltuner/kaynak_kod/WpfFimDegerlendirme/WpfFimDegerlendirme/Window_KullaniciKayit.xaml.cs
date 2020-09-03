using Microsoft.Win32;
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

namespace WpfFimDegerlendirme
{
    /// <summary>
    /// Interaction logic for Window_KullaniciKayit.xaml
    /// </summary>
    public partial class Window_KullaniciKayit : Window
    {
        public Window_KullaniciKayit()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        string imageLocation;
        private void btnKayitOl_Click(object sender, RoutedEventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtAdSoyad.Text != "" && txtEpostaAdresi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Sifreler Uyusmuyor", "UYARI");
                }
                else
                {
                    if (!veritabani.KullaniciSorgula(txtKullaniciAdi.Text))
                    {
                        if (veritabani.KullaniciEkle(txtAdSoyad.Text, txtKullaniciAdi.Text, txtEpostaAdresi.Text, dtDogumTarihi.Text, txtSifre.Text, cbCinsiyet.Text))
                        {
                            MessageBox.Show("Kayit Basarili", "KAYIT");
                        }
                        else
                        {
                            MessageBox.Show("Kayit olunamadi", "HATA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanici Adi daha onceden alinmis", "UYARI");
                    }
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanlari doldurunuz", "UYARI");
            }
        }

        private void btnResimSec_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
