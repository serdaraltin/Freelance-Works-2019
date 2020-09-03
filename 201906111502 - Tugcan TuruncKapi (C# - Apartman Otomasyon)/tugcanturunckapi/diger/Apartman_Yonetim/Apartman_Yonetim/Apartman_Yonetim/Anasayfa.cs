using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apartman_Yonetim
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection
            (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\vt1.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            KararDefteri karar = new KararDefteri();
            karar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daireler daireler = new Daireler();
            daireler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gelir gelir = new Gelir();
            gelir.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider();
            gider.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

      
        }
    }
