using System;
using System.Collections.Generic;
using System.Text;

namespace MaasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int yabanciDilTazminati = 0, aileYardimi = 0;
            double kidemTazminati=0, cocukYardimi = 0;

            Console.Write("Çocuk Sayısı (2,3...): ");
            int cS = Convert.ToInt32(Console.ReadLine());
            if (cS == 2)
                cocukYardimi = 0.01;
            else if (cS == 3)
                cocukYardimi = 0.02;
            else if (cS > 3)
                cocukYardimi = 0.05;

            Console.Write("Kıdem Tazminatı (lise,lisans,ylisans,doktora) : ");
            string kidemT = Console.ReadLine();
            if (kidemT == "lise")
                kidemTazminati = 0.01;
            else if (kidemT == "lisans")
                kidemTazminati = 0.02;
            else if (kidemT == "ylisans")
                kidemTazminati = 0.03;
            else if (kidemT == "doktora")
                kidemTazminati = 0.04;

            Console.Write("Yabancı Dil Tazminatı (0-100) :");
            int ydT = Convert.ToInt32(Console.ReadLine());
            if (ydT >= 70 && ydT < 80)
                yabanciDilTazminati = 25;
            else if (ydT >= 80 && ydT < 90)
                yabanciDilTazminati = 55;
            else if (ydT >= 90 && ydT <= 100)
                yabanciDilTazminati = 125;


            Console.Write("Aile Yardımı (es calisiyor[e],es calismiyor[h]): ");
            if (Console.ReadLine() == "e")
                aileYardimi = 22;
            else
                aileYardimi = 48;


            maasHesapla(cocukYardimi, kidemTazminati, yabanciDilTazminati, aileYardimi);



        }

        public static void maasHesapla(double cocukYardimi, double kidemTazminati, int yabanciDilTazminati, int aileYardimi)
        {
            int netMaas = 2700;

            double maas = netMaas + (netMaas * cocukYardimi) + aileYardimi + yabanciDilTazminati + (netMaas * kidemTazminati);

            Console.WriteLine("Maaş : " + maas.ToString());
            Console.ReadKey();
        }
    }
}
