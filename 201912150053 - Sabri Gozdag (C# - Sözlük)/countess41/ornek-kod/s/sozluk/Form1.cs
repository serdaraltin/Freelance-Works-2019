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

namespace sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=dbSozluk.accdb");
            da = new OleDbDataAdapter("SElect *from sozluk", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "sozluk");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Clear();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "turkce Like '" + textBox1.Text + "%'";
            //dv.RowFilter = string.Format("Ad LIKE '{0}%'", textBox5.Text);
            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    listBox1.Items.Add(dv[i].Row["turkce"]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "turkce ='" + listBox1.SelectedItem.ToString() +"'";
            textBox2.Text = dv[0].Row["ingilizce"].ToString();   
        }
    }
}
