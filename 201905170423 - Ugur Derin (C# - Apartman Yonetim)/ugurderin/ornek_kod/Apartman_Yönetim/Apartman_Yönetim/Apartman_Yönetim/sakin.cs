using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
namespace Apartman_Yönetim
{
    public partial class sakin : Form
    {
        public sakin()
        {
            InitializeComponent();
        }
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

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress; initial Catalog=apartman; Integrated Security=true");
        string toplammaas = "";
        string _odenen = "";
        SqlCommand komut;
        void toplama()
        {
            try
            {
                // Select SUM(maas)From personel
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select SUM(tutar)From borclar", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                toplammaas = dataGridView1.Rows[0].Cells[0].Value.ToString();
                baglanti.Close();
                label1.Text = String.Format("{0:0.00}", double.Parse(toplammaas)) + " TL";
            }
            catch
            {
                ;
            }

        }
        void odenen()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select SUM(odenen)From odenen", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView2.DataSource = dt;

                _odenen = dataGridView2.Rows[0].Cells[0].Value.ToString();
                baglanti.Close();
                label2.Text = String.Format("{0:0.00}", double.Parse(_odenen)) + " TL";
            }
            catch
            {
                ;
            }
        }
        void borclarim()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * From borclar where kullanici='" + Form1.giris + "'", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView4.DataSource = dt;
                baglanti.Close();
                dataGridView4.Columns[0].Visible = false;
                dataGridView4.Columns[1].HeaderText = "Borç Kategorisi";
                dataGridView4.Columns[2].HeaderText = "TC Kimlik No";
                dataGridView4.Columns[3].HeaderText = "Borç Tutarı";
                dataGridView4.Columns[4].HeaderText = "Borç Açıklaması";
                dataGridView4.Columns[5].HeaderText = "Borç Tarihi";
                dataGridView4.Columns[1].Width = 110;
                dataGridView4.Columns[2].Width = 110;
                dataGridView4.Columns[3].Width = 110;
                dataGridView4.Columns[4].Width = 110;
                dataGridView4.Columns[5].Width = 110;
            }
            catch
            {
                ;
            }
        }
        void odedigim()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * From odenen where odeyen='" + Form1.giris + "'", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView3.DataSource = dt;
                baglanti.Close();
                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].HeaderText = "Ödeyenin TC NO";
                dataGridView3.Columns[2].HeaderText = "Ödenen Miktar";
                dataGridView3.Columns[3].HeaderText = "Ödeme Türü";
                dataGridView3.Columns[1].Width = 120;
                dataGridView3.Columns[2].Width = 120;
                dataGridView3.Columns[3].Width = 118;
            }
            catch
            {
                ;
            }
        }
        private void sakin_Load(object sender, EventArgs e)
        {
            odedigim();
            odenen();
            toplama();
            borclarim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM borclar WHERE kategori LIKE'%" + textBox1.Text + "%' and kullanici='" + Form1.giris + "'or aciklama LIKE '%" + textBox1.Text + "' and kullanici='" + Form1.giris + "'or tutar LIKE '%" + textBox1.Text + "' and kullanici='" + Form1.giris + "'", baglanti);
            ad.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DefaultPageSettings.PaperSize = printDocument1.PrinterSettings.PaperSizes[5];
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
            try
            {
                //ÇİZİM BAŞLANGICI
                Font myFont = new Font("Calibri", 7); //font oluşturduk
                SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
                Pen myPen = new Pen(Color.Black); //kalem oluşturduk

                ffff.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(), myFont, sbrush, 50, 25);
                ffff.Graphics.DrawLine(myPen, 50, 45, 770, 45); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX

                myFont = new Font("Calibri", 8, FontStyle.Bold);//Fatura başlığı yazacağımız için fontu kalın yaptık ve puntoyu büyütüp 15 yaptık.
                ffff.Graphics.DrawString("Borç Listesi", myFont, sbrush, 175, 65);
                ffff.Graphics.DrawLine(myPen, 50, 95, 770, 95); //çizgi çizdik.

                myFont = new Font("Calibri", 6, FontStyle.Bold); //Detay başlığını yazacağımız için fontu kalın yapıp puntoyu 10 yaptık.
                ffff.Graphics.DrawString("Kategori", myFont, sbrush, 25, 110); //Detay başlığı
                ffff.Graphics.DrawString("TC No", myFont, sbrush, 90, 110); //Detay başlığı
                ffff.Graphics.DrawString("Tutar", myFont, sbrush, 145, 110); // Detay başlığı
                ffff.Graphics.DrawString("Açıklama", myFont, sbrush, 220, 110); //Detay başlığı
                ffff.Graphics.DrawString("Tarih", myFont, sbrush, 315, 110); //Detay başlığı
                ffff.Graphics.DrawLine(myPen, 25, 125, 770, 125); //Çizgi çizdik.

                int y = 150; //y koordinatının yerini belirledik.(Verilerin yazılmaya başlanacağı yer)

                myFont = new Font("Calibri", 6); //fontu 10 yaptık.

                int i = 0;//satır sayısı için değişken tanımladık.
                while (i <= dataGridView4.Rows.Count)//döngüyü son satırda sonlandıracağız.
                {
                    ffff.Graphics.DrawString(dataGridView4[1, i].Value.ToString(), myFont, sbrush, 25, y);//1.sütun
                    ffff.Graphics.DrawString(dataGridView4[2, i].Value.ToString(), myFont, sbrush, 90, y);//2.sütun
                    ffff.Graphics.DrawString(dataGridView4[3, i].Value.ToString(), myFont, sbrush, 145, y);//3.sütun
                    ffff.Graphics.DrawString(dataGridView4[4, i].Value.ToString(), myFont, sbrush, 220, y);//4.sütun
                    ffff.Graphics.DrawString(dataGridView4[5, i].Value.ToString(), myFont, sbrush, 310, y);//5.sütun
                    y += 20; //y koordinatını arttırdık.
                    i += 1; //satır sayısını arttırdık

                    //yeni sayfaya geçme kontrolü
                    if (y > 1000)
                    {
                        ffff.Graphics.DrawString("(Devamı -->)", myFont, sbrush, 700, y + 50);
                        y = 50;
                        break; //burada yazdırma sınırına ulaştığımız için while döngüsünden çıkıyoruz
                               //çıktığımızda while baştan başlıyor i değişkeni değer almaya devam ediyor
                               //yazdırma yeni sayfada başlamış oluyor
                    }
                }
                //çoklu sayfa kontrolü
                if (i < dataGridView4.RowCount - 1)
                {
                    ffff.HasMorePages = true;
                }
                else
                {
                    ffff.HasMorePages = false;
                    i = 0;
                }
                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;
            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komutum = new SqlCommand("update kullanici set tc_no = '" + maskedTextBox1.Text + "', isim = '" + textBox10.Text + "',soyisim = '" + textBox11.Text + "',email='" + textBox12.Text + "',telefon='" + textBox13.Text + "',daire_no='" + textBox14.Text + "',ev_durumu='" + comboBox5.Text + "'  where tc_no='" + Form1.giris + "'", baglanti);
            komutum.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            baglanti.Close();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == Form1.sifre)
            {
                if (textBox17.Text == textBox16.Text)
                {
                    baglanti.Open();
                    komut = new SqlCommand("update kullanici set sifre ='" + TextSifrele(textBox17.Text) + "'where tc_no='" + Form1.giris + "'", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarılı");
                    baglanti.Close();
                   
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
            }
            else
            {
                MessageBox.Show("Mevcut Şifreniz Yanlıştır");
            }
        }

        private void chromeButton7_Click(object sender, EventArgs e)
        {
            //panel20.Hide();
            baglanti.Open();
            komut = new SqlCommand("select * from kullanici where tc_no='" + Form1.giris + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                maskedTextBox1.Text = dr["tc_no"].ToString();
                textBox10.Text = dr["isim"].ToString();
                textBox11.Text = dr["soyisim"].ToString();
                textBox12.Text = dr["email"].ToString();
                textBox13.Text = dr["telefon"].ToString();
                textBox14.Text = dr["daire_no"].ToString();
                comboBox5.Text = dr["ev_durumu"].ToString();
            }
            else
            {
                MessageBox.Show("Veri Çekme İşlemi Başarısız");
            }
            baglanti.Close();
            panel8.Hide();
            // panel16.Hide();
        }

        private void chromeButton6_Click(object sender, EventArgs e)
        {

            panel20.Hide();
            panel8.Show();
        }
    }
}
