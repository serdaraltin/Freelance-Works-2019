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
    /// Interaction logic for Window_AnaSayfa.xaml
    /// </summary>
    public partial class Window_AnaSayfa : Window
    {
        public Window_AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, RoutedEventArgs e)
        {
            Window_KullaniciGiris kullaniciGiris = new Window_KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }

        private void btnYoneticiGiris_Click(object sender, RoutedEventArgs e)
        {
            Window_YoneticiGiris yoneticiGiris = new Window_YoneticiGiris();
            yoneticiGiris.Show();
            this.Hide();
        }
    }
}
