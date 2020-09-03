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
    public partial class Form_AidatEkle : Form
    {
        public Form_AidatEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();


        private void KullaniciListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From KULLANICI", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                cbUye.Items.Add(oku["KullaniciAd"].ToString());
            baglanti.Close();
            cbUye.SelectedIndex = 0;
        }
        private void Form_AidatEkle_Load(object sender, EventArgs e)
        {
            KullaniciListele();
            cbAy.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text != "")
            {
                float tutar = (float)Convert.ToDouble(txtTutar.Text);
                if (veritabani.AidatEkle(veritabani.UyeCekId(veritabani.KullaniciCekId(cbUye.Text)), tutar, cbAy.Text))
                {
                    MessageBox.Show("Aidat kaydi işlemi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Kayit yapilamadi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
