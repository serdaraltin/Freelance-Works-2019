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
    /// Interaction logic for Window_YonetmenDızenle.xaml
    /// </summary>
    public partial class Window_YonetmenDızenle : Window
    {
        public Window_YonetmenDızenle()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        public int YonetmenId;

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.YonetmenGuncelle(YonetmenId, txtYonetmen_AdSoyad.Text, dtYonetmen_DogumTarihi.Text, txtYonetmen_DogumYeri.Text, dtYonetmen_OlumTarihi.Text, txtYonetmen_Hakkinda.Text))
            {
                MessageBox.Show("Güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Yonetmen Where Id='" + YonetmenId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtYonetmen_AdSoyad.Text = oku["AdiSoyadi"].ToString();
                dtYonetmen_DogumTarihi.Text = oku["DogumTarihi"].ToString();
                txtYonetmen_DogumYeri.Text = oku["DogumYeri"].ToString();
                dtYonetmen_OlumTarihi.Text = oku["OlumTarihi"].ToString();
                txtYonetmen_Hakkinda.Text = oku["Hakkinda"].ToString();

            }
            oku.Close();
            baglanti.Close();
        }
    }
}
