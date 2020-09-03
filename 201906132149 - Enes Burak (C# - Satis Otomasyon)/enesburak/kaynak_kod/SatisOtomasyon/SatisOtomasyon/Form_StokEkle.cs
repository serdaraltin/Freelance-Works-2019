using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatisOtomasyon
{
    public partial class Form_StokEkle : Form
    {
        public Form_StokEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=True");

        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
     
        private void Form_StokEkle_Load(object sender, EventArgs e)
        {
            cbUrun.DataSource = veritabani.Urun_AdListele();
            cbUrun.SelectedIndex = cbUrun.Items.Count - 1;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.Stok_Ekle(veritabani.Urun_GetirId(cbUrun.Text), Convert.ToInt32(ndAdet.Value)))
            {
                MessageBox.Show("Stok Eklendi");
            }
            else
            {
                MessageBox.Show("Stok Eklenemedi !!!");
            }
        }
    }
}
