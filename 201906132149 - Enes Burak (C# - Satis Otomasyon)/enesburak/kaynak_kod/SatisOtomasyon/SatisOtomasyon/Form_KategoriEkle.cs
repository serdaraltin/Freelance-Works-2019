using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_KategoriEkle : Form
    {
        public Form_KategoriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();

        private void KategoriListele()
        {
            cbUstKategori.Items.Clear();
            cbUstKategori.Items.Add("--Yok--");
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From KATEGORI", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                   cbUstKategori.Items.Add(oku["Ad"].ToString());
                }
                baglanti.Close();
            }
            catch
            {
                baglanti.Close();
            }
            cbUstKategori.SelectedIndex = 0;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (veritabani.Kategori_Kontrol(txtAd.Text))
            {
                MessageBox.Show("Kategori zaten kayıtlı.");
            }
            else
            {
                if(cbUstKategori.SelectedIndex == 0)
                {
                    if (veritabani.Kategori_Ekle(txtAd.Text))
                    {
                        MessageBox.Show("Kategori eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kategori eklenemedi !!!");
                    }
                }
                else
                {
                    if (veritabani.Kategori_Ekle(veritabani.Kategori_GetirId(cbUstKategori.Text), txtAd.Text))
                    {
                        MessageBox.Show("Kategori eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kategori eklenemedi !!!");
                    }
                }
                
            }
            txtAd.Text = "";
            KategoriListele();
        }

        private void Form_KategoriEkle_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }
    }
}
