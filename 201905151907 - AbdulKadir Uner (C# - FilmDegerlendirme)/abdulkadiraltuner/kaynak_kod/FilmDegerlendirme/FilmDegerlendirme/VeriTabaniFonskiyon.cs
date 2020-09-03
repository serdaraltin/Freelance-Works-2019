using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace FilmDegerlendirme
{
    public class VeriTabaniFonskiyon
    {
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.SunucuAd + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
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

        public bool KullaniciEkle(string AdSoyad,string KullaniciAdi,string EpostaAdresi,DateTime DogumTarihi,string Sifre,string Cinsiyet,string Resim,string CalismaYolu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Kullanici (AdSoyad,KullaniciAdi,EpostaAdresi,DogumTarihi,Sifre,Cinsiyet,Resim) Values(@AdSoyad,@KullaniciAdi,@EpostaAdresi,@DogumTarihi,@Sifre,@Cinsiyet,@Resim)", baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                komut.Parameters.AddWithValue("@EpostaAdresi", EpostaAdresi);
                komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                komut.Parameters.AddWithValue("@Sifre", Sifre);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                if(Resim !="")
                    komut.Parameters.AddWithValue("@Resim", "img_"+KullaniciAdi);
                else
                    komut.Parameters.AddWithValue("@Resim", "img_Default");
                komut.ExecuteNonQuery();
                baglanti.Close();
                if(Resim !="")
                    File.Copy(Resim, CalismaYolu + @"/data/images/img_" + KullaniciAdi + ".jpg");
                     
                return true;
            }
            catch {
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
                }else
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

        public bool KullaniciGiris(string KullaniciAdi,string Sifre)
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
            catch {
                baglanti.Close();
                return false;
            }
        }

        public string KullaniciResim(string KullaniciAdi)
        {
            try
            {
                string Resim="";
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
    }
}
