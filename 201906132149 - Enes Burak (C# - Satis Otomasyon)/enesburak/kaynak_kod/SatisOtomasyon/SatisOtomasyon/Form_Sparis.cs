using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SatisOtomasyon
{
    public partial class Form_Sparis : Form
    {
        int KullaniciId;
        public Form_Sparis(int KId)
        {
            InitializeComponent();
            KullaniciId = KId;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();

        int UrunId;


        private ArrayList SiparisListele()
        {
            ArrayList Siparisler = new ArrayList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From SIPARIS Where KullaniciId='"+KullaniciId+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ArrayList Siparis = new ArrayList();
                Siparis.Add(Convert.ToInt32(oku["UrunId"].ToString()));
                Siparis.Add(Convert.ToInt32(oku["Adet"].ToString()));
                Siparis.Add(oku["Tarih"].ToString());
                Siparisler.Add(Siparis);
            }
            baglanti.Close();
            return Siparisler;
        }

        private ArrayList UrunBilgi(int UId)
        {
            try
            {
                ArrayList urun = new ArrayList();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UrunGetirBilgi", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", UId);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    urun.Add(oku["Ad"].ToString());
                    urun.Add(veritabani.Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                    urun.Add(oku["Miktar"].ToString());
                    urun.Add(oku["Fiyat"].ToString());
                }
                baglanti.Close();
                return urun;
            }
            catch
            {
                baglanti.Close();
                return null;
            }
        }
        private void UrunListele()
        {
            dgUrunler.Rows.Clear();
            foreach (ArrayList Siparis in SiparisListele())
            { 
                ArrayList Urun = UrunBilgi(Convert.ToInt32(Siparis[0].ToString()));
                dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2] + " kg/lt", Urun[3] + " tl",Siparis[1],Siparis[2]);
            }
        }
        private void Form_Sparis_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void dgUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UrunId = veritabani.Urun_GetirId(dgUrunler.Rows[e.RowIndex].Cells[0].Value.ToString());
                rcUrunAd.Text = dgUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                lbFiyat.Text = "Fiyat : " + dgUrunler.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbMarka.Text = "Marka : " + dgUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbMiktar.Text = "Miktar : " + dgUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbAdet.Text = "Adet : " + dgUrunler.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbTarih.Text = "Tarih : " + dgUrunler.Rows[e.RowIndex].Cells[5].Value.ToString();


                if (File.Exists(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png"))
                    pbUrunResim.Image = Image.FromFile(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png");

            }
            catch { }
        }

        private void btnExelAktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dgUrunler.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dgUrunler.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgUrunler.Columns.Count; i++)
            {
                for (int j = 0; j < dgUrunler.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dgUrunler[i, j].Value;
                }
            }
        }
    }
}
