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
    /// Interaction logic for Window_KategoriDuzenle.xaml
    /// </summary>
    public partial class Window_KategoriDuzenle : Window
    {
        public Window_KategoriDuzenle()
        {
            InitializeComponent();
          
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source="+SunucuBilgi.Default.Sunucu+"; initial Catalog="+SunucuBilgi.Default.VeriTabani+"; Integrated Security=true");
        public int KategoriId;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Kategori Where Id='" + KategoriId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAd.Text = oku["KategoriAd"].ToString();
                txtAciklama.Text = oku["Aciklama"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.KategoriGuncelle(KategoriId, txtAd.Text, txtAciklama.Text))
            {
                MessageBox.Show("Kategori Güncellendi");
                this.Close();
            }else
            {
                MessageBox.Show("Kategori Güncellenemedi");
            }
        }

       
    }
}
