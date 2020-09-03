using System;
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
    public partial class Form_UrunEkle : Form
    {
        public Form_UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();

        string resim;
       
     
        private void Form_UrunEkle_Load(object sender, EventArgs e)
        {
            cbKategori.DataSource = veritabani.Kategori_Listele();
            cbMarka.DataSource = veritabani.Marka_Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            float Miktar=0, Fiyat=0;
            try
            {
                Fiyat = (float)Convert.ToDouble(txtFiyat.Text);
            }
            catch
            {
                MessageBox.Show("Fiyat veya Miktar girişi hatalı !");
            }
            if (cbKategori.Text != "" && cbMarka.Text != "" && txtAd.Text != "" && txtFiyat.Text != "")
            {
                if (veritabani.Urun_Kontrol(txtAd.Text))
                {
                    MessageBox.Show("Ürün zaten kayıtlı");
                }
                else
                {
                    int KategoriId = veritabani.Kategori_GetirId(cbKategori.Text);
                    int MarkaId = veritabani.Marka_GetirId(cbMarka.Text);

                    if (veritabani.Urun_Ekle(KategoriId, MarkaId, txtMiktar.Text, txtOlcu.Text, txtAd.Text, Fiyat, rcAciklama.Text))
                    {
                        veritabani.Klasor_Yapilandir(Application.StartupPath);
                        File.Copy(resim, Application.StartupPath + "/gorsel/urun/"+veritabani.Urun_GetirId(txtAd.Text).ToString()+".png");
                        DialogResult soru = MessageBox.Show("Ürün eklendi\n Ürün için stok eklemek ister misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(soru == DialogResult.Yes)
                        {
                            Form_StokEkle stokekle = new Form_StokEkle();
                            stokekle.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün eklenemedi !!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz !");
            }



        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            sec.Filter = "Jped Dosyaları|*.jpg|Png Dosyaları|*.png";
            sec.Title = "Resim Dosyası Seç";
            if (sec.ShowDialog() == DialogResult.OK)
            {
                resim = sec.FileName;
                pbResim.Image = Image.FromFile(sec.FileName);
            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Form_KategoriEkle KategoriEkle = new Form_KategoriEkle();
            KategoriEkle.ShowDialog();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Form_MarkaEkle MarkaEkle = new Form_MarkaEkle();
            MarkaEkle.ShowDialog();
        }

        private void btnMarkaYenile_Click(object sender, EventArgs e)
        {
            cbMarka.DataSource = veritabani.Marka_Listele();
            cbMarka.SelectedIndex = cbMarka.Items.Count - 1;

        }

        private void btnKategoriYenile_Click(object sender, EventArgs e)
        {
            cbKategori.DataSource = veritabani.Kategori_Listele();
            cbKategori.SelectedIndex = cbKategori.Items.Count -1;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
