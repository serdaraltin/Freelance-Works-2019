using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_OgretmenYonetim : Form
    {
        public Form_OgretmenYonetim()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

        int Id = 0;

        private void temizle()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is TextBox)
                    item.ResetText();
            }
        }
        private void Listele()
        {
            dataGridOgretmen.DataSource = veritabani.ogretmen_Liste().Tables["ogretmen"];
            temizle();
        }
        private void Form_OgretmenEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool bos = false;

            foreach (Control item in this.panel1.Controls)
            {
                if (item is TextBox && item.Text == "")
                    bos = true;
            }

            if (!bos)
            {
                if (btnKaydet.Text == "Kaydet")
                {

                    if (veritabani.ogretmen_Ekle(txtTc.Text, txtAd.Text, txtSoyad.Text, txtAlan.Text))
                    {
                        MessageBox.Show("Öğretmen eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen kaydı başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (btnKaydet.Text == "Güncelle")
                {

                    if (veritabani.ogretmen_Guncelle(Id,txtTc.Text, txtAd.Text, txtSoyad.Text, txtAlan.Text))
                    {
                        MessageBox.Show("Öğretmen güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen güncelleme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            temizle();
            txtTc.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (veritabani.ogretmen_Sil(Id))
            {
                btnKaydet.Text = "Kaydet";
                txtTc.Focus();
                MessageBox.Show("Öğretmen kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğretmen kaydı silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizle();
            Listele();
        }

        private void dataGridOgretmen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridOgretmen.Rows[e.RowIndex].Cells[0].Value.ToString());
                int i = 1;

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = veritabani.ogretmen_Bilgi(Id)[i].ToString();
                        i++;
                    }
                }
                btnKaydet.Text = "Güncelle";
            }
            catch { }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
