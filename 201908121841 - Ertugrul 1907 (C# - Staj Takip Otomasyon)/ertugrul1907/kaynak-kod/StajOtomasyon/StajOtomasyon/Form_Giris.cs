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
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        private void Form_Giris_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "/images"))
                Directory.CreateDirectory(Application.StartupPath + "/images");
           

            if (! File.Exists(Ayar_Veritabani.Default.veritabani))
            {
                Form_Baglanti baglanti = new Form_Baglanti();
                baglanti.ShowDialog();
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciad.Text != "" && txtParola.Text != "")
            {
                if(veritabani.yonetici_Giris(txtKullaniciad.Text,txtParola.Text))
                {
                    Form_Anasayfa anasayfa = new Form_Anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya parola", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
