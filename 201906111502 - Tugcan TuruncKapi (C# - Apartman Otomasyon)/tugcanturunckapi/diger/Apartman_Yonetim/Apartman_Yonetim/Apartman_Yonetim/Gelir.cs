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
    public partial class Gelir : Form
    {
        public static string gelirad;
        public static int gelirtl;
        public Gelir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            gelirad=textBox1.Text;
            gelirtl = Convert.ToInt32(textBox2.Text);


        }
    }
}
