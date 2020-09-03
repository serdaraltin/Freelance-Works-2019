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
    /// Interaction logic for Window_PuanVer.xaml
    /// </summary>
    public partial class Window_PuanVer : Window
    {
        public Window_PuanVer()
        {
            InitializeComponent();
        }
        public int FilmId,KullaniciId;
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        private void btnGonder_Click(object sender, RoutedEventArgs e)
        {
            veritabani.FilmPuanVer(KullaniciId, FilmId, Convert.ToInt32(cbPuan.Text));
            MessageBox.Show("Puanınız işlendi");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtFilmAdi.Text = veritabani.FilmGetirAd(FilmId);
        }

      }
}
