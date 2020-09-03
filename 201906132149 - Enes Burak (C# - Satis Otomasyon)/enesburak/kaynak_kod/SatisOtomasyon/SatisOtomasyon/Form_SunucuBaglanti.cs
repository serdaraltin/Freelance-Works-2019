using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SatisOtomasyon
{
    public partial class Form_SunucuBaglanti : Form
    {
        public Form_SunucuBaglanti()
        {
            InitializeComponent();
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            if(txtSunucu.Text != "" && txtVeriTabani.Text != "")
            {
                SqlConnection baglanti = new SqlConnection("Data Source="+txtSunucu.Text+"; initial Catalog="+txtVeriTabani.Text+"; Integrated Security=true");
                try
                {
                    baglanti.Open();
                    baglanti.Close();
                    MessageBox.Show("Bağlantı Testi başarılı");
                }
                catch
                {
                    baglanti.Close();
                    MessageBox.Show("Bağlantı Testi başarısız !!!");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSunucu.Text != "" && txtVeriTabani.Text != "")
            {
                SunucuBilgi.Default.Sunucu = txtSunucu.Text;
                SunucuBilgi.Default.VeriTabani = txtVeriTabani.Text;
                SunucuBilgi.Default.Save();
                MessageBox.Show("Yapılandırma kaydedildi.");
            }
        }

        private void Form_SunucuBaglanti_Load(object sender, EventArgs e)
        {
            txtSunucu.Text = SunucuBilgi.Default.Sunucu;
            txtVeriTabani.Text = SunucuBilgi.Default.VeriTabani;
        }
    }
}
