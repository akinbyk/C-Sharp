using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            yaz("merhaba", true);
            Console.ReadKey();
        }
        static void yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void yaz(string metin, bool tercih)
        {
            if (tercih)
            {
                Console.WriteLine(metin.ToUpper());
            }
            else
            {
                Console.WriteLine(metin.ToLower());
            }
        }
    }
}
