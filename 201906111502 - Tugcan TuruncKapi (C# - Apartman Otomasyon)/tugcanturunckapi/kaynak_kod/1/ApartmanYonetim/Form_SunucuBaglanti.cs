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
    public partial class Form_SunucuBaglanti : Form
    {
        public Form_SunucuBaglanti()
        {
            InitializeComponent();
        }
        
        private void btnTestEt_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source="+txtSunucu.Text+"; initial Catalog="+txtVeritabani.Text+"; Integrated Security=true");
            try
            {
                baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Bağlantı Testi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SunucuBilgi.Default.Sunucu = txtSunucu.Text;
            SunucuBilgi.Default.VeriTabani = txtVeritabani.Text;
            SunucuBilgi.Default.Save();
            MessageBox.Show("Sunucu Yapılandırması Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
