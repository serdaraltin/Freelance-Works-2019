using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FilmDegerlendirme
{
    public partial class Form_KullaniciKayit : Form
    {
        VeriTabaniFonskiyon veritabani = new VeriTabaniFonskiyon();
        public Form_KullaniciKayit()
        {
            InitializeComponent();
        }
        string imageLocation;

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyasec = new OpenFileDialog();
            dosyasec.FileName = "Resim";
            dosyasec.Title = "Profil Resmi Sec";
            dosyasec.Filter = "JPG Dosyalari|*.jpg|PNG Dosyalari|*.png";

            if (dosyasec.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(dosyasec.FileName);
                imageLocation = dosyasec.FileName;
            }

        }

        private void Form_KullaniciKayit_Load(object sender, EventArgs e)
        {
            pbResim.Image = Properties.Resources.User;
            cbCinsiyet.Text = cbCinsiyet.Items[0].ToString();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtAdSoyad.Text != "" && txtEpostaAdresi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Sifreler Uyusmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!veritabani.KullaniciSorgula(txtKullaniciAdi.Text))
                    {
                        if (veritabani.KullaniciEkle(txtAdSoyad.Text, txtKullaniciAdi.Text, txtEpostaAdresi.Text, dtDogumTarihi.Value, txtSifre.Text, cbCinsiyet.Text, imageLocation, Application.StartupPath))
                        {
                            MessageBox.Show("Kayit Basarili", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kayit olunamadi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanici Adi daha onceden alinmis", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanlari doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
