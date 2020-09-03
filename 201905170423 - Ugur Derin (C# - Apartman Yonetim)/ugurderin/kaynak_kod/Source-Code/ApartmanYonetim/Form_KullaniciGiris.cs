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
    public partial class Form_KullaniciGiris : Form
    {
        public Form_KullaniciGiris()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void Form_KullaniciGiris_Load(object sender, EventArgs e)
        {
            pbResim.Image = Properties.Resources.Kullanici;
        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            try { pbResim.Image = Image.FromFile(Application.StartupPath + "/images/" + veritabani.ResimCekAd(veritabani.KullaniciCekId(txtKullaniciAd.Text)).ToString()); } catch { }
           
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (veritabani.KullaniciGiris(txtKullaniciAd.Text, txtSifre.Text))
            {
                Form_KullaniciPanel KullaniciPanel = new Form_KullaniciPanel();
                KullaniciPanel.KullaniciId = Convert.ToInt32(veritabani.KullaniciCekId(txtKullaniciAd.Text));
                KullaniciPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
