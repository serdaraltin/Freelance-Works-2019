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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SunucuBilgi.Default.Dosya);

        DataSet dataset;

        private void Listele()
        {
            dataGridView1.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select *From Gider", baglanti);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Gider");
            dataGridView1.DataSource = dataset.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gider_Load(object sender, EventArgs e)
        {
            Listele();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (veritabani.gider_ekle(textBox1.Text, Convert.ToInt32(textBox2.Text), comboBox1.Text, Convert.ToInt32(comboBox2.Text)))
            {
                MessageBox.Show("Gider kaydı eklenedi");
            }
            else
            {
                MessageBox.Show("Gider kaydı ekelenemedi");
            }
            Listele();
        }
    }
}
