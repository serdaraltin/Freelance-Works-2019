using System;

using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_KullaniciGiris : Form
    {
        public Form_KullaniciGiris()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (veritabani.Kullanici_Kontrol(txtKullaniciAd.Text, txtSifre.Text))
            {
                Form_KullaniciPaneli kullaniciPanel = new Form_KullaniciPaneli(veritabani.Kullanici_GetirId(txtKullaniciAd.Text));
                kullaniciPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya Sifre hatali");
            }
        }

        private void Form_KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }
    }
}
