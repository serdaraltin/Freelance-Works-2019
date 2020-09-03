using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Program : Form
    {
        int MusteriId;
        bool Guncelleme;
        public Form_Program(int MId)
        {
            InitializeComponent();
            MusteriId = MId;
        }
        public Form_Program(int MId,bool Gun)
        {
            InitializeComponent();
            MusteriId = MId;
            Guncelleme = Gun;
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();


        private void Listele()
        {
            txt_Id.Text = MusteriId.ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(MusteriId)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(MusteriId)[2].ToString();
        }
        private void Program_Bilgi(int MusteriId)
        {
            txt_Alan.Text = veritabani.Program_Bilgi(MusteriId)[0].ToString();
            txt_Antrenman.Text = veritabani.Program_Bilgi(MusteriId)[1].ToString();
            txt_Diyet.Text = veritabani.Program_Bilgi(MusteriId)[2].ToString();
            chb_Pazartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[3]);
            chb_Sali.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[4]);
            chb_Carsamba.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[5]);
            chb_Persembe.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[6]);
            chb_Cuma.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[7]);
            chb_Cumartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[8]);
        }
        private void Form_Program_Load(object sender, EventArgs e)
        {
            Listele();
            if (Guncelleme)
            {
                Program_Bilgi(MusteriId);
                btn_Kaydet.Text = "GÜNCELLE";
                lb_Title.Text = "GÜNCELLEME";
            }
                
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Ekle()
        {
            if (veritabani.Program_Ekle(MusteriId, txt_Alan.Text, txt_Antrenman.Text, txt_Diyet.Text, chb_Pazartesi.Checked, chb_Sali.Checked,
               chb_Carsamba.Checked, chb_Persembe.Checked, chb_Cuma.Checked, chb_Cumartesi.Checked))
            {
                MessageBox.Show("Program eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Program kaydı başarısız !!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Guncelle()
        {
            if (veritabani.Program_Guncelle(MusteriId, txt_Alan.Text, txt_Antrenman.Text, txt_Diyet.Text, chb_Pazartesi.Checked, chb_Sali.Checked,
             chb_Carsamba.Checked, chb_Persembe.Checked, chb_Cuma.Checked, chb_Cumartesi.Checked))
            {
                MessageBox.Show("Program güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Program güncelleme başarısız !!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(!(txt_Alan.Text != "" && txt_Antrenman.Text != "" && txt_Diyet.Text != ""))
            {
                MessageBox.Show("Gerekli alanları doldurunuz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Guncelleme)
                Guncelle();
            else
                Ekle();
           
        }
    }
}
