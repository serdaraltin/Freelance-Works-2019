using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SporSalonuYonetim
{
    public partial class Form_VeritabaniBaglanti : Form
    {
        public Form_VeritabaniBaglanti()
        {
            InitializeComponent();
        }

        //secilen dosyaya yapılan bağlantıyı test etmek için bir fonksiyon
        private Boolean test_et(string dosya) //bağlantı başarılı ise geriye true değilse false değer döndürüyor
        {
            //access veritabanı bağlantısı oluşturuluyor ve dosya yolu giriliyor
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dosya + ";");
            //bağlantı başarılı ise
            try
            {
                //bağlantı açıp kapatılarak test ediliyor
                baglanti.Open();
                baglanti.Close();
                //işlem başarılı ise geriye true değer döndürüyor
                return true;
            }
            //bağlantı başarısız ise
            catch
            {
                //hata olmaması için bağlantı kapatılıyor
                baglanti.Close();
                //geriye false değer döndürülüyor
                return false;
            }
        }

        //...(dosya seç) butonuna tıklandığında yapılacak işlemler
        private void btn_DosyaSec_Click(object sender, EventArgs e)
        {
            //bir adet dosya seçim ekranı oluşturuluyor ve özellikleri belirleniyor
            OpenFileDialog DosyaSec = new OpenFileDialog();
            DosyaSec.Filter = "Access Veritabanı|*.mdb|Tüm Dosyalar|*.*";
            DosyaSec.Title = "Veritabanı Dosyası Seç";
            DosyaSec.FileName = "Veritabani.mdb";


            //dosya seçim ekranından bir dosya seçilmiş ise işlem yapılıyor
            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                //secilen dosyaya bağlantı yapılabiliyorsa işlem yapılıyor
                if (test_et(DosyaSec.FileName))
                {
                    //textbox nesnesine seçilen dosyanın yolu yazılıyor
                    txt_Dosya.Text = DosyaSec.FileName;
                    //bağlantı testinin başarılı olduğuna dair bilgi kutucuğu oluşturuluyor
                    MessageBox.Show("Bağlantı başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //eğer seçilen dosyaya bağlantı yapılamaz ise işlem yapılıyor
                else
                {
                    //bağlantının başarısız olduğuna dair bilgi kutucuğu oluşturuluyor
                    MessageBox.Show("Bağlantı başarısız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //kaydet butonuna tıklandığında yapılacak işlemler
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //eğer textbox nesnesi boş değil ve içerisindeki veri doğru ise işlemler yapılıyor
            if(txt_Dosya.Text != "" && test_et(txt_Dosya.Text))
            {
                //ayarlara veritabanının dosya konumu kaydediliyor
                Ayarlar.Default.veritabani = txt_Dosya.Text;
                Ayarlar.Default.Save();
                //kayıt edildiğine dair bir bilgilendirme kutucuğu oluşturuluyor
                MessageBox.Show("Kayıt edildi,", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //işlemlerden sonra program yeniden başlatılıyor
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Veritabanı dosyası seçilmedi veya bulunamadı !!!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //Form açıldığında yapılacak işlemlerin tanımlandığı alan
        private void Form_VeritabaniBaglanti_Load(object sender, EventArgs e)
        {
            //dosya yolunu gösteren textbox nesnesine, eğer daha önceden veritabanı bilgisi girilmiş ise o bilgi ayarlardan okunarak yazılıyor
            txt_Dosya.Text = Ayarlar.Default.veritabani; 
        }

        //kapatma butonuna tıklandığında yapılacak işlemler
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //bu formu kapatma işlemi
            this.Close();
        }
    }
}
