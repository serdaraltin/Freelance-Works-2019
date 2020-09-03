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
    /// Interaction logic for Window_KullaniciGiris.xaml
    /// </summary>
    public partial class Window_KullaniciGiris : Window
    {
        public Window_KullaniciGiris()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        private void btnGirisYap_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.KullaniciGiris(txtKullaniciAdi.Text, pwSifre.Password))
            {
                Window_KullaniciPanel kullaniciPanel = new Window_KullaniciPanel();
                kullaniciPanel.KullaniciId = veritabani.KullaniciGetirId(txtKullaniciAdi.Text);
                kullaniciPanel.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("KullaniciAdi veya Sifre Hatali", "UYARI");
            }
        }
    }
}
