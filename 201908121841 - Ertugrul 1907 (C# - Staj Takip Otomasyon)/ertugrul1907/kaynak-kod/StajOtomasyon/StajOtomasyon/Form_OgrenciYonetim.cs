using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_OgrenciYonetim : Form
    {
        public Form_OgrenciYonetim()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();


        string resimDosya = null;

        private void temizle()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is TextBox)
                    item.ResetText();
            }
            txtNumara.Text = veritabani.ogrenci_YeniNumara().ToString();
            btnResimSec.Enabled = true;
            pbResim.Image = null;
        }
        private void listele()
        {
            if (veritabani.ogrenci_Liste() != null)
                dataGridOgrenci.DataSource = veritabani.ogrenci_Liste().Tables["ogrenci"];
            temizle();
        }
        private void Form_OgrenciEkle_Load(object sender, EventArgs e)
        {
            txtNumara.Text = veritabani.ogrenci_YeniNumara().ToString();
            listele();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyasec = new OpenFileDialog();
            dosyasec.Filter = "Jpg Dosyaları|*.jpg|Png Dosyaları|*.png|Tüm Dosyalar|*.*";
            dosyasec.Title = "Öğrenci Resmi Seç";
            if (dosyasec.ShowDialog() == DialogResult.OK)
            {
                resimDosya = dosyasec.FileName;
                pbResim.Image = Image.FromFile(resimDosya);
            }
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

                    if (veritabani.ogrenci_Ekle(txtTc.Text, txtAd.Text, txtSoyad.Text, txtSinif.Text, txtBolum.Text, txtDal.Text, txtAdres.Text, txtSehir.Text, txtİlce.Text))
                    {
                        string resimYol = Application.StartupPath + "/images/ogrenci_" + veritabani.ogrenci_YeniNumara().ToString() + ".png";
                        if (resimDosya != null && File.Exists(resimDosya))
                            File.Copy(resimDosya, resimYol);
                        else
                        {
                            Properties.Resources.ogrenci.Save(resimYol);
                        }
                        MessageBox.Show("Öğrenci eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci kaydı başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {

                    if (veritabani.ogrenci_Guncelle(Convert.ToInt32(txtNumara.Text), txtTc.Text, txtAd.Text, txtSoyad.Text, txtSinif.Text, txtBolum.Text, txtDal.Text, txtAdres.Text, txtSehir.Text, txtİlce.Text))
                    {
                        MessageBox.Show("Öğrenci güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci güncelleme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    temizle();

                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listele();
        }

        private void dataGridOgrenci_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";

            temizle();
            txtTc.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (veritabani.ogrenci_Sil(Convert.ToInt32(txtNumara.Text)))
            {
                btnKaydet.Text = "Kaydet";
                temizle();
                txtTc.Focus();
                listele();
                MessageBox.Show("Öğrenci kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci kaydı silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizle();


        }

        private void dataGridOgrenci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numara = Convert.ToInt32(dataGridOgrenci.Rows[e.RowIndex].Cells[0].Value.ToString());
                int i = 0;

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = veritabani.ogrenci_Bilgi(numara)[i].ToString();
                        i++;
                    }
                }
                btnKaydet.Text = "Güncelle";
                pbResim.Image = null;
                btnResimSec.Enabled = false;
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/ogrenci_" + numara.ToString() + ".png");
                resimDosya = Application.StartupPath + "/images/ogrenci_" + numara.ToString() + ".png";

            }
            catch { }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "")
            {
                dataGridOgrenci.DataSource = veritabani.ogrenci_Ara(Convert.ToInt32(txtAra.Text)).Tables["ogrenci"];
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form_OgrenciYonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }
    }
}
