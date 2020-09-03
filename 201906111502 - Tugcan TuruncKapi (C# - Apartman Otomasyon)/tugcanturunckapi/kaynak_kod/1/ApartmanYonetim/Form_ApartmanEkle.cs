using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ApartmanYonetim
{
    public partial class Form_ApartmanEkle : Form
    {
        public Form_ApartmanEkle()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void Form_ApartmanEkle_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (int Id in veritabani.YoneticiListeleAd())
                {
                    cbYonetici.Items.Add(veritabani.KullaniciCekAd(Id));
                }
                cbYonetici.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Yönetici bulunamadı, lütfen apartman eklemeden önce yönetici oluşturun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtBlok.Text != "" && txtAidatTL.Text != "")
            {
                float Aidat = (float)Convert.ToDouble(txtAidatTL.Text);
                if (veritabani.ApartmanEkle(veritabani.YoneticiCekId(Convert.ToInt32(veritabani.KullaniciCekId(cbYonetici.Text))), txtAd.Text, txtBlok.Text, (int)ndKatSayi.Value, (int)ndDaireSayisi.Value, Aidat))
                {
                    MessageBox.Show("Apartman kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eklenemedi !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
