using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apartman_Yonetim
{
    public partial class SunucuAyarla : Form
    {
        public SunucuAyarla()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            sec.Filter = "Veri Tabanı Dosyalari|*.mdb";
            sec.Title = "Veri Tabanı Seç";

            if (sec.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = sec.FileName;
            }
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            if (txtDosya.Text != "")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtDosya.Text);
                try
                {
                    baglanti.Open();
                    baglanti.Close();
                    MessageBox.Show("Bağlantı testi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bağlantı başarısız" + Environment.NewLine + hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Lütfen dosya seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDosya.Text != "")
            {
                SunucuBilgi.Default.Dosya = txtDosya.Text;
                SunucuBilgi.Default.Save();
                MessageBox.Show("Bağlantı bilgileri kayıt edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen dosya seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
