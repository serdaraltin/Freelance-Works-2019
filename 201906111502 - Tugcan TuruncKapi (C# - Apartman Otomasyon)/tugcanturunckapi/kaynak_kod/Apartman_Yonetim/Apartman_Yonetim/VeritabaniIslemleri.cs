using System;
using System.Data.OleDb;

namespace Apartman_Yonetim
{
    
    class VeritabaniIslemleri
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+SunucuBilgi.Default.Dosya);

        //KIRACI ISLEMLERI
        public bool kiraci_ekle(int DaireId, string Ad, string Soyad, string TelNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Kiraci (Ad,Soyad,TelNo,Eposta,DaireId) Values(@Ad,@Soyad,@TelNo,@Eposta,@DaireId)", baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@TelNo", TelNo);
                komut.Parameters.AddWithValue("@Eposta", Eposta);
                komut.Parameters.AddWithValue("@DaireId", DaireId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool kiraci_guncelle(int Id,string Ad, string Soyad, string TelNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Kiraci set Ad='"+Ad+"',Soyad='"+Soyad+"',TelNo='"+TelNo+"',Eposta='"+Eposta+"' Where Id="+Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool kiraci_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Kiraci Where Id="+Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool kiraci_sorgula(int DaireId)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Kiraci Where DaireId like '" + DaireId+"%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    baglanti.Close();
                    return true;
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
        public int kiraci_GetirId(int DaireId)
        {
            try
            {
                int KiraciId = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Kiraci Where DaireId like '" + DaireId + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    KiraciId = Convert.ToInt32(oku["Id"].ToString());
                }
                oku.Close();
                baglanti.Close();
                return KiraciId;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public int kiraci_odeme(int OdemeId)
        {
            try
            {
                int toplam = 0;
              


                return toplam;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //EVSAHIBI ISLEMLERI
        public bool evsahibi_ekle(int DaireId, string Ad, string Soyad, string TelNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into EvSahibi (Ad,Soyad,TelNo,Eposta,DaireId) Values(@Ad,@Soyad,@TelNo,@Eposta,@DaireId)", baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@TelNo", TelNo);
                komut.Parameters.AddWithValue("@Eposta", Eposta);
                komut.Parameters.AddWithValue("@DaireId", DaireId);

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
        public bool evsahibi_guncelle(int Id, string Ad, string Soyad, string TelNo, string Eposta)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update EvSahibi set Ad='" + Ad + "',Soyad='" + Soyad + "',TelNo='" + TelNo + "',Eposta='" + Eposta + "' Where Id=" + Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool evsahibi_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From EvSahibi Where Id=" + Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool evsahibi_sorgula(int DaireId)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From EvSahibi Where DaireId like '" + DaireId + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    baglanti.Close();
                    return true;
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
        public int evsahibi_GetirId(int DaireId)
        {
            try
            {
                int EvSahibi = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From EvSahibi Where DaireId like '" + DaireId + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    EvSahibi = Convert.ToInt32(oku["Id"].ToString());
                }
                oku.Close();
                baglanti.Close();
                return EvSahibi;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //DAIRE ISLEMLERI
        public bool daire_ekle(string Ad,int KiraciId,int EvSahibiId)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Daire (Ad,KiraciId,EvSahibiId) Values(@Ad,@KiraciId,@EvSahibiId)", baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@KiraciId", KiraciId);
                komut.Parameters.AddWithValue("@EvSahibiId", EvSahibiId);


                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool daire_guncelle(int Id, string Ad, int KiraciId, int EvSahibiId)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Daire set Ad='"+Ad+",KiraciId='"+KiraciId+",EvSahibiId='"+EvSahibiId+" Where Id="+Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool daire_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Daire Where Id=" + Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        //GELIR ISLEMLERI
        public bool gelir_ekle(string Ad, int Tutar)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Gelir (Ad,Tutar) Values(@Ad,@Tutar)",baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Tutar", Tutar);


                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool gelir_guncelle(int Id,string Ad, int Tutar)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Gelir set Ad='"+Ad+",Tutar='"+Tutar+" Where Id="+Id,baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool gelir_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Gelir Where Id=" + Id,baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public int gelir_toplam()
        {
            try
            {
                int toplam = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Gelir",baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplam += Convert.ToInt32(oku["Tutar"].ToString());
                }
                oku.Close();
                baglanti.Close();
                return toplam;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public int gelir_GetirTutar(int Id)
        {
            try
            {
                int tutar = 0;

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Gelir Where Id like'" + Id + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    tutar += Convert.ToInt32(oku["Tutar"].ToString());
                }

                baglanti.Close();
                return tutar;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public string gelir_GetirAd(int Id)
        {
            try
            {
                string Ad = null;

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Gelir Where Id like'" + Id + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Ad += oku["Ad"].ToString();
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
        //GIDER ISLEMLERI
        public bool gider_ekle(string Ad, int Tutar, string Ay, int Yil)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Gider (Ad,Tutar,Ay,Yil) Values(@Ad,@Tutar,@Ay,@Yil)",baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@Ay", Ay);
                komut.Parameters.AddWithValue("@Yil", Yil);


                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool gider_guncelle(int Id, string Ad, int Tutar, string Ay, int Yil)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Gider set Ad='" + Ad + ",Tutar='" + Tutar + ",Ay='"+Ay+",Yil='"+Yil+" Where Id=" + Id,baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool gider_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Gider Where Id=" + Id,baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public int gider_toplam()
        {
            try
            {
                int toplam = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Gider", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplam += Convert.ToInt32(oku["Tutar"].ToString());
                }
                oku.Close();
                baglanti.Close();
                return toplam;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }

        //KARAR ISLEMLERI
        public bool karar_ekle(string Tanim, DateTime Tarih)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Karar (Tanim,Tarih) Values(@Tanim,@Tarih)",baglanti);

                komut.Parameters.AddWithValue("@Tanim", Tanim);
                komut.Parameters.AddWithValue("@Tarih", Tarih);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool karar_guncelle(int Id, string Tanim, DateTime Tarih)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Karar set Tanim='" + Tanim + ",Tarih='" + Tarih + " Where Id=" + Id,baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool karar_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Karar Where Id=" + Id);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        //ODEME ISLEMLERI
        public bool odeme_ekle(int DaireId, int GelirId, string Ay, int Yil)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Odeme (DaireId,GelirId,Ay,Yil) Values(@DaireId,@GelirId,@Ay,@Yil)", baglanti);

                komut.Parameters.AddWithValue("@DaireId", DaireId);
                komut.Parameters.AddWithValue("@GelirId", GelirId);
                komut.Parameters.AddWithValue("@Ay", Ay);
                komut.Parameters.AddWithValue("@Yil", Yil);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool odeme_guncelle(int Id, int DaireId, int GelirId, string Ay, int Yil)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Odeme set DaireId=@DaireId,GelirId=@GelirId,Ay=@Ay,Yil=@Yil Where Id=" + Id, baglanti);

                komut.Parameters.AddWithValue("@DaireId", DaireId);
                komut.Parameters.AddWithValue("@GelirId", GelirId);
                komut.Parameters.AddWithValue("@Ay", Ay);
                komut.Parameters.AddWithValue("@Yil", Yil);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool odeme_sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Odeme Where Id=" + Id, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
