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
using System.Data;

namespace VeriTabanıproje
{
    public partial class Form_AdminLogin : Form
    {
        public Form_AdminLogin()
        {
            InitializeComponent();
        }
   
    
        SqlConnection connect = new SqlConnection("Data Source=" + Properties.Settings.Default.Sunucu + ";Initial Catalog="+ Properties.Settings.Default.VeriTabani + ";Integrated Security=True");
        public void YoneticiGiris(string id, string passwd)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Select *from Yonetici where YöneticiId='" + id + "' AND YöneticiSifre='" + passwd + "'", connect);//Veritabanından YoneticiId ve YoneticiId ye ait sifreyi sorgulama.
            SqlDataReader datareader = command.ExecuteReader();
            if (datareader.Read())//Dondurulen degerin "True" olması durumunu kontrol etme.
            {
                datareader.Close();
                Form_ManagementPanel adminpanel = new Form_ManagementPanel();
                adminpanel.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanici Id veya Şifre hatalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
            connect.Close();
        }

        private void Form_AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        { 
            if(txtYoneticiId.Text !="" && txtSifre.Text !="")
                YoneticiGiris(txtYoneticiId.Text, txtSifre.Text);//YoneticiGiris yordamını çalıştırma ve içerisine parametre gönderme.
            else
                MessageBox.Show("Gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFirmaGiris_Click(object sender, EventArgs e)
        {
            Form_Login FirmaGiris = new Form_Login();
            FirmaGiris.Show();
            this.Close();
        }
    }
}
