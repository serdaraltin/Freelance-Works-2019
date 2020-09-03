using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections;

namespace ApartmanYonetim
{
    class VeriTabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        //YONETICI ISLEMLERI
        public bool YoneticiGiris(int KullaniciId)
        {
            try
            {
                bool kontrol = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                    kontrol = true;
                  
                baglanti.Close();
                return kontrol;

            }
            catch
            {
                return false;
            }
        }
        public bool YoneticiEkle(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId",KullaniciId);
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
        public ArrayList YoneticiListeleAd()
        {
            try
            {
                ArrayList veri = new ArrayList();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("YoneticiCek",baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    veri.Add(Convert.ToInt32(oku["KullaniciId"].ToString()));
                }
                baglanti.Close();

                return veri;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public int YoneticiCekId(int KullaniciId)
        {
            try
            {
                int YoneticiId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From YONETICI Where KullaniciId='" + KullaniciId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    YoneticiId = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return YoneticiId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public int YoneticiCekKullaniciId(int YoneticiId)
        {
            try
            {
                int KullaniciId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From YONETICI Where Id='" + YoneticiId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KullaniciId = Convert.ToInt32(oku["KullaniciId"].ToString());
                baglanti.Close();
                return KullaniciId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }

        //KULLANICI ISLEMLERI
        public bool KullaniciGiris(string KullaniciAd, string Sifre)
        {
            try
            {
                bool durum = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciKontrol", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())        
                        durum = true;
               
                baglanti.Close();
                return durum;
            }
            catch
            {
                return false;
            }
        }
        public int KullaniciCekId(string KullaniciAd)
        {
            try
            {
                int KullaniciId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciCekId",baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read()) 
                    KullaniciId = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return KullaniciId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public string KullaniciCekAd(int KullaniciId)
        {
            try
            {
                string KullaniciAd = null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciCekAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KullaniciAd = oku["KullaniciAd"].ToString();
                baglanti.Close();
                return KullaniciAd;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public string KullaniciCekAdSoyad(int KullaniciId)
        {
            try
            {
                string KullaniciAdSoyad = null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciCekAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
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

        public bool KullaniciKontrol(string KullaniciAd, string Sifre)
        {
            try
            {
                bool durum = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciCekAd", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read()) 
                  durum = true;
                baglanti.Close();
                return durum;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciEkle(string KullaniciAd, string Sifre, string AdSoyad, string MailAdres, string Telefon, DateTime DogumTarih, string Cinsiyet, string MedeniDurum,string Resim, string CalismaYolu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@MailAdres", MailAdres);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@DogumTarih", DogumTarih);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                komut.Parameters.AddWithValue("@MedeniDurum", MedeniDurum);
                komut.ExecuteNonQuery();
                baglanti.Close();

                ResimEkle(KullaniciCekId(KullaniciAd),Resim, CalismaYolu);

                return true;

            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciGuncelle(int KullaniciId, string Sifre, string AdSoyad, string MailAdres, string Telefon, DateTime DogumTarih, string Cinsiyet, string MedeniDurum, string Resim, string CalismaYolu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@MailAdres", MailAdres);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@DogumTarih", DogumTarih);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                komut.Parameters.AddWithValue("@MedeniDurum", MedeniDurum);
                komut.ExecuteNonQuery();
                baglanti.Close();

                ResimGuncelle(KullaniciId, Resim, CalismaYolu);

                return true;

            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool KullaniciSil(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("KullaniciSil", baglanti);
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

        //RESIM ISLEMLERI
        public void ResimEkle(int KullaniciId, string Resim, string CalismaYolu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ResimEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@Ad", KullaniciId);
                komut.ExecuteNonQuery();

                baglanti.Close();
                string ResimDizin = CalismaYolu + "/images";
                if (!File.Exists(ResimDizin))
                    Directory.CreateDirectory(ResimDizin);
                if (Resim != null)
                    File.Copy(Resim, ResimDizin +"/"+ KullaniciId);
                else
                    Properties.Resources.Kullanici.Save(ResimDizin +"/" + KullaniciId);  
            }
            catch
            {
                baglanti.Close();
            }
              
        }
        public void ResimGuncelle(int KullaniciId, string Resim, string CalismaYolu)
        {
            try
            {
                int ResimAd = ResimCekAd(KullaniciId) + 1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ResimGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@Ad", ResimAd);
                komut.ExecuteNonQuery();

                baglanti.Close();
                string ResimDizin = CalismaYolu + "/images";
                if (Resim != null)
                    File.Copy(Resim, ResimDizin + "/" + ResimAd);
             
            }
            catch
            {
                baglanti.Close();
            }

        }
        public int  ResimCekAd(int KullaniciId)
        {
            try
            {
                int ResimAd = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ResimCek", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    ResimAd = Convert.ToInt32(oku["Ad"].ToString());
                
                baglanti.Close();
                return ResimAd;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }

        //APARTMAN ISLEMLERI
        public bool ApartmanEkle(int YoneticiId, string Ad, string ApartmanBlok, int KatSayi, int DaireSayi, float Aidat)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ApartmanEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@YoneticiId", YoneticiId);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@ApartmanBlok", ApartmanBlok);
                komut.Parameters.AddWithValue("@KatSayi", KatSayi);
                komut.Parameters.AddWithValue("@DaireSayi", DaireSayi);
                komut.Parameters.AddWithValue("@Aidat", Aidat);
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
        public bool ApartmanGuncelle(int ApartmanId, int YoneticiId, string Ad, string ApartmanBlok, int KatSayi, int DaireSayi, float Aidat)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ApartmanGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
                komut.Parameters.AddWithValue("@YoneticiId", YoneticiId);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@ApartmanBlok", ApartmanBlok);
                komut.Parameters.AddWithValue("@KatSayi", KatSayi);
                komut.Parameters.AddWithValue("@DaireSayi", DaireSayi);
                komut.Parameters.AddWithValue("@Aidat", Aidat);
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
        public bool ApartmanSil(int AparmantId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ApartmanSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ApartmanId", AparmantId);
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
        public int ApartmanCekId(string Ad)
        {
            try
            {
                int ApartmanId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Ad='" + Ad + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    ApartmanId = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return ApartmanId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public string ApartmanCekAd(int AparmantId)
        {
            try
            {
                string ApartmanAd= null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From APARTMAN Where Id='" + AparmantId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    ApartmanAd = oku["Ad"].ToString();
                baglanti.Close();
                return ApartmanAd;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

        //UYE ISLEMLERI
        public bool UyeEkle(int KullaniciId, int ApartmanId, int KatNo, int DaireNo)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UyeEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
                komut.Parameters.AddWithValue("@KatNo", KatNo);
                komut.Parameters.AddWithValue("@DaireNo", DaireNo);
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
        public bool UyeGuncelle(int UyeId, int ApartmanId, int KatNo, int DaireNo)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UyeGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
                komut.Parameters.AddWithValue("@KatNo", KatNo);
                komut.Parameters.AddWithValue("@DaireNo", DaireNo);
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
        public bool UyeSil(int UyeId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UyeSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyeId", UyeId);            
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
        public bool UyeSorgula(int KullaniciId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where KullaniciId='" + KullaniciId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if(oku.Read())
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
        public int UyeCekId(int KullaniciId)
        {
            try
            {
                int UyeId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where KullaniciId='" + KullaniciId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    UyeId = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return UyeId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public int UyeCekApartman(int UyeId)
        {
            try
            {
                int ApartmanId= -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where Id='"+UyeId+"'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    ApartmanId = Convert.ToInt32(oku["ApartmanId"].ToString());
                baglanti.Close();
                return ApartmanId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public int UyeCekKatNo(int UyeId)
        {
            try
            {
                int Katno = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where Id='" + UyeId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    Katno = Convert.ToInt32(oku["KatNo"].ToString());
                baglanti.Close();
                return Katno;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public int UyeCekDaireNo(int UyeId)
        {
            try
            {
                int DaireNo = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where Id='" + UyeId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    DaireNo = Convert.ToInt32(oku["DaireNo"].ToString());
                baglanti.Close();
                return DaireNo;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public int UyeCekKullaniciId(int UyeId)
        {
            try
            {
                int KullaniciId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From UYE Where Id='" + UyeId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    KullaniciId = Convert.ToInt32(oku["KullaniciId"].ToString());
                baglanti.Close();
                return KullaniciId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }

        //GUVENLIK ISLEMLERI
        public bool GuvenlikEkle(int ApartmanId, string AdSoyad, string Telefon)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("GuvenlikEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
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
        public bool GuvenlikGuncelle(int GuvenlikId, int ApartmanId, string AdSoyad, string Telefon)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("GuvenlikGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@GuvenlikId",GuvenlikId);
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);

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
        public bool GuvenlikSil(int ApartmanId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Guvenliksil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ApartmanId", ApartmanId);
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

        //DUYURU ISLEMLERI
        public bool DuyuruEkle(int YoneticiId, string Baslik, string Metin)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DuyuruEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@YoneticiId", YoneticiId);
                komut.Parameters.AddWithValue("@Baslik", Baslik);
                komut.Parameters.AddWithValue("@Metin", Metin);
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
        public bool DuyuruSil(int DuyuruId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DuyuruSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@DuyuruId", DuyuruId);
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

        //BIREY ISLEMLERI
        public bool BireyEkle(int UyeId, string AdSoyad, int Yas)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BireyEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@Yas", Yas);
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
        public bool BireyGuncelle(int BireyId,int UyeId, string AdSoyad, int Yas)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BireyGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BireyId", BireyId);
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@Yas", Yas);
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
        public bool BireySil(int BireyId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BireySil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BireyId", BireyId);
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
        public string BireyCekAdSoyad(int BireyId)
        {
            try
            {
                string AdSoyad = null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From BIREY Where Id='" + BireyId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    AdSoyad = oku["AdSoyad"].ToString();
                baglanti.Close();
                return AdSoyad;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public int BireyCekYas(int BireyId)
        {
            try
            {
                int Yas = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From BIREY Where Id='" + BireyId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    Yas = Convert.ToInt32(oku["Yas"].ToString());
                baglanti.Close();
                return Yas;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }

        //AIDAT ISLEMLERI
        public bool AidatEkle(int UyeId, float Tutar, string Ay)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("AidatEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Ay", Ay);
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
        public bool AidatGuncelle(int AidatId ,int UyeId, float Tutar, string Ay)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("AidatGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@AidatId", AidatId);
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Ay", Ay);
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
        public bool AidatSil(int AidatId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("AidatSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@AidatId", AidatId);
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
        public int AidatCekUyeId(int AidatId)
        {
            try
            {
                int UyeId = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From AIDAT Where Id='" + AidatId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    UyeId = Convert.ToInt32(oku["UyeId"].ToString());
                }
                baglanti.Close();
                return UyeId;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }
        public string AidatCekAy(int AidatId)
        {
            try
            {
                string Ay = null;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From AIDAT Where Id='" + AidatId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Ay = oku["Ay"].ToString();
                }
                baglanti.Close();
                return Ay;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public float AidatCekTutar(int AidatId)
        {
            try
            {
                float Tutar = -1;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From AIDAT Where Id='" + AidatId + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Tutar = (float)Convert.ToDouble(oku["Tutar"].ToString());
                }
                baglanti.Close();
                return Tutar;
            }
            catch
            {
                baglanti.Close();
                return -1;
            }
        }

        //DOGALGAZ ISLEMLERI
        public bool DogalGazEkle(int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DogalGazEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool DogalGazGuncelle(int DogalGazId, int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DogalGazGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@DogalGazId", DogalGazId);
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool DogalGazSil(int DogalGazId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DogalGazSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@DogalGazId", DogalGazId);
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

        //SU ISLEMLERI
        public bool SuEkle(int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SuEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool SuGuncelle(int SuId, int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SuGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@SuId", SuId);
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool SuSil(int SuId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SuSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@SuId", SuId);
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

        //ELEKTRIK ISLEMLERI
        public bool ElektrikEkle(int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ElektrikEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool ElektrikGuncelle(int ElektrikId, int BorcId, int FaturaId, DateTime Tarih, DateTime SonOdeme, float Tutar, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ElektrikGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ElektrikId", ElektrikId);
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@FaturaId", FaturaId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@SonOdeme", SonOdeme);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool ElektrikSil(int ElektrikId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ElektrikSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ElektrikId", ElektrikId);
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

        //BORC ISLEMLERI
        public bool BorcEkle(int UyeId,DateTime Tarih, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BorcEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool BorcGuncelle(int BorcId,int UyeId, DateTime Tarih, string Durum)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BorcGuncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BorcId", BorcId);
                komut.Parameters.AddWithValue("@UyeId", UyeId);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@Durum", Durum);
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
        public bool BorcSil(int BorcId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("BorcSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BorcId", BorcId);
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


    }
}
