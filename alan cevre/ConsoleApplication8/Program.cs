using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static int alanhesapla(int a, int b)
        {

            return a * b;
        }
        static int cevrehesapla(int a, int b)
        {

            return 2 * (a + b);
        }
        static void Main(string[] args)
        {
            int uzunkenar, kısakenar, alan, cevre;
            Console.Write("æ Uzunkenarı Giriniz æ: ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("× Kısakenarı Giriniz ×: ");
            kısakenar = Convert.ToInt32(Console.ReadLine());
            alan = alanhesapla(uzunkenar, kısakenar);
            Console.WriteLine("µ Dikdörtgenin Alanı µ: {0}  ", alan);
            cevre = cevrehesapla(uzunkenar, kısakenar);
            Console.WriteLine("« Dikdörtgenin Çevresi »: {0}  ", cevre);
            Console.ReadLine();


        }
    }
}
