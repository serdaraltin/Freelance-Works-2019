using System;
using System.Collections;
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

        List<string[]> musteriler = new List<string[]>();
        string[] gMusteri;
        int indexNo = -1;
        public void Listele()
        {
            lstMusteri.Items.Clear();
            foreach (string[] veri in musteriler)
            {
                ListViewItem item = new ListViewItem(veri[0]);
                item.SubItems.Add(veri[1]);
                item.SubItems.Add(veri[2]);
                item.SubItems.Add(veri[3]);
                item.SubItems.Add(veri[4]);
                lstMusteri.Items.Add(item);
            }
        }
        public bool Ekle(string Ad, string Soyad, int Yas, string Tur, string Telefon)
        {
            try
            {
                string[] musteri = { Ad, Soyad, Yas.ToString(), Tur, Telefon };
                musteriler.Add(musteri);
                MessageBox.Show(Ad + " " + Soyad + " isimli kayıt eklendi.");
                Listele();
                return true;
            }
            catch
            {
                Listele();
                return false;
            }
        }

        public bool Guncelle(int itemNo, string Ad, string Soyad, string Yas, string Tur, string Telefon)
        {
            try
            {
                musteriler[itemNo][0] = Ad;
                musteriler[itemNo][1] = Soyad;
                musteriler[itemNo][2] = Yas;
                musteriler[itemNo][3] = Tur;
                musteriler[itemNo][4] = Telefon;
                MessageBox.Show(Ad + " " + Soyad + " isimli kayıt güncellendi.");
                Listele();
                return true;
            }
            catch
            {
                Listele();
                return false;
            }
        }

        public int Bul(string Ad, string Soyad, string Yas, string Tur, string Telefon)
        {
            int sayac = 0;
            foreach (string[] item in musteriler)
            {
                if (item[0] == Ad && item[1] == Soyad && item[2] == Yas && item[3] == Tur && item[4] == Telefon)
                    return sayac;
                sayac++;
            }
            return -1;
        }
        public bool Sil(string Ad, string Soyad, string Yas, string Tur, string Telefon)
        {
            foreach (string[] item in musteriler)
            {
                if (item[0] == Ad && item[1] == Soyad && item[2] == Yas && item[3] == Tur && item[4] == Telefon)
                {
                    musteriler.Remove(item);
                    MessageBox.Show(Ad +" "+Soyad+ " isimli kayıt silindi!!!");
                    Listele();
                    return true;
                }
            }
            Listele();
            return false;
        }


        private void Form_Anasayfa_Load(object sender, EventArgs e)
        {
           
            Listele();
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hakkinda hakkinda = new Form_Hakkinda();
            hakkinda.ShowDialog();
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            Ekle(txtAd.Text, txtSoyad.Text, (int)nudYas.Value, txtTur.Text, mtxtTelefon.Text);
            btnTemizle.PerformClick();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

            Listele();
            gMusteri = null;
        }

        private void lstMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string[] sMusteri = {
                    lstMusteri.SelectedItems[0].SubItems[0].Text,
                    lstMusteri.SelectedItems[0].SubItems[1].Text,
                    lstMusteri.SelectedItems[0].SubItems[2].Text,
                    lstMusteri.SelectedItems[0].SubItems[3].Text,
                     lstMusteri.SelectedItems[0].SubItems[4].Text
                    };
                gMusteri = sMusteri;
                if (gMusteri[0] != "")
                {
                    btnGuncelle2.Enabled = true;
                    btnSil2.Enabled = true;
                }
                else
                {
                    btnGuncelle2.Enabled = false;
                    btnSil2.Enabled = false;
                }

            }
            catch
            {
                gMusteri = null;
                btnGuncelle2.Enabled = false;
                btnSil2.Enabled = false;
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            try { 
                Sil(gMusteri[0], gMusteri[1], gMusteri[2], gMusteri[3], gMusteri[4]);
            }
            catch { }
        }

        private void lstMusteri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtAd.Text = lstMusteri.SelectedItems[0].SubItems[0].Text;
                txtSoyad.Text = lstMusteri.SelectedItems[0].SubItems[1].Text;
                nudYas.Value = Convert.ToInt32(lstMusteri.SelectedItems[0].SubItems[2].Text);
                txtTur.Text = lstMusteri.SelectedItems[0].SubItems[3].Text;
                mtxtTelefon.Text = lstMusteri.SelectedItems[0].SubItems[4].Text;
                btnGuncelle1.Enabled = true;
                btnSil1.Enabled = true;
                btnEkle1.Enabled = false;
            }
            catch
            {

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTur.Clear();
            mtxtTelefon.Clear();
            nudYas.Value = 20;
            btnGuncelle1.Enabled = false;
            btnSil1.Enabled = false;
            btnEkle1.Enabled = true;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            txtAd.Text = gMusteri[0];
            txtSoyad.Text = gMusteri[1];
            nudYas.Value = Convert.ToInt32(gMusteri[2]);
            txtTur.Text = gMusteri[3];
            mtxtTelefon.Text = gMusteri[4];
            btnGuncelle1.Enabled = true;
            btnSil1.Enabled = true;
            btnEkle1.Enabled = false;
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            btnTemizle.PerformClick();
            txtAd.Focus();
        }

        private void btnGuncelle1_Click(object sender, EventArgs e)
        {
            int indexNo = Bul(gMusteri[0], gMusteri[1], gMusteri[2], gMusteri[3], gMusteri[4]);
            Guncelle(indexNo, txtAd.Text, txtSoyad.Text, nudYas.Value.ToString(), txtTur.Text, mtxtTelefon.Text);
            btnTemizle.PerformClick();
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            Sil(gMusteri[0], gMusteri[1], gMusteri[2], gMusteri[3], gMusteri[4]);
        }
    }
}
