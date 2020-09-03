using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApartmanYonetim
{
    public partial class Form_DuyuruEkle : Form
    {
        public Form_DuyuruEkle()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int YoneticiId;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text != "" && rcMetin.Text != "")
            {
                if (veritabani.DuyuruEkle(YoneticiId, txtBaslik.Text, rcMetin.Text))
                {
                    MessageBox.Show("Duyuru Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eklenemedi", "HATa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DuyuruEkle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(YoneticiId.ToString());
        }
    }
}
