using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Bilgi_Yarismasi
{
    public partial class Form_VeritabaniBaglanti : Form
    {
        public Form_VeritabaniBaglanti()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=; Jet OLEDB:Database Password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyasec = new OpenFileDialog();
            dosyasec.Filter = "Access (2003) Veritabanı Dosyaları|*.mdb|Tüm Dosyalar|*.*";
            dosyasec.Title = "Veritabanı Seç";
            dosyasec.FileName = "Veritabanı.mdb";

            if(dosyasec.ShowDialog() == DialogResult.OK)
            {
                txt_veritabani.Text = dosyasec.FileName;
            }
        }

        private void btn_TestEt_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txt_veritabani.Text + "; Jet OLEDB:Database Password=" + txt_Parola.Text + ";");
            try
            {  
                baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Bağlantı başarılı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata oluştu" + Environment.NewLine + hata.Message.ToString(),"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_veritabani.Text != "" && txt_Parola.Text != "")
            {
                Ayarlar.Default.veritabani = txt_veritabani.Text;
                Ayarlar.Default.parola = txt_Parola.Text;
                Ayarlar.Default.Save();
                MessageBox.Show("Kayıt işlemi başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Gerekli Alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Form_VeritabaniBaglanti_Load(object sender, EventArgs e)
        {
            txt_veritabani.Text = Ayarlar.Default.veritabani;
            txt_Parola.Text = Ayarlar.Default.parola;
        }
    }
}
