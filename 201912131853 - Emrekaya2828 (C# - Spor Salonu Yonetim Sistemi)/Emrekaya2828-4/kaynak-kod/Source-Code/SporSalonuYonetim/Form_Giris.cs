using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        
        //veritabani sinifindan yeni bir nesne uretiliyor
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();

        //kapat butonu tıklama
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            //program kapatılıyor
            Application.Exit();
        }

        //giriş butonu tıklama
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //veritabanı bağlantısı başarısız olursa
            if (!veritabani.Baglanti_Test())
            {
                //uyarı amaçlı mesaj kutusu oluşturuluyor
                MessageBox.Show("Öncelikle veritabanı bağlantısı yapılmalı !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //kullanıcı adı ve parola bilgisi boş değilse yani doluysa
            if (!(txt_KullaniciAd.Text != "" && txt_Parola.Text != ""))
            {
                //uyarı amaçlı mesaj kutusu oluşturuluyor
                MessageBox.Show("Gerekli alanları doldurunuz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //girilen kullanıcı adı ve parola doğru ise
            if (veritabani.Kullanici_Kontrol(txt_KullaniciAd.Text, txt_Parola.Text))
            {
                //anasayfa formu(pencere) açılıyor
                Form_Anasayfa anaSayfa = new Form_Anasayfa();
                anaSayfa.ShowDialog(); //üst üste bindiriliyor
            }
            //girilen kullanıcı adı veya parola doğru değilse
            else
            {
                //uyarı amaçlı mesaj kutusu oluşturuluyor
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //giriş formu(pencere) açıldığında olacak işlemler
        private void Form_Giris_Load(object sender, EventArgs e)
        {
            //veritabanı bağlantısı başarısız ise
            if (!veritabani.Baglanti_Test())
            {
                //veritabanı formu(pencere) açılıyor (kullanıcının veritabanını girmesi için)
                Form_VeritabaniBaglanti veritabaniBaglanti = new Form_VeritabaniBaglanti();
                veritabaniBaglanti.ShowDialog(); //pencereler üst üste bindiriliyor
                //this.Hide();
                return;
            }
            //veritabanı kontrolü başarılı fakat yönetici bilgisi yok ise
            if(!(veritabani.Yonetici_Kontrol() > 0))
            {
                //yeni yönetici oluşturmak için kurulum sihirbazı formu(pencere) açılıyor
                Form_KurulumSihirbazi kurulumS = new Form_KurulumSihirbazi();
                kurulumS.ShowDialog(); //pencereler üst üste bindiriliyor
                //this.Hide();
            }
        }
    }
}
