using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_MusteriListesi : Form
    {
        public Form_MusteriListesi()
        {
            InitializeComponent();
        }

        //veritabanı sınıfındna yeni bir nesne üretiliyor
        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        //müşteri id bilgisi için değişken oluşturma
        int MusteriId;

        //müşterileri listelemek için fonksiyon
        private void Musteri_Listele()
        {
            //tabloya müşteri bilgileri dolduruluyor
            dg_Musteri.DataSource = veritabani.Musteri_Listele().Tables["Musteri"];
            //sağ bölüm ve alt bölümdeki kutular(textbox...) temizleniyor
            foreach(Control item in panel2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
        }

        //müşteri arama işlemi için fonksiyon
        private void Musteri_Ara(string TcNo)
        {
            //tc no bilgisine göre müşteri aranıyor ve tabloda görüntüleniyor
            dg_Musteri.DataSource = veritabani.Musteri_Ara(TcNo).Tables["Musteri"];
            //sağ bölüm ve alt bölümdeki kutular(textbox...) temizleniyor
            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
        }

        //müşteri seçildikten sonra görüntüleme için fonksiyon
        private void Musteri_Bilgi(int MusteriId)
        {
            //sağ bölüm ve alt bölümdeki kutular(textbox...) temizleniyor
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
            }
            //program hazırla kısmı hazırlanıyor
            btn_ProgramHazirla.Text = "PROGRAM HAZIRLA";
            //müşteri id bilgisi yanlış ise sonlandırılıyor
            if (!(MusteriId > 0))
                return;
            //-> müşteri bilgileri gerekli alanlara dolduruluyor
            txt_TcNo.Text = veritabani.Musteri_Bilgi(MusteriId)[0].ToString();
            txt_Ad.Text = veritabani.Musteri_Bilgi(MusteriId)[1].ToString();
            txt_Soyad.Text = veritabani.Musteri_Bilgi(MusteriId)[2].ToString();
            txt_Telefon.Text = veritabani.Musteri_Bilgi(MusteriId)[3].ToString();
            txt_Meslek.Text = veritabani.Musteri_Bilgi(MusteriId)[4].ToString();
            txt_DogumTarih.Text = veritabani.Musteri_Bilgi(MusteriId)[5].ToString();
            txt_Boy.Text = veritabani.Musteri_Bilgi(MusteriId)[6].ToString();
            txt_Kilo.Text = veritabani.Musteri_Bilgi(MusteriId)[7].ToString();
            txt_Adres.Text = veritabani.Musteri_Bilgi(MusteriId)[8].ToString();
            //<- müşteri bilgileri gerekli alanlara dolduruldu

            //müşteri resim bilgisi için değişken tanımlama
            string Resim = Application.StartupPath + "/musteri/" + MusteriId.ToString() + ".png";
            //müşteriye ait resim varsa
            if (File.Exists(Resim))
                //müşteri resmi kutucukta görüntüleniyor
                pb_Resim.Image = Image.FromFile(Resim);
            else
                //resim yoksa kutucuk boş bırakılıyor
                pb_Resim.Image = null;
            //müşteriye ait bir çalışma programı yoksa sonlandırılıyor
            if (!(veritabani.Program_Kontrol(MusteriId)))
                return;

            //-> müşteriye ait çalışma programı bilgileri gerekli alanlara dolduruluyor
            txt_Alan.Text = veritabani.Program_Bilgi(MusteriId)[0].ToString();
            txt_Antrenman.Text = veritabani.Program_Bilgi(MusteriId)[1].ToString();
            txt_Diyet.Text = veritabani.Program_Bilgi(MusteriId)[2].ToString();
            chb_Pazartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[3]);
            chb_Sali.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[4]);
            chb_Carsamba.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[5]);
            chb_Persembe.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[6]);
            chb_Cuma.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[7]);
            chb_Cumartesi.Checked = Convert.ToBoolean(veritabani.Program_Bilgi(MusteriId)[8]);
            //<- müşteriye ait çalışma programı bilgileri gerekli alanlara dolduruludu


            //program bilgisi var olduğu için program hazırla yerine program güncelle olarak değiştiriliyor buton metni
            btn_ProgramHazirla.Text = "PROGRAM GÜNCELLE";
        }


        //müşteri listesi formu(pencere) açıldığında
        private void Form_MusteriListesi_Load(object sender, EventArgs e)
        {
            //tüm müşteriler listeleniyor
            Musteri_Listele();
        }

        //tablodan müşteri seçildiğinda
        private void dg_Musteri_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //müşteri id bilgisi alma
            MusteriId = Convert.ToInt32(dg_Musteri.Rows[e.RowIndex].Cells[0].Value);
            //müşteri bilgilerini görüntüleme
            Musteri_Bilgi(MusteriId);
        }

        //kapat butonu tıklama
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            //bu form(pencere) kapatılır
            this.Close();
        }

        //yenile butonu tıklama
        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            //müşteriler yenilenir(listele)
            Musteri_Listele();
        }

        //yeni kayıt butonu tıklama
        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            //yeni müşteri formu(pencere) açılır
            Form_YeniMusteri yeniMusteri = new Form_YeniMusteri();
            yeniMusteri.ShowDialog(); //pencere üst üste bindirme
        }

        //sil butonu tıklama
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //soru penceresi oluşur (evet,hayır)
            DialogResult soru = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //silme onaylanır ise
            if (soru == DialogResult.Yes)
            {
                //müşteri veritabanından silinir
                if(veritabani.Musteri_Sil(MusteriId))
                {
                    //müşteriler yenilenir(listele)
                    Musteri_Listele();
                }
            }
        }

        //güncelle butonu tıklama
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //yeni müşteri formu(pencere) güncelleme modunda açılır
            Form_YeniMusteri mGuncelle = new Form_YeniMusteri(MusteriId);
            mGuncelle.ShowDialog(); //pencere üst üste bindirilir
        }

        //program hazırla butonu tıklama
        private void btn_ProgramHazirla_Click(object sender, EventArgs e)
        {
            //eğer müşteriye ait bir çalışma programı yoksa
            if(btn_ProgramHazirla.Text == "PROGRAM HAZIRLA")
            {
                //program formu(pencere) açılır
                Form_Program programH = new Form_Program(MusteriId);
                programH.ShowDialog();
            }
            //müşterinin çalışma programı varsa
            else
            {
                //program formu(pencere) güncelleme modunda açılır
                Form_Program programH = new Form_Program(MusteriId,true);
                programH.ShowDialog();
            }
        }

        //ara butonu tıklama
        private void btn_Ara_Click(object sender, EventArgs e)
        {
            //ara kısmı boş değilse, doluysa
            if (txt_Ara.Text != "")
                //müşteri veritabanında aranır
                Musteri_Ara(txt_Ara.Text);
            else
                //arama kısmı boş ise bilgi verilir
                MessageBox.Show("Lütfen arama yapmak için müşteri Tc No giriniz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
