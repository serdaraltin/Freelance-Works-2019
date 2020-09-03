using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_MusteriEkle : Form
    {
        public Form_MusteriEkle()
        {
            InitializeComponent();
        }
        string resim;
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void Form_MusteriEkle_Load(object sender, EventArgs e)
        {
            cbCinsiyet.SelectedIndex = 0;
            for (int i = 15; i < 125; i++)
                cbYas.Items.Add(i.ToString());
            cbYas.SelectedIndex = 5;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            sec.Filter = "Jpeg Dosyaları|*.jpg|Png Dosyaları|*.png";
            sec.Title = "Resim Dosyası Seç";
            if (sec.ShowDialog() == DialogResult.OK)
            {
                resim = sec.FileName;
                pbResim.Image = Image.FromFile(sec.FileName);
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if(txtAd.Text != "" && txtSoyad.Text != "" && txtEposta.Text != "" && txtTelefon.Text != "" && txtSifre.Text != "" && txtKullaniciAd.Text != "")
            {
                if (veritabani.Kullanici_Kontrol(txtKullaniciAd.Text))
                {
                    MessageBox.Show("Kullanici Adi daha önceden alınmış !");
                }
                else
                {
                    if (veritabani.Musteri_Ekle(txtAd.Text, txtSoyad.Text, cbCinsiyet.Text, Convert.ToInt32(cbYas.Text), txtTelefon.Text, txtEposta.Text))
                    {
                        if (veritabani.Kullanici_Ekle(veritabani.Musteri_GetirId(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtEposta.Text), txtKullaniciAd.Text, txtSifre.Text))
                        {
                            veritabani.Klasor_Yapilandir(Application.StartupPath);
                            if(resim != null)
                                File.Copy(resim, Application.StartupPath + "/gorsel/kullanici/" + veritabani.Kullanici_GetirId(txtKullaniciAd.Text) + ".png");
                            MessageBox.Show("Kayıt başarılı");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız !!!");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Kayıt yapılamadı !!!");
                    }
                }
            }
        }
    }
}
