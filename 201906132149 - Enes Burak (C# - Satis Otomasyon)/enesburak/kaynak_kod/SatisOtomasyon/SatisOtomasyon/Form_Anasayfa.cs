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
    public partial class Form_Anasayfa : Form
    {
        public Form_Anasayfa()
        {
            InitializeComponent();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Form_YöneticiGiris yoneticig = new Form_YöneticiGiris();
            yoneticig.Show();
            this.Hide();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            Form_KullaniciGiris kullanicig = new Form_KullaniciGiris();
            kullanicig.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form_MusteriEkle kayitol = new Form_MusteriEkle();
            kayitol.ShowDialog();
            
        }

        private void Form_Anasayfa_Load(object sender, EventArgs e)
        {
            if(SunucuBilgi.Default.Sunucu == "" || SunucuBilgi.Default.VeriTabani == "")
            {
                Form_SunucuBaglanti sunucubaglanti = new Form_SunucuBaglanti();
                sunucubaglanti.ShowDialog();
            }
        }
    }
}
