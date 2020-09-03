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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SunucuBilgi.Default.Dosya);

        DataSet dsOdeme, dsGelir, dsGider;

        int GelirId, OdemeId, GiderId;

        private void ListeleOdeme(string Ay, int Yil)
        {

            baglanti.Close();
            dgOdeme.DataSource = null;
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Odeme Where Yil Between 1990 and " + Yil, baglanti);
            dsOdeme = new DataSet();
           
            da.Fill(dsOdeme, "Odeme");

            //.Tables[0].Columns[2].DataType = typeof(String);

            dgOdeme.DataSource = dsOdeme.Tables[0];
            baglanti.Close();
     
           /* foreach (DataGridViewRow row in dgOdeme.Rows)
            {
                try
                {
                    if ((int)row.Cells[2].Value != 0)
                    {
                        int gId = Convert.ToInt32(row.Cells[2].Value.ToString());
                        row.Cells[2].ValueType = typeof(String);
                        row.Cells[2].Value = veritabani.gelir_GetirAd(gId);
                    }
                }
                catch { }
            }*/
        }
        private void ListeleGelir()
        {
            baglanti.Close();
            dgGelir.DataSource = null;
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Gelir Where Id like '" + GelirId + "%'", baglanti);
            dsGelir = new DataSet();
            da.Fill(dsGelir, "Gelir");
            dgGelir.DataSource = dsGelir.Tables[0];
            baglanti.Close();
        }
        private void ListeleGider(string Ay, int Yil)
        {
            baglanti.Close();
            dgGider.DataSource = null;
            OleDbDataAdapter da = new OleDbDataAdapter("Select *From Gider Where Yil Between 1990 and " + Yil, baglanti);
            dsGider = new DataSet();
            da.Fill(dsGider, "Gider");
            dgGider.DataSource = dsGider.Tables[0];
            baglanti.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            ListeleOdeme(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
            ListeleGider(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listele(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
        }

        private void dgOdeme_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GelirId = Convert.ToInt32(dsOdeme.Tables[0].Rows[e.RowIndex]["GelirId"].ToString());
                OdemeId = Convert.ToInt32(dsOdeme.Tables[0].Rows[e.RowIndex]["Id"].ToString());
                ListeleGelir();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OdemeId > 0)
            {
                if (veritabani.odeme_sil(OdemeId))
                {
                    MessageBox.Show("Ödeme kaydı silindi");
                }
                else
                {
                    MessageBox.Show("Ödeme kaydi silinemedi");
                }
                ListeleOdeme(comboBox1.Text, Convert.ToInt32(comboBox2.Text));

                ListeleGelir();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (veritabani.gider_sil(GiderId))
            {
                MessageBox.Show("Gider kaydı silindi");
            }
            else
            {
                MessageBox.Show("Gider kaydı silindi");
            }
            ListeleGider(comboBox1.Text, Convert.ToInt32(comboBox2.Text));

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
            for (int j = 0; j < dgGider.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgGider.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgGider.Rows.Count; i++)
            {
                for (int j = 0; j < dgGider.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgGider[j, i].Value == null ? "" : dgGider[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void dgGider_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GiderId = Convert.ToInt32(dsGider.Tables[0].Rows[e.RowIndex]["Id"].ToString());
        }

        private void dgOdeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListeleOdeme(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
            ListeleGider(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listele(comboBox1.Text, Convert.ToInt32(comboBox2.Text));
        }





    }
}
