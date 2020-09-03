using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_IsyeriYonetim : Form
    {
        public Form_IsyeriYonetim()
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
            dataGridIsyeri.DataSource = veritabani.isyeri_Liste().Tables["isyeri"];
            temizle();
        }
        private void Form_VeliYonetim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Form_IsyeriYonetim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";

            temizle();
            txtAd.Focus();
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

                    if (veritabani.isyeri_Ekle(txtAd.Text,txtSahib.Text,txtTelefon.Text,txtEposta.Text,txtAdres.Text,txtIl.Text,txtIlce.Text))
                    {
                        MessageBox.Show("İşyeri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İşyeri kaydı başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (btnKaydet.Text == "Güncelle")
                {

                    if (veritabani.isyeri_Guncelle(Id,txtAd.Text, txtSahib.Text, txtTelefon.Text, txtEposta.Text, txtAdres.Text, txtIl.Text, txtIlce.Text))
                    {
                        MessageBox.Show("İşyeri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İşyeri güncelleme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (veritabani.isyeri_Sil(Id))
            {
                btnKaydet.Text = "Kaydet";
                txtAd.Focus();
                MessageBox.Show("İşyeri kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşyeri kaydı silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizle();
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridIsyeri.DataSource = veritabani.isyeri_Ara(txtAra.Text).Tables["isyeri"];
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridIsyeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridIsyeri.Rows[e.RowIndex].Cells[0].Value.ToString());
                int i = 0;

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = veritabani.isyeri_Bilgi(Id)[i].ToString();
                        i++;
                    }
                }
                btnKaydet.Text = "Güncelle";
            }
            catch { }
        }
    }
}
