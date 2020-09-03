using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_Baglanti : Form
    {
        public Form_Baglanti()
        {
            InitializeComponent();
        }

        private bool testEt(string veritabani)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtVeritabani.Text);
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

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyasec = new OpenFileDialog();
            dosyasec.Filter = "Access (mdb) Veritaban|*.mdb|Access Veritabanı|*.access|Tüm Dosyalar|*.*";
            dosyasec.Title = "Veritabanı Dosyasını Seç";
            if (dosyasec.ShowDialog() == DialogResult.OK)
            {
                txtVeritabani.Text = dosyasec.FileName;
            }
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            if (txtVeritabani.Text != "")
            {
                if (testEt(txtVeritabani.Text))
                {
                    MessageBox.Show("Bağlantı başarılı", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bağlantı başarısız !", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı Seçiniz", "Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtVeritabani.Text != "")
            {
                if (testEt(txtVeritabani.Text))
                {
                    Ayar_Veritabani.Default.veritabani = txtVeritabani.Text;
                    Ayar_Veritabani.Default.Save();
                    DialogResult soru =  MessageBox.Show("Veritabanı kaydedildi"+Environment.NewLine+ "Yeniden başlatılsın mı ?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(soru==DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Bağlantı başarısız !", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı Seçiniz", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Baglanti_Load(object sender, EventArgs e)
        {
            txtVeritabani.Text = Ayar_Veritabani.Default.veritabani;
            MessageBox.Show("Yapılacak olan değişiklikler programın tümünü etkileyecektir !!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
