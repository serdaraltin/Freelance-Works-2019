using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmanYonetim
{
    public partial class Form_BireyEkle : Form
    {
        public Form_BireyEkle()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        private void Form_BireyEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From UYE", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbUye.Items.Add(veritabani.KullaniciCekAd(Convert.ToInt32(oku["KullaniciId"].ToString())));
            }
            cbUye.SelectedIndex = 0;
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "")
            {
                if (veritabani.BireyEkle(veritabani.UyeCekId(veritabani.KullaniciCekId(cbUye.Text)), txtAdSoyad.Text, (int)ndYas.Value))
                {
                    MessageBox.Show("Birey kaydi eklendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kayit yapilamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
