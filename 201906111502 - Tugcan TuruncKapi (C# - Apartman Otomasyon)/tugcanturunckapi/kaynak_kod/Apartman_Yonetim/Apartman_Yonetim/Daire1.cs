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
    public partial class Daire1 : Form
    {
        public Daire1()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SunucuBilgi.Default.Dosya);


        public int daireid = 0;

        DataSet dsKiraci, dsEvSahibi, dsOdeme, dsGelir,dsGelir2;

        int KiraciId, EvSahibiId, GelirId,GelirId2;

        private void ListeleGelirTanim()
        {
            baglanti.Close();

            dataGridView3.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Gelir", baglanti);
            dsGelir = new DataSet();
            da.Fill(dsGelir, "Gelir");
            dataGridView3.DataSource = dsGelir.Tables[0];
            baglanti.Close();
        }
        private void ListeleOdeme(string Ay , int Yil)
        {
            baglanti.Close();

            dgOdeme.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Odeme Where DaireId like '" + daireid + "%' and Ay like '"+Ay+"%' and Yil like '"+Yil+"%'", baglanti);
            dsOdeme = new DataSet();
            da.Fill(dsOdeme, "Odeme");
            dgOdeme.DataSource = dsOdeme.Tables[0];
            baglanti.Close();
        }
        private void ListeleGelir()
        {
            baglanti.Close();

            dgGelir.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Gelir Where Id like '"+ GelirId2 + "%'", baglanti);
            dsGelir2 = new DataSet();
            da.Fill(dsGelir2, "Gelir");
            dgGelir.DataSource = dsGelir2.Tables[0];
            baglanti.Close();
            
        }
        private void KiraciToplamOdeme(string Ay, int Yil)
        {
            int odemeToplam = 0;

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select *From Odeme Where DaireId like '" + daireid + "%' and Ay like '" + Ay + "%' and Yil like '" + Yil + "%'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                odemeToplam += veritabani.gelir_GetirTutar(Convert.ToInt32(oku["GelirId"].ToString()));
            }
            oku.Close();
            baglanti.Close();

            label21.Text = odemeToplam.ToString()+" TL";
        }
        public void ListeleKiraci()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From Kiraci Where DaireId like '" + daireid + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtKiraciAd.Text = oku["Ad"].ToString();
                    txtKiraciSoyad.Text = oku["Soyad"].ToString();
                    txtKiraciTelNo.Text = oku["TelNo"].ToString();
                    txtKiraciEposta.Text = oku["Eposta"].ToString();

                }
                oku.Close();
                baglanti.Close();

            }
            catch
            {
                baglanti.Close();
            }

        }
        public void ListeleEvSahibi()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select *From EvSahibi Where DaireId like '" + daireid + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtEvSahibiAd.Text = oku["Ad"].ToString();
                    txtEvSahibiSoyAd.Text = oku["Soyad"].ToString();
                    txtEvSahibiTelNo.Text = oku["TelNo"].ToString();
                    txtEvSahibiEposta.Text = oku["Eposta"].ToString();

                }
                oku.Close();
                baglanti.Close();

            }
            catch
            {
                baglanti.Close();
            }

        }

        private void btnEvSahibiEkle_Click(object sender, EventArgs e)
        {
            if (veritabani.evsahibi_sorgula(daireid) == false)
            {
                if (veritabani.evsahibi_ekle(daireid, txtEvSahibiAd.Text, txtEvSahibiSoyAd.Text, txtEvSahibiTelNo.Text, txtEvSahibiEposta.Text))
                {
                    MessageBox.Show("Ev Sahibi kaydı eklendi");
                }
                else
                {
                    MessageBox.Show("Ev Sahibi kaydı eklenemedi");

                }
            }
            else
            {
                MessageBox.Show("Ev Sahibi kaydı zaten var");

            }
        }

        private void btnKiraciSil_Click(object sender, EventArgs e)
        {
            if (veritabani.kiraci_sil(veritabani.kiraci_GetirId(daireid)))
            {
                MessageBox.Show("Kiraci kaydı silindi");
                txtKiraciAd.Text = "";
                txtKiraciSoyad.Text = "";
                txtKiraciTelNo.Text = "";
                txtKiraciEposta.Text = "";
            }
            else
            {
                MessageBox.Show("Kiraci kaydı silinemedi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(veritabani.kiraci_sorgula(daireid) && veritabani.evsahibi_sorgula(daireid))
            {
                if (veritabani.odeme_ekle(daireid, GelirId, cbAy.Text, Convert.ToInt32(cbYil.Text)))
                {
                    MessageBox.Show("Ödeme kaydı eklendi");
                }
                else
                {
                    MessageBox.Show("Ödeme kaydı eklenemedi");
                }
            }
            else
            {
                MessageBox.Show("Ev Sahibi veya Kiraci kaydı yok !");
            }
            ListeleOdeme(comboBox5.Text,Convert.ToInt32(comboBox4.Text));
        }

        private void btnEvSahibiSil_Click(object sender, EventArgs e)
        {
            if (veritabani.evsahibi_sil(veritabani.evsahibi_GetirId(daireid)))
            {
                MessageBox.Show("Ev Sahibi kaydı silindi");
                txtEvSahibiAd.Text = "";
                txtEvSahibiSoyAd.Text = "";
                txtEvSahibiTelNo.Text = "";
                txtEvSahibiEposta.Text = "";
            }
            else
            {
                MessageBox.Show("Ev Sahibi kaydı silinemedi");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListeleOdeme(comboBox5.Text, Convert.ToInt32(comboBox4.Text));  
            dgGelir.DataSource = null;
            KiraciToplamOdeme(comboBox5.Text, Convert.ToInt32(comboBox4.Text));
        }

        private void dgOdeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgOdeme.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgOdeme.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgOdeme.Rows.Count; i++)
            {
                for (int j = 0; j < dgOdeme.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgOdeme[j, i].Value == null ? "" : dgOdeme[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgOdeme_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GelirId2 = Convert.ToInt32(dsOdeme.Tables[0].Rows[e.RowIndex]["GelirId"].ToString());
            ListeleGelir();
           
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GelirId = Convert.ToInt32(dsGelir.Tables[0].Rows[e.RowIndex]["Id"].ToString());
            ListeleGelir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }


        private void Daire1_Load(object sender, EventArgs e)
        {
            cbAy.SelectedIndex = 0;
            cbYil.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;

            label3.Text = daireid.ToString();
            ListeleGelirTanim();
            ListeleKiraci();
            ListeleEvSahibi();
            ListeleOdeme(comboBox5.Text, Convert.ToInt32(comboBox4.Text));
            KiraciToplamOdeme(comboBox5.Text, Convert.ToInt32(comboBox4.Text));


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (veritabani.kiraci_sorgula(daireid) == false)
            {
                if (veritabani.kiraci_ekle(daireid, txtKiraciAd.Text, txtKiraciSoyad.Text, txtKiraciTelNo.Text, txtKiraciEposta.Text))
                {
                    MessageBox.Show("Kiracı kaydı eklendi");
                }
                else
                {
                    MessageBox.Show("Kiracı kaydı eklenemedi");

                }
            }
            else
            {
                MessageBox.Show("Kiracı kaydı zaten var");

            }
        }




    }
}
