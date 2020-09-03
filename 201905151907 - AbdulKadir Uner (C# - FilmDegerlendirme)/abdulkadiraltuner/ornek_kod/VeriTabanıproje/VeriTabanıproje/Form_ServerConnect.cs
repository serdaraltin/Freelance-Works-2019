using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabanıproje
{
    public partial class Form_ServerConnect : Form
    {
        public Form_ServerConnect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sunucu = textBox1.Text;
            Properties.Settings.Default.VeriTabani = textBox2.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True");
            try
            {
                connect.Open();
                connect.Close();
                MessageBox.Show("Bağlantı Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception hata)
            { MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
