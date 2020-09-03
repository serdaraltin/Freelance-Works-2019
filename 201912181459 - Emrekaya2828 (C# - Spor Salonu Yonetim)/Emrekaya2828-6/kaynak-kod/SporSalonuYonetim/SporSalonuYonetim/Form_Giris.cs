using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAd.Text == "" && txtParola.Text == "")
            {
                MessageBox.Show("Gerekli alanları doldurunuz !");
                return;
            }
            if(txtKullaniciAd.Text == "kullanıcı" && txtParola.Text == "123456")
            {
                Form_Anasayfa anasayfa = new Form_Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya parola");
            }
        }
    }
}
