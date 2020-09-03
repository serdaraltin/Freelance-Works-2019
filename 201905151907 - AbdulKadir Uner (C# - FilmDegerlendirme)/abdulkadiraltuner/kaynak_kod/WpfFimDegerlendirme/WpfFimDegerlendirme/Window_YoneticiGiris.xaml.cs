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
    /// Interaction logic for Window_YoneticiGiris.xaml
    /// </summary>
    public partial class Window_YoneticiGiris : Window
    {
        public Window_YoneticiGiris()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        private void btnGirisYap_Click(object sender, RoutedEventArgs e)
        {
           if (veritabani.YoneticiGiris(txtKullaniciAdi.Text, txtSifre.Text))
            {
               
                Window_YonetimPanel YonetimPanel = new Window_YonetimPanel();
                YonetimPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya Sifre hatali", "HATA");
            }
        }
    }
}
