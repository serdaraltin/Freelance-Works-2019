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
    public partial class Form_BorcEkle : Form
    {
        public Form_BorcEkle()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int UyeId;
        private void Form_BorcEkle_Load(object sender, EventArgs e)
        {
            txtUye.Text = veritabani.KullaniciCekAd(veritabani.UyeCekKullaniciId(UyeId));
            cbDurum.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.BorcEkle(UyeId, dtTarih.Value, cbDurum.Text))
            {
                MessageBox.Show("Borc kaydı başarıyla eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eklenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
