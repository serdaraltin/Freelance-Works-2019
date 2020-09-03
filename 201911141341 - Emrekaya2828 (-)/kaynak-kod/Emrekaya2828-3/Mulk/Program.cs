using System;
using System.Collections.Generic;
using System.Text;

namespace Mulk
{
    class Program
    {
        static void Main(string[] args)
        {
            //tarla adında Arsa türünde bir nesne tanımlama.
            Arsa tarla = new Arsa(12345,"camlibel fistikcilik", 100, 100, 75);
            //tarla türünde tanımlanmış nesne içerisindeki Yazdir fonksiyonunu çağırma.
            tarla.Yazdir();

            //villa adında Konut türünde bir nesne tanımlama.
            Konut villa = new Konut(2, 5, 16000);
            //villa türünde tanımlanmış nesne içerisindeki Yazdir fonksiyonunu çağırma.
            villa.Yazdir();

            //hyundai adında Arac türünde bir nesne tanımlama.
            Arac hyundai = new Arac("Hyundai 2015", 1500, 56000);
            //hyundai türünde tanımlanmış nesne içerisindeki Yazdir fonksiyonunu çağırma.
            hyundai.Yazdir();

            Console.ReadKey();
        }
    }

    //Mulk adında tum kiralanabilir yapıların ortak özelliklerini barındıran class(sınıf) tanımlaması.
    class Mulk
    {
        //Bir mulke ait olabilecek genel özellikler
        public string tur = "belirtilmemis";
        public int en = 0;
        public int boy = 0;
        public int metreKare = 0;
        public double m2Fiyat = 50;
        public double fiyat = 0;

        //Eger bir arsa kiralanacak ise metreKareHesapla fonksiyonu ile arsanın metrekaresi hesaplanmaktadır.
        public int metreKareHesapla(int g_en, int g_boy)
        {
            return g_en * g_boy;
        }
    }

    //Mulk sınıfından türetilen Arsa sınıfı arsa kiralama işleminde kullanılmak üzere hazırlanmıştır.
    class Arsa : Mulk
    {
        //Arsa turundeki yapının kendine has özelliklerinin tanımlanması.
        private int parselNo = 0;
        public string ad = "belirtilmemis";

        //parsel numarasına doğrudan erişim olmaması için private(özel) yapılıp getter ve setter ile işlem yapılması.
        public int ParselNo
        {
            get { return parselNo; } //parsel numarasını döndürür.
            set { parselNo = value; }//parsel numarasına verilen değeri atar.
        }
        //Yaratılan mülkün türünü belirtmek için oluşturulan fonksiyon.
        public void Yarat()
        {
            tur = "Arsa";
        }
        //sadece parsel numarası verilmiş bir arsa için yapıcı fonksiyon tanımı.
        public Arsa(int paseln)
        {
            Yarat();
            ParselNo = paseln;
            fiyat = metreKare * m2Fiyat;
            Console.WriteLine("Minecraft harita yukleniyor...\nHarita yuklenemedi!");
        }
        //parsel no, ad(başlık), en, boy, metrekare fiyatı gibi bilgileri verilmiş arsa için yapıcı fonksiyon tanımı.
        public Arsa(int paseln, string g_ad, int g_en, int g_boy, int m2_fiyat)
        {
            Yarat();
            ParselNo = paseln;
            ad = g_ad;
            en = g_en;
            boy = g_boy;
            m2Fiyat = m2_fiyat;
            metreKare = metreKareHesapla(en, boy);
            fiyat = metreKare * m2Fiyat;
            Console.WriteLine("Ne degerli malin varmis be.");
        }
        //arsa bilgilerinin yazırılması.
        public void Yazdir()
        {
            Console.WriteLine(
                "\n=================" +
                "\nTur : " + tur +
                "\nParsel No : " + ParselNo.ToString() +
                "\nBaslik : " + ad +
                "\nEn : " + en +
                "\nBoy : " + boy +
                "\nMetreKare Fiyat : " + m2Fiyat +
                "\nFiyat : " + fiyat +
                "\n=================\n"
                );
        }
    }
    //Mulk sınıfından türetilen Konut sınıfı arsa kiralama işleminde kullanılmak üzere hazırlanmıştır.
    class Konut : Mulk
    {
        //Konut turundeki yapının kendine has özelliklerinin tanımlanması.
        public int katSayisi = 0;
        public int odaSayisi = 0;
        public int toplamOda = 0;
        public string ad = "belirtilmemis";

        //Yaratılan mülkün türünü belirtmek için oluşturulan fonksiyon.
        public void YaratMsg()
        {
            tur = "Konut";
        }

        //Hiçbir özelliği verilmeyen konut için yapıcı fonksiyon.
        public Konut()
        {
            YaratMsg();
            Console.WriteLine("Icimde kimse oturamaz, muhendis birseyleri unutmus.\nSabir.");
        }

