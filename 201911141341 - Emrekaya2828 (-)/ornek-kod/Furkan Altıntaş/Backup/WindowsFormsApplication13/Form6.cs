using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form6 : Form
    {
        public Form1 frm1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
