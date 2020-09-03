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
    public partial class Form_MarkaEkle : Form
    {
        public Form_MarkaEkle()
        {
            InitializeComponent();
        }
        string resim;
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.Marka_Kontrol(txtAd.Text))
            {
                MessageBox.Show("Marka zaten kayıtlı.");
            }
            else
            {
                if (veritabani.Marka_Ekle(txtAd.Text))
                {
                    veritabani.Klasor_Yapilandir(Application.StartupPath);
                    if(File.Exists(Application.StartupPath + "/gorsel/marka/" + veritabani.Marka_GetirId(txtAd.Text) + ".png"))
                        File.Copy(resim, Application.StartupPath + "/gorsel/marka/" + veritabani.Marka_GetirId(txtAd.Text) + ".png");
                    MessageBox.Show("Marka eklendi");
                    txtAd.Text = "";
                }
                else
                {
                    MessageBox.Show("Marka eklenemedi !!!");
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            sec.Filter = "Jped Dosyaları|*.jpg|Png Dosyaları|*.png";
            sec.Title = "Resim Dosyası Seç";
            if (sec.ShowDialog() == DialogResult.OK)
            {
                resim = sec.FileName;
                pbResim.Image = Image.FromFile(sec.FileName);
            }
        }
    }
}
