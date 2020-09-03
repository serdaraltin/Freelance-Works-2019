using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ozansorgucu
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
        }

        public DataSet Listele()
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model", baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet Soru1(int min, int max)
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model Where FİYAT Between " + min + " and " + max, baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet Soru2(int Fmin, int Fmax, int Bmin, int Bmax)
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model Where (FİYAT Between " + Fmin + " and " + Fmax+") and "+
                    "(BATARYA Between "+Bmin+" and "+Bmax+")", baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet Soru3(int Fmin, int Fmax, int Bmin, int Bmax, int Kmin, int Kmax)
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model Where (FİYAT Between " + Fmin + " and " + Fmax + ") and " +
                    "(BATARYA Between " + Bmin + " and " + Bmax + ") and "+
                    "(KAMERA Between " + Kmin + " and " + Kmax + ")",
                    baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet Soru4(int Fmin, int Fmax, int Bmin, int Bmax, int Kmin, int Kmax,int Rmin, int Rmax)
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model Where (FİYAT Between " + Fmin + " and " + Fmax + ") and " +
                    "(BATARYA Between " + Bmin + " and " + Bmax + ") and " +
                    "(KAMERA Between " + Kmin + " and " + Kmax + ") and "+
                    "(BELLEK Between " + Rmin + " and " + Rmax + ")",
                    baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        public DataSet Soru5(int Fmin, int Fmax, int Bmin, int Bmax, int Kmin, int Kmax, int Rmin, int Rmax, int Emin, int Emax)
        {
            try
            {
                baglanti.Open();
                DataSet veriler = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("Select *From model Where (FİYAT Between " + Fmin + " and " + Fmax + ") and " +
                    "(BATARYA Between " + Bmin + " and " + Bmax + ") and " +
                    "(KAMERA Between " + Kmin + " and " + Kmax + ") and " +
                    "(BELLEK Between " + Rmin + " and " + Rmax + ") and "+
                    "(EKRAN_BOYUTU Between " + Emin + " and " + Emax + ")",
                    baglanti);
                adaptor.Fill(veriler, "model");

                adaptor.Dispose();
                baglanti.Close();
                return veriler;

            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }

    }
}
