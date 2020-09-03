using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StajOtomasyon
{
    public partial class Form_Staj : Form
    {
        public Form_Staj()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Ayar_Veritabani.Default.veritabani);
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

        int Id = 0, ogrenciId, isyeriId, ogretmenId, veliId, defterId = 0;

        private void temizle()
        {
            foreach (Control item in this.panel2.Controls)
            {
                if (item is TextBox)
                    item.ResetText();
            }
            chDurum.Checked = false;
            dtStajGun.Value = DateTime.Now;
            btnKaydet.Text = "Kaydet";
        }

        private void Listele()
        {
            try
            {
                cbOgrenci.Items.Clear();
                cbOgretmen.Items.Clear();
                cbIsyeri.Items.Clear();
                cbVeli.Items.Clear();

                foreach (ArrayList ogrenci in veritabani.ogrenci_liste())
                {
                    cbOgrenci.Items.Add(ogrenci[0] + " - " + ogrenci[1] + " " + ogrenci[2]);
                }
                cbOgrenci.SelectedIndex = 0;

                foreach (ArrayList ogretmen in veritabani.ogretmen_liste())
                {
                    cbOgretmen.Items.Add(ogretmen[0] + " - " + ogretmen[1] + " " + ogretmen[2]);
                }
                cbOgretmen.SelectedIndex = 0;

                foreach (ArrayList isyeri in veritabani.isyeri_liste())
                {
                    cbIsyeri.Items.Add(isyeri[0] + " - " + isyeri[1]);
                }
                cbIsyeri.SelectedIndex = 0;

                foreach (ArrayList veli in veritabani.veli_liste())
                {
                    cbVeli.Items.Add(veli[0] + " - " + veli[1] + " " + veli[2]);
                }
                cbVeli.SelectedIndex = 0;
            }
            catch { }
        }

        private void staj_Listele(int stajId)
        {
            ogrenciId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[0]);
            isyeriId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[1]);
            ogretmenId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[2]);
            veliId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[3]);



            dataGridOgrenci.DataSource = veritabani.ogrenci_Ara(ogrenciId).Tables["ogrenci"];
            dataGridIsyeri.DataSource = veritabani.isyeri_Ara(isyeriId).Tables["isyeri"];
            dataGridOgretmen.DataSource = veritabani.ogretmen_Ara(ogretmenId).Tables["ogretmen"];
            dataGridVeli.DataSource = veritabani.veli_Ara(veliId).Tables["veli"];

            dataGridDefter.DataSource = veritabani.defter_Ara(stajId).Tables["defter"];


            txtNumara.Text = veritabani.ogrenci_Bilgi(ogrenciId)[0].ToString();
            txtTc.Text = veritabani.ogrenci_Bilgi(ogrenciId)[1].ToString();
            txtAd.Text = veritabani.ogrenci_Bilgi(ogrenciId)[2].ToString();
            txtSoyad.Text = veritabani.ogrenci_Bilgi(ogrenciId)[3].ToString();
            txtSinif.Text = veritabani.ogrenci_Bilgi(ogrenciId)[4].ToString();

            if (File.Exists(Application.StartupPath + "/images/ogrenci_" + txtNumara.Text + ".png"))
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/ogrenci_" + txtNumara.Text + ".png");


        }

        private void staj_Listele(int stajId, int defId)
        {
            ogrenciId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[0]);
            isyeriId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[1]);
            ogretmenId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[2]);
            veliId = Convert.ToInt32(veritabani.staj_Bilgi(stajId)[3]);



            dataGridOgrenci.DataSource = veritabani.ogrenci_Ara(ogrenciId).Tables["ogrenci"];
            dataGridIsyeri.DataSource = veritabani.isyeri_Ara(isyeriId).Tables["isyeri"];
            dataGridOgretmen.DataSource = veritabani.ogretmen_Ara(ogretmenId).Tables["ogretmen"];
            dataGridVeli.DataSource = veritabani.veli_Ara(veliId).Tables["veli"];

            //dataGridDefter.DataSource = veritabani.defter_Ara(stajId).Tables["defter"];


            txtNumara.Text = veritabani.ogrenci_Bilgi(ogrenciId)[0].ToString();
            txtTc.Text = veritabani.ogrenci_Bilgi(ogrenciId)[1].ToString();
            txtAd.Text = veritabani.ogrenci_Bilgi(ogrenciId)[2].ToString();
            txtSoyad.Text = veritabani.ogrenci_Bilgi(ogrenciId)[3].ToString();
            txtSinif.Text = veritabani.ogrenci_Bilgi(ogrenciId)[4].ToString();

            if (File.Exists(Application.StartupPath + "/images/ogrenci_" + txtNumara.Text + ".png"))
                pbResim.Image = Image.FromFile(Application.StartupPath + "/images/ogrenci_" + txtNumara.Text + ".png");


            dtStajGun.Value = Convert.ToDateTime(veritabani.defter_Bilgi(defterId)[1]);
            dtStajGun.Enabled = false;
            chDurum.Checked = Convert.ToBoolean(veritabani.defter_Bilgi(defterId)[2]);

        }

        public void stajlar()
        {

            dataGridStaj.Rows.Clear();

            foreach(string[] row in veritabani.staj_Listele())
            {
                dataGridStaj.Rows.Add(row);
            }

        }

        public void staj_Ara(int ogrenciNo)
        {
           /* dataGridStaj.Rows.Clear();

            foreach (string[] row in veritabani.staj_Ara(ogrenciNo))
            {
                dataGridStaj.Rows.Add(row);
            }*/
        }

        private void Form_StajEkle_Load(object sender, EventArgs e)
        {
           /* dataGridStaj.ColumnCount = 7;
            dataGridStaj.Columns[0].Name = "Id";
            dataGridStaj.Columns[1].Name = "Öğrenci";
            dataGridStaj.Columns[2].Name = "İş Yeri";
            dataGridStaj.Columns[3].Name = "Öğretmen";
            dataGridStaj.Columns[4].Name = "Veli";
            dataGridStaj.Columns[5].Name = "Başlangıç";
            dataGridStaj.Columns[6].Name = "Bitiş";*/
            Listele();
            dataGridStaj.DataSource = veritabani.staj_Liste().Tables["staj"];
            dataGridDefter.DataSource = veritabani.defter_Liste().Tables["defter"];
            //stajlar();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridStaj.DataSource = veritabani.staj_Ara(Convert.ToInt32(txtAra.Text)).Tables["staj"];
        }

        private void btnYapildi_Click(object sender, EventArgs e)
        {

        }

        private void btnGunKaydet_Click(object sender, EventArgs e)
        {
            if (btnGunKaydet.Text == "Kaydet")
            {
                if (Id != 0)
                {
                    if (!veritabani.defter_SorgulaTarih(Id, Convert.ToDateTime(dtStajGun.Value.ToShortDateString())))
                    {
                        if (veritabani.defter_Ekle(Id, Convert.ToDateTime(dtStajGun.Value.ToShortDateString()), chDurum.Checked))
                        {
                            MessageBox.Show("Staj Defter Kaydı eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirlenen tarih için staj bilgisi bulunmakta !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                dataGridDefter.DataSource = veritabani.defter_Ara(Id).Tables["defter"];
            }
            else
            {
                if (veritabani.defter_Guncelle(defterId, chDurum.Checked))
                {
                    MessageBox.Show("Staj Defter Kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dataGridDefter.DataSource = veritabani.defter_Liste().Tables["defter"];
            }
            //temizle();

        }

        private void btnGunSil_Click(object sender, EventArgs e)
        {
            if (btnGunKaydet.Text == "Güncelle")
            {
                if (veritabani.defter_Sil(defterId))
                {
                    MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Id != 0)
                    {
                        staj_Listele(Id);
                    }
                    else
                    {
                        dataGridDefter.DataSource = veritabani.defter_Liste().Tables["defter"];
                    }
                }
            }
            temizle();

        }

        private void btnGunYeni_Click(object sender, EventArgs e)
        {
            chDurum.Checked = false;
            dtStajGun.Enabled = true;
            defterId = 0;
            btnGunKaydet.Text = "Kaydet";
        }

        private void Form_Staj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Anasayfa anasayfa = new Form_Anasayfa();
            anasayfa.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Güncelle")
            {
                if (veritabani.staj_Sil(Id))
                {
                    MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            dataGridStaj.DataSource = veritabani.staj_Liste().Tables["staj"];
            //stajlar();
            Listele();
            temizle();
        }

        private void dataGridDefter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                defterId = Convert.ToInt32(dataGridDefter.Rows[e.RowIndex].Cells[0].Value.ToString());

                staj_Listele(Convert.ToInt32(veritabani.defter_Bilgi(defterId)[0]), defterId);

                btnGunKaydet.Text = "Güncelle";

            }
            catch { }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ogrenciId = Convert.ToInt32(cbOgrenci.Text.Substring(0, cbOgrenci.Text.IndexOf("-")));
            int ogretmenId = Convert.ToInt32(cbOgretmen.Text.Substring(0, cbOgretmen.Text.IndexOf("-")));
            int isyeriId = Convert.ToInt32(cbIsyeri.Text.Substring(0, cbIsyeri.Text.IndexOf("-")));
            int veliId = Convert.ToInt32(cbVeli.Text.Substring(0, cbVeli.Text.IndexOf("-")));



            if (veritabani.staj_Ekle(ogrenciId, isyeriId, ogretmenId, veliId, Convert.ToDateTime(dtBaslangic.Value.ToShortDateString()), Convert.ToDateTime(dtBitis.Value.ToShortDateString())))
            {
                MessageBox.Show("Staj kayı eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Staj kayı eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridStaj.DataSource = veritabani.staj_Liste().Tables["staj"];
            //stajlar();
            Listele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridStaj.DataSource = veritabani.staj_Liste().Tables["staj"];
            //stajlar();
        }

        private void dataGridStaj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridStaj.Rows[e.RowIndex].Cells[0].Value.ToString());

                btnKaydet.Text = "Güncelle";
                staj_Listele(Id);

            }
            catch { }
        }
    }
}
