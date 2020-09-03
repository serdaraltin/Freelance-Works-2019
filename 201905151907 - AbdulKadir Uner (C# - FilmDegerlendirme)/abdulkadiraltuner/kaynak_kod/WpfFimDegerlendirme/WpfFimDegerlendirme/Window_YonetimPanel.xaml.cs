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
using System.Collections;

namespace WpfFimDegerlendirme
{
    /// <summary>
    /// Interaction logic for Window_YonetimPanel.xaml
    /// </summary>
    /// 
     

    public partial class Window_YonetimPanel : Window
    {
        public Window_YonetimPanel()
        {
            InitializeComponent();
        }
        VeriTabaniIslem veritabani = new VeriTabaniIslem();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        DataSet kategoriDataSet;
        DataSet senaristDataSet;
        DataSet yonetmenDataSet;
        DataSet filmtanimDataSet;
        private void KategoriListele()
        {
            baglanti.Open();
            kategoriDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Kategori",baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(kategoriDataSet);
            this.dataGrid_Kategori.ItemsSource = kategoriDataSet.Tables[0].DefaultView;
            baglanti.Close();


            cbFilmTanim_Kategori.ItemsSource = veritabani.KategoriAdListele();
            cbFilmTanim_Kategori.SelectedIndex = 0;
        }
        private void SenaristListele()
        {
            baglanti.Open();
            senaristDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Senarist", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(senaristDataSet);
            this.dataGrid_Senarist.ItemsSource = senaristDataSet.Tables[0].DefaultView;
            baglanti.Close();


            cbFilmTanim_Senarist.ItemsSource = veritabani.SenaristAdListele();
            cbFilmTanim_Senarist.SelectedIndex = 0;
        }
        private void YonetmenListele()
        {
            baglanti.Open();
            yonetmenDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Yonetmen", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(yonetmenDataSet);
            this.dataGrid_Yonetmen.ItemsSource = yonetmenDataSet.Tables[0].DefaultView;
            baglanti.Close();


            cbFilmTanim_Yonetmen.ItemsSource = veritabani.YonetmenAdListele();
            cbFilmTanim_Yonetmen.SelectedIndex = 0;
        }
        private void FilmTanimlariListele()
        {
            baglanti.Open();
            filmtanimDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Film_Tanim", baglanti);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(filmtanimDataSet);
            this.dataGrid_FilmTanim.ItemsSource = filmtanimDataSet.Tables[0].DefaultView;
            baglanti.Close();
        }
        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            KategoriListele();
            SenaristListele();
            YonetmenListele();
            FilmTanimlariListele();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.KategoriEkle(txtKategori_Ad.Text, txtKategori_Aciklama.Text))
            {
                MessageBox.Show("Kategori eklendi");
                KategoriListele();
            }else
            {
                MessageBox.Show("Kategori eklenemedi !!!");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int Id= Convert.ToInt32(kategoriDataSet.Tables[0].Rows[dataGrid_Kategori.SelectedIndex]["Id"].ToString());
            if (veritabani.KategoriSil(Id))
            {
                MessageBox.Show("Kategori Silindi");
                KategoriListele();
            }else
            {
                MessageBox.Show("Kategori Silinemedi");
                KategoriListele();
            }
        }

        private void btn_KategoriDuzenle_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(kategoriDataSet.Tables[0].Rows[dataGrid_Kategori.SelectedIndex]["Id"].ToString());
            Window_KategoriDuzenle kategoriDuzenle = new Window_KategoriDuzenle();
            kategoriDuzenle.KategoriId = Id;
            kategoriDuzenle.ShowDialog();
        }

        private void btn_KategoriYenile_Click(object sender, RoutedEventArgs e)
        {
            KategoriListele();
    
        }

        private void btnSenarist_Ekle_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.SenaristEkle(txtSenarist_AdSoyad.Text, dtSenarist_DogumTarihi.Text, txtSenarist_DogumYeri.Text, dtSenarist_OlumTarihi.Text, txtSenarist_Hakkinda.Text))
            {
                MessageBox.Show("Senarist Eklendi");
                SenaristListele();
            }else
            {
                MessageBox.Show("Senarist Eklenemedi");
            }
        }

        private void btnSenarist_Yenile_Click(object sender, RoutedEventArgs e)
        {
            SenaristListele();
        }

        private void btnSenarist_Sil_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(senaristDataSet.Tables[0].Rows[dataGrid_Senarist.SelectedIndex]["Id"].ToString());
            if (veritabani.SenaristSil(Id))
            {
                MessageBox.Show("Senarist Silindi");
                SenaristListele();
            }
            else
            {
                MessageBox.Show("Senarist Silinemedi");
                SenaristListele();
            }
        }

        private void btnSenarist_Duzenle_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(senaristDataSet.Tables[0].Rows[dataGrid_Senarist.SelectedIndex]["Id"].ToString());

            Window_SenaristDuzenle senaristDuzenle = new Window_SenaristDuzenle();
            senaristDuzenle.SenaristId = Id;
            senaristDuzenle.ShowDialog();
        }

        private void btnYonetmenYenile_Click(object sender, RoutedEventArgs e)
        {
            FilmTanimlariListele();
        }

        private void btnYonetmenEkle_Click(object sender, RoutedEventArgs e)
        {
            if (veritabani.YonetmenEkle(txtYonetmen_AdSoyad.Text, dtYonetmen_DogumTarihi.Text, txtYonetmen_DogumYeri.Text, dtYonetmen_OlumTarihi.Text, txtYonetmen_Hakkinda.Text))
            {
                MessageBox.Show("Yonetmen Eklendi");
                YonetmenListele();
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }

        private void btnYonetmenDuzenle_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(yonetmenDataSet.Tables[0].Rows[dataGrid_Yonetmen.SelectedIndex]["Id"].ToString());

            Window_YonetmenDızenle yonetmentDuzenle = new Window_YonetmenDızenle();
            yonetmentDuzenle.YonetmenId = Id;
            yonetmentDuzenle.ShowDialog();
        }

        private void btnFilmTanim_Ekle_Click(object sender, RoutedEventArgs e)
        {
            int KategoriID = veritabani.KategoriGetirId(cbFilmTanim_Kategori.Text);
            int SenaristID = veritabani.SenaristGetirId(cbFilmTanim_Senarist.Text);
            int YonetmenID = veritabani.YonetmenGetirId(cbFilmTanim_Yonetmen.Text);


            if (veritabani.FilmTanimEkle(txtFilmTanim_Ad.Text,txtFilmTanim_Sure.Text,KategoriID,SenaristID,YonetmenID,dtFilmTanim_VizyonTarih.Text))
            {
                MessageBox.Show("Film Eklendi");
                FilmTanimlariListele();
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }

        private void btnFilmTanim_Duzenle_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(filmtanimDataSet.Tables[0].Rows[dataGrid_FilmTanim.SelectedIndex]["Id"].ToString());

            Window_FilmTanimDuzenle filmtanimDuzenle = new Window_FilmTanimDuzenle();
            filmtanimDuzenle.FilmId = Id;
            filmtanimDuzenle.ShowDialog();
        }
    }
}
