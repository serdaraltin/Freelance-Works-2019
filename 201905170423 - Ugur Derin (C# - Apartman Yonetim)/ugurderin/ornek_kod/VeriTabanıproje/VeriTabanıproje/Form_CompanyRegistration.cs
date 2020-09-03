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
using System.Net.Mail;

namespace VeriTabanıproje
{
    public partial class Form_CompanyRegistration : Form
    {
        public Form_CompanyRegistration()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=" + Properties.Settings.Default.Sunucu + ";Initial Catalog=" + Properties.Settings.Default.VeriTabani + ";Integrated Security=True");


        public void KayitEt(string FirmaAdi , string Telefon, string Eposta, string Mensei, string Mahalle, string Il, string Ilce , string SokakCadde, string No,string YetkiliAdSoyad, string Sifre)
        {
            try
            {
                connect.Open();
                //MusteriFirma tablosuna veri ekeleme
                SqlCommand command = new SqlCommand("Insert Into MusteriFirma (FirmaAdi,Eposta,Telefon,Mensei,YetkiliIsim,Sifre,YöneticiId) values (@FirmaAdi,@Eposta,@Telefon,@Mensei,@YetkiliIsim,@Sifre,@YoneticiId)", connect);
                command.Parameters.AddWithValue("@FirmaAdi", FirmaAdi);
                command.Parameters.AddWithValue("@Eposta", Eposta);
                command.Parameters.AddWithValue("@Telefon", Telefon);
                command.Parameters.AddWithValue("@Mensei", Mensei);
                command.Parameters.AddWithValue("@YetkiliIsim", YetkiliAdSoyad);
                command.Parameters.AddWithValue("@Sifre", Sifre);
                command.Parameters.AddWithValue("@YoneticiId", "Y1545");
                command.ExecuteNonQuery();
                //MusteriFirma tablosuna veri ekeleme

                //FirmaId verisini alma
                SqlCommand command2 = new SqlCommand("Select *from MusteriFirma", connect);
                SqlDataReader datareader = command2.ExecuteReader();
                int FirmaId= 0;
                while (datareader.Read())
                    FirmaId = Convert.ToInt32(datareader["FirmaId"].ToString());
                datareader.Close();
                //FirmaId verisini alma

                //FirmaAdresi tablosuna veri ekeleme
                SqlCommand command3 = new SqlCommand("Insert Into FirmaAdresi (Il,Ilce,Mahalle,Sokak,No,FirmaId) values (@Il,@Ilce,@Mahalle,@Sokak,@No,@FirmaId)", connect);
                command3.Parameters.AddWithValue("@Il", Il);
                command3.Parameters.AddWithValue("@Ilce", Ilce);
                command3.Parameters.AddWithValue("@Mahalle", Mahalle);
                command3.Parameters.AddWithValue("@Sokak", SokakCadde);
                command3.Parameters.AddWithValue("@No", No);
                command3.Parameters.AddWithValue("@FirmaId", FirmaId);
                command3.ExecuteNonQuery();
                //FirmaAdresi tablosuna veri ekeleme

                connect.Close();

                string epostaicerik = "Firma Adı : " + FirmaAdi + Environment.NewLine +
                    "Eposta : " + Eposta + Environment.NewLine +
                    "Telefon : " + Telefon + Environment.NewLine +
                    "Mensei : " + Mensei + Environment.NewLine +
                    "Il : " + Il + Environment.NewLine +
                    "Ilce :" + Ilce + Environment.NewLine +
                    "Mahalle :" + Mahalle + Environment.NewLine +
                    "Sokak/Cadde :" + SokakCadde +" No : "+No+ Environment.NewLine +
                    "Bilgilerine sahip yeni hesabınız oluşturulmuştur." + Environment.NewLine+ Environment.NewLine +
                   "FirmaId : " + FirmaId.ToString() + Environment.NewLine +
                    "Şifre : " + Sifre + Environment.NewLine +
                    "Şeklinde giriş yapabilirsiniz. İyi Günler.";

                MailGonder(Eposta, "VeritabanıProje Kayıt", epostaicerik);

                MessageBox.Show("Kayıt Tamamlandı" + Environment.NewLine + "FirmaId için >> Eposta kutunuzu << kontrol ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception hatamesaji)
            { MessageBox.Show(hatamesaji.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        public void MailGonder(string eposta, string konu, string icerik)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("veritabaniproje@yandex.com");
            mail.To.Add(eposta);
            mail.Subject = konu;
            mail.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("veritabaniproje@yandex.com", "123456789test");
            smtp.Port = 587;
            smtp.Host = "smtp.yandex.com";
            smtp.EnableSsl = true;
            //smtp.SendAsync(mail, (object)mail);
            smtp.Send(mail);
        }
        private void Form_CompanyRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            bool bosdeger = false;
            foreach (Control item in groupBox1.Controls)//grubbox1 içerisindeki textbox kontrollerini inceleyerek boş bir değer varmı kontrol ediyor.
            {
                if (item is TextBox && item.Text == "")
                {
                    errorProvider1.SetError(item, "Bu alan boş olamaz!");
                    bosdeger = true;
                }
            }
            foreach (Control item in groupBox2.Controls)//grubbox1 içerisindeki textbox kontrollerini inceleyerek boş bir değer varmı kontrol ediyor.
            {
                if (item is TextBox && item.Text == "")
                {
                    errorProvider1.SetError(item, "Bu alan boş olamaz!");
                    bosdeger = true;
                }
            }
            if (!(bosdeger)) //bos bir deger yok ise koşul gerçekleşir.
                KayitEt(txt_FirmaAdi.Text, txtTelefon.Text, txtEposta.Text, txtMensei.Text, txtMahalle.Text, txtIl.Text, txtIlce.Text, txtSokakCadde.Text,txtNo.Text, txtYetkiliAdSoyad.Text, txtSifre.Text);
        }
    }
}
