using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmDegerlendirme
{
    public partial class Form_SunucuBaglanti : Form
    {
        public Form_SunucuBaglanti()
        {
            InitializeComponent();
        }

         private void btnTestEt_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=" + txt_SunucuAdi.Text + "; initial Catalog=" + txt_VeriTabaniAdi.Text + "; Integrated Security=true");

            try
            {
               
                baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Baglanti Basarili", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception hata)
            {
                baglanti.Close();
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SunucuBilgi.Default.SunucuAd = txt_SunucuAdi.Text;
            SunucuBilgi.Default.VeriTabani = txt_VeriTabaniAdi.Text;
            SunucuBilgi.Default.Save();
        }

        private void Form_SunucuBaglanti_Load(object sender, EventArgs e)
        {
            txt_SunucuAdi.Text = SunucuBilgi.Default.SunucuAd;
            txt_VeriTabaniAdi.Text = SunucuBilgi.Default.VeriTabani;
        }
    }
}
