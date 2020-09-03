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
    public partial class Form_KullaniciEkle : Form
    {
        public Form_KullaniciEkle()
        {
            InitializeComponent();
        }
        string ResimYol = null;
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void Form_KullaniciEkle_Load(object sender, EventArgs e)
        {
            cbCinsiyet.SelectedIndex = 0;
            cbMedeniDurum.SelectedIndex = 0;
            pbResim.Image = Properties.Resources.Kullanici;
           
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Title = "Resim Seç";
            DosyaSec.FileName = "Resim.jpg";
            DosyaSec.Filter = "Jpg Dosyaları|*.jpg|Png Dosyaları|*.png";
            
            if(DosyaSec.ShowDialog() == DialogResult.OK)
            {
                ResimYol = DosyaSec.FileName;
                pbResim.Image = Image.FromFile(DosyaSec.FileName);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAdSoyad.Text != "" && txtMailAdres.Text != "" && txtTelefon.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "")
            {
                if (veritabani.KullaniciEkle(txtKullaniciAd.Text, txtSifre.Text, txtAdSoyad.Text, txtMailAdres.Text, txtTelefon.Text, dtDogumTarih.Value, cbCinsiyet.Text, cbMedeniDurum.Text, ResimYol, Application.StartupPath))
                {
                    if (chYoneticiKullanici.Checked)
                        veritabani.YoneticiEkle(veritabani.KullaniciCekId(txtKullaniciAd.Text));
                    MessageBox.Show("Kayıt İşlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox textbox = (TextBox)item;
                            textbox.Clear();
                        }
                    }
                    cbCinsiyet.SelectedIndex = 0;
                    cbMedeniDurum.SelectedIndex = 0;
                    dtDogumTarih.Value = DateTime.Now;
                    pbResim.Image = Properties.Resources.Kullanici;

                }
                else
                {
                    MessageBox.Show("Kullanici zaten kayitli", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
