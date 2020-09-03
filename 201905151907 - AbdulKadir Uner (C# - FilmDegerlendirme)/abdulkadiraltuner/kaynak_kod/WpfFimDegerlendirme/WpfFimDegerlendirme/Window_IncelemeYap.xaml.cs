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
    /// Interaction logic for Window_IncelemeYap.xaml
    /// </summary>
    public partial class Window_IncelemeYap : Window
    {
        public Window_IncelemeYap()
        {
            InitializeComponent();
        }
        public int FilmId, KullaniciId;
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtFilmAdi.Text = veritabani.FilmGetirAd(FilmId);
        }

        private void btnGonder_Click(object sender, RoutedEventArgs e)
        {
            veritabani.FilmIncelemeYap(KullaniciId, FilmId, txtFilmInceleme.Text);
            MessageBox.Show("İncelemeniz Eklendi");
            this.Close();
        }

        
    }
}
