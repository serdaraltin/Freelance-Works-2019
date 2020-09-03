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
    public partial class Form_GuvenlikEkle : Form
    {
        public Form_GuvenlikEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int ApartmanId;

        private void Form_GuvenlikEkle_Load(object sender, EventArgs e)
        {
            txtApartmanAd.Text = veritabani.ApartmanCekAd(ApartmanId);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.GuvenlikEkle(ApartmanId, txtAdSoyad.Text, txtTelefon.Text))
            {
                MessageBox.Show("Güvenlik görevlisi eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
