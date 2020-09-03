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
    /// Interaction logic for Window_FilmTanimDuzenle.xaml
    /// </summary>
    public partial class Window_FilmTanimDuzenle : Window
    {
        public Window_FilmTanimDuzenle()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        public int FilmId;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Film_Tanim Where Id='" + FilmId + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtFilmTanim_Ad.Text = oku["Ad"].ToString();
                txtFilmTanim_Sure.Text = oku["Sure"].ToString();
               
                dtFilmTanim_VizyonTarih.Text = oku["VizyonaGirisTarih"].ToString();
            }
            oku.Close();
            baglanti.Close();

            cbFilmTanim_Kategori.ItemsSource = veritabani.KategoriAdListele();
            cbFilmTanim_Senarist.ItemsSource = veritabani.SenaristAdListele();
            cbFilmTanim_Yonetmen.ItemsSource = veritabani.YonetmenAdListele();
            cbFilmTanim_Kategori.SelectedIndex = 0;
            cbFilmTanim_Senarist.SelectedIndex = 0;
            cbFilmTanim_Yonetmen.SelectedIndex = 0;
        }

        private void btnFilmTanim_Ekle_Click(object sender, RoutedEventArgs e)
        {
            int KategoriID = veritabani.KategoriGetirId(cbFilmTanim_Kategori.Text);
            int SenaristID = veritabani.SenaristGetirId(cbFilmTanim_Senarist.Text);
            int YonetmenID = veritabani.YonetmenGetirId(cbFilmTanim_Yonetmen.Text);


            if (veritabani.FilmTanimGuncelle(FilmId,txtFilmTanim_Ad.Text, txtFilmTanim_Sure.Text, KategoriID, SenaristID, YonetmenID, dtFilmTanim_VizyonTarih.Text))
            {
                MessageBox.Show("Film Güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
