using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Anasayfa : Form
    {
        public Form_Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Veritabani_Click(object sender, EventArgs e)
        {
            Form_VeritabaniBaglanti veritabaniBaglanti = new Form_VeritabaniBaglanti();
            veritabaniBaglanti.ShowDialog();
        }

        private void btm_YeniMusteri_Click(object sender, EventArgs e)
        {
            Form_YeniMusteri yeniMusteri = new Form_YeniMusteri();
            yeniMusteri.ShowDialog();
        }

        private void btn_MusteriListe_Click(object sender, EventArgs e)
        {
            Form_MusteriListesi musteriListe = new Form_MusteriListesi();
            musteriListe.ShowDialog();
        }

        private void btn_Hakkinda_Click(object sender, EventArgs e)
        {
            Form_Hakkinda hakkinda = new Form_Hakkinda();
            hakkinda.ShowDialog();
        }
    }
}
