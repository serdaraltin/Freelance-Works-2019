using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_Anasayfa : Form
    {
        public Form_Anasayfa()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Form_OgrenciYonetim ogrenci = new Form_OgrenciYonetim();
            ogrenci.Show();
            this.Hide();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            Form_OgretmenYonetim ogretmen = new Form_OgretmenYonetim();
            ogretmen.ShowDialog();
        }

        private void btnVeli_Click(object sender, EventArgs e)
        {
            Form_VeliYonetim veli = new Form_VeliYonetim();
            veli.ShowDialog();

        }

        private void btnStaj_Click(object sender, EventArgs e)
        {
            Form_Staj staj = new Form_Staj();
            staj.Show();
            this.Hide();
        }

        private void btnIsyeri_Click(object sender, EventArgs e)
        {
            Form_IsyeriYonetim isyeri = new Form_IsyeriYonetim();
            isyeri.ShowDialog();
        }

        private void btnVeritabani_Click(object sender, EventArgs e)
        {
            Form_Baglanti veritabani = new Form_Baglanti();
            veritabani.ShowDialog();
           
        }

        private void Form_Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
