using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
namespace Apartman_Yönetim
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress; initial Catalog=apartman; Integrated Security=true");

        string sifre;
        private string password = "1";



        private byte[] Sifrele(byte[] SifresizVeri, byte[] Key, byte[] IV)

        {

            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();



            alg.Key = Key;

            alg.IV = IV;



            CryptoStream cs = new CryptoStream(ms,



            alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(SifresizVeri, 0, SifresizVeri.Length);

            cs.Close();



            byte[] sifrelenmisVeri = ms.ToArray();

            return sifrelenmisVeri;

        }



        private byte[] SifreCoz(byte[] SifreliVeri, byte[] Key, byte[] IV)

        {

            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();



            alg.Key = Key;

            alg.IV = IV;



            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);



            cs.Write(SifreliVeri, 0, SifreliVeri.Length);

            cs.Close();



            byte[] SifresiCozulmusVeri = ms.ToArray();

            return SifresiCozulmusVeri;

        }



        public string TextSifrele(string sifrelenecekMetin)

        {

            byte[] sifrelenecekByteDizisi = System.Text.Encoding.Unicode.GetBytes(sifrelenecekMetin);



            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,



            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});



            byte[] SifrelenmisVeri = Sifrele(sifrelenecekByteDizisi,



                 pdb.GetBytes(32), pdb.GetBytes(16));



            return Convert.ToBase64String(SifrelenmisVeri);

        }



        public string TextSifreCoz(string text)

        {

            byte[] SifrelenmisByteDizisi = Convert.FromBase64String(text);



            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,



                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,



            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});



            byte[] SifresiCozulmusVeri = SifreCoz(SifrelenmisByteDizisi,



                pdb.GetBytes(32), pdb.GetBytes(16));



            return System.Text.Encoding.Unicode.GetString(SifresiCozulmusVeri);

        }
        private void Yolla_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) //eğer bağlantı kapalıysa
            {
                baglanti.Open(); //bağlantıyı aç
            }

            SqlCommand com = new SqlCommand("Select * from kullanici where tc_no='" + textBox2.Text.ToString() +
                "'and email='" + textBox1.Text.ToString() + "'", baglanti);
            //burada veritabanina kodlayarak yazdımız şifrelerin kodlarını karşılaştırdık
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                //
                
                sifre = oku["sifre"].ToString();
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                Gonder("Unutmuş Olduğunuz Şifreniz Ektedir", textBox2.Text);
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            baglanti.Close();
            }
        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("emailadresiniz@gmail.com");
            //
            ePosta.To.Add(textBox1.Text);
            ;
         
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("emailadresiniz@gmail.com", "emailsifresi");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
    }
}
