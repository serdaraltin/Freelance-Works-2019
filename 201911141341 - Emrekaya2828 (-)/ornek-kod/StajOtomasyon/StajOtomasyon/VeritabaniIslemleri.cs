using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

using System.Text;

namespace StajOtomasyon
{
    class VeritabaniIslemleri
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Ayar_Veritabani.Default.veritabani);

        //YONETICI ISLEMLERI
        public bool yonetici_Giris(string kullaniciad, string parola)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From yonetici Where kullaniciad='" + kullaniciad + "' and parola='" + parola + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
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
        //YONETICI ISLEMLERI


        //OGRENCI ISLEMLERI   
        public int ogrenci_YeniNumara()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select Last(Id) From ogrenci", baglanti);
                int numara = (int)komut.ExecuteScalar();
                baglanti.Close();
                return numara;
            }
            catch
            {
                return 0;
            }
        }
        public bool ogrenci_Ekle(string tc, string ad, string soyad, string sinif, string bolum, string dal, string adres, string sehir, string ilce)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into ogrenci (tc,ad,soyad,sinif,bolum,dal,adres,sehir,ilce) values(@tc,@ad,@soyad,@sinif,@bolum,@dal,@adres,@sehir,@ilce)", baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@sinif", sinif);
                komut.Parameters.AddWithValue("@bolum", bolum);
                komut.Parameters.AddWithValue("@dal", dal);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@sehir", sehir);
                komut.Parameters.AddWithValue("@ilce", ilce);

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
        public bool ogrenci_Guncelle(int numara, string tc, string ad, string soyad, string sinif, string bolum, string dal, string adres, string sehir, string ilce)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update ogrenci set tc=@tc,ad=@ad,soyad=@soyad,sinif=@sinif,bolum=@bolum,dal=@dal,adres=@adres,sehir=@sehir,ilce=@ilce Where Id='" + numara + "'", baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@sinif", sinif);
                komut.Parameters.AddWithValue("@bolum", bolum);
                komut.Parameters.AddWithValue("@dal", dal);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@sehir", sehir);
                komut.Parameters.AddWithValue("@ilce", ilce);

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
        public bool ogrenci_Sil(int numara)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From ogrenci Where Id=" + numara, baglanti);
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
        public DataSet ogrenci_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From ogrenci", baglanti);
                adapter.Fill(dataset, "ogrenci");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList ogrenci_Bilgi(int numara)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From ogrenci Where Id=" + numara, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["tc"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());
                    array.Add(oku["sinif"].ToString());
                    array.Add(oku["bolum"].ToString());
                    array.Add(oku["dal"].ToString());
                    array.Add(oku["adres"].ToString());
                    array.Add(oku["sehir"].ToString());
                    array.Add(oku["ilce"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList ogrenci_liste()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From ogrenci", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                ArrayList ogreciler = new ArrayList();
                while (oku.Read())
                {
                    ArrayList array = new ArrayList();
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());

                    ogreciler.Add(array);
                }

                oku.Close();
                baglanti.Close();
                return ogreciler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet ogrenci_Ara(int Id)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From ogrenci Where Id=" + Id, baglanti);
                adapter.Fill(dataset, "ogrenci");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        //OGRENCI ISLEMLERI


        //OGRETMEN ISLEMLERI
        public bool ogretmen_Ekle(string tc, string ad, string soyad, string alan)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Insert Into ogretmen (tc,ad,soyad,alan) values(@tc,@ad,@soyad,@alan)", baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@alan", alan);


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
        public bool ogretmen_Guncelle(int Id, string tc, string ad, string soyad, string alan)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update ogretmen set tc=@tc,ad=@ad,soyad=@soyad,alan=@alan Where Id=" + Id, baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@alan", alan);


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
        public bool ogretmen_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From ogretmen Where Id=" + Id, baglanti);
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
        public ArrayList ogretmen_Bilgi(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From ogretmen Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["tc"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());
                    array.Add(oku["alan"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet ogretmen_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From ogretmen", baglanti);
                adapter.Fill(dataset, "ogretmen");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList ogretmen_liste()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From ogretmen", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                ArrayList ogreciler = new ArrayList();
                while (oku.Read())
                {
                    ArrayList array = new ArrayList();
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());

                    ogreciler.Add(array);
                }

                oku.Close();
                baglanti.Close();
                return ogreciler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet ogretmen_Ara(int Id)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From ogretmen Where Id=" + Id, baglanti);
                adapter.Fill(dataset, "ogretmen");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        //OGRETMEN ISLEMLERI


        //VELI ISLEMLERI
        public bool veli_Ekle(string tc, string ad, string soyad, string yakinlik, string adres, string telefon, string egitim)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Insert Into veli (tc,ad,soyad,yakinlik,adres,telefon,egitim) values(@tc,@ad,@soyad,@yakinlik,@adres,@telefon,@egitim)", baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@yakinlik", yakinlik);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@egitim", egitim);


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
        public bool veli_Guncelle(int Id, string tc, string ad, string soyad, string yakinlik, string adres, string telefon, string egitim)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Update veli set tc=@tc,ad=@ad,soyad=@soyad,yakinlik=@yakinlik,adres=@adres,telefon=@telefon,egitim=@egitim Where Id=" + Id, baglanti);

                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@yakinlik", yakinlik);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@egitim", egitim);


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
        public bool veli_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From veli Where Id=" + Id, baglanti);
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
        public ArrayList veli_Bilgi(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From veli Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["tc"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());
                    array.Add(oku["yakinlik"].ToString());
                    array.Add(oku["adres"].ToString());
                    array.Add(oku["telefon"].ToString());
                    array.Add(oku["egitim"].ToString());
                    array.Add(oku["gelir"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet veli_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From veli", baglanti);
                adapter.Fill(dataset, "veli");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet veli_Ara(string ad)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From veli Where ad='" + ad + "'", baglanti);
                adapter.Fill(dataset, "veli");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList veli_liste()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From veli", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                ArrayList ogreciler = new ArrayList();
                while (oku.Read())
                {
                    ArrayList array = new ArrayList();
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["soyad"].ToString());

                    ogreciler.Add(array);
                }

                oku.Close();
                baglanti.Close();
                return ogreciler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet veli_Ara(int Id)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From veli Where Id=" + Id, baglanti);
                adapter.Fill(dataset, "veli");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        //VELI ISLEMLERI



        //ISYERI ISLEMLERI
        public bool isyeri_Ekle(string ad, string sahib, string telefon, string eposta, string adres, string il, string ilce)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Insert Into isyeri (ad,sahib,telefon,eposta,adres,il,ilce) values(@ad,@sahib,@telefon,@eposta,@adres,@il,@ilce)", baglanti);

                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@sahib", sahib);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@il", il);
                komut.Parameters.AddWithValue("@ilce", ilce);


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
        public bool isyeri_Guncelle(int Id, string ad, string sahib, string telefon, string eposta, string adres, string il, string ilce)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Update isyeri set ad=@ad,sahib=@sahib,telefon=@telefon,eposta=@eposta,adres=@adres,il=@il,ilce=@ilce Where Id=" + Id, baglanti);

                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@sahib", sahib);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@il", il);
                komut.Parameters.AddWithValue("@ilce", ilce);

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
        public bool isyeri_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From isyeri Where Id=" + Id, baglanti);
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
        public ArrayList isyeri_Bilgi(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From isyeri Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["ad"].ToString());
                    array.Add(oku["sahib"].ToString());
                    array.Add(oku["telefon"].ToString());
                    array.Add(oku["eposta"].ToString());
                    array.Add(oku["adres"].ToString());
                    array.Add(oku["il"].ToString());
                    array.Add(oku["ilce"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet isyeri_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From isyeri", baglanti);
                adapter.Fill(dataset, "isyeri");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet isyeri_Ara(string ad)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From isyeri Where ad='" + ad + "'", baglanti);
                adapter.Fill(dataset, "isyeri");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList isyeri_liste()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From isyeri", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                ArrayList ogreciler = new ArrayList();
                while (oku.Read())
                {
                    ArrayList array = new ArrayList();
                    array.Add(oku["Id"].ToString());
                    array.Add(oku["ad"].ToString());

                    ogreciler.Add(array);
                }

                oku.Close();
                baglanti.Close();
                return ogreciler;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet isyeri_Ara(int Id)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From isyeri Where Id=" + Id, baglanti);
                adapter.Fill(dataset, "isyeri");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        //ISYERI ISLEMLERI



        //STAJ ISLEMLERI
        public bool staj_Ekle(int ogrenciId, int isyeriId, int ogretmenId, int veliId, DateTime baslangic, DateTime bitis)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Insert Into staj (ogrenciId,isyeriId,ogretmenId,veliId,baslangic,bitis) values(@ogrenciId,@isyeriId,@ogretmenId,@veliId,@baslangic,@bitis)", baglanti);

                komut.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                komut.Parameters.AddWithValue("@isyeriId", isyeriId);
                komut.Parameters.AddWithValue("@ogretmenId", ogretmenId);
                komut.Parameters.AddWithValue("@veliId", veliId);
                komut.Parameters.AddWithValue("@baslangic", baslangic);
                komut.Parameters.AddWithValue("@bitis", bitis);

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
        public bool staj_Guncelle(int Id, int ogrenciId, int isyeriId, int ogretmenId, int veliId, DateTime baslangic, DateTime bitis)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Update staj set ogrenciId=@OgrenciId,isyeriId=@isyeriId,ogretmenId=@ogretmenId,veliId=@veliId,baslangic=@baslangic,bitis=@bitis Where Id='" + Id + "'", baglanti);

                komut.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                komut.Parameters.AddWithValue("@isyeriId", isyeriId);
                komut.Parameters.AddWithValue("@ogretmenId", ogretmenId);
                komut.Parameters.AddWithValue("@veliId", veliId);
                komut.Parameters.AddWithValue("@baslangic", baslangic);
                komut.Parameters.AddWithValue("@bitis", bitis);

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
        public bool staj_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From staj Where Id=" + Id, baglanti);
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
        public ArrayList staj_Bilgi(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From staj Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["ogrenciId"].ToString());
                    array.Add(oku["isyeriId"].ToString());
                    array.Add(oku["ogretmenId"].ToString());
                    array.Add(oku["veliId"].ToString());
                    array.Add(oku["baslangic"].ToString());
                    array.Add(oku["bitis"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList staj_Listele()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From staj", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                while (oku.Read())
                {
                    VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

                    string ogrenciAd = veritabani.ogrenci_Bilgi(Convert.ToInt32(oku["ogrenciId"].ToString()))[2].ToString();
                    string isyeriAd = veritabani.isyeri_Bilgi(Convert.ToInt32(oku["isyeriId"].ToString()))[0].ToString();
                    string ogretmenAd = veritabani.ogretmen_Bilgi(Convert.ToInt32(oku["ogretmenId"].ToString()))[2].ToString();
                    string veliAd = veritabani.veli_Bilgi(Convert.ToInt32(oku["veliId"].ToString()))[2].ToString();

                    string[] row = new string[]
                        {
                       oku["Id"].ToString(), ogrenciAd,isyeriAd,ogretmenAd,veliAd,oku["baslangic"].ToString(),oku["bitis"].ToString()
                        };
                    array.Add(row);
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet staj_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From staj", baglanti);
                adapter.Fill(dataset, "staj");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        /*  public ArrayList staj_Ara(int ogrenciId)
          {

                  baglanti.Open();
                  OleDbCommand komut = new OleDbCommand("Select *From staj Where ogrenciId="+ogrenciId, baglanti);
                  OleDbDataReader oku = komut.ExecuteReader();
                  ArrayList array = new ArrayList();

                  while (oku.Read())
                  {
                      VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

                      string ogrenciAd = veritabani.ogrenci_Bilgi(Convert.ToInt32(oku["ogrenciId"].ToString()))[2].ToString();
                      string isyeriAd = veritabani.isyeri_Bilgi(Convert.ToInt32(oku["isyeriId"].ToString()))[0].ToString();
                      string ogretmenAd = veritabani.ogretmen_Bilgi(Convert.ToInt32(oku["ogretmenId"].ToString()))[2].ToString();
                      string veliAd = veritabani.veli_Bilgi(Convert.ToInt32(oku["veliId"].ToString()))[2].ToString();

                      string[] row = new string[]
                          {
                         oku["Id"].ToString(), ogrenciAd,isyeriAd,ogretmenAd,veliAd,oku["baslangic"].ToString(),oku["bitis"].ToString()
                          };
                      array.Add(row);
                  }

                  oku.Close();
                  baglanti.Close();
                  return array;

          }*/
        public DataSet staj_Ara(int ogrenciId)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From staj Where ogrenciId=" + ogrenciId, baglanti);
                adapter.Fill(dataset, "staj");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        //STAJ ISLEMLERI



        //STAJ ISLEMLERI
        public bool defter_Ekle(int stajId, DateTime tarih, bool durum)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Insert Into defter (stajId,tarih,durum) values(@stajId,@tarih,@durum)", baglanti);

                komut.Parameters.AddWithValue("@stajId", stajId);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@durum", durum);

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
        public bool defter_Guncelle(int Id, bool durum)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Update defter set durum=@durum Where Id=" + Id, baglanti);

                komut.Parameters.AddWithValue("@durum", durum);

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
        public bool defter_Sil(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From defter Where Id=" + Id, baglanti);
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
        public DataSet defter_Liste()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From defter", baglanti);
                adapter.Fill(dataset, "defter");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet defter_Ara(int stajId)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From defter Where stajId=" + stajId, baglanti);
                adapter.Fill(dataset, "defter");
                adapter.Dispose();
                baglanti.Close();

                return dataset;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public ArrayList defter_Bilgi(int Id)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From defter Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList array = new ArrayList();

                if (oku.Read())
                {
                    array.Add(oku["stajId"].ToString());
                    array.Add(oku["tarih"].ToString());
                    array.Add(oku["durum"].ToString());
                }

                oku.Close();
                baglanti.Close();
                return array;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool defter_SorgulaTarih(int stajId, DateTime tarih)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("Select *From defter Where stajId=" + stajId + " and tarih=" + tarih, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
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
    }
}
