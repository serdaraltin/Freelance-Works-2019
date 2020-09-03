using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SporSalonuYonetim
{
    public partial class Form_VeritabaniBaglanti : Form
    {
        public Form_VeritabaniBaglanti()
        {
            InitializeComponent();
        }

        private Boolean test_et(string dosya)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dosya + ";");
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
        private void btn_DosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Filter = "Access Veritabanı|*.mdb|Tüm Dosyalar|*.*";
            DosyaSec.Title = "Veritabanı Dosyası Seç";
            DosyaSec.FileName = "Veritabani.mdb";

            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                if (test_et(DosyaSec.FileName))
                {
                    txt_Dosya.Text = DosyaSec.FileName;
                    MessageBox.Show("Bağlantı başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bağlantı başarısız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(txt_Dosya.Text != "" && test_et(txt_Dosya.Text))
            {
                Ayarlar.Default.veritabani = txt_Dosya.Text;
                Ayarlar.Default.Save();
                MessageBox.Show("Kayıt edildi,", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Veritabanı dosyası seçilmedi veya bulunamadı !!!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form_VeritabaniBaglanti_Load(object sender, EventArgs e)
        {
            txt_Dosya.Text = Ayarlar.Default.veritabani;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
