using System;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_KurulumSihirbazi : Form
    {
        public Form_KurulumSihirbazi()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        int MusteriId;
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_KurulumSihirbazi_Load(object sender, EventArgs e)
        {          
        }

        private void btn_DevamEt_Click(object sender, EventArgs e)
        {
            if (veritabani.Musteri_Ekle(txt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, txt_Telefon.Text, 
                txt_Meslek.Text, Convert.ToDateTime(dt_DogumTarih.Value), Convert.ToInt32(nud_Boy.Value), Convert.ToInt32(nud_Kilo.Value),txt_Adres.Text))
            {
                MusteriId = veritabani.Musteri_GetirId(txt_TcNo.Text);
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Bitir_Click(object sender, EventArgs e)
        {
            if(txt_Parola.Text == txt_ParolaTekrar.Text)
            {
                int kullaniciId = veritabani.Kullanici_GetirId(txt_KullaniciAd.Text);
                if (kullaniciId == 0)
                {
                    if (veritabani.Kullanici_Ekle(MusteriId, txt_KullaniciAd.Text, txt_Parola.Text))
                    {
                        kullaniciId = veritabani.Kullanici_GetirId(txt_KullaniciAd.Text);
                        veritabani.Yonetici_Ekle(kullaniciId);
                        MessageBox.Show("Kurulum işlemi tamamlandı\nYeninden başlatılacak...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt yapılamadı.\nBilgileri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı alınmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Parola uyuşmuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
