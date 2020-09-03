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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.frm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.frm6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "INSERT INTO Tablo1(tc,ad,soyad,tel,meslek,d_tarih,boy,kilo) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "' ,'" + textBox8.Text + "') ";


            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen silinicek kaydın tcsini giriniz");
            }
            else
            {
                try
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE FROM Tablo1 WHERE tc='" + textBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.bag.Close();
                    frm1.kmt.Dispose();
                    frm1.dtst.Clear();
                    frm1.listele();
                    MessageBox.Show("Kayıt Silindi");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";

                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "UPDATE Tablo1 SET ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',tel='" + textBox4.Text + "' ,meslek='" + textBox5.Text + "' ,d_tarih='" + textBox6.Text + "',boy='" + textBox7.Text + "',kilo='" + textBox8.Text + "' WHERE tc='" + textBox1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
