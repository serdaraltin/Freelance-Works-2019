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
    public partial class Form_KullaniciPaneli : Form
    {
        int KullaniciId;
        public Form_KullaniciPaneli(int KId)
        {
            InitializeComponent();
            KullaniciId = KId;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();


        int UrunId;
        bool FiltreKategori, FiltreMiktar, FiltreMarka, FiltreFiyat;

        private void Urun_Filtrele()
        {
            dgUrunler.Rows.Clear();

            int KategoriId = veritabani.Kategori_GetirId(cbKategori.Text);
            int MarkaId = veritabani.Marka_GetirId(cbMarka.Text);
            int FiyatMin = Convert.ToInt32(txtFiyatMin.Text);
            int FiyatMax = Convert.ToInt32(txtFiyatMax.Text);

            if (FiltreKategori)
            {
                //Kategori
                if (!FiltreMiktar && !FiltreMarka && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("KategoriId='" + KategoriId + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
                //Kategori + Miktar
                if (FiltreMiktar && !FiltreMarka && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("KategoriId='" + KategoriId + "' and Miktar='" + cbMiktar.Text + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
                //Kategori + Marka
                if (FiltreMarka && !FiltreMiktar && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("KategoriId='" + KategoriId + "' and MarkaId='" + MarkaId + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
                //Kategori + Miktar + Marka
                if (FiltreMarka && FiltreMiktar && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("KategoriId='" + KategoriId + "' and Miktar='" + cbMiktar.Text + "' and MarkaId='" + MarkaId + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
            }
            if (FiltreMiktar)
            {
                //Miktar
                if (!FiltreKategori && !FiltreMarka && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("Miktar='" + cbMiktar.Text + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
                //Miktar + Marka
                if (FiltreMarka && !FiltreKategori && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("MarkaId='" + MarkaId + "' and Miktar='" + cbMiktar.Text + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
            }
            if (FiltreMarka)
            {
                //Marka
                if (!FiltreKategori && !FiltreMiktar && !FiltreFiyat)
                {
                    foreach (ArrayList Urun in Urun_Listele("MarkaId='" + MarkaId + "'"))
                        dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                }
            }
            if (FiltreFiyat)
            {
                //Fiyat
                if (!FiltreKategori && !FiltreMarka && !FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Kategori
                if (FiltreKategori && !FiltreMarka && !FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and KategoriId='" + KategoriId + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Miktar
                if (FiltreMiktar && !FiltreKategori && !FiltreMarka)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and Miktar='" + cbMiktar.Text + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Marka
                if (FiltreMarka && !FiltreKategori && !FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and MarkaId='" + MarkaId + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Kategori + Miktar
                if (!FiltreMarka && FiltreKategori && FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and Miktar='" + cbMiktar.Text + "' and KategoriId='" + KategoriId + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Kategori + Marka
                if (FiltreMarka && FiltreKategori && !FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and MarkaId='" + MarkaId + "' and KategoriId='" + KategoriId + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
                //Fiyat + Kategori + Miktar + Marka
                if (FiltreMarka && FiltreKategori && FiltreMiktar)
                {
                    for (int fiyat = FiyatMin; fiyat <= FiyatMax; fiyat++)
                    {
                        foreach (ArrayList Urun in Urun_Listele("Fiyat='" + fiyat + "' and Miktar='" + cbMiktar.Text + "' and KategoriId='" + KategoriId + "' and MarkaId='" + MarkaId + "'"))
                            dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
                    }
                }
            }

        }
        public ArrayList Urun_Listele()
        {
            try
            {
                baglanti.Open();
                ArrayList veri = new ArrayList();
                SqlCommand komut = new SqlCommand("Select *From URUN", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ArrayList urun = new ArrayList();
                    urun.Add(oku["Ad"].ToString());
                    urun.Add(veritabani.Kategori_GetirAd(Convert.ToInt32(oku["KategoriId"].ToString())));
                    urun.Add(veritabani.Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                    urun.Add(oku["Miktar"].ToString());
                    urun.Add(oku["Fiyat"].ToString());

                    veri.Add(urun);


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
        public ArrayList Urun_Listele(string Sorgu)
        {
            try
            {
                baglanti.Open();
                ArrayList veri = new ArrayList();
                SqlCommand komut = new SqlCommand("Select *From URUN Where " + Sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ArrayList urun = new ArrayList();
                    urun.Add(oku["Ad"].ToString());
                    urun.Add(veritabani.Kategori_GetirAd(Convert.ToInt32(oku["KategoriId"].ToString())));
                    urun.Add(veritabani.Marka_GetirAd(Convert.ToInt32(oku["MarkaId"].ToString())));
                    urun.Add(oku["Miktar"].ToString());
                    urun.Add(oku["Fiyat"].ToString());
                    veri.Add(urun);
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
        public ArrayList EnCokSatanlar()
        {
            try
            {
                baglanti.Open();
                ArrayList veri = new ArrayList();
                SqlCommand komut = new SqlCommand("EnCokSatanlar", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ArrayList urun = new ArrayList();
                    urun.Add(oku["UrunId"].ToString());
                    urun.Add(oku["sayi"].ToString());
                    veri.Add(urun);
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
            foreach (ArrayList Urun in Urun_Listele())
                dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
        }
        private void Form_KullaniciPaneli_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(veritabani.Kullanici_GetirMusteriId(KullaniciId).ToString());

            if (File.Exists(Application.StartupPath + "/gorsel/kullanici/" + KullaniciId.ToString() + ".png"))
                pbKullaniciResim.Image = Image.FromFile(Application.StartupPath + "/gorsel/kullanici/" + KullaniciId.ToString() + ".png");
            lbAdSyad.Text = veritabani.Musteri_GetirAd(veritabani.Kullanici_GetirMusteriId(KullaniciId));

            cbKategori.DataSource = veritabani.Kategori_Listele();
            cbMiktar.DataSource = veritabani.Urun_MiktarListele();
            cbMarka.DataSource = veritabani.Marka_Listele();

            UrunListele();
          

            foreach (ArrayList Siparis in EnCokSatanlar())
            {
                ArrayList Urun = UrunBilgi(Convert.ToInt32(Siparis[0].ToString()));
                dgEnCokSatanlar.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl",Siparis[1]);
            }
                
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
                if (veritabani.Stok_GetirAdet(UrunId) > 0)
                {
                    btnSepeteEkle.Enabled = true;
                    lbStok.Text = "Stok : " + veritabani.Stok_GetirAdet(UrunId).ToString() + " Adet";
                    ndAdet.Maximum = veritabani.Stok_GetirAdet(UrunId);
                    ndAdet.Enabled = true;

                    ndAdet.Value = 1;
                }
                else
                {
                    btnSepeteEkle.Enabled = false;
                    ndAdet.Enabled = false;
                    ndAdet.Value = 1;
                    lbStok.Text = "Stok : Maalesef ürün tükendi";
                }

                if (File.Exists(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png"))
                    pbUrunResim.Image = Image.FromFile(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png");

            }
            catch { }
        }

        private void btnFiltreleMiktar_Click(object sender, EventArgs e)
        {
            FiltreMiktar = true;
            Urun_Filtrele();
        }

        private void btnFiltreleFiyat_Click(object sender, EventArgs e)
        {
            FiltreFiyat = true;
            Urun_Filtrele();
        }

        private void txtFiyatMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyatMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtFiyatMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.Sepet_Kontrol(veritabani.Sepet_GetirId(KullaniciId, UrunId)))
            {
                MessageBox.Show("Ürün zaten sepetinizde mevcut");
            }
            else
            {
                if (veritabani.Sepet_Ekle(KullaniciId, UrunId, Convert.ToInt32(ndAdet.Value)))
                {
                    MessageBox.Show(veritabani.Urun_GetirAd(UrunId) + "\nÜrünü sepete eklendi", "BİGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün eklenemedi !!!");
                }
            }
        }

        private void btnSepetim_Click(object sender, EventArgs e)
        {
            Form_Sepet sepet = new Form_Sepet(KullaniciId);
            sepet.ShowDialog();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Form_Hesap hesap = new Form_Hesap(KullaniciId);
            hesap.ShowDialog();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            Form_Sparis siparislerim = new Form_Sparis(KullaniciId);
            siparislerim.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }

        private void Form_KullaniciPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }

        private void dgEnCokSatanlar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                UrunId = veritabani.Urun_GetirId(dgEnCokSatanlar.Rows[e.RowIndex].Cells[0].Value.ToString());
                rcUrunAd2.Text = dgEnCokSatanlar.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbKategori2.Text = "Kategori : " + dgEnCokSatanlar.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbFiyat2.Text = "Fiyat : " + dgEnCokSatanlar.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbMarka2.Text = "Marka : " + dgEnCokSatanlar.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbMiktar2.Text = "Miktar : " + dgEnCokSatanlar.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbOlcu2.Text = "Ölçüler : " + veritabani.Urun_GetirOlcu(UrunId);
                if (veritabani.Stok_GetirAdet(UrunId) > 0)
                {
                    btnSepeteEkle2.Enabled = true;
                    lbStok2.Text = "Stok : " + veritabani.Stok_GetirAdet(UrunId).ToString() + " Adet";
                    ndAdet2.Maximum = veritabani.Stok_GetirAdet(UrunId);
                    ndAdet2.Enabled = true;

                    ndAdet2.Value = 1;
                }
                else
                {
                    btnSepeteEkle2.Enabled = false;
                    ndAdet2.Enabled = false;
                    ndAdet2.Value = 1;
                    lbStok2.Text = "Stok : Maalesef ürün tükendi";
                }

                if (File.Exists(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png"))
                    pbUrunResim2.Image = Image.FromFile(Application.StartupPath + "/gorsel/urun/" + UrunId.ToString() + ".png");

            }
            catch { }
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            if (veritabani.Sepet_Kontrol(veritabani.Sepet_GetirId(KullaniciId, UrunId)))
            {
                MessageBox.Show("Ürün zaten sepetinizde mevcut");
            }
            else
            {
                if (veritabani.Sepet_Ekle(KullaniciId, UrunId, Convert.ToInt32(ndAdet.Value)))
                {
                    MessageBox.Show(veritabani.Urun_GetirAd(UrunId) + "\nÜrünü sepete eklendi", "BİGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün eklenemedi !!!");
                }
            }
        }

        private void btnFitreleKategori_Click(object sender, EventArgs e)
        {
            FiltreKategori = true;
            Urun_Filtrele();
        }

        private void btnFiltreleMarka_Click(object sender, EventArgs e)
        {
            FiltreMarka = true;
            Urun_Filtrele();
        }



        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            FiltreKategori = false;
            FiltreMiktar = false;
            FiltreMarka = false;
            dgUrunler.Rows.Clear();
            foreach (ArrayList Urun in Urun_Listele())
                dgUrunler.Rows.Add(Urun[0], Urun[1], Urun[2], Urun[3] + " kg/lt", Urun[4] + " tl");
        }
    }
}
