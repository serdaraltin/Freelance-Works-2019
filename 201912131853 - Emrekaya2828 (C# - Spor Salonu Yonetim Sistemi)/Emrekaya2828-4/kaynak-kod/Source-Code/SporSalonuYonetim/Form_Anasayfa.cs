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

        //kapat butonu tıklama
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //programdan çıkılıyor
            Application.Exit();
        }

        //küçült butonu tıklama
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            //pencerenin boyutu küçültülüyor
            this.WindowState = FormWindowState.Minimized;
        }

        //veritabani butonu tıklama
        private void btn_Veritabani_Click(object sender, EventArgs e)
        {
            //veritabanı formu(pencere) açılıyor
            Form_VeritabaniBaglanti veritabaniBaglanti = new Form_VeritabaniBaglanti();
            veritabaniBaglanti.ShowDialog();//pencere üst üste bindirilecek şekilde görüntüleniyor
        }

        //yeni müşteri butonu tıklama
        private void btm_YeniMusteri_Click(object sender, EventArgs e)
        {
            //yeni müşteri formu(pencere) açılıyor
            Form_YeniMusteri yeniMusteri = new Form_YeniMusteri();
            yeniMusteri.ShowDialog();//pencere üst üste bindirilecek şekilde görüntüleniyor
        }

        //müşteri liste butonu tıklama
        private void btn_MusteriListe_Click(object sender, EventArgs e)
        {
            //müşteri listesi formu(pencere) açılıyor
            Form_MusteriListesi musteriListe = new Form_MusteriListesi();
            musteriListe.ShowDialog();//pencere üst üste bindirilecek şekilde görüntüleniyor
        }

        //hakkında butonu tıklama
        private void btn_Hakkinda_Click(object sender, EventArgs e)
        {
            //hakkında formu(pencere) açılıyor
            Form_Hakkinda hakkinda = new Form_Hakkinda();
            hakkinda.ShowDialog(); //pencere üst üste bindirilecek şekilde görüntüleniyor
        }
    }
}
