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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Apartman_Yonetim
{
    public partial class KararDefteri : Form
    {
        public KararDefteri()
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
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select *From Karar", baglanti);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Karar");
            dataGridView1.DataSource = dataset.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void KararDefteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Text).ToString());
            if (veritabani.karar_ekle(textBox1.Text, Convert.ToDateTime(dateTimePicker1.Text)))
            {
                MessageBox.Show("Karar kaydı eklendi");
            }
            else
            {
                MessageBox.Show("Karar kaydı eklenemedi");
            }
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }
        }
    }
}
