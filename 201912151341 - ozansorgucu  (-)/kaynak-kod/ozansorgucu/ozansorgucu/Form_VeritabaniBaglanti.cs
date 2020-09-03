using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ozansorgucu
{
    public partial class Form_VeritabaniBaglanti : Form
    {
        public Form_VeritabaniBaglanti()
        {
            InitializeComponent();
        }

        public bool Baglanti_Test(string sunucu, string veritabani)
        {
            SqlConnection baglanti = new SqlConnection("Data Source="+sunucu+";Initial Catalog="+veritabani+";Integrated Security=True");
            try
            {
                baglanti.Open();
                baglanti.Close();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Baglanti_Test(txtSunucu.Text, txtVeritabani.Text))
            {
                Ayarlar.Default.sunucu = txtSunucu.Text;
                Ayarlar.Default.veritabani = txtVeritabani.Text;
                Ayarlar.Default.Save();
                MessageBox.Show("Veritabanı ayarları kaydedildi\nProgram yeniden başlatılacak", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Bağlantı testi başarısız olduğu için ayarlar kaydedilmedi !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_VeritabaniBaglanti_Load(object sender, EventArgs e)
        {
            txtSunucu.Text = Ayarlar.Default.sunucu;
            txtVeritabani.Text = Ayarlar.Default.veritabani;
        }
    }
}
