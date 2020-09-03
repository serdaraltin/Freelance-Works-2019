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
    public partial class Form_BireyGuncelle : Form
    {
        public Form_BireyGuncelle()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");

        public int BireyId=1;
        private void Form_BireyGuncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From UYE", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbUye.Items.Add(veritabani.KullaniciCekAd(Convert.ToInt32(oku["KullaniciId"].ToString())));
               
            }
            baglanti.Close();
            cbUye.SelectedIndex = 0;

            txtAdSoyad.Text = veritabani.BireyCekAdSoyad(BireyId);
            ndYas.Value = veritabani.BireyCekYas(BireyId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "")
            {
                if (veritabani.BireyGuncelle(BireyId, veritabani.UyeCekId(veritabani.KullaniciCekId(cbUye.Text)), txtAdSoyad.Text, (int)ndYas.Value))
                {
                    MessageBox.Show("Güncelleme işlemi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Guncellenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
