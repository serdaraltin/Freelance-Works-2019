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
    public partial class Form_Anasayfa : Form
    {
        public Form_Anasayfa()
        {
            InitializeComponent();
        }

        private void Form_Anasayfa_Load(object sender, EventArgs e)
        {
            if(SunucuBilgi.Default.Sunucu == "")
            {
                Form_SunucuBaglanti SunucuBaglanti = new Form_SunucuBaglanti();
                SunucuBaglanti.ShowDialog();
            }
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Form_YoneticiGiris YoneticiGiris = new Form_YoneticiGiris();
            YoneticiGiris.Show();
            this.Hide();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            Form_KullaniciGiris KullaniciGiris = new Form_KullaniciGiris();
            KullaniciGiris.Show();
            this.Hide();
        }
    }
}
