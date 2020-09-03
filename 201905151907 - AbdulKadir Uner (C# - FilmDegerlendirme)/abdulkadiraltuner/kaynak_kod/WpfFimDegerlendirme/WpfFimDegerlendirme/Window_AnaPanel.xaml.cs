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
    /// Interaction logic for Window_AnaPanel.xaml
    /// </summary>
    public partial class Window_AnaPanel : Window
    {
        public Window_AnaPanel()
        {
            InitializeComponent();
        }

        private void button_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window_YoneticiGiris yoneticiGiris = new Window_YoneticiGiris();
            yoneticiGiris.Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(SunucuBilgi.Default.Sunucu == "")
            {
                Window_SunucuBilgi sunucuBilgi = new Window_SunucuBilgi();
                sunucuBilgi.ShowDialog();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window_KullaniciGiris kullaniciGiris = new Window_KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }
    }
}
