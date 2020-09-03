using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_Hesap : Form
    {
        int KullaniciId;
        public Form_Hesap(int KId)
        {
            InitializeComponent();
            KullaniciId = KId;
        }
        VeriTabaniIslemleri veritabanı = new VeriTabaniIslemleri();



        private void Form_Hesap_Load(object sender, EventArgs e)
        {
            this.Text = "Hesap > " + veritabanı.Kullanici_GetirAd(KullaniciId);

            for (int i = 15; i < 125; i++)
                cbYas.Items.Add(i.ToString());

            int MusteriId = veritabanı.Kullanici_GetirMusteriId(KullaniciId);
            if (File.Exists(Application.StartupPath + "/gorsel/kullanici/" + KullaniciId.ToString() + ".png"))
                pbResim.Image = Image.FromFile(Application.StartupPath + "/gorsel/kullanici/" + KullaniciId.ToString() + ".png");

            txtAd.Text = veritabanı.Musteri_GetirHesap(MusteriId)[0].ToString();
            txtSoyad.Text = veritabanı.Musteri_GetirHesap(MusteriId)[1].ToString();
            cbCinsiyet.Text = veritabanı.Musteri_GetirHesap(MusteriId)[2].ToString();
            cbYas.Text = veritabanı.Musteri_GetirHesap(MusteriId)[3].ToString();
            txtTelefon.Text = veritabanı.Musteri_GetirHesap(MusteriId)[5].ToString();
            txtEposta.Text = veritabanı.Musteri_GetirHesap(MusteriId)[6].ToString();

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                }
                else
                {
                    if (!veritabanı.Kullanici_Guncelle(KullaniciId, txtSifre.Text))
                    {
                        MessageBox.Show("Kullanici güncellenemedi !!!");
                    }
                }

            }

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon.Text != "" && txtEposta.Text != "")
            {
                int MusteriId = veritabanı.Kullanici_GetirMusteriId(KullaniciId);

                if (veritabanı.Musteri_Guncelle(MusteriId, txtAd.Text, txtSoyad.Text, cbCinsiyet.Text, Convert.ToInt32(cbYas.Text), txtTelefon.Text, txtEposta.Text))
                {
                    MessageBox.Show("Hesap bilgileri güncellendi");
                }
            }
        }
    }
}

