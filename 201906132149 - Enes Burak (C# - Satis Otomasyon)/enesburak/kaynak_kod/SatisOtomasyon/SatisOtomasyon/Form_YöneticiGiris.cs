using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_YöneticiGiris : Form
    {
        public Form_YöneticiGiris()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAd.Text != "" && txtSifre.Text != "")
            {
                if (veritabani.Kullanici_Kontrol(txtKullaniciAd.Text, txtSifre.Text))
                {
                    if (veritabani.Yonetici_Kontrol(veritabani.Kullanici_GetirId(txtKullaniciAd.Text)))
                    {
                        Form_YonetimPaneli yonetim = new Form_YonetimPaneli();
                        yonetim.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Yönetici yetkisi bulunamadı !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya şifre hatalı !!!");
                }
            }
        }

        private void Form_YöneticiGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }
    }
}
