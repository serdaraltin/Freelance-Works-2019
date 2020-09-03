using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ozansorgucu
{
    public partial class Form_AnaSayfa : Form
    {
        public Form_AnaSayfa()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
     
        int Fmin, Fmax , Bmin , Bmax, Kmin, Kmax, Rmin, Rmax, Emin, Emax;
        public void Listele()
        {
            dataGridView1.DataSource = veritabani.Listele().Tables["model"];
        
            Fmin = 0;
            Fmax = 99999;
        }
        public void Fiyat(int min, int max)
        {
            dataGridView1.DataSource = veritabani.Soru1(min,max).Tables["model"];
  
            Fmin = min;
            Fmax = max;
        }
        public void Batarya(int Fmin,int Fmax, int min, int max)
        {
            dataGridView1.DataSource = veritabani.Soru2(Fmin,Fmax,min,max).Tables["model"];
            Bmin = min;
            Bmax = max;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Fmin = 0;
            Fmax = 999999;
            Bmin = 0;
            Bmax = 999999;
            Kmin = 0;
            Kmax = 999999;
            Rmin = 0;
            Rmax = 999999;
            Emin = 0;
            Emax = 999999;
            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 0;
            cb3.SelectedIndex = 0;
            cb4.SelectedIndex = 0;
            cb5.SelectedIndex = 0;
            dataGridView1.DataSource = null;
            p1.Enabled = true;
            btnYenile.Enabled = false;
           
        }

        public void Kamera(int Fmin, int Fmax, int Bmin, int Bmax, int min, int max)
        {
            dataGridView1.DataSource = veritabani.Soru3(Fmin, Fmax, Bmin, Bmax,min,max).Tables["model"];
            Kmin = min;
            Kmax = max;

        }
        public void Ram(int Fmin, int Fmax, int Bmin, int Bmax, int Kmin, int Kmax, int min ,int max)
        {
            dataGridView1.DataSource = veritabani.Soru4(Fmin, Fmax, Bmin, Bmax, Kmin,Kmax, min, max).Tables["model"];
            Rmin = min;
            Rmax = max;

        }
        public void Ekran(int Fmin, int Fmax, int Bmin, int Bmax, int Kmin, int Kmax, int Rmin, int Rmax, int min, int max)
        {
            dataGridView1.DataSource = veritabani.Soru5(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin, Rmax , min, max).Tables["model"];
            Emin = min;
            Emax = max;

        }
        private void Form_AnaSayfa_Load(object sender, EventArgs e)
        {
            if(Ayarlar.Default.sunucu == "" || Ayarlar.Default.veritabani == "" || veritabani.Baglanti_Test() == false)
            {
                Form_VeritabaniBaglanti vtaban = new Form_VeritabaniBaglanti();
                vtaban.ShowDialog();
            }
            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 0;
            cb3.SelectedIndex = 0;
            cb4.SelectedIndex = 0;
            cb5.SelectedIndex = 0;

            
        }

        private void btnOnay1_Click(object sender, EventArgs e)
        {
            switch ((cb1.SelectedIndex+1))
            {
                case 1:
                    Listele();
                    break;

                case 2:
                    //2229-7920
                    Fiyat(2229, 7920);
                    break;

                case 3:
                    //2229-6845
                    Fiyat(2229, 6845);
                    break;

                case 4:
                    //2229-6479
                    Fiyat(2229, 6479);
                    break;

                case 5:
                    //2229-5255
                    Fiyat(2229, 5255);
                    break;
            }
            p1.Enabled = false;
            p2.Enabled = true;
        }

        private void btnOnay2_Click(object sender, EventArgs e)
        {
            switch ((cb2.SelectedIndex+1))
            {
                case 1:
                    Batarya(Fmin, Fmax, 0, 99999);
                    break;

                case 2:
                    //3110-5000
                    Batarya(Fmin, Fmax, 3110, 5000);
                    break;

                case 3:
                    //3340-5000
                    Batarya(Fmin, Fmax, 3340, 5000);
                    break;

                case 4:
                    //3400-5000
                    Batarya(Fmin, Fmax, 3400, 5000);
                    break;

                case 5:
                    //3650-5000
                    Batarya(Fmin, Fmax, 3650, 5000);
                    break;
            }
            p2.Enabled = false;
            p3.Enabled = true;
        }

        private void btnOnay3_Click(object sender, EventArgs e)
        {
            switch ((cb3.SelectedIndex+1))
            {
                case 1:
                case 2:
                    //hepsi
                    Kamera(Fmin, Fmax, Bmin, Bmax,0,99999);
                    break;
                case 3:
                    //16-64
                    Kamera(Fmin, Fmax, Bmin, Bmax, 16, 64);
                    break;

                case 4:
                    //40-64
                case 5:
                    //40-64
                    Kamera(Fmin, Fmax, Bmin, Bmax, 40, 64);
                    break;
            }

            p3.Enabled = false;
            p4.Enabled = true;
            if (dataGridView1.Rows.Count < 2)
            {
                p4.Enabled = false;
                btnYenile.Enabled = true;
            }
        }

        private void btnOnay4_Click(object sender, EventArgs e)
        {
            
            switch ((cb4.SelectedIndex+1))
            {
                case 1:
                case 2:
                case 3:
                    //hepsi
                    Ram(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax,0,99999);
                    break;
                case 4:
                case 5:
                    //6-8
                    Ram(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, 4, 8);
                    break;
            }
            p4.Enabled = false;
            p5.Enabled = true;
            if (dataGridView1.Rows.Count < 2)
            {
                p5.Enabled = false;
                btnYenile.Enabled = true;
            }
        }

        private void btnOnay5_Click(object sender, EventArgs e)
        {
            switch ((cb5.SelectedIndex+1))
            {
                case 1:
                    Ekran(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin,Rmax,0,99999);
                    break;

                case 2:
                    //610-653
                    Ekran(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin, Rmax, 610, 653);
                    break;

                case 3:
                    //615-653
                    Ekran(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin, Rmax, 615, 653);
                    break;

                case 4:
                    //630-653
                    Ekran(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin, Rmax, 630, 653);
                    break;

                case 5:
                    //639-653
                    Ekran(Fmin, Fmax, Bmin, Bmax, Kmin, Kmax, Rmin, Rmax, 639, 653);
                    break;
            }
            p5.Enabled = false;
            btnYenile.Enabled = true;
        }
    }
}
