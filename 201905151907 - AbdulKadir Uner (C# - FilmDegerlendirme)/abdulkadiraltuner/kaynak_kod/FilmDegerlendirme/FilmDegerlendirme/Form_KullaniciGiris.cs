using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilmDegerlendirme
{
    public partial class Form_KullaniciGiris : Form
    {
        public Form_KullaniciGiris()
        {
            InitializeComponent();
        }
        VeriTabaniFonskiyon veritabani = new VeriTabaniFonskiyon();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (veritabani.KullaniciGiris(txtKullaniciAdi.Text, txtSifre.Text))
            {
               // MessageBox.Show("Giris Basarili");

            }
            else
            {
                MessageBox.Show("KullaniciAdi veya Sifre Hatali","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pbResim.Image = Image.FromFile(Application.StartupPath+@"/data/images/"+veritabani.KullaniciResim(txtKullaniciAdi.Text)+".jpg");
            }
            catch {
                pbResim.Image = Properties.Resources.User;
            }
        }

        private void Form_KullaniciGiris_Load(object sender, EventArgs e)
        {
            pbResim.Image = Properties.Resources.User;
        }
    }
}
