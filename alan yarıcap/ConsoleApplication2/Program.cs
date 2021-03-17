using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static double alanh(int m)
        {
            double pi = 3.14;
            double sonuc = pi * (m * m);
            return sonuc;
        }
        static double cevreh(int m)
        {
            double pi = 3.14;
            double sonuc = 2 * (pi * m);
            return sonuc;
        }
        static void Main(string[] args)
        {
            int yarıçap;
            Console.Write(" Yarıçapı Giriniz:");
            yarıçap = Convert.ToInt16(Console.ReadLine());
            double alan = alanh(yarıçap);
            double cevre = cevreh(yarıçap);
            Console.WriteLine(" Daire'nin Alan'ı={0}", alan);
            Console.Write(" Daire'nin cevresi=" + cevre);
            Console.ReadLine();


        }
    }
}
