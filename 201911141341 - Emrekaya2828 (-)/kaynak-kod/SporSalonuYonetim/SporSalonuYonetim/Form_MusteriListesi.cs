using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_MusteriListesi : Form
    {
        public Form_MusteriListesi()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        int MusteriId;
        private void Musteri_Listele()
        {
            dg_Musteri.DataSource = veritabani.Musteri_Listele().Tables["Musteri"];
            foreach(Control item in panel2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
        }
        private void Musteri_Ara(string TcNo)
        {
            dg_Musteri.DataSource = veritabani.Musteri_Ara(TcNo).Tables["Musteri"];
            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
        }

        private void Musteri_Bilgi(int MusteriId)
        {
            foreach(Control item in panel1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
            }
            btn_ProgramHazirla.Text = "PROGRAM HAZIRLA";
            if (!(MusteriId > 0))
                return;
            txt_TcNo.Text = veritabani.Musteri_Bilgi(MusteriId)[0].ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(MusteriId)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(MusteriId)[2].ToString();
            txt_Telefon.Text = veritabani.Musteri_Bilgi(MusteriId)[3].ToString();
            txt_Meslek.Text = veritabani.Musteri_Bilgi(MusteriId)[4].ToString();
            txt_DogumTarih.Text = veritabani.Musteri_Bilgi(MusteriId)[5].ToString();
            txt_Boy.Text = veritabani.Musteri_Bilgi(MusteriId)[6].ToString();
            txt_Kilo.Text = veritabani.Musteri_Bilgi(MusteriId)[7].ToString();
            txt_Adres.Text = veritabani.Musteri_Bilgi(MusteriId)[8].ToString();
            string Resim = Application.StartupPath + "/musteri/" + MusteriId.ToString() + ".png";
            if (File.Exists(Resim))
                pb_Resim.Image = Image.FromFile(Resim);
            else
                pb_Resim.Image = null;
            if (!(veritabani.Program_Kontrol(MusteriId)))
                return;
            txt_Alan.Text = veritabani.Program_Bilgi(MusteriId)[0].ToString();
            txt_Antrenman.Text = veritabani.Program_Bilgi(MusteriId)[1].ToString();
            txt_Diyet.Text = veritabani.Program_Bilgi(MusteriId)[2].ToString();
            chb_Pazartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[3]);
            chb_Sali.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[4]);
            chb_Carsamba.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[5]);
            chb_Persembe.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[6]);
            chb_Cuma.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[7]);
            chb_Cumartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[8]);
            btn_ProgramHazirla.Text = "PROGRAM GÜNCELLE";
        }

        private void Form_MusteriListesi_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
        }

        private void dg_Musteri_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MusteriId = Convert.ToInt32(dg_Musteri.Rows[e.RowIndex].Cells[0].Value);
            Musteri_Bilgi(MusteriId);
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Musteri_Listele();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            Form_YeniMusteri yeniMusteri = new Form_YeniMusteri();
            yeniMusteri.ShowDialog();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(soru == DialogResult.Yes)
            {
                if(veritabani.Musteri_Sil(MusteriId))
                {
                    Musteri_Listele();
                }
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
         
            Form_YeniMusteri mGuncelle = new Form_YeniMusteri(MusteriId);
            mGuncelle.ShowDialog();
        }

        private void btn_ProgramHazirla_Click(object sender, EventArgs e)
        {
            if(btn_ProgramHazirla.Text == "PROGRAM HAZIRLA")
            {
                Form_Program programH = new Form_Program(MusteriId);
                programH.ShowDialog();
            }
            else
            {
                Form_Program programH = new Form_Program(MusteriId,true);
                programH.ShowDialog();
            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (txt_Ara.Text != "")
                Musteri_Ara(txt_Ara.Text);
            else
                MessageBox.Show("Lütfen arama yapmak için müşteri Tc No giriniz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
