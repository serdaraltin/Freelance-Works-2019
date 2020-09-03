using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_YonetimPaneli : Form
    {
        public Form_YonetimPaneli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_KategoriEkle kategoriekle = new Form_KategoriEkle();
            kategoriekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_MarkaEkle mEkle = new Form_MarkaEkle();
            mEkle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form_UrunEkle uEkle = new Form_UrunEkle();
            uEkle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_StokEkle sEkle = new Form_StokEkle();
            sEkle.ShowDialog();
        }
    }
}
