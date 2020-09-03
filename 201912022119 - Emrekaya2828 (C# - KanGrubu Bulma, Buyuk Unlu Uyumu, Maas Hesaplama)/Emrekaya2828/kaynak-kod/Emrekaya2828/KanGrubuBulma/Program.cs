using System;
using System.Collections.Generic;
using System.Text;

namespace KanGrubuBulma
{
    class Program
    {

        static void Main(string[] args)
        {
            string msel, fsel, msel2, fsel2;

            Console.Write("Anne Kan Grubu (a,b,ab,o) : ");
            msel = Console.ReadLine();
            Console.Write("Anne Kan Grubu RH (n,p) : ");
            msel2 = Console.ReadLine();

            Console.Write("Baba Kan Grubu (a,b,ab,o) : ");
            fsel = Console.ReadLine();
            Console.Write("Baba Kan Grubu RH (n,p) : ");
            fsel2 = Console.ReadLine();

            hesapla(msel, fsel, msel2, fsel2);
        }

        public static void hesapla(string msel, string fsel, string msel2, string fsel2)
        {
            double  la = 0, lo = 0, lb = 0, la2 = 0, lo2 = 0, lb2 = 0;

            if (msel == "a")
            {
                la = 75;
                lo = 25;
                lb = 0;
            }
            else if (msel == "b")
            {
                la = 0;
                lb = 75;
                lo = 25;
            }
            else if (msel == "o")
            {
                la = 0;
                lb = 0;
                lo = 100;
            }
            else if (msel == "ab")
            {
                la = 50;
                lb = 50;
                lo = 0;
            }
            if (fsel == "a")
            {
                la2 = 75;
                lb2 = 0;
                lo2 = 25;
            }
            else if (fsel == "b")
            {
                la2 = 0;
                lb2 = 75;
                lo2 = 25;
            }
            else if (fsel == "o")
            {
                la2 = 0;
                lb2 = 0;
                lo2 = 100;
            }
            else if (fsel == "ab")
            {
                la2 = 50;
                lb2 = 50;
                lo2 = 0;
            }
            double crh1 = 0;
            double crh2 = 0;
            if (msel2 == "n" && fsel2 == "n") { crh1 = 0; crh2 = 100; }
            else if (msel2 == "p" && fsel2 == "n") { crh1 = 75; crh2 = 25; }
            else if (msel2 == "n" && fsel2 == "p") { crh1 = 75; crh2 = 25; }
            else if (msel2 == "p" && fsel2 == "p") { crh1 = 93.75; crh2 = 6.25; }

            double aa = (la * la2) / 100;
            double ab = (la * lb2 + lb * la2) / 100;
            double ao = (la * lo2 + lo * la2) / 100;
            double bb = (lb * lb2) / 100;
            double bo = (lb * lo2 + lo * lb2) / 100;
            double oo = (lo * lo2) / 100;
            double resa = aa + ao;
            double resb = bb + bo;
            double resab = ab;
            double reso = oo;
           
            Console.WriteLine("\nÇocuğun A Kan Grubu olma ihtimali : " + resa.ToString());
            Console.WriteLine("Çocuğun B Kan Grubu olma ihtimali : " + resb.ToString());
            Console.WriteLine("Çocuğun AB Kan Grubu olma ihtimali : " + resab.ToString());
            Console.WriteLine("Çocuğun 0 Kan Grubu olma ihtimali : " + reso.ToString());
            Console.WriteLine("Çocuğun Rh (+) olma ihtimali : " + crh1.ToString());
            Console.WriteLine("Çocuğun Rh (-) olma ihtimali : " + crh2.ToString());

            Console.ReadKey();
        }

    }
}
