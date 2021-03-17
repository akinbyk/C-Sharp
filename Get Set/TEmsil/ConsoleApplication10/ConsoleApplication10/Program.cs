using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    


    class Program
    {
        public delegate string temsil(string a);

        class Okul
        {
            public string bilgi(string veri)
            {
                return "Okul türü = " + veri;
            }
        }
        public static string deneme(string a)
        {
            return "Deneme Metodu =" + a;
        }


        static void Main(string[] args)
        {
            Okul ogıl = new Okul();
            temsil tem = new temsil(ogıl.bilgi);
            Console.WriteLine(tem("EML"));

            tem = new temsil(deneme);
            Console.WriteLine(tem("ATL"));
            Console.ReadKey();


        }
    }
}
