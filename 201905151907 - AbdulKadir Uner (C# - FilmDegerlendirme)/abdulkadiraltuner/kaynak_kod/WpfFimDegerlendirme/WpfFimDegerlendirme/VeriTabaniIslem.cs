using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace WpfFimDegerlendirme
{
    class VeriTabaniIslem
    {
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        //YONETICI ISLEMLERI
        public bool YoneticiGiris(string kullaniciadi, string sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Yonetici Where KullaniciAdi='" + kullaniciadi + "' AND Sifre='" + sifre + "'", baglanti);
                SqlDataReader datareader = komut.ExecuteReader();
                if (datareader.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }

            }
            catch
            {
                baglanti.Close();
                return false;
            }

        }

        //KULLANICI ISLEMLERI
        public bool KullaniciEkle(string AdSoyad, string KullaniciAdi, string EpostaAdresi, string DogumTarihi, string Sifre, string Cinsiyet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Kullanici (AdSoyad,KullaniciAdi,EpostaAdresi,DogumTarihi,Sifre,Cinsiyet) Values(@AdSoyad,@KullaniciAdi,@EpostaAdresi,@DogumTarihi,@Sifre,@Cinsiyet)", baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                komut.Parameters.AddWithValue("@EpostaAdresi", EpostaAdresi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
               
                komut.ExecuteNonQuery();
                baglanti.Close();
           
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciGuncelle(int KullaniciId, string AdSoyad, string EpostaAdresi, string DogumTarihi, string Sifre, string Cinsiyet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Kullanici set AdSoyad=@AdSoyad,EpostaAdresi=@EpostaAdresi,DogumTarihi=@DogumTarihi,Sifre=@Sifre,Cinsiyet=@Cinsiyet Where Id='" + KullaniciId+"'", baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@EpostaAdresi", EpostaAdresi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciSorgula(string KullaniciAdi)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Kullanici Where KullaniciAdi='" + KullaniciAdi + "'", baglanti);
                SqlDataReader datareader = komut.ExecuteReader();
                if (datareader.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciGiris(string KullaniciAdi, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Kullanici Where KullaniciAdi='" + KullaniciAdi + "' AND Sifre='" + Sifre + "'", baglanti);
                SqlDataReader datareader = komut.ExecuteReader();
                if (datareader.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }

            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public string KullaniciResim(string KullaniciAdi)
        {
            try
            {
                string Resim = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Kullanici Where KullaniciAdi='" + KullaniciAdi + "'", baglanti);
                SqlDataReader datareader = komut.ExecuteReader();
                while (datareader.Read())
                    Resim = datareader["Resim"].ToString();
                datareader.Close();
                baglanti.Close();
                return Resim;
            }
            catch
            {
                baglanti.Close();
                return "";
            }
        }
        public string KullaniciGetirAdSoyad(int Id)
        {
            try
            {
                string KullaniciAdSoyad=null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kullanici Where Id='" + Id + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KullaniciAdSoyad = oku["AdSoyad"].ToString();
                
                baglanti.Close();
                return KullaniciAdSoyad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public int KullaniciGetirId(string kullaniciAdi)
        {
            try
            {
                int KullaniciId = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kullanici Where KullaniciAdi='" + kullaniciAdi + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KullaniciId = Convert.ToInt32(oku["Id"].ToString());

                baglanti.Close();
                return KullaniciId;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //KATEGORI ISLEMLERI
        public ArrayList KategoriAdListele()
        {
            try
            {
          
                    
                baglanti.Open();

                ArrayList dizi = new ArrayList();

                SqlCommand komut = new SqlCommand("Select * From Kategori", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    dizi.Add(oku["KategoriAd"].ToString());
                baglanti.Close();
                return dizi;               
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool KategoriEkle(string KategoriAd, string Aciklama)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Kategori (KategoriAd,Aciklama) Values(@KategoriAd,@Aciklama)", baglanti);
                komut.Parameters.AddWithValue("@KategoriAd", KategoriAd);
                komut.Parameters.AddWithValue("@Aciklama", Aciklama);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KategoriSil(int Id)
        {
           try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Kategori Where Id='" + Id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KategoriGuncelle(int Id, string KategoriAd, string Aciklama)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Kategori set KategoriAd=@KategoriAd,Aciklama=@Aciklama Where Id='" + Id + "'", baglanti);
                komut.Parameters.AddWithValue("@KategoriAd", KategoriAd);
                komut.Parameters.AddWithValue("@Aciklama", Aciklama);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public int KategoriGetirId(string Ad)
        {
            try
            {
                int KategoriID = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kategori Where KategoriAd='" + Ad + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KategoriID = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();

                return KategoriID;
            }   
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string KategoriGetirAd(int Id)
        {
            try
            {
                string KategoriAd = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kategori Where Id='" + Id + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KategoriAd = oku["KategoriAd"].ToString();
                baglanti.Close();

                return KategoriAd;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //SENARIST ISLEMLERI
        public ArrayList SenaristAdListele()
        {
            try
            {
                baglanti.Open();
 
                ArrayList dizi = new ArrayList();

                SqlCommand komut = new SqlCommand("Select * From Senarist", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    dizi.Add(oku["AdiSoyadi"].ToString());
                baglanti.Close();
                return dizi;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool SenaristEkle(string AdiSoyadi, string DogumTarihi, string DogumYeri,string OlumTarihi, string Hakkinda)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Senarist (AdiSoyadi,DogumTarihi,DogumYeri,OlumTarihi,Hakkinda) Values(@AdiSoyadi,@DogumTarihi,@DogumYeri,@OlumTarihi,@Hakkinda)", baglanti);
                komut.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
                komut.Parameters.AddWithValue("@OlumTarihi", Convert.ToDateTime(OlumTarihi));
                komut.Parameters.AddWithValue("@Hakkinda", Hakkinda);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool SenaristSil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Senarist Where Id='" + Id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool SenaristGuncelle(int Id, string AdiSoyadi, string DogumTarihi, string DogumYeri, string OlumTarihi, string Hakkinda)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Senarist set AdiSoyadi=@AdiSoyadi,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,OlumTarihi=@OlumTarihi,Hakkinda=@Hakkinda Where Id='" + Id + "'", baglanti);
                komut.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
                komut.Parameters.AddWithValue("@OlumTarihi", Convert.ToDateTime(OlumTarihi));
                komut.Parameters.AddWithValue("@Hakkinda", Hakkinda);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public int SenaristGetirId(string Ad)
        {
            try
            {
                int SenaristID = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Senarist Where AdiSoyadi='" + Ad + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    SenaristID = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();

                return SenaristID;
            }
            catch
            {
                return 0;
            }
        }
        public string SenaristGetirAd(int Id)
        {
            try
            {
                string SenaristAd = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Senarist Where Id='" + Id + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    SenaristAd = oku["AdiSoyadi"].ToString();
                baglanti.Close();

                return SenaristAd;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //YONETMEN ISLEMLERI
        public ArrayList YonetmenAdListele()
        {
            try
            {
                baglanti.Open();

                ArrayList dizi = new ArrayList();

                SqlCommand komut = new SqlCommand("Select * From Yonetmen", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    dizi.Add(oku["AdiSoyadi"].ToString());
                baglanti.Close();
                return dizi;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool YonetmenEkle(string AdiSoyadi, string DogumTarihi, string DogumYeri, string OlumTarihi, string Hakkinda)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Yonetmen (AdiSoyadi,DogumTarihi,DogumYeri,OlumTarihi,Hakkinda) Values(@AdiSoyadi,@DogumTarihi,@DogumYeri,@OlumTarihi,@Hakkinda)", baglanti);
                komut.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
                komut.Parameters.AddWithValue("@OlumTarihi", Convert.ToDateTime(OlumTarihi));
                komut.Parameters.AddWithValue("@Hakkinda", Hakkinda);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool YonetmenSil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Yonetmen Where Id='" + Id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool YonetmenGuncelle(int Id, string AdiSoyadi, string DogumTarihi, string DogumYeri, string OlumTarihi, string Hakkinda)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Yonetmen set AdiSoyadi=@AdiSoyadi,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,OlumTarihi=@OlumTarihi,Hakkinda=@Hakkinda Where Id='" + Id + "'", baglanti);
                komut.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(DogumTarihi));
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
                komut.Parameters.AddWithValue("@OlumTarihi", Convert.ToDateTime(OlumTarihi));
                komut.Parameters.AddWithValue("@Hakkinda", Hakkinda);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public int YonetmenGetirId(string Ad)
        {
            try
            {
                int YonetmenID = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Yonetmen Where AdiSoyadi='" + Ad + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    YonetmenID = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();

                return YonetmenID;
            }
            catch
            {
                return 0;
            }
        }
        public string YonetmenGetirAd(int Id)
        {
            try
            {
                string YonetmenAd = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Yonetmen Where Id='" + Id + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    YonetmenAd = oku["AdiSoyadi"].ToString();
                baglanti.Close();

                return YonetmenAd;
            }
            catch
            {
                return null;
            }
        }

        //FILM TANIM ISLEMLERI
        public bool FilmTanimEkle(string Ad, string Sure, int Kategori, int SenaristID, int YonetmenID, string VizyonaGirisTarih)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Film_Tanim (Ad,Sure,Kategori,SenaristID,YonetmenID,VizyonaGirisTarih) Values(@Ad,@Sure,@Kategori,@SenaristID,@YonetmenID,@VizyonaGirisTarih)", baglanti);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Sure", Sure);
                komut.Parameters.AddWithValue("@Kategori", Kategori);
                komut.Parameters.AddWithValue("@SenaristID", SenaristID);
                komut.Parameters.AddWithValue("@YonetmenID", YonetmenID);
                komut.Parameters.AddWithValue("@VizyonaGirisTarih", Convert.ToDateTime(VizyonaGirisTarih));

                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool FilmTanimSil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Film_Tanim Where Id='" + Id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool FilmTanimGuncelle(int Id, string Ad, string Sure, int Kategori, int SenaristID, int YonetmenID, string VizyonaGirisTarih)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Film_Tanim set Ad=@Ad,Sure=@Sure,Kategori=@Kategori,SenaristID=@SenaristID,YonetmenID=@YonetmenID,VizyonaGirisTarih=@VizyonaGirisTarih Where Id='" + Id + "'", baglanti);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Sure", Sure);
                komut.Parameters.AddWithValue("@Kategori", Kategori);
                komut.Parameters.AddWithValue("@SenaristID", SenaristID);
                komut.Parameters.AddWithValue("@YonetmenID", YonetmenID);
                komut.Parameters.AddWithValue("@VizyonaGirisTarih", Convert.ToDateTime(VizyonaGirisTarih));
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }

        //FILM ISLEMLERI
        public string FilmGetirAd(int FilmId)
        {
            try
            {
                string FilmAd = null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Film_Tanim Where Id='" + FilmId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    FilmAd = oku["Ad"].ToString();
                baglanti.Close();
                return FilmAd;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //IZLEME ISLEMLERI
        public void FilmIzle(int KullaniciId,int FilmId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Film_Izlenme (KullaniciID,FilmID) Values(@KullaniciID,@FilmID)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", KullaniciId);
                komut.Parameters.AddWithValue("@FilmID", FilmId);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch { baglanti.Close(); }
        }
        public int FilmGetirIzlenme(int FilmId)
        {
            try
            {
                int izlenme = 0;
                baglanti.Open();
               
                SqlCommand komut = new SqlCommand("Select Count(*) From Film_Izlenme Where FilmID='" + FilmId + "'", baglanti);
                izlenme = (Int32)komut.ExecuteScalar();
                baglanti.Close();
                return izlenme;
            }
            catch
            {
                return 0;
            }
        }  

        //PUAN ISLEMLERI
        public void FilmPuanVer(int KullaniciId, int FilmId, int Puan)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Film_Puan (KullaniciID,FilmID,Puan) Values(@KullaniciID,@FilmID,@Puan)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", KullaniciId);
                komut.Parameters.AddWithValue("@FilmID", FilmId);
                komut.Parameters.AddWithValue("@Puan", Puan);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch { baglanti.Close(); }
        }
        public int FilmGetirPuan(int FilmId)
        {
            try
            {
                int toplam = 0;
                int puanSayi = 0;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Film_Puan Where FilmID='" + FilmId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplam += Convert.ToInt32(oku["Puan"].ToString());
                    puanSayi += 1;
                }
                baglanti.Close();
                return  toplam / puanSayi;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //INCELEME ISLEMLERI
        public void FilmIncelemeYap(int KullaniciId, int FilmId, string Inceleme)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Film_Inceleme (KullaniciID,FilmID,Inceleme) Values(@KullaniciID,@FilmID,@Inceleme)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", KullaniciId);
                komut.Parameters.AddWithValue("@FilmID", FilmId);
                komut.Parameters.AddWithValue("@Inceleme", Inceleme);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch { baglanti.Close(); }
        }
        public int FilmGetirInceleme(int FilmId)
        {
            try
            {
                int inceleme = 0;
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select Count(*) From Film_Inceleme Where FilmID='" + FilmId + "'", baglanti);
                inceleme = (Int32)komut.ExecuteScalar();
                baglanti.Close();
                return inceleme;
            }
            catch
            {
                return 0;
            }
        }
    }
}
