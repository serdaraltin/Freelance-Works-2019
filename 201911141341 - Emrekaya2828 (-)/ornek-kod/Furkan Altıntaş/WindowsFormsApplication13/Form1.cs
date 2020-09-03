using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=vt1.mdb");
        public DataSet dtst = new DataSet();
        public OleDbCommand kmt = new OleDbCommand();
        public void listele()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Tablo1", bag);
            adtr.Fill(dtst, "Tablo1");
            frm3.dataGridView1.DataSource = dtst;
            frm3.dataGridView1.DataMember = "Tablo1";
            bag.Close();
            adtr.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();

            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
            frm6.frm1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
