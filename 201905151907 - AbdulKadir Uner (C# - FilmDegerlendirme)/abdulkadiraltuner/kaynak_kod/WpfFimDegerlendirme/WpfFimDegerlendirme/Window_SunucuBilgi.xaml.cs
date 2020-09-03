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
    /// Interaction logic for Window_SunucuBilgi.xaml
    /// </summary>
    public partial class Window_SunucuBilgi : Window
    {
        public Window_SunucuBilgi()
        {
            InitializeComponent();
        }

        private void brnKaydet_Click(object sender, RoutedEventArgs e)
        {
            SunucuBilgi.Default.Sunucu = txtSunucu.Text;
            SunucuBilgi.Default.VeriTabani = txtVeritabani.Text;
            SunucuBilgi.Default.Save();
            this.Close();
        }
    }
}
