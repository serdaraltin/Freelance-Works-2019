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
    public partial class Form_AidatGuncelle : Form
    {
        public Form_AidatGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();

        public int AidatId=1;
        private void Form_AidatGuncelle_Load(object sender, EventArgs e)
        {
            txtUye.Text = veritabani.KullaniciCekAd(veritabani.UyeCekKullaniciId(veritabani.AidatCekUyeId(AidatId)));
            txtAy.Text = veritabani.AidatCekAy(AidatId);
            txtTutar.Text = veritabani.AidatCekTutar(AidatId).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text != "")
            {
                float tutar = (float)Convert.ToDouble(txtTutar.Text);
                if (veritabani.AidatGuncelle(AidatId,veritabani.UyeCekId(veritabani.KullaniciCekId(txtUye.Text)), tutar, txtAy.Text))
                {
                    MessageBox.Show("Aidat kaydi işlemi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
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
