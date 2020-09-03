using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_VeliYonetim : Form
    {
        public Form_VeliYonetim()
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
            btnKaydet.Text = "Kaydet";
        }
        private void Listele()
        {
            dataGridVeli.DataSource = veritabani.veli_Liste().Tables["veli"];
            temizle();
        }
        private void Form_VeliYonetim_Load(object sender, EventArgs e)
        {
            cbEgitim.SelectedIndex = 3;
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "")
            {
                dataGridVeli.DataSource = veritabani.veli_Ara(txtAra.Text).Tables["veli"];
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

                    if (veritabani.veli_Ekle(txtTc.Text, txtAd.Text, txtSoyad.Text, txtYakinlik.Text,txtAdres.Text,txtTelefon.Text,cbEgitim.Text))
                    {
                        MessageBox.Show("Veli eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Veli kaydı başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (btnKaydet.Text == "Güncelle")
                {

                    if (veritabani.veli_Guncelle(Id,txtTc.Text, txtAd.Text, txtSoyad.Text, txtYakinlik.Text, txtAdres.Text, txtTelefon.Text, cbEgitim.Text))
                    {
                        MessageBox.Show("Veli güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Veli güncelleme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            temizle();
            Listele();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";

            temizle();
            txtTc.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (veritabani.veli_Sil(Id))
            {
                btnKaydet.Text = "Kaydet";
                txtTc.Focus();
                MessageBox.Show("Veli kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veli kaydı silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizle();
            Listele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridVeli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridVeli.Rows[e.RowIndex].Cells[0].Value.ToString());
                int i = 1;

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = veritabani.veli_Bilgi(Id)[i].ToString();
                        i++;
                    }
                }
                btnKaydet.Text = "Güncelle";


            }
            catch { }
        }
    }
}
