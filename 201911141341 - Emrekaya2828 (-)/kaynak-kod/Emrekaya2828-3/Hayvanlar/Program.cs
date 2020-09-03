using System;
using System.Collections.Generic;
using System.Text;

namespace Hayvanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kus papagan = new Kus("papağan", "Akciger", 10, "Kabarik", "Sari");
            papagan.omur = 15;
            papagan.yas = 3;
            papagan.ayakSayisi = 2;
            papagan.Yazdir();


            Kedi leopar = new Kedi("leopar", "Akciger");
            leopar.omur = 8;
            leopar.yas = 2;
            leopar.ayakSayisi = 4;
            leopar.Yazdir();

            Balik hamsi = new Balik("Solungac");
            hamsi.Yazdir();

            Surungen yilan = new Surungen("Akciger");
            yilan.Yazdir();

            Console.ReadKey();
        }
    }

    //Hayvan adında tum kiralanabilir yapıların ortak özelliklerini barındıran class(sınıf) tanımlaması.
    class Hayvan
    {
        //Bir Hayvana ait olabilecek genel özellikler
        public int ayakSayisi = 2;
        public string kuyrukSekil = "belirtilmemis";
        public string kuyrukRenk = "belirtilmemis";
        public string solunum = "belirtilmemis";
        public int omur = 1;
        public int yas = 1;
        public string tur = "belirtilmemis";
    }

    //Hayvan sınıfından türetilen Kus sınıfı.
    class Kus : Hayvan
    {
        //Kuş hayvanının kendine has kanat hızı için özellik tanımlaması.
        public int kanatHiz = 0;
        public string cins = "belirtilmemis";

        //Oluşturulan hayvan türünü belirlemek için fonksiyon.
        public void YaratMsg()
        {
            tur = "Kus";
        }

        //Cins ve Solunum bilgisi verilen kuşun yapıcı fonksiyonu.
        public Kus(string g_cins, string solTur)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            Console.WriteLine("Talih kusu basimiza kondu, hadi bakalim");
        }

        //Cins, Solunum, Kanat Hızı, Kuyruk Şekli, Kuyruk Rengi gibi bilgileri verilen kuşun yapıcı fonksiyonu.
        public Kus(string g_cins, string solTur, int kntHiz, string kySekil, string kyRenk)
        {
            YaratMsg();
            cins = g_cins;
            kanatHiz = kntHiz;
            solunum = solTur;
            kuyrukSekil = kySekil;
            kuyrukRenk = kyRenk;
            Console.WriteLine("Acayip bir kuş, öyle böyle değil.");
        }

        //Öt fonksiyonu.
        public void Ot()
        {
            Console.WriteLine("cik cik cik");
        }

        //Uç fonksiyonu.
        public void Uc()
        {
            Console.WriteLine("Lord of the Rings de neden kartallar yuzugu goturmedi.");
        }

        //Kuş bilgilerini yazdırmak için fonksiyon.
        public void Yazdir()
        {
            Console.WriteLine("\n===================" +
                "\nTur : " + tur +
                "\nCins : " + cins +
                "\nAyak Sayisi : " + ayakSayisi +
                "\nKuyruk Sekli : " + kuyrukSekil +
                "\nKuyruk Rengi : " + kuyrukRenk +
                "\nKanat Hizi : " + kanatHiz +
                "\nSolunum : " + solunum +
                "\nOmur : " + omur +
                "\nYas : " + yas +
                "\nKalan Omur : " +
                (omur - yas) +
                "\n===================");
        }
    }

    //Hayvan sınıfından türetilen Kedi sınıfı.
    class Kedi : Hayvan
    {
        //Kedi turundeki yapının kendine has özelliklerinin tanımlanması.
        public string cins = "belirtilmemiş";

        //Yaratılan hayvanın türünü belirtmek için oluşturulan fonksiyon.
        public void YaratMsg()
        {
            tur = "Kedi";
        }

        //Cins ve Solunum bilgisi verilen kedinin yapıcı fonksiyonu.
        public Kedi(string g_cins, string solTur)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            Console.WriteLine("Sirinmi sirin bir kedimiz oldu. Sut verin.");
        }

        //Cins, Solunum, Kuyruk Şekli, Kuyruk Rengi bilgileri verilen kedinin yapıcı fonksiyonu.
        public Kedi(string g_cins, string solTur, string kySekil, string kyRenk)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            kuyrukSekil = kySekil;
            kuyrukRenk = kyRenk;
            Console.WriteLine("Yasiyor yasiyor!!!, schrodingerin kedisi hayat buldu !\nNereye gitti bu?");
        }

        //Kedi bilgilerini yazdırmak için fonksiyon.
        public void Yazdir()
        {
            Console.WriteLine("\n===================" +
                "\nTur : " + tur +
                "\nCins : " + cins +
                "\nAyak Sayisi : " + ayakSayisi +
                "\nKuyruk Sekli : " + kuyrukSekil +
                "\nKuyruk Rengi : " + kuyrukRenk +
                "\nSolunum : " + solunum +
                "\nOmur : " + omur +
                "\nYas : " + yas +
                "\nKalan Omur : " +
                (omur - yas) +
                "\n===================");
        }
    }

    //Hayvan sınıfından türetilen Surungen sınıfı.
    class Surungen : Hayvan
    {
        public string cins = "belirtilmemiş"; //neden hayvan sınıfında cinsi için özellik oluşturulmadı diye bir soru oluşabilir bunun nedeni tüm hayvanların cinsi bilinmiyor, yaa :D
         
        //Yaratılan hayvanın türünü belirtmek için oluşturulan fonksiyon.
        public void YaratMsg()
        {
            tur = "Surungen";
        }

        //Sadece Solunum bilgisi verilen sürüngenin yapıcı fonksiyonu.
        public Surungen(string solTur)
        {
            YaratMsg();
            solunum = solTur;
            Console.WriteLine("Yeni bir türüm, gdo lu şeyleri tek siz yemiyorsunuz.");
        }

        //Cins, Solunum bilgisi verilen sürüngenin yapıcı fonksiyonu.
        public Surungen(string g_cins, string solTur)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            Console.WriteLine("Surunmek cok sikici, olmek istiyorum");
        }

        //Cins, Solunum, Kuyruk Şekli, Kuyruk Renk bilgileri verilen sürüngenin yapıcı fonksiyonu.
        public Surungen(string g_cins, string solTur, string kySekil, string kyRenk)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            kuyrukSekil = kySekil;
            kuyrukRenk = kyRenk;
            Console.WriteLine("Kuyrugum yok kuyrugum yok yuzmem derede\n Ben sanirim kertenkele olarak geldim bu dunyaya.");
        }

        //Sürüngen bilgilerini yazdıran fonksiyon.
        public void Yazdir()
        {
            Console.WriteLine("\n===================" +
            "\nTur : " + tur +
            "\nCins : "+ cins+
            "\nKuyruk Sekli : " + kuyrukSekil +
            "\nKuyruk Rengi : " + kuyrukRenk +
            "\nSolunum : " + solunum +
            "\nOmur : " + omur +
            "\nYas : " + yas +
            "\nKalan Omur : " +
            (omur - yas) +
            "\n===================");
        }
    }

    //Hayvan sınıfından türetilen Balik sınıfı.
    class Balik : Hayvan
    {
        //Balik turundeki yapının kendine has özelliklerinin tanımlanması.
        public int yuzgecSayisi = 0;
        public string cins = "belirtilmemis";

        //Yaratılan hayvanın türünü belirtmek için oluşturulan fonksiyon.
        public void YaratMsg()
        {
            tur = "Balik";
        }

        //Hiçbir bilgisi verilmeyen hayvanın yaratılması ve ölmesi fonksiyonu.
        public Balik()
        {
            YaratMsg();
            Console.WriteLine("Boguluyorum, ogogllogolgo.");
        }

        //Cins ve Solunum bilgisi verilen hayvancağzın sadece bir taş gibi etrafı izleyebilmesi fonksiyonu.
        public Balik(string g_cins, string solTur)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            Console.WriteLine("Yasama amacim bile yok, oldugum yerden sadece etrafimda olanlari izleyebiliyorum." +
                "\nLanet olsun bu hayata.");
        }

        //Cins, Solunum, Yüzgeç Sayısı bilgileri verilen tam bir balığın yaşama başlaması fonksiyonu.
        public Balik(string g_cins, string solTur, int ycSayisi)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            yuzgecSayisi = ycSayisi;
            Console.WriteLine("Nefes alabiliyorum\nYasasin su anlamsiz hayatimda ordan buraya yuzebilirim.");
        }
        //Cins, Solunum, Yüzgeç Sayısı, Kuyruk Şekli, Kuyruk Rengi bilgileri verilen tam bir balığın yaşama başlaması fonksiyonu.
        public Balik(string g_cins, string solTur, int ycSayisi, string kySekil, string kyRenk)
        {
            YaratMsg();
            cins = g_cins;
            solunum = solTur;
            kuyrukSekil = kySekil;
            kuyrukRenk = kyRenk;
            yuzgecSayisi = ycSayisi;
            Console.WriteLine("Kuyrugum yok kuyrugum yok yuzmem derede\nBu neydiya, hatirladim karabas(galiba)");
        }

        //Balık bilgilerini yazdırmak için fonksiyon.
        public void Yazdir()
        {
            Console.WriteLine("\n===================" +
                "\nTur : " + tur +
                "\nCins : "+ cins+
                "\nKuyruk Sekli : " + kuyrukSekil +
                "\nKuyruk Rengi : " + kuyrukRenk +
                "\nSolunum : " + solunum +
                "\nYuzgec Sayisi : " + yuzgecSayisi +
                "\nOmur : " + omur +
                "\nYas : " + yas +
                "\nKalan Omur : " +
                (omur - yas) +
                "\n===================");
        }
    }

}
