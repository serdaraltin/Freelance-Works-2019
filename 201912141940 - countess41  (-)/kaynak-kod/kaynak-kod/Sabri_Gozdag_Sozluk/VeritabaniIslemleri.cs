using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Sabri_Gozdag_Sozluk
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=" + Ayarlar.Default.sunucu + ";Initial Catalog=" + Ayarlar.Default.veritabani + ";Integrated Security=True");

        public bool Baglanti_Test()
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
            return false;
        }

        public List<string> Ara(string aranan, string tur, bool tam)//genel olarak arama
        {
            try
            {
                baglanti.Open();
                string komutMetin = tur + "_ara";
                if (tam)
                    komutMetin += "_tam";
                SqlCommand komut = new SqlCommand(komutMetin, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@" + tur, aranan);
                List<string> liste = new List<string>();
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                    if (tur == "bilgisayar" || tur == "bilisim" || tur == "elektronik" || tur == "teknik" || tur == "tip")
                        liste.Add(oku["terim"].ToString());
                    else
                        liste.Add(oku[tur].ToString());
                oku.Close();
                baglanti.Close();
                return liste;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public string Ara(string aranan, string tur, bool tam, bool anlam)//anlam arama
        {
            try
            {
                baglanti.Open();
                string komutMetin = tur + "_ara";
                if (tam)
                    komutMetin += "_tam";

                SqlCommand komut = new SqlCommand(komutMetin, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@" + tur, aranan);
                SqlDataReader oku = komut.ExecuteReader();

                string veri = null;
                if (oku.Read())
                {
                    if (tur == "ingilizce")
                        veri = oku["turkce"].ToString() + " : " + oku["anlam"].ToString();
                    else if(tur == "turkce")
                        veri = oku["ingilizce"].ToString() + " : " + oku["anlam"].ToString();
                    else
                        veri = aranan + " : " + oku["anlam"].ToString();
                }
                  

                oku.Close();
                baglanti.Close();
                return veri;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool Ekle(string tablo, string terim, string anlam)//terim ekleme
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(tablo + "_ekle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@terim",terim);
                komut.Parameters.AddWithValue("@anlam", anlam);
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
        public bool Ekle(string dil, string ingilizce, string turkce, string anlam)//ingilizce/turkce ekleme
        {
            
                baglanti.Open();  
                SqlCommand komut = new SqlCommand(dil + "_ekle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ingilizce", ingilizce);
                komut.Parameters.AddWithValue("@turkce", turkce);
                komut.Parameters.AddWithValue("@anlam", anlam);
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
         
        }

    }
}
