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

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SunucuBilgi.Default.Dosya);


        private int GelirToplam()
        {
            try
            {
                int toplam = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Odeme",baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplam += veritabani.gelir_GetirTutar(Convert.ToInt32(oku["GelirId"].ToString()));
                }
                oku.Close();
                baglanti.Close();
                return toplam;

            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        private int GiderToplam()
        {
            try
            {
                int toplam = 0;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Gider", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplam += Convert.ToInt32(oku["Tutar"].ToString());
                }
                oku.Close();
                baglanti.Close();
                return toplam;

            }
            catch
            {
                baglanti.Close();
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KararDefteri karar = new KararDefteri();
            karar.ShowDialog();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daireler daireler = new Daireler();
            daireler.ShowDialog();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gelir gelir = new Gelir();
            gelir.ShowDialog();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider();
            gider.ShowDialog();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.ShowDialog();
           // this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(SunucuBilgi.Default.Dosya == "")
            {
                SunucuAyarla sa = new SunucuAyarla();
                sa.ShowDialog();
            }
            label6.Text = GelirToplam().ToString(); ;
            label8.Text = GiderToplam().ToString();
            label4.Text = veritabani.gider_toplam().ToString();
            label2.Text = (GelirToplam() - GiderToplam()).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SunucuAyarla sa = new SunucuAyarla();
            sa.ShowDialog();
        }
    }
    }
