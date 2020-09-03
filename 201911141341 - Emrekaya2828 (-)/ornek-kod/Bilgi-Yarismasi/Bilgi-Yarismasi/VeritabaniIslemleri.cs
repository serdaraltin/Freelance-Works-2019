using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace Bilgi_Yarismasi
{
    class VeritabaniIslemleri
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Ayarlar.Default.veritabani + "; Jet OLEDB:Database Password=" + Ayarlar.Default.parola + ";");




        public bool Soru_Ekle(string Soru,string A,string B,string C,string D,int DogruCevap)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert Into sorular (Soru,A,B,C,D,DogruCevap) values(@Soru,@A,@B,@C,@D,@DogruCevap)", baglanti);
                komut.Parameters.AddWithValue("@Soru", Soru);
                komut.Parameters.AddWithValue("@A", A);
                komut.Parameters.AddWithValue("@B", B);
                komut.Parameters.AddWithValue("@C", C);
                komut.Parameters.AddWithValue("@D", D);
                komut.Parameters.AddWithValue("@DogruCevap", DogruCevap);
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
