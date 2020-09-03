using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yonetim
{
    public partial class Gelir : Form
    {
        public static string gelirad;
        public static int gelirtl;
        public Gelir()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SunucuBilgi.Default.Dosya);

        DataSet dataset;
        int GelirId;
        private void Listele()
        {
            dataGridView1.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select *From Gelir",baglanti);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Gelir");
            dataGridView1.DataSource = dataset.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            gelirad = textBox1.Text;
            gelirtl = Convert.ToInt32(textBox2.Text);


            if (veritabani.gelir_ekle(gelirad, gelirtl))
            {
                MessageBox.Show("Gelir kaydı eklendi");

            }
            else
            {
                MessageBox.Show("Gelir kaydı eklenemedi");
            }
            Listele();
        }

        private void Gelir_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(GelirId > 0)
            {
                if (veritabani.gelir_sil(GelirId))
                {
                    MessageBox.Show("Gelir kaydı silindi");
                   
                }
                else
                {
                    MessageBox.Show("Gelir kaydı silinemedi");
                }
            }
            Listele();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GelirId = Convert.ToInt32(dataset.Tables[0].Rows[e.RowIndex]["Id"].ToString());
        }
    }
}
