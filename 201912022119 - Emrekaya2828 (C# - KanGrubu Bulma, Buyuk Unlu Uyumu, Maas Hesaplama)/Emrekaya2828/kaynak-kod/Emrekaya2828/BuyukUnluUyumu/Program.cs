using System;
using System.Collections.Generic;
using System.Text;

namespace BuyukUnluUyumu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kalin = new string[] { "a", "ı", "o", "u" };
            string[] ince = new string[] { "e", "i", "ö", "ü" };
            string[] rakam = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool incevarmi = false;
            bool kalinvarmi = false;

            Console.Write("Kelime Giriniz : ");
            string kelime = Console.ReadLine();

            foreach (char k in kelime)
            {
                for(int i = 0; i<kalin.Length; i++)
                {
                    if (kalin[i] == k.ToString())
                        kalinvarmi = true;
                }
                for (int i = 0; i < kalin.Length; i++)
                {
                    if (ince[i] == k.ToString())
                        incevarmi = true;
                }
            }

            if (kalinvarmi == true && incevarmi == true)
            {
                // hem kalın hem ince sesli varsa büyük ünlü uyumuna uymaz
                Console.WriteLine("Büyük Ünlü Uyumuna Uymaz.");
            }
            else if (kalinvarmi == true && incevarmi == false)
            {
                //sadece kalın sesli varsa büyük ünlü uyumuna uyar
                Console.WriteLine("Büyük Ünlü Uyumuna Uyar.");

            }
            else if (incevarmi == true && kalinvarmi == false)
            {
                //sadece ince sesli varsa büyük ünlü uyumuna uyar
                Console.WriteLine("Büyük Ünlü Uyumuna Uyar.");
            }

            Console.ReadKey();
        }
    }
}
