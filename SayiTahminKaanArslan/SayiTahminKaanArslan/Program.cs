using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUsingExample9B_KaanArslan
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Random rnd = new Random();
            int tutulansayi = rnd.Next(1, 100);

            int tahmin;

            do
            {
                Console.WriteLine("bir ila yuz arasi bir sayi giriniz");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin > tutulansayi)
                Console.WriteLine("kucuk sayi giriniz");

                else
                Console.WriteLine("buyuk sayi giriniz");

            } while (tahmin!= tutulansayi);
            Console.WriteLine("tebrikler, bildiniz");
            Console.ReadKey();



        }
    }
}
