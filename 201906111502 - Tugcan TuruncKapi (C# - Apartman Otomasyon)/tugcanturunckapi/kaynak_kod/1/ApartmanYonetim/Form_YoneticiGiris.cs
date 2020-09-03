using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApartmanYonetim
{
    public partial class Form_YoneticiGiris : Form
    {
        public Form_YoneticiGiris()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void Form_YoneticiGiris_Load(object sender, EventArgs e)
        {
            try { pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(veritabani.KullaniciCekId(txtKullaniciAd.Text)).ToString()); } catch { }

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
   
            if (veritabani.YoneticiGiris(veritabani.KullaniciCekId(txtKullaniciAd.Text)) && veritabani.KullaniciGiris(txtKullaniciAd.Text,txtSifre.Text))
            {
                Form_YonetimPanel YonetimPanel = new Form_YonetimPanel();
                YonetimPanel.YKullaniciId = veritabani.KullaniciCekId(txtKullaniciAd.Text);
                YonetimPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            try { pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(veritabani.KullaniciCekId(txtKullaniciAd.Text))); } catch { }

        }
    }
}
