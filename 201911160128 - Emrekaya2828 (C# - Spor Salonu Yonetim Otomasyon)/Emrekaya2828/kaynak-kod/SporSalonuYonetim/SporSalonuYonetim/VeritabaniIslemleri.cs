using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace SporSalonuYonetim
{
    class VeritabaniIslemleri
    {
        // Global baglanti nesnesi olusturma
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Ayarlar.Default.veritabani + ";");


        // BAGLANTI ISLEMLERI
        public bool Baglanti_Test() // Veritabani baglanti testi
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


        // YONETICI ISLEMLERI
        public bool Yonetici_Ekle(int KullaniciId) // Yeni yonetici ekleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Yonetici (KullaniciId) values(@KullaniciId)", baglanti);
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
        public int Yonetici_Kontrol() // Yonetici varligi kontrolu
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select Count(*) From Yonetici" , baglanti);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();
                return count;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }


        // KULLANICI ISLEMLERI
        public bool Kullanici_Ekle(int MusteriId, string KullaniciAd, string Parola) // Yeni kullanici ekleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Kullanici (MusteriId,KullaniciAd,Parola) values(@MusteriId,@KullaniciAd,@Parola)", baglanti);
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Parola", Parola);
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
        public bool Kullanici_Guncelle(int Id, int MusteriId, string KullaniciAd, string Parola) // Kullanici guncelleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Kullanici set MusteriId=@MusteriId,KullaniciAd=@KullaniciAd,Parola=@Parola Where Id=" + Id, baglanti);
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut.Parameters.AddWithValue("@Parola", Parola);
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
        public int Kullanici_GetirId(string KullaniciAd) // Kullanici Adından Id sorgulama
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Kullanici Where KullaniciAd=" + KullaniciAd, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                int Id = 0;
                if (oku.Read())
                    Id = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public bool Kullanici_Kontrol(string KullaniciAd, string Parola) // Kullanici kontrol
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Kullanici Where KullaniciAd='" + KullaniciAd + "' and Parola='" + Parola + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                bool kontrol = false;
                if (oku.Read())
                    kontrol = true;
                baglanti.Close();
                return kontrol;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Kullanici_Sil(int Id) // Kullanici silme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Kullanici Where Id=" + Id, baglanti);
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


        // MUSTERI ISLEMLERI
        public bool Musteri_Ekle(string TcNo, string Ad, string Soyad, string Telefon, string Meslek, DateTime DogumTarih, int Boy, int Kilo, string Adres) // Yeni musteri ekleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Musteri (TcNo,Ad,Soyad,Telefon,Meslek,DogumTarih,Boy,Kilo,Adres) values(@TcNo,@Ad,@Soyad,@Telefon,@Meslek,@DogumTarih,@Boy,@Kilo,@Adres)", baglanti);
                komut.Parameters.AddWithValue("@TcNo", TcNo);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@Meslek", Meslek);
                komut.Parameters.AddWithValue("@DogumTarih", DogumTarih);
                komut.Parameters.AddWithValue("@Boy", Boy);
                komut.Parameters.AddWithValue("@Kilo", Kilo);
                komut.Parameters.AddWithValue("@Adres", Adres);
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
        public bool Musteri_Guncelle(int Id, string TcNo, string Ad, string Soyad, string Telefon, string Meslek, DateTime DogumTarih, int Boy, int Kilo, string Adres) // Musteri guncelleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Musteri set TcNo=@TcNo,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,Meslek=@Meslek,DogumTarih=@DogumTarih,Boy=@Boy,Kilo=@Kilo,Adres=@Adres Where Id=" + Id, baglanti);
                komut.Parameters.AddWithValue("@TcNo", TcNo);
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@Meslek", Meslek);
                komut.Parameters.AddWithValue("@DogumTarih", DogumTarih);
                komut.Parameters.AddWithValue("@Boy", Boy);
                komut.Parameters.AddWithValue("@Kilo", Kilo);
                komut.Parameters.AddWithValue("@Adres", Adres);
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
        public int Musteri_GetirId(string TcNo) // Musteri TcNo dan Id sorgulama
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Musteri Where TcNo='" + TcNo + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                int Id = 0;
                if (oku.Read())
                    Id = Convert.ToInt32(oku["Id"].ToString());
                baglanti.Close();
                return Id;
            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        public DataSet Musteri_Listele() // Tum musterileri listeleme
        {
            try
            {
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From Musteri", baglanti);
                adapter.Fill(dataset, "Musteri");
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
        public ArrayList Musteri_Bilgi(int Id) // Musteriye ait bilgileri edinme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Musteri Where Id=" + Id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList bilgi = new ArrayList();
                if (oku.Read())
                {

                    bilgi.Add(oku["TcNo"].ToString());
                    bilgi.Add(oku["Ad"].ToString());
                    bilgi.Add(oku["Soyad"].ToString());
                    bilgi.Add(oku["Telefon"].ToString());
                    bilgi.Add(oku["Meslek"].ToString());
                    bilgi.Add(Convert.ToDateTime(oku["DogumTarih"]));
                    bilgi.Add(Convert.ToInt32(oku["Boy"]));
                    bilgi.Add(Convert.ToInt32(oku["Kilo"]));
                    bilgi.Add(oku["Adres"].ToString());
                }
                baglanti.Close();
                return bilgi;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool Musteri_Sil(int Id) // Musteri silme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Musteri Where Id=" + Id, baglanti);
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
        public DataSet Musteri_Ara(string Ad) // Ad bilgisinden musteri arama
        {
            try
            {
                baglanti.Open();
                DataSet dataset = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select *From Musteri Where Ad like '%" + Ad + "%'", baglanti);
                adapter.Fill(dataset, "Musteri");
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


        // PROGRAM ISLEMLERI
        public bool Program_Ekle(int MusteriId, string Alan, string Antrenman, string Diyet, bool Pazartesi, bool Sali, bool Carsamba, bool Persembe, bool Cuma, bool Cumartesi) // Yeni program ekleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into Program (MusteriId,Alan,Antrenman,Diyet,Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi) values(@MusteriId,@Alan,@Antrenman,@Diyet,@Pazartesi,@Sali,@Carsamba,@Persembe,@Cuma,@Cumartesi)", baglanti);
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@Alan", Alan);
                komut.Parameters.AddWithValue("@Antrenman", Antrenman);
                komut.Parameters.AddWithValue("@Diyet", Diyet);
                komut.Parameters.AddWithValue("@Pazartesi", Pazartesi);
                komut.Parameters.AddWithValue("@Sali", Sali);
                komut.Parameters.AddWithValue("@Carsamba", Carsamba);
                komut.Parameters.AddWithValue("@Persembe", Persembe);
                komut.Parameters.AddWithValue("@Cuma", Cuma);
                komut.Parameters.AddWithValue("@Cumartesi", Cumartesi);
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
        public bool Program_Guncelle(int MusteriId, string Alan, string Antrenman, string Diyet, bool Pazartesi, bool Sali, bool Carsamba, bool Persembe, bool Cuma, bool Cumartesi) // Program guncelleme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Program set MusteriId=@MusteriId,Alan=@Alan,Antrenman=@Antrenman,Diyet=@Diyet,Pazartesi=@Pazartesi,Sali=@Sali,Carsamba=@Carsamba,Persembe=@Persembe,Cuma=@Cuma,Cumartesi=@Cumartesi Where MusteriId=" + MusteriId, baglanti);
                komut.Parameters.AddWithValue("@MusteriId", MusteriId);
                komut.Parameters.AddWithValue("@Alan", Alan);
                komut.Parameters.AddWithValue("@Antrenman", Antrenman);
                komut.Parameters.AddWithValue("@Diyet", Diyet);
                komut.Parameters.AddWithValue("@Pazartesi", Pazartesi);
                komut.Parameters.AddWithValue("@Sali", Sali);
                komut.Parameters.AddWithValue("@Carsamba", Carsamba);
                komut.Parameters.AddWithValue("@Persembe", Persembe);
                komut.Parameters.AddWithValue("@Cuma", Cuma);
                komut.Parameters.AddWithValue("@Cumartesi", Cumartesi);
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
        public ArrayList Program_Bilgi(int MusteriId) // Musteriye ait program bilgisi edinme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Program Where MusteriId=" + MusteriId, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                ArrayList bilgi = new ArrayList();
                if (oku.Read())
                {

                    bilgi.Add(oku["Alan"].ToString());
                    bilgi.Add(oku["Antrenman"].ToString());
                    bilgi.Add(oku["Diyet"].ToString());
                    bilgi.Add(Convert.ToBoolean(oku["Pazartesi"].ToString()));
                    bilgi.Add(Convert.ToBoolean(oku["Sali"].ToString()));
                    bilgi.Add(Convert.ToBoolean(oku["Carsamba"].ToString()));
                    bilgi.Add(Convert.ToBoolean(oku["Persembe"].ToString()));
                    bilgi.Add(Convert.ToBoolean(oku["Cuma"].ToString()));
                    bilgi.Add(Convert.ToBoolean(oku["Cumartesi"].ToString()));
                }
                baglanti.Close();
                return bilgi;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public bool Program_Kontrol(int MusteriId) // Program kontrol
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Program Where MusteriId=" + MusteriId, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                bool kontrol = false;
                if (oku.Read())
                    kontrol = true;
                baglanti.Close();
                return kontrol;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool Program_Sil(int Id) // Program silme
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Delete From Program Where Id=" + Id, baglanti);
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
