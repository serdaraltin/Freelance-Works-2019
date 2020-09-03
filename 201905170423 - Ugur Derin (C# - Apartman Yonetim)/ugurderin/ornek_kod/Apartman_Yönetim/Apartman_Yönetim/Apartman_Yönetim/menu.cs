using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Security.Cryptography;
namespace Apartman_Yönetim
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress; initial Catalog=apartman; Integrated Security=true");
        SqlCommand komut;
        string kontrol = "";
        DataSet dset = new DataSet();
        string yetki_gelir = "0";
        string yetki_gider = "0";
        string yetki_kasa = "0";
        string yetki_borc = "0";
        string yetki_daire = "0";
        string yetki_kullanici = "0";
        string bilgisayarAdi = Dns.GetHostName();
        string toplammaas = "";
        string _odenen = "";
        string _borc = "";
        string toplamgelir = "";
        string toplamgider = "";
        double bakiye = 0;
        string secilen = "";
        string _hesaplama = "";
        int hesapla;
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
        
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox33.Text = "";
            textBox45.Text = "";
            textBox44.Text = "";
           // textBox46.Text = "";
            //
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            //
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            //
            comboBox13.Text = "";
            comboBox12.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
        }
        void borc_tipi()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM borc_tipi", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView12.DataSource = dt;
                dataGridView12.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView12.Columns[1].HeaderText = "Borç Tipi";
                dataGridView12.Columns[2].HeaderText = "Borç Açıklaması";
                dataGridView12.Columns[1].Width = 133;
                dataGridView12.Columns[2].Width = 145;
            }
            catch
            {
                ;
            }
        }
        void kullanici2()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM kullanici", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView10.DataSource = dt;
                dataGridView10.Columns[0].Visible = false;
                dataGridView10.Columns[9].Visible = false;
                dataGridView10.Columns[8].Visible = false;
               
                baglanti.Close();
                dataGridView10.Columns[1].HeaderText = "TC Kimlik No";
                dataGridView10.Columns[2].HeaderText = "İsim";
                dataGridView10.Columns[3].HeaderText = "Soyisim";
                dataGridView10.Columns[4].HeaderText = "Email Adresi";
                dataGridView10.Columns[5].HeaderText = "Telefon No";
                dataGridView10.Columns[6].HeaderText = "Daire";
                dataGridView10.Columns[7].HeaderText = "Ev Durumu";
           
                dataGridView10.Columns[1].Width = 90;
                dataGridView10.Columns[2].Width = 62;
                dataGridView10.Columns[3].Width = 62;
                dataGridView10.Columns[4].Width = 90;
                dataGridView10.Columns[5].Width = 90;
                dataGridView10.Columns[6].Width = 90;
                dataGridView10.Columns[7].Width = 90;
                
            }
            catch
            {
                ;
            }
        }
        void LOG()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM log ORDER BY id DESC", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView7.DataSource = dt;
                dataGridView7.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView7.Columns[1].HeaderText = "Gerçekleştirilen İşlem";
                dataGridView7.Columns[2].HeaderText = "İpi Adresi";
                dataGridView7.Columns[3].HeaderText = "TC Numarası";
                dataGridView7.Columns[4].HeaderText = "İşlem Açıklaması";
                dataGridView7.Columns[5].HeaderText = "İşlem Tarihi";
                dataGridView7.Columns[1].Width = 115;
                dataGridView7.Columns[2].Width = 110;
                dataGridView7.Columns[3].Width = 110;
                dataGridView7.Columns[4].Width = 112;
                dataGridView7.Columns[5].Width = 110;
            }
            catch
            {
                ;
            }
        }
        void daire()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter add = new SqlDataAdapter("SELECT * FROM daire", baglanti);
                DataTable dtt = new DataTable();
                add.Fill(dtt);
                dataGridView9.DataSource = dtt;
                dataGridView9.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView9.Columns[1].HeaderText = "Daire Tipi";
                dataGridView9.Columns[2].HeaderText = "Kira Tutarı";
                dataGridView9.Columns[3].HeaderText = "Aidat Tutarı";
                dataGridView9.Columns[1].Width = 110;
                dataGridView9.Columns[2].Width = 110;
                dataGridView9.Columns[3].Width = 105;
            }
            catch
            {
                ;
            }
        }
        void toplama()
        {
            try
            {
                // Select SUM(maas)From personel
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select SUM(tutar)From borclar", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView8.DataSource = dt;
                toplammaas = dataGridView8.Rows[0].Cells[0].Value.ToString();
                baglanti.Close();
                label1.Text = String.Format("{0:0.00}", double.Parse(toplammaas)) + " TL";
            }
            catch
            {
                ;
            }
        }
        void kullanici()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM kullanici", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
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
        void gelir()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter add = new SqlDataAdapter("SELECT * FROM gelirler", baglanti);
                DataTable dtt = new DataTable();
                add.Fill(dtt);
                dataGridView5.DataSource = dtt;
                dataGridView5.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView5.Columns[0].Visible = false;
                dataGridView5.Columns[1].HeaderText = "Gelir Kategorisi";
                dataGridView5.Columns[2].HeaderText = "Gelir Tutarı";
                dataGridView5.Columns[3].HeaderText = "Gelir Açıklaması";
                dataGridView5.Columns[4].HeaderText = "Gelir Tarihi";
                dataGridView5.Columns[1].Width = 130;
                dataGridView5.Columns[2].Width = 130;
                dataGridView5.Columns[3].Width = 130;
                dataGridView5.Columns[4].Width = 130;
               
            }
            catch
            {
                ;
            }
        }
        void gider()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM giderler", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView6.DataSource = dt;
                dataGridView6.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView6.Columns[1].HeaderText = "Gider Kategorisi";
                dataGridView6.Columns[2].HeaderText = "Gider Tutarı";
                dataGridView6.Columns[3].HeaderText = "Gider Açıklaması";
                dataGridView6.Columns[4].HeaderText = "Gider Tarihi";
                dataGridView6.Columns[1].Width = 130;
                dataGridView6.Columns[2].Width = 130;
                dataGridView6.Columns[3].Width = 130;
                dataGridView6.Columns[4].Width = 130;
            }
            catch
            {
                ;
            }
        }
        void Borclar()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * From borclar ORDER BY id DESC", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView11.DataSource = dt;
                dataGridView11.Columns[0].Visible = false;
                baglanti.Close();
                dataGridView11.Columns[1].HeaderText = "Borç Kategorisi";
                dataGridView11.Columns[2].HeaderText = "TC Numarası";
                dataGridView11.Columns[3].HeaderText = "Borç Tutarı";
                dataGridView11.Columns[4].HeaderText = "Borç Açıklaması";
                dataGridView11.Columns[5].HeaderText = "Borç Tarihi";
                dataGridView11.Columns[1].Width = 97;
                dataGridView11.Columns[2].Width = 97;
                dataGridView11.Columns[3].Width = 90;
                dataGridView11.Columns[4].Width = 105;
                dataGridView11.Columns[5].Width = 103;
            }
            catch
            {
                ;
            }
        }
        private void menu_Load(object sender, EventArgs e)
        {
            label82.Text = Form1.giris;
            yukle();
            try
            {
                printDocument2.DefaultPageSettings.PaperSize = printDocument2.PrinterSettings.PaperSizes[5];
                printDocument4.DefaultPageSettings.PaperSize = printDocument4.PrinterSettings.PaperSizes[5];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            doldurt();
            daire();
            LOG();
            kullanici();
            
            toplama();
            odenen();
            odedigim();
            borclarim();
            gelir();
            gider();
            int kayitsayisi = dataGridView1.RowCount - 1;
            String.Format("{0:0.##}", label3.Text = kayitsayisi.ToString() + " Kullanıcı");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.MultiSelect = false;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.MultiSelect = false;
            dataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView7.MultiSelect = false;
            dataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView8.MultiSelect = false;
            dataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView9.MultiSelect = false;
            dataGridView10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView10.MultiSelect = false;
            dataGridView11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView11.MultiSelect = false;
            dataGridView12.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView12.MultiSelect = false;
            dataGridView13.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView13.MultiSelect = false;
            dataGridView14.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView14.MultiSelect = false;
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
                if (i < dataGridView4.RowCount-1)
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
        private void chromeButton2_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_gelir == "1")
            {
                panel25.Hide();
            panel4.Show();
            panel5.Hide();
            }
            else
            {
                MessageBox.Show("Gelir İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into gelirler(kategori,tutar,aciklama,tarih)values('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString() + "') ", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Gelir Ekleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gelir Ekleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox3.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
                  gelir();
                  temizle();
            }
            catch
            {
                
            }
    }
        private void chromeButton1_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_gelir == "1")
            {
                panel25.Hide();
            panel5.Hide();
            panel4.Hide();
            }
            else
            {
                MessageBox.Show("Gelir İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void dataGridView5_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView5.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView5_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView5_Duzenle));
                }
                //boşluğada tıklansa hepsini sil menüsü gösterilsin
                //  m.MenuItems.Add(new MenuItem("Hepsini Sil", dataGridView1_hepsiniSil));
                m.Show(dataGridView5, new Point(e.X, e.Y));//menuyu goster
            }
        }
        private void dataGridView5_Sil(object sender, EventArgs e)
        {
            
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from gelirler where id='" + dataGridView5.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gelir Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Gelir Silme İşlemi Yapılmıştır" + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            gelir();
            temizle();
        }
        private void dataGridView5_Duzenle(object sender, EventArgs e)
        {
            panel5.Show();
            comboBox2.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
        }
        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double tutar = Math.Round(double.Parse(textBox5.Text));
                baglanti.Open();
                komut = new SqlCommand("update gelirler set kategori = '" + comboBox2.Text + "', tutar = '" + tutar + "', aciklama = '" + textBox4.Text + "', tarih = '" + DateTime.Now.ToString() + "'where id='" + dataGridView5.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Gelir Güncelleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gelir Güncelleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox4.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
                gelir();
                temizle();
                gelir();
                panel5.Hide();
            }
            catch
            {
                ;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into giderler(kategori,tutar,aciklama,tarih)values('" + comboBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + DateTime.Now.ToString() + "') ", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Gider Ekleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gider Ekleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox6.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
                gider();
                temizle();
            }
            catch
            {
                ;
            }
        }
        private void dataGridView6_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView6.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView6_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView6_Duzenle));
                }
                //boşluğada tıklansa hepsini sil menüsü gösterilsin
                //  m.MenuItems.Add(new MenuItem("Hepsini Sil", dataGridView1_hepsiniSil));
                m.Show(dataGridView6, new Point(e.X, e.Y));//menuyu goster
            }
        }
        private void dataGridView6_Sil(object sender, EventArgs e)
        {
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from giderler where id='" + dataGridView6.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gider Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "" + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            gider();
            temizle();
        }
        private void dataGridView6_Duzenle(object sender, EventArgs e)
        {
            panel7.Show();
            comboBox4.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
          
            panel5.Show();
            comboBox2.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from gelirler where id='" + dataGridView5.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gelir Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Gelir Silme İşlemi Yapılmıştır" + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            gelir();
            temizle();
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from giderler where id='" + dataGridView6.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gider Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "" + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            gider();
             temizle();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            panel7.Show();
            comboBox4.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
        }
        private void chromeButton3_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_gider == "1")
            {
                panel24.Hide();
            panel6.Show();
            panel7.Hide();
            }
            else
            {
                MessageBox.Show("Gider İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double tutar = Math.Round(double.Parse(textBox9.Text));
                baglanti.Open();
                komut = new SqlCommand("update giderler set kategori = '" + comboBox4.Text + "', tutar = '" + tutar + "', aciklama = '" + textBox8.Text + "', tarih = '" + DateTime.Now.ToString() + "'where id='" + dataGridView6.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Gider Güncelleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Gider Güncelleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox8.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
                gider();
                temizle();
                panel7.Hide();
            }
            catch
            {
                ;
            }
        }
        private void chromeButton4_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_gider == "1")
            {
                panel24.Hide();
                panel7.Hide();
                panel6.Hide();
            }
            else
            {
                MessageBox.Show("Gider İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void chromeButton5_Click(object sender, EventArgs e)
        {
            LOG();
            panel21.Hide();
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM log WHERE islem LIKE'%" + textBox15.Text + "%' or ip LIKE '%"+textBox15.Text+ "%' or tc LIKE '%"+textBox15.Text+"%'or aciklama LIKE '%"+textBox15.Text+"%'OR tarih LIKE '%"+textBox15.Text+"%' ", baglanti);
            ad.Fill(dt);
            dataGridView7.DataSource = dt;
            baglanti.Close();
        }
        private void chromeButton7_Click(object sender, EventArgs e)
        {
            panel20.Hide();
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
            kullanici();
            temizle();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == Form1.sifre)
            {
                if (textBox17.Text == textBox16.Text)
                {
                    baglanti.Open();
                    komut = new SqlCommand("update kullanici set sifre ='" +TextSifrele(textBox17.Text) + "'where tc_no='" + Form1.giris + "'", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarılı");
                    baglanti.Close();
                    temizle();
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
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into daire(tipi,kira,aidat)values('" + textBox21.Text + "','" + textBox20.Text + "','" + textBox19.Text + "') ", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Daire Tipi Ekleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Daire Tipi Ekleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Yeni Bir Daire Tipi Eklenmiştir." + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
                daire();
                temizle();
            }
            catch
            {
                ;
            }
        }
        private void chromeButton9_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_daire == "1")
            {
                panel23.Hide();
                 panel9.Hide();
        }
            else
            {
                MessageBox.Show("Daire İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void chromeButton8_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_daire == "1")
            {
                panel23.Hide();
            panel10.Hide();
            panel9.Show();
            }
            else
            {
                MessageBox.Show("Daire İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void chromeButton6_Click(object sender, EventArgs e)
        {
            panel20.Hide();
            panel8.Show();
        }
        private void dataGridView9_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView9.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView9_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView9_Duzenle));
                }
                //boşluğada tıklansa hepsini sil menüsü gösterilsin
                //  m.MenuItems.Add(new MenuItem("Hepsini Sil", dataGridView1_hepsiniSil));
                m.Show(dataGridView9, new Point(e.X, e.Y));//menuyu goster
            }
        }
        private void dataGridView9_Sil(object sender, EventArgs e)
        {
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from daire where id='" + dataGridView9.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Daire Tipi Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Daire Tipi Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            daire();
            temizle();
        }
        private void dataGridView9_Duzenle(object sender, EventArgs e)
        {
            panel10.Show();
            textBox24.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            textBox23.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            textBox22.Text = dataGridView9.CurrentRow.Cells[3].Value.ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("update daire set tipi = '" + textBox24.Text + "', kira = '" + textBox23.Text + "', aidat = '" + textBox22.Text + "'where id='" + dataGridView9.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Daire Tipi Güncelleme İşlemi Başarılı");
                baglanti.Close();
                //sira loga eklemede
                baglanti.Open();
                SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Daire Tip Güncelleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox22.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                log.ExecuteNonQuery();
                baglanti.Close();
               temizle();
                daire();
                panel10.Hide();
            }
            catch
            {
                ;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            panel10.Show();
            textBox24.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            textBox23.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            textBox22.Text = dataGridView9.CurrentRow.Cells[3].Value.ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("İçeri girdi"+ dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString());
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from daire where id='" + dataGridView9.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Daire Tipi Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Daire Tipi Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            daire();
             temizle();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            string SectigimizVeriler = "";
            try
            {
                if (textBox27.Text.Contains("@") && textBox27.Text.Contains(".com"))
                {
                    if (textBox29.Text == textBox30.Text)
                    {
                        baglanti.Open();
                        string sifrelisifre=TextSifrele(textBox30.Text);
                        komut = new SqlCommand("insert into kullanici(tc_no,isim,soyisim,email,telefon,daire_no,ev_durumu,rol,sifre) values('" + maskedTextBox2.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + maskedTextBox3.Text + "','" + textBox28.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + sifrelisifre + "')", baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Ekleme Başarılı");
                        baglanti.Close();
                        if (comboBox7.Text == "Admin")
                        {
                            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                            {
                                yetki_gelir = "1";
                            }
                            else
                            {
                                yetki_gelir = "0";
                            }
                            MessageBox.Show(yetki_gelir);
                            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
                            {
                                yetki_gider = "1";
                            }
                            else
                            {
                                yetki_gider = "0";
                            }
                            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
                            {
                                yetki_kasa = "1";
                            }
                            else
                            {
                                yetki_kasa = "0";
                            }
                            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
                            {
                                yetki_borc = "1";
                            }
                            else
                            {
                                yetki_borc = "0";
                            }
                            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
                            {
                                yetki_daire = "1";
                            }
                            else
                            {
                                yetki_daire = "0";
                            }
                            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
                            {
                                yetki_kullanici = "1";
                            }
                            else
                            {
                                yetki_kullanici = "0";
                            }
                        
          
                        baglanti.Open();
                            komut = new SqlCommand("insert into yetki(tc,gelir_isleri,gider_isleri,kasa_isleri,borc_isleri,daire_isleri,kullanici_isleri) values('" + maskedTextBox2.Text + "','" + yetki_gelir + "','" + yetki_gider + "','" + yetki_kasa + "','" + yetki_borc + "','" + yetki_daire + "','" + yetki_kullanici + "')", baglanti);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        temizle();
                        kullanici();
                        kullanici2();
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Gerçek Bir Email Giriniz");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hatanız var ! " + hata.Message);
            }
        }
        private void chromeCheckbox1_CheckedChanged(object sender)
        {
          
            if (chromeCheckbox1.Checked == true)
            {
                textBox30.PasswordChar = '\0';
                textBox29.PasswordChar = '\0';
                
            }
            else
            {
                textBox29.PasswordChar = '*';
                textBox30.PasswordChar = '*';
            }
        }
        private void chromeButton10_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_kullanici == "1")
            {
                panel22.Hide();
                panel13.Hide();
                panel12.Hide();
                panel11.Show();
                kullanici2();
            }
            else
            {
                MessageBox.Show("Böyle Bir Yetkiniz Yok");
            }
        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM kullanici WHERE tc_no LIKE'%" + textBox31.Text + "%'or isim LIKE '%"+textBox31.Text+"%'or soyisim LIKE '%" + textBox31.Text + "%'", baglanti);
            ad.Fill(dt);
            dataGridView10.DataSource = dt;
            baglanti.Close();
        }
        private void dataGridView10_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView10.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView10_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView10_Duzenle));
                    m.MenuItems.Add(new MenuItem("Engelle", dataGridView10_Engelle));
                    m.MenuItems.Add(new MenuItem("Rol Düzenle", dataGridView10_RolDuzenle));
                }
                //boşluğada tıklansa hepsini sil menüsü gösterilsin
                m.Show(dataGridView10, new Point(e.X, e.Y));//menuyu goster
            }
        }
        private void dataGridView10_Sil(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from kullanici where tc_no='" + dataGridView10.CurrentRow.Cells["tc_no"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            kullanici2();
            kullanici();
        }
        private void dataGridView10_Engelle(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int rastgele = rdm.Next(00000000,99999999);
            string engel = "Engellendi!+" + rastgele.ToString();
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("update kullanici set sifre = '" + engel + "' where tc_no='" + dataGridView10.CurrentRow.Cells["tc_no"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Engelleme İşlemi Başarılı");
            baglanti.Close();
            kullanici();
            kullanici2();
            temizle();
            
        }
        private void dataGridView10_RolDuzenle(object sender, EventArgs e)
        {
            textBox38.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
            panel13.Show();
            
        }
        private void dataGridView10_Duzenle(object sender, EventArgs e)
        {
            try
            {
                panel13.Hide();
                panel12.Show();
                textBox32.Text =TextSifreCoz( dataGridView10.CurrentRow.Cells[9].Value.ToString());
                textBox33.Text = TextSifreCoz( dataGridView10.CurrentRow.Cells[9].Value.ToString());
                comboBox8.Text = dataGridView10.CurrentRow.Cells[8].Value.ToString();
                comboBox9.Text = dataGridView10.CurrentRow.Cells[7].Value.ToString();
                textBox34.Text = dataGridView10.CurrentRow.Cells[6].Value.ToString();
                maskedTextBox4.Text = dataGridView10.CurrentRow.Cells[5].Value.ToString();
                textBox35.Text = dataGridView10.CurrentRow.Cells[4].Value.ToString();
                textBox36.Text = dataGridView10.CurrentRow.Cells[3].Value.ToString();
                textBox37.Text = dataGridView10.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox5.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Satır seçtiğinizden emin olun"+hata.Message);
            }
            
        }
        private void chromeButton11_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_kullanici == "1")
            {
                panel22.Hide();
            panel13.Hide();
            panel11.Hide();
            panel12.Hide();
            }
            else
            {
                MessageBox.Show("Böyle Bir Yetkiniz Yok");
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from kullanici where tc_no='" + dataGridView10.CurrentRow.Cells["tc_no"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            kullanici2();
            kullanici();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel13.Hide();
            textBox32.Text = TextSifreCoz(dataGridView10.CurrentRow.Cells[9].Value.ToString());
            textBox33.Text = TextSifreCoz(dataGridView10.CurrentRow.Cells[9].Value.ToString());
            comboBox8.Text = dataGridView10.CurrentRow.Cells[8].Value.ToString();
            comboBox9.Text = dataGridView10.CurrentRow.Cells[7].Value.ToString();
            textBox34.Text = dataGridView10.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox4.Text = dataGridView10.CurrentRow.Cells[5].Value.ToString();
            textBox35.Text = dataGridView10.CurrentRow.Cells[4].Value.ToString();
            textBox36.Text = dataGridView10.CurrentRow.Cells[3].Value.ToString();
            textBox37.Text = dataGridView10.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox5.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int rastgele = rdm.Next(00000000, 99999999);
            string engel = "Engellendi!+" + rastgele.ToString();
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("update kullanici set sifre = '" + engel + "' where tc_no='" + dataGridView10.CurrentRow.Cells["tc_no"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Engelleme İşlemi Başarılı");
            baglanti.Close();
            kullanici();
            kullanici2();
             temizle();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                textBox38.Text = dataGridView10.CurrentRow.Cells[10].Value.ToString();
                panel3.Show();
            }
            catch (Exception)
            {
                throw;
            }
          
        }
        private void button20_Click(object sender, EventArgs e)
        {
       
            baglanti.Open();
            string sifrelisifre = TextSifrele(textBox33.Text);
            SqlCommand komutum = new SqlCommand("update kullanici set tc_no = '" + maskedTextBox5.Text + "', isim = '" + textBox37.Text + "',soyisim = '" + textBox36.Text + "',email='" + textBox35.Text + "',telefon='" + maskedTextBox4.Text + "',daire_no='" + textBox34.Text + "',ev_durumu='" + comboBox9.Text + "',rol='" + comboBox8.Text + "',sifre='" + sifrelisifre + "'  where tc_no='" + dataGridView10.CurrentRow.Cells["tc_no"].Value.ToString() + "'", baglanti);
            komutum.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            baglanti.Close();
            kullanici2();
           temizle();
            panel12.Hide();
        }
        private void chromeCheckbox2_CheckedChanged(object sender)
        {
            if (chromeCheckbox2.Checked == true)
            {
                textBox32.PasswordChar = '\0';
                textBox33.PasswordChar = '\0';
            }
            else
            {
                textBox32.PasswordChar = '*';
                textBox33.PasswordChar = '*';
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                string yetki_gelir1 = "0";
                string yetki_gider1 = "0";
                string yetki_kasa1 = "0";
                string yetki_borc1 = "0";
                string yetki_daire1 = "0";
                string yetki_kullanici1 = "0";
                if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
                {
                    yetki_gelir1 = "1";
                }
                else
                {
                    yetki_gelir1 = "0";
                }
                if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
                {
                    yetki_gider1 = "1";
                }
                else
                {
                    yetki_gider1 = "0";
                }
                if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
                {
                    yetki_kasa1 = "1";
                }
                else
                {
                    yetki_kasa1 = "0";
                }
                if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
                {
                    yetki_borc1 = "1";
                }
                else
                {
                    yetki_borc1 = "0";
                }
                if (checkedListBox2.GetItemCheckState(4) == CheckState.Checked)
                {
                    yetki_daire1 = "1";
                }
                else
                {
                    yetki_daire1 = "0";
                }
                if (checkedListBox2.GetItemCheckState(5) == CheckState.Checked)
                {
                    yetki_kullanici1 = "1";
                }
                else
                {
                    yetki_kullanici1 = "0";
                }
                baglanti.Open();
                SqlCommand komutum = new SqlCommand("update yetki set gelir_isleri = '" + yetki_gelir1 + "',gider_isleri = '" + yetki_gider1 + "',kasa_isleri = '" + yetki_kasa1 + "',borc_isleri='" + yetki_borc1 + "',daire_isleri='" + yetki_daire1 + "',kullanici_isleri='" + yetki_kullanici1 + "'  where tc='" + textBox38.Text + "'", baglanti);
                komutum.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yetkiler Başarıyla Değiştirildi");
                temizle();
                kullanici2();
                panel13.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
           
          
        }
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into borclar(kategori,kullanici,tutar,aciklama,tarih) values('" + comboBox10.Text + "','" + comboBox11.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Borçlandırma İşlemi Başarılı");
                baglanti.Close();
            }
            catch
            {
                ;
            }
            //sira loga eklemede burdan başliyor
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borçlandırma İşlemi" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + textBox40.Text + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
           temizle();
        }
        private void chromeButton13_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_borc == "1")
            {
                panel16.Hide();
                panel15.Hide();
                panel14.Hide();
                doldurt();
              
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz yokdur");
            }
        }
        void doldurt()
        {
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            comboBox10.Items.Clear();
            comboBox11.Items.Clear();
            comboBox13.Items.Clear();
             comboBox12.Items.Clear();
            comboBox14.Items.Clear(); //hangi amaçla neden eklemi hatirlamıyorum o yüzden silemem ama sen silersin kendin bilirsin :D
            // combo 2 ekle oraya o yok bi dk bırak bu şekilde çalıştırana bı
        //her çağirişimizde metodu tekrar tekrar yükler alta doğru uzar diye önce temizleyip ekliyoruz mantık bu ama combobların ısmı yanzlıs
            baglanti.Open();
            komut = new SqlCommand("select * from borc_tipi", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                // gelir ve gider comboların ısımlerını gelir ve gider yapıp burdada degıstırırımısın tasarım her dfasında bozuluyor istersen izzle nasıl bozuldunu artı başka yerde ekleme silme güncelleştirmede kullanıyoruz hepsi hata yapacak
                // bunla tek form ıcındemı ğeki combobox 4 ile 2 yi goruyomu yani görüyor yoksa kızıl renge bürünüyor hata veriyor
                comboBox4.Items.Add(dr["borc_tipi"].ToString());
                comboBox2.Items.Add(dr["borc_tipi"].ToString());
                comboBox10.Items.Add(dr["borc_tipi"].ToString());
                comboBox13.Items.Add(dr["borc_tipi"].ToString());
               
            }
            //buralarb urası
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("select * from kullanici", baglanti);
            komutt.ExecuteNonQuery();
            SqlDataReader drr = komutt.ExecuteReader();
            while (drr.Read())
            {
                comboBox11.Items.Add(drr["tc_no"].ToString());
                comboBox12.Items.Add(drr["tc_no"].ToString());
                comboBox14.Items.Add(drr["tc_no"].ToString());//burda çekdi
            }
            baglanti.Close();
        }
        private void chromeButton12_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_borc == "1")
            {
                panel16.Hide();
                panel15.Hide();
                panel14.Show();
                Borclar();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz yokdur");
            }
        }
        private void dataGridView11_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView11.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView11_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView11_Duzenle));
                }
                m.Show(dataGridView11, new Point(e.X, e.Y));//menuyu goste
            }
        }
        private void dataGridView11_Sil(object sender, EventArgs e)
        {
       ;
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from borclar where id='" + dataGridView6.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            Borclar();
            temizle();
        }
        private void dataGridView11_Duzenle(object sender, EventArgs e)
        {
            try
            {
                panel15.Show();
                comboBox13.Text = dataGridView11.CurrentRow.Cells[1].Value.ToString();
                comboBox12.Text = dataGridView11.CurrentRow.Cells[2].Value.ToString();
                textBox42.Text = dataGridView11.CurrentRow.Cells[4].Value.ToString();
                _borc = dataGridView11.CurrentRow.Cells[3].Value.ToString();
                textBox43.Text = String.Format("{0:0}", Math.Round(double.Parse(_borc), 0));
            }
            catch (Exception)
            {
                throw;
            }
          
        }
        private void button24_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from borclar where id='" + dataGridView6.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            Borclar();
            temizle();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            panel15.Show();
            comboBox13.Text = dataGridView11.CurrentRow.Cells[1].Value.ToString();
            comboBox12.Text = dataGridView11.CurrentRow.Cells[2].Value.ToString();
          
            textBox42.Text = dataGridView11.CurrentRow.Cells[4].Value.ToString();
            _borc = dataGridView11.CurrentRow.Cells[3].Value.ToString();
            textBox43.Text = String.Format("{0:0}", Math.Round(double.Parse(_borc),0));
        }
        private void button25_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("update borclar set kategori ='" + comboBox13.Text + "',kullanici='" + comboBox12.Text + "',tutar='" + textBox43.Text + "',aciklama='" + textBox42.Text + "'where id = '" + dataGridView11.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede hepsi
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Güncelleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Güncelleme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            Borclar();
            panel15.Hide();
            temizle();
        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM borclar WHERE kategori LIKE'%" + textBox41.Text + "%' or kullanici LIKE '%" + textBox41.Text + "%'or aciklama LIKE '%" + textBox41.Text + "%'OR tutar LIKE '%" + textBox41.Text + "%' ", baglanti);
            ad.Fill(dt);
            dataGridView11.DataSource = dt;
            baglanti.Close();
        }
        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into borc_tipi(borc_tipi,aciklama)values('" + textBox44.Text + "','" + textBox45.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme İşlemi Başarılı");
                baglanti.Close();
            }
            catch
            {
                ;
            }
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Tipi Ekleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Tipi Ekleme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            Borclar();
            temizle();
            
        }
        private void chromeButton14_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_borc == "1")
            {
                panel18.Hide();
                panel17.Show();
                panel19.Hide();
                borc_tipi();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz yokdur");
            }
        }
        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM borc_tipi WHERE borc_tipi LIKE'%" + textBox46.Text + "%' or aciklama LIKE '%" + textBox46.Text + "%'", baglanti);
            ad.Fill(dt);
            dataGridView12.DataSource = dt;
            baglanti.Close();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            panel18.Show();
            textBox48.Text = dataGridView12.CurrentRow.Cells[1].Value.ToString();
            textBox47.Text = dataGridView12.CurrentRow.Cells[2].Value.ToString();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from borc_tipi where id='" + dataGridView12.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Tipi Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Tipi Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            borc_tipi();
            temizle();
        }
        private void chromeButton15_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_borc == "1")
            {
                panel18.Hide();
                panel17.Hide();
                panel19.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz yokdur");
            }
        }
        private void dataGridView12_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView12.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView12_Sil));
                    m.MenuItems.Add(new MenuItem("Düzenle", dataGridView12_Duzenle));
                }
                m.Show(dataGridView12, new Point(e.X, e.Y));//menuyu goster
            }
        }
        private void dataGridView12_Sil(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("delete from borc_tipi where id='" + dataGridView12.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komutt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Tipi Silme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Tipi Silme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            borc_tipi();
            temizle();
        }
        private void dataGridView12_Duzenle(object sender, EventArgs e)
        {
            try
            {
                panel18.Show();
                textBox48.Text = dataGridView12.CurrentRow.Cells[1].Value.ToString();
                textBox47.Text = dataGridView12.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
               ;
            }
           
        }
        private void button29_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("update borc_tipi set borc_tipi ='" + textBox48.Text + "',aciklama='" + textBox47.Text + "'where id = '" + dataGridView12.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            baglanti.Close();
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Tipi Güncelleme" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Tipi Güncelleme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            borc_tipi();
            temizle();
            panel18.Hide();
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
            try
            {
                //ÇİZİM BAŞLANGICI
                Font myFont = new Font("Calibri", 7); //font oluşturduk
                SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
                Pen myPen = new Pen(Color.Black); //kalem oluşturduk
                ffff.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(), myFont, sbrush, 50, 25);
                ffff.Graphics.DrawLine(myPen, 40 ,45, 770, 45); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX
                myFont = new Font("Calibri", 10, FontStyle.Bold);
                ffff.Graphics.DrawString("KASA ÇIKTISI", myFont, sbrush, 175, 65);
                ffff.Graphics.DrawLine(myPen, 40, 95, 770, 95); //çizgi çizdik.
                myFont = new Font("Calibri", 6, FontStyle.Bold); //Detay başlığını yazacağımız için fontu kalın yapıp puntoyu 10 yaptık.
                ffff.Graphics.DrawString("TOPLAM GELİR", myFont, sbrush, 40, 110); //Detay başlığı
                ffff.Graphics.DrawString("TOPLAM GİDER", myFont, sbrush, 40, 160); //Detay başlığı
                ffff.Graphics.DrawString("BAKİYE", myFont, sbrush, 40, 210); // Detay başlığı
            
                ffff.Graphics.DrawLine(myPen, 40, 125, 770, 125); //Çizgi çizdik.
                myFont = new Font("Calibri", 9); //fontu 10 yaptık.
             
                    ffff.Graphics.DrawString(toplamgelir+" TL", myFont, sbrush,40, 125);//1.sütun
                    ffff.Graphics.DrawString(toplamgider+" TL", myFont, sbrush, 40, 175);//2.sütun
                    ffff.Graphics.DrawString(bakiye.ToString()+" TL", myFont, sbrush, 40, 225);//3.sütun
                   
             
                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;
            }
            catch
            {
            }
        }
        private void chromeButton17_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_kasa == "1")
            {
                yukle();
                panel30.Hide();
                panel29.Hide();
                panel26.Hide();
                panel28.Hide();
                panel27.Hide();
            }
            else
            {
                MessageBox.Show("Kasa İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        void yukle()
        {
            baglanti.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select SUM(tutar) from gelirler ", baglanti);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView8.DataSource = dt;
            toplamgelir = dataGridView8.Rows[0].Cells[0].Value.ToString();
            baglanti.Close();
            baglanti.Open();
            SqlDataAdapter ad2 = new SqlDataAdapter("select SUM(tutar) from giderler ", baglanti);
            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            toplamgider = dataGridView2.Rows[0].Cells[0].Value.ToString();
            bakiye = double.Parse(toplamgelir.ToString()) - double.Parse(toplamgider.ToString());
            baglanti.Close();
        }
        private void button30_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }
        private void chromeButton16_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_kasa == "1")
            {
                panel30.Hide();
                panel29.Hide();
                panel26.Show();
                panel27.Hide();
                panel28.Hide();
            }
            else
            {
                MessageBox.Show("Kasa İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            secilen = comboBox14.Text;
            panel27.Show();
            try
            {
                baglanti.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * From borclar where kullanici='" + secilen + "'", baglanti);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView13.DataSource = dt;
                baglanti.Close();
                dataGridView13.Columns[0].Visible = false;
                dataGridView13.Columns[1].HeaderText = "Borç Kategorisi";
                dataGridView13.Columns[2].HeaderText = "TC Kimlik No";
                dataGridView13.Columns[3].HeaderText = "Borç Tutarı";
                dataGridView13.Columns[4].HeaderText = "Borç Açıklaması";
                dataGridView13.Columns[5].HeaderText = "Borç Tarihi";
                dataGridView13.Columns[1].Width = 110;
                dataGridView13.Columns[2].Width = 110;
                dataGridView13.Columns[3].Width = 110;
                dataGridView13.Columns[4].Width = 110;
                dataGridView13.Columns[5].Width = 110;
            }
            catch
            {
                ;
            }
        }
        private void panel26_Paint(object sender, PaintEventArgs e)
        {
        }
        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
            try
            {
                //ÇİZİM BAŞLANGICI
                Font myFont = new Font("Calibri", 7); //font oluşturduk
                SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
                Pen myPen = new Pen(Color.Black); //kalem oluşturduk
                ffff.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(), myFont, sbrush, 50, 25);
                ffff.Graphics.DrawLine(myPen, 25, 45, 770, 45); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX
                myFont = new Font("Calibri", 8, FontStyle.Bold);//Fatura başlığı yazacağımız için fontu kalın yaptık ve puntoyu büyütüp 15 yaptık.
                ffff.Graphics.DrawString("Borç Listesi", myFont, sbrush, 175, 65);
                ffff.Graphics.DrawLine(myPen, 25, 95, 770, 95); //çizgi çizdik.
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
                    ffff.Graphics.DrawString(dataGridView13[1, i].Value.ToString(), myFont, sbrush, 25, y);//1.sütun
                    ffff.Graphics.DrawString(dataGridView13[2, i].Value.ToString(), myFont, sbrush, 90, y);//2.sütun
                    ffff.Graphics.DrawString(dataGridView13[3, i].Value.ToString(), myFont, sbrush, 145, y);//3.sütun
                    ffff.Graphics.DrawString(dataGridView13[4, i].Value.ToString(), myFont, sbrush, 220, y);//4.sütun
                    ffff.Graphics.DrawString(dataGridView13[5, i].Value.ToString(), myFont, sbrush, 310, y);//5.sütun
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
                if (i < dataGridView13.RowCount - 1)
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
        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument3.DefaultPageSettings.PaperSize = printDocument3.PrinterSettings.PaperSizes[5];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            printDocument3.Print();
        }
        private void chromeButton18_Click(object sender, EventArgs e)
        {
            if (Form1.yetki_kasa == "1")
            {
                panel30.Hide();
                panel29.Hide();
               
                panel27.Show();
                panel28.Show();
                try
                {
                    baglanti.Open();
                    SqlDataAdapter ad = new SqlDataAdapter("Select * From borclar where kullanici='" + Form1.giris + "'", baglanti);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView14.DataSource = dt;
                    baglanti.Close();
                    dataGridView14.Columns[0].Visible = false;
                    dataGridView14.Columns[1].HeaderText = "Borç Kategorisi";
                    dataGridView14.Columns[2].HeaderText = "TC Kimlik No";
                    dataGridView14.Columns[3].HeaderText = "Borç Tutarı";
                    dataGridView14.Columns[4].HeaderText = "Borç Açıklaması";
                    dataGridView14.Columns[5].HeaderText = "Borç Tarihi";
                    dataGridView14.Columns[1].Width = 110;
                    dataGridView14.Columns[2].Width = 110;
                    dataGridView14.Columns[3].Width = 110;
                    dataGridView14.Columns[4].Width = 110;
                    dataGridView14.Columns[5].Width = 110;
                }
                catch
                {
                    ;
                }
            }
            else
            {
                MessageBox.Show("Kasa İşlemleri Yetkiniz Bulunmamaktadır");
            }
        }
        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM borclar WHERE kategori LIKE'%" + textBox49.Text + "%' and kullanici='" + Form1.giris + "'or aciklama LIKE '%" + textBox49.Text + "' and kullanici='" + Form1.giris + "'or tutar LIKE '%" + textBox49.Text + "' and kullanici='" + Form1.giris + "'", baglanti);
            ad.Fill(dt);
            dataGridView14.DataSource = dt;
            baglanti.Close();
        }
        private void dataGridView14_MouseClick(object sender, MouseEventArgs e)
        {
            //Uzerine gelinen satırın numarasını alıyoruz
            int currentMouseOverRow = dataGridView14.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    //menuleri ekliyoruz
                    m.MenuItems.Add(new MenuItem("Borç Öde", dataGridView14_ode));
                 
                }
              
                m.Show(dataGridView14, new Point(e.X, e.Y));//menuyu goster
            }
        
        }
        private void dataGridView14_ode(object sender, EventArgs e)
        {
           
         
           
            panel29.Show();
            lbl1.Text = dataGridView14.CurrentRow.Cells[2].Value.ToString();
            label84.Text = dataGridView14.CurrentRow.Cells[1].Value.ToString();
            label85.Text = dataGridView14.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void label90_Click(object sender, EventArgs e)
        {
        }
        private void panel29_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label89_Click(object sender, EventArgs e)
        {
        }
        private void button33_Click(object sender, EventArgs e)
        {
            _hesaplama = dataGridView14.CurrentRow.Cells[3].Value.ToString();
            string kalan = String.Format("{0:0}", Math.Round(double.Parse(_hesaplama), 0));
             hesapla = int.Parse(kalan) - int.Parse(textBox50.Text);
            MessageBox.Show("Kalan Miktar= " + hesapla.ToString());
            if (0<=hesapla)
            {
                baglanti.Open();
                komut = new SqlCommand("update borclar set tutar -='" + textBox50.Text + "'where id = '" + dataGridView14.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ödeme İşlemi Başarılı");
                baglanti.Close();
                printDocument4.Print();
                panel29.Hide();
            }
            else
            {
                MessageBox.Show("fazla ödeme yapdınız");
            }
            //sira loga eklemede
            baglanti.Open();
            SqlCommand log = new SqlCommand("insert into log(islem,ip,tc,aciklama,tarih)values('" + "Borç Ödeme İşlemi" + "','" + Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString() + "','" + Form1.giris + "','" + "Borç Ödeme İşlemi Başarıyla Gerçekleşti." + "','" + DateTime.Now.ToString() + "')", baglanti);
            log.ExecuteNonQuery();
            baglanti.Close();
            Borclar();
            temizle();
        }
        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
            try
            {
                //ÇİZİM BAŞLANGICI
                Font myFont = new Font("Calibri", 7); //font oluşturduk
                SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
                Pen myPen = new Pen(Color.Black); //kalem oluşturduk
                ffff.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(), myFont, sbrush, 50, 25);
                ffff.Graphics.DrawLine(myPen, 40, 45, 770, 45); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX
                myFont = new Font("Calibri", 10, FontStyle.Bold);
                ffff.Graphics.DrawString("Ödeme Fişi", myFont, sbrush, 175, 65);
                ffff.Graphics.DrawLine(myPen, 40, 95, 770, 95); //çizgi çizdik.
                myFont = new Font("Calibri", 6, FontStyle.Bold); //Detay başlığını yazacağımız için fontu kalın yapıp puntoyu 10 yaptık.
                ffff.Graphics.DrawString("TC NO", myFont, sbrush, 40, 110); //Detay başlığı
                ffff.Graphics.DrawString("BORÇ ADI", myFont, sbrush, 40, 160); //Detay başlığı
                ffff.Graphics.DrawString("KALAN MİKTAR", myFont, sbrush, 40, 210); // Detay başlığı
               
                ffff.Graphics.DrawLine(myPen, 40, 125, 770, 125); //Çizgi çizdik.
                myFont = new Font("Calibri", 9); //fontu 10 yaptık.
                ffff.Graphics.DrawString(dataGridView14.CurrentRow.Cells[2].Value.ToString(), myFont, sbrush, 40, 125);//1.sütun
                ffff.Graphics.DrawString(dataGridView14.CurrentRow.Cells[1].Value.ToString() , myFont, sbrush, 40, 175);//2.sütun
                ffff.Graphics.DrawString(hesapla + " TL", myFont, sbrush, 40, 225);//3.sütun
                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;
            }
            catch
            {
            }
        }
        private void label83_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button34_Click(object sender, EventArgs e)
        {
            panel29.Show();
            try
            {
                lbl1.Text = dataGridView14.CurrentRow.Cells[2].Value.ToString();
                label84.Text = dataGridView14.CurrentRow.Cells[1].Value.ToString();
                label85.Text = dataGridView14.CurrentRow.Cells[3].Value.ToString();
            }
            catch 
            {
               ;
            }
           
        }
    }
}