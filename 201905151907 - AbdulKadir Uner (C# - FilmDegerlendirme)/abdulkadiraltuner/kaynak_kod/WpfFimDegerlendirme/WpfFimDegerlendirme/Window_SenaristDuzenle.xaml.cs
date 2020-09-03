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
    /// Interaction logic for Window_SenaristDuzenle.xaml
    /// </summary>
    /// 

    public partial class Window_SenaristDuzenle : Window
    {
        public Window_SenaristDuzenle()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        public int SenaristId;
        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.SenaristGuncelle(SenaristId, txtSenarist_AdSoyad.Text, dtSenarist_DogumTarihi.Text, txtSenarist_DogumYeri.Text, dtSenarist_OlumTarihi.Text, txtSenarist_Hakkinda.Text))
            {
                MessageBox.Show("Güncellendi");
                this.Close();
            }else
            {
                MessageBox.Show("Hata");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Senarist Where Id='" + SenaristId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtSenarist_AdSoyad.Text = oku["AdiSoyadi"].ToString();
                dtSenarist_DogumTarihi.Text = oku["DogumTarihi"].ToString();
                txtSenarist_DogumYeri.Text = oku["DogumYeri"].ToString();
                dtSenarist_OlumTarihi.Text = oku["OlumTarihi"].ToString();
                txtSenarist_Hakkinda.Text = oku["Hakkinda"].ToString();

            }
            oku.Close();
            baglanti.Close();
        }
    }
}
