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
using System.Data;


namespace WpfFimDegerlendirme
{
    /// <summary>
    /// Interaction logic for Window_KullaniciPanel.xaml
    /// </summary>
    public partial class Window_KullaniciPanel : Window
    {
        public Window_KullaniciPanel()
        {
            InitializeComponent();
        }
        public int KullaniciId;

        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        DataSet filmDataSet;
        DataSet filmAramaDataSet;
        private void FilmListele()
        {
            baglanti.Open();
            filmDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Film_Tanim", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(filmDataSet);
            

            this.dataGrid_Film.ItemsSource = filmDataSet.Tables[0].DefaultView;
            baglanti.Close();
        }

        private void FilmArama(string FilmAdi)
        {
            baglanti.Open();
            filmAramaDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Film_Tanim Where Ad like '%"+FilmAdi+"%'", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(filmAramaDataSet);


            this.dataGrid_Film.ItemsSource = filmAramaDataSet.Tables[0].DefaultView;
            baglanti.Close();

        }
        private void SenaristArama(int SenaristID)
        {
            baglanti.Open();
            filmAramaDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Film_Tanim Where SenaristID like '%" + SenaristID + "%'", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(filmAramaDataSet);


            this.dataGrid_Film.ItemsSource = filmAramaDataSet.Tables[0].DefaultView;
            baglanti.Close();

        }
        private void YonetmenArama(int SenaristID)
        {
            baglanti.Open();
            filmAramaDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Film_Tanim Where YonetmenID like '%" + SenaristID + "%'", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(filmAramaDataSet);


            this.dataGrid_Film.ItemsSource = filmAramaDataSet.Tables[0].DefaultView;
            baglanti.Close();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lb_Hosgeldiniz.Content= "Hoşgeldiniz "+veritabani.KullaniciGetirAdSoyad(KullaniciId);
            FilmListele();
        }

        private void btnFilmAra_Click(object sender, RoutedEventArgs e)
        {
            FilmArama(txtFilmAra.Text);
        }

        private void btnSenaristAra_Click(object sender, RoutedEventArgs e)
        {
            SenaristArama(veritabani.SenaristGetirId(txtSenaristAra.Text));
        }

        private void btnYonetmenAra_Click(object sender, RoutedEventArgs e)
        {
            YonetmenArama(veritabani.YonetmenGetirId(txtYonetmenAra.Text));
        }

        private void dataGrid_Film_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Id = Convert.ToInt32(filmDataSet.Tables[0].Rows[dataGrid_Film.SelectedIndex]["Id"].ToString());

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Film_Tanim Where Id='" + Id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtFilm_Ad.Text = oku["Ad"].ToString();
                txtFilm_Sure.Text = oku["Sure"].ToString();
                txtFilm_Kategori.Text = veritabani.KategoriGetirAd(Convert.ToInt32(oku["Kategori"].ToString()));
                txtFilm_Senarist.Text = veritabani.SenaristGetirAd(Convert.ToInt32(oku["SenaristID"].ToString()));
                txtFilm_Yonetmen.Text = veritabani.YonetmenGetirAd(Convert.ToInt32(oku["YonetmenID"].ToString()));
                txtFilm_Vizyon.Text = oku["VizyonaGirisTarih"].ToString();
            }
            baglanti.Close();
            txtFilm_Izlenme.Text = veritabani.FilmGetirIzlenme(Id).ToString();
            txtFilm_Puan.Text = veritabani.FilmGetirPuan(Id).ToString();
            txtFilm_Inceleme.Text = veritabani.FilmGetirInceleme(Id).ToString();

        }

        private void btnIzle_Click(object sender, RoutedEventArgs e)
        {
            int FilmId = Convert.ToInt32(filmDataSet.Tables[0].Rows[dataGrid_Film.SelectedIndex]["Id"].ToString());
            veritabani.FilmIzle(KullaniciId, FilmId);

        }

        private void btnPuanla_Click(object sender, RoutedEventArgs e)
        {
            Window_PuanVer puanver = new Window_PuanVer();
            puanver.KullaniciId = this.KullaniciId;
            puanver.FilmId = Convert.ToInt32(filmDataSet.Tables[0].Rows[dataGrid_Film.SelectedIndex]["Id"].ToString());
            puanver.ShowDialog();
        }

        private void btnYorumYap_Click(object sender, RoutedEventArgs e)
        {
            Window_IncelemeYap incelemeyap = new Window_IncelemeYap();
            incelemeyap.KullaniciId = this.KullaniciId;
            incelemeyap.FilmId = Convert.ToInt32(filmDataSet.Tables[0].Rows[dataGrid_Film.SelectedIndex]["Id"].ToString());
            incelemeyap.ShowDialog();
        }

        private void btnHesapAyarlari_Loaded(object sender, RoutedEventArgs e)
        {
        
        }

        private void btnHesapAyarlari_Click(object sender, RoutedEventArgs e)
        {
            Window_KullaniciHesapAyarlari hesapAyarlari = new Window_KullaniciHesapAyarlari();
            hesapAyarlari.KullaniciId = this.KullaniciId;
            hesapAyarlari.Show();
        }

        private void btnCikisYap_Click(object sender, RoutedEventArgs e)
        {
            Window_KullaniciGiris kullaniciGiris = new Window_KullaniciGiris();
            kullaniciGiris.Show();
            this.Close();
        }

        private void btnPopulerFilmler_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
