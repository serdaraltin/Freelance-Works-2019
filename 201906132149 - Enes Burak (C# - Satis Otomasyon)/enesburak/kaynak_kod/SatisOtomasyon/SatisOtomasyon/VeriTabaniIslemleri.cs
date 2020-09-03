using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SatisOtomasyon
{
    class VeriTabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");

        public void Klasor_Yapilandir(string Yol)
        {
            if (!Directory.Exists(Yol + "/gorsel"))
                Directory.CreateDirectory(Yol + "/gorsel");
            if (!Directory.Exists(Yol + "/gorsel/kullanici"))
                Directory.CreateDirectory(Yol + "/gorsel/kullanici");
            if (!Directory.Exists(Yol + "/gorsel/urun"))
                Directory.CreateDirectory(Yol + "/gorsel/urun");
            if (!Directory.Exists(Yol + "/gorsel/marka"))
                Directory.CreateDirectory(Yol + "/gorsel/marka");
        }
        //TEST
        public bool Test()
        {
            try
            {
                baglanti.Open();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }

        //YONETICI
        public bool Yonetici_Kontrol(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
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
        public bool Yonetici_Ekle(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
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
        public bool Yonetici_Guncelle(int Id, int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
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
        public bool Yonetici_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Yonetici_GetirId(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }


        //KULLANICI
        public bool Kullanici_Kontrol(string KullaniciAd)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciKayitKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
                baglanti.Close();
                return false;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Kullanici_Kontrol(string KullaniciAd, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
                baglanti.Close();
                return false;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Kullanici_Ekle(int MusteriId, string KullaniciAd, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
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
        public bool Kullanici_Guncelle(int Id, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGuncelleHesap", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
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
        public bool Kullanici_Guncelle(int Id, int MusteriId, string KullaniciAd, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
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
        public bool Kullanici_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Kullanici_GetirId(string KullaniciAd)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string Kullanici_GetirAd(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGetirAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Ad = null;
                while (oku.Read())
                {
                    Ad = oku["KullaniciAd"].ToString();
                }
                baglanti.Close();
                return Ad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public int Kullanici_GetirMusteriId(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGetirMusteriId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                int MusteriId = 0;
                while (oku.Read())
                {
                    MusteriId = Convert.ToInt32(oku["MusteriId"].ToString());
                }
                baglanti.Close();
                return MusteriId;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //MUSTERI
        public bool Musteri_Kontrol(string KullaniciAd, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
                baglanti.Close();
                return false;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Musteri_Ekle(string Ad, string Soyad, string Cinsiyet, int Yas, string TelefonNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MusteriEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                komut.Parameters.AddWithValue("@Yas", Yas);
                komut.Parameters.AddWithValue("@TelefonNo", TelefonNo);
                komut.Parameters.AddWithValue("@Eposta", Eposta);
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
        public bool Musteri_Guncelle(int Id, string Ad, string Soyad, string Cinsiyet, int Yas, string TelefonNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MusteriGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                komut.Parameters.AddWithValue("@Yas", Yas);
                komut.Parameters.AddWithValue("@TelefonNo", TelefonNo);
                komut.Parameters.AddWithValue("@Eposta", Eposta);
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
        public bool Musteri_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MusteriSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Musteri_GetirId(string Ad, string Soyad, string TelefonNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MusteriGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@TelefonNo", TelefonNo);
                komut.Parameters.AddWithValue("@Eposta", Eposta);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string Musteri_GetirAd(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MusteriGetirAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Ad = null;
                while (oku.Read())
                {
                    Ad = oku["Ad"].ToString();
                    Ad += " " + oku["Soyad"].ToString();
                }
                baglanti.Close();
                return Ad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList Musteri_GetirHesap(int Id)
        {
            try
            {
                baglanti.Open();
                ArrayList Bilgiler = new ArrayList();
                SqlCommand komut = new SqlCommand("MusteriGetirHesap", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    Bilgiler.Add(oku["Ad"].ToString());
                    Bilgiler.Add(oku["Soyad"].ToString());
                    Bilgiler.Add(oku["Cinsiyet"].ToString());
                    Bilgiler.Add(oku["Yas"].ToString());
                    Bilgiler.Add(oku["Ad"].ToString());
                    Bilgiler.Add(oku["TelefonNo"].ToString());
                    Bilgiler.Add(oku["Eposta"].ToString());

                }
                baglanti.Close();
                return Bilgiler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //KATEGORI
        public bool Kategori_Kontrol(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
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
        public bool Kategori_Ekle(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UstKategori", 0);
                komut.Parameters.AddWithValue("@Ad", Ad);
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
        public bool Kategori_Ekle(int UstKategori, string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UstKategori", UstKategori);
                komut.Parameters.AddWithValue("@Ad", Ad);
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
        public bool Kategori_Guncelle(int Id, string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@Ad", Ad);
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
        public bool Kategori_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Kategori_GetirId(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string Kategori_GetirAd(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KategoriGetirAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Ad = null;
                while (oku.Read())
                {
                    Ad = oku["Ad"].ToString();
                }
                baglanti.Close();
                return Ad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList Kategori_Listele()
        {
            try
            {
                baglanti.Open();
                ArrayList Kategoriler = new ArrayList();
                SqlCommand komut = new SqlCommand("KategoriListele", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Kategoriler.Add(oku["Ad"].ToString());
                }
                baglanti.Close();
                return Kategoriler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //MARKA
        public bool Marka_Kontrol(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
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
        public bool Marka_Ekle(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
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
        public bool Marka_Guncelle(int Id, string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@Ad", Ad);
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
        public bool Marka_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Marka_GetirId(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string Marka_GetirAd(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("MarkaGetirAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Ad = null;
                while (oku.Read())
                {
                    Ad = oku["Ad"].ToString();
                }
                baglanti.Close();
                return Ad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList Marka_Listele()
        {
            try
            {
                baglanti.Open();
                ArrayList Markalar = new ArrayList();
                SqlCommand komut = new SqlCommand("MarkaListele", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Markalar.Add(oku["Ad"].ToString());
                }
                baglanti.Close();
                return Markalar;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //URUN
        public bool Urun_Kontrol(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
                baglanti.Close();
                return false;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Urun_Ekle(int KategoriId, int MarkaId, string Miktar, string Olcu, string Ad, float Fiyat, string Aciklama)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KategoriId", KategoriId);
                komut.Parameters.AddWithValue("@MarkaId", MarkaId);
                komut.Parameters.AddWithValue("@Miktar", Miktar);
                komut.Parameters.AddWithValue("@Olcu", Olcu);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Fiyat", Fiyat);
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
        public bool Urun_Guncelle(int Id, int KategoriId, int MarkaId, float Miktar, string Olcu, string Ad, float Fiyat, string Aciklama)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@KategoriId", KategoriId);
                komut.Parameters.AddWithValue("@MarkaId", MarkaId);
                komut.Parameters.AddWithValue("@Miktar", Miktar);
                komut.Parameters.AddWithValue("@Olcu", Olcu);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Fiyat", Fiyat);
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
        public bool Urun_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Urun_GetirId(string Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", Ad);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string Urun_GetirAd(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunGetirAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Ad = null;
                while (oku.Read())
                {
                    Ad = oku["Ad"].ToString();
                }
                baglanti.Close();
                return Ad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public string Urun_GetirOlcu(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunGetirOlcu", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                string Olcu = null;
                while (oku.Read())
                {
                    Olcu = oku["Olcu"].ToString();
                }
                baglanti.Close();
                return Olcu;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList Urun_GetirBilgi(int Id)
        {
            
                baglanti.Open();
               
                SqlCommand komut = new SqlCommand("UrunGetirBilgi", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                ArrayList urun = new ArrayList();
                while (oku.Read())
                {

                    urun.Add(oku["Ad"].ToString());
                    urun.Add(Kategori_GetirAd(Convert.ToInt32(oku["KategoriId"].ToString())));
                    urun.Add(Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                    urun.Add(oku["Miktar"].ToString());
                    urun.Add(oku["Fiyat"].ToString());

                }

                baglanti.Close();
                return urun;
         
        }
        public ArrayList Urun_Listele()
        {

            baglanti.Open();
            ArrayList Urunler = new ArrayList();
            SqlCommand komut = new SqlCommand("Select *From URUN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ArrayList urun = new ArrayList();
                urun.Add(oku["Ad"].ToString());
                urun.Add(Kategori_GetirAd(Convert.ToInt32(oku["KategoriId"].ToString())));
                urun.Add(Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                urun.Add(oku["Miktar"].ToString());
                urun.Add(oku["Fiyat"].ToString());

                Urunler.Add(urun);
            }

            baglanti.Close();
            return Urunler;
        }
        public ArrayList Urun_AdListele()
        {

            baglanti.Open();
            ArrayList Urunler = new ArrayList();
            SqlCommand komut = new SqlCommand("Select *From URUN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Urunler.Add(oku["Ad"].ToString());
            }

            baglanti.Close();
            return Urunler;
        }
        public ArrayList Urun_MiktarListele()
        {
            try
            {
                baglanti.Open();
                ArrayList Miktarlar = new ArrayList();
                SqlCommand komut = new SqlCommand("UrunMiktarListele", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Miktarlar.Add(oku["Miktar"].ToString());
                }
                baglanti.Close();
                return Miktarlar;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //STOK
        public bool Stok_Ekle(int UrunId, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("StokEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);

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
        public bool Stok_Guncelle(int Id, int UrunId, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("StokGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);

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
        public bool Stok_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("StokSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Stok_GetirAdet(int UrunId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("StokGetirAdet", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                SqlDataReader oku = komut.ExecuteReader();
                int Adet = 0;
                while (oku.Read())
                {
                    Adet = Convert.ToInt32(oku["Adet"].ToString());
                }
                baglanti.Close();
                return Adet;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //SEPET
        public bool Sepet_Kontrol(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
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
        public bool Sepet_Ekle(int KullaniciId, int UrunId, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);

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
        public bool Sepet_Guncelle(int Id, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetAdetGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@Adet", Adet);
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
        public bool Sepet_Guncelle(int Id, int UrunId, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);

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
        public bool Sepet_Guncelle(int Id, int KullaniciId, int UrunId, int Adet)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@Adet", Adet);

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
        public bool Sepet_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Sepet_GetirAdet(int KullaniciId, int UrunId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetGetirAdet", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                SqlDataReader oku = komut.ExecuteReader();
                int Adet = 0;
                while (oku.Read())
                {
                    Adet = Convert.ToInt32(oku["Adet"].ToString());
                }
                baglanti.Close();
                return Adet;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public int Sepet_GetirId(int KullaniciId, int UrunId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SepetGetirId", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //SIPARIS
        public bool Siparis_Ekle(int KullaniciId, int UrunId, int Adet, DateTime Tarih)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SiparisEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);
                komut.Parameters.AddWithValue("@Tarih", Tarih);

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
        public bool Siparis_Ekle(int Id, int KullaniciId, int UrunId, int Adet, DateTime Tarih)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SiparisGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                komut.Parameters.AddWithValue("@KullaniciId", UrunId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@Adet", Adet);
                komut.Parameters.AddWithValue("@Tarih", Tarih);

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
        public bool Siparis_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SiparisSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
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
        public int Siparis_GetirTarih(int KullaniciId, int UrunId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SiparisGetirTarih", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                SqlDataReader oku = komut.ExecuteReader();
                int Id = 0;
                while (oku.Read())
                {
                    Id = Convert.ToInt32(oku["Id"].ToString());
                }
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
    }
}