        //Kat Sayısı, Oda Sayısı ve Kiralama Fiyatı gibi bilgileri verilen Konut için yapıcı fonksiyon.
        public Konut(int g_kSayi, int g_oSayi, double g_fiyat)
        {
            YaratMsg();
            katSayisi = g_kSayi;
            odaSayisi = g_oSayi;
            fiyat = g_fiyat;
            toplamOda = toplamOdaHesapla(katSayisi, odaSayisi);
            Console.WriteLine("Boya badana yeni yapildi.");
        }

        //Toplam Oda sayısını hesaplamak için fonksiyon tanımı.
        public int toplamOdaHesapla(int g_katS, int g_OdaS)
        {
            return g_katS * g_OdaS;
        }

        //Konut bilgilerini yazdırmak için fonksiyon tanımı.
        public void Yazdir()
        {
            Console.WriteLine(
                "\n=================" +
                "\nTur : " + tur +
                "\nBaslik : " + ad +
                "\nKat : " + katSayisi +
                "\nKat Oda : " + odaSayisi +
                "\nToplam Oda : " + toplamOda +
                "\nFiyat : " + fiyat +
                  "\n=================\n"
                );
        }
    }

    //Mulk sınıfından türetilen Arac sınıfı arsa kiralama işleminde kullanılmak üzere hazırlanmıştır.
    class Arac : Mulk
    {
        //Arac turundeki yapının kendine has özelliklerinin tanımlanması.
        public string model = "belirtilmemis";
        public int Km = 0;
        public bool sigorta = false;
        public int sigortaSure = 0;
        public int soforSayi = 0;

        //Yaratılan mülkün türünü belirtmek için oluşturulan fonksiyon.
        public void Yarat()
        {
            tur = "Arac";
        }

        //Model ve Kiralama Fiyatı verilen Araç için yapıcı fonksiyon, kilometre bilgisi olmadığı için  0 kilometre sayılır ve sigortası 2 yıldır.(aslında sigorta yıllıkmı bilmiyorum ama burada amaç yapıyı kullanmak)
        public Arac(string g_model, double kiralamaFiyat)
        {
            model = g_model;
            sigorta = true;
            sigortaSure = 2;
            fiyat = kiralamaFiyat;
            Console.WriteLine("Sifir kilometre kizimiz hizmetinizde.");
        }

        //Model, Kiramala Fiyatı ve Kilometre bilgisi verilen Araç için yapıcı fonksiyon. Sigorta bilgisi olmadığı için sigorta süresi 0 sayılır.(sigortası yoksa süresi neden olsun)
        public Arac(string g_model, double kiralamaFiyat, int g_km)
        {
            model = g_model;
            Km = g_km;
            fiyat = kiralamaFiyat;
            Console.WriteLine("Tertemiz, aile icin uygun.\nAlip sevgilisine artistlik yapacaklar gelmesin.");
        }

        //Model, Kiralama Fiyat, Kilometre, Söför Sayısı bilgileri verilen Araç için yapıcı fonksiyon. Söför Sayisi olduğu için ekstra ücretlendirme vardır.
        public Arac(string g_model, double kiralamaFiyat, int g_km, int g_soforSayi)
        {
            model = g_model;
            Km = g_km;
            int ekstraUcret = g_soforSayi * 50;
            soforSayi = g_soforSayi;
            fiyat = kiralamaFiyat + ekstraUcret;
            Console.WriteLine("Gezi turlari icin bir numaradir.\nYokusu bir cikisi var akla zarar.");
        }

        //Model, Kiralama Fiyat, Kilometre, Sigorta, Sigorta Süresi, Söför Sayısı bilgileri verilen Araç için yapıcı fonksiyon.
        public Arac(string g_model, double kiralamaFiyat, int g_km, bool g_sigorta, int g_sigortaSure, int g_soforSayi)
        {
            model = g_model;
            Km = g_km;
            sigorta = g_sigorta;
            sigortaSure = g_sigortaSure;
            int ekstraUcret = g_soforSayi * 50;
            soforSayi = g_soforSayi;
            fiyat = kiralamaFiyat + ekstraUcret;
            Console.WriteLine("Sigortasi yeni yapildi\nCevirmeyi gorunce koltuga pusmana gerek yok.");
        }

        //Arac bilgilerini yazdırma.
        public void Yazdir()
        {
            string sigortaDurumu = "yok";
            if (sigorta)
                sigortaDurumu = "var";

            Console.WriteLine(
                "\n=================" +
                "\nTur : " + tur +
                "\nModel : " + model +
                "\nKm : " + Km +
                "\nSigorta : " + sigortaDurumu +
                "\nSigorta Sure : " + sigortaSure +
                "\nSofor Sayi : " + soforSayi +
                "\nFiyat : " + fiyat +
                "\n=================\n"
                );
        }
    }
}
