using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (!veritabani.Baglanti_Test())
            {
                MessageBox.Show("Öncelikle veritabanı bağlantısı yapılmalı !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(txt_KullaniciAd.Text != "" && txt_Parola.Text != ""))
            {
                MessageBox.Show("Gerekli alanları doldurunuz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (veritabani.Kullanici_Kontrol(txt_KullaniciAd.Text, txt_Parola.Text))
            {
                Form_Anasayfa anaSayfa = new Form_Anasayfa();
                anaSayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form_Giris_Load(object sender, EventArgs e)
        {
            if (!veritabani.Baglanti_Test())
            {
                Form_VeritabaniBaglanti veritabaniBaglanti = new Form_VeritabaniBaglanti();
                veritabaniBaglanti.ShowDialog();
                //this.Hide();
                return;
            }
            if(!(veritabani.Yonetici_Kontrol() > 0))
            {
                Form_KurulumSihirbazi kurulumS = new Form_KurulumSihirbazi();
                kurulumS.ShowDialog();
                //this.Hide();
            }
        }
    }
}
