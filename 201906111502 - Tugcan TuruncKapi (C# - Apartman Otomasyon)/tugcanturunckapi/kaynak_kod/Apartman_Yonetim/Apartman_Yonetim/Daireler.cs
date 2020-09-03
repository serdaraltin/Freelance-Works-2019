using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yonetim
{
    public partial class Daireler : Form
    {
        public Daireler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 1;
            daire1.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 2;
            daire1.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 3;
            daire1.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 4;
            daire1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 5;
            daire1.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 6;
            daire1.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 7;
            daire1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 8;
            daire1.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 9;
            daire1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 10;
            daire1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 11;
            daire1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Daire1 daire1 = new Daire1();
            daire1.daireid = 12;
            daire1.ShowDialog();
        }
    }
}
