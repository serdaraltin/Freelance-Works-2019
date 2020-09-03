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

namespace SatisOtomasyon
{
    public partial class Form_Sepet : Form
    {
        int KullaniciId;
        public Form_Sepet(int KId)
        {
            InitializeComponent();
            KullaniciId = KId;
        }


        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();

        int UrunId;


        private ArrayList SepetListele()
        {
            ArrayList Veri = new ArrayList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SepetListele", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KullaniciId", KullaniciId);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int UId = Convert.ToInt32(oku["UrunId"].ToString());
                Veri.Add(UId);
            }
            baglanti.Close();
            return Veri;
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
                    urun.Add(veritabani.Kategori_GetirAd(Convert.ToInt32(oku["KategoriId"].ToString())));
                    urun.Add(veritabani.Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                    urun.Add(oku["Miktar"].ToString());
                    urun.Add(oku["Fiyat"].ToString());
                    urun.Add(veritabani.Sepet_GetirAdet(KullaniciId, UId));
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
            foreach (int Urunid in SepetListele())
            {
                ArrayList Urun = UrunBilgi(Urunid);
                dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl", Urun[5]);
            }
        }
        private void Form_Sepet_Load(object sender, EventArgs e)
        {

            UrunListele();
        }

        private void dgUrunler_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                UrunId = veritabani.Urun_GetirId(dgUrunler.Rows[e.RowIndex].Cells[0].Value.ToString());
                rcUrunAd.Text = dgUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbKategori.Text = "Kategori : " + dgUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbFiyat.Text = "Fiyat : " + dgUrunler.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbMarka.Text = "Marka : " + dgUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbMiktar.Text = "Miktar : " + dgUrunler.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbOlcu.Text = "Ölçüler : " + veritabani.Urun_GetirOlcu(UrunId);
                lbAdet.Text =   "Adet : " + dgUrunler.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (veritabani.Stok_GetirAdet(UrunId) > 0)
                {

                    lbStok.Text = "Stok : " + veritabani.Stok_GetirAdet(UrunId).ToString() + " Adet";
                    ndAdet.Maximum = veritabani.Stok_GetirAdet(UrunId);
                    ndAdet.Value = Convert.ToInt32(dgUrunler.Rows[e.RowIndex].Cells[5].Value);
                }
              

                if (File.Exists(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png"))
                    pbUrunResim.Image = Image.FromFile(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png");

            }
            catch { }
        }

        private void btnUrunuSil_Click(object sender, EventArgs e)
        {
            if(UrunId != 0)
            {
                if (veritabani.Sepet_Sil(veritabani.Sepet_GetirId(KullaniciId, UrunId)))
                {
                    UrunListele();
                    MessageBox.Show("Ürün silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seçili ürün bulunmamakta");
            }
          
        }

        private void ndAdet_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdetDegistir_Click(object sender, EventArgs e)
        {
            if (veritabani.Sepet_Guncelle(veritabani.Sepet_GetirId(KullaniciId, UrunId), Convert.ToInt32(ndAdet.Value)))
            {
                UrunListele();
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int UId in SepetListele())
                {
                    int Adet = veritabani.Sepet_GetirAdet(KullaniciId, UId);
                    veritabani.Siparis_Ekle(KullaniciId, UId, Adet,DateTime.Now);
                    veritabani.Sepet_Sil(veritabani.Sepet_GetirId(KullaniciId, UId));
                }
                MessageBox.Show("Sipariş baraşırılı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Sipariş yapılamadı !!!");
            }
        }
    }
}
