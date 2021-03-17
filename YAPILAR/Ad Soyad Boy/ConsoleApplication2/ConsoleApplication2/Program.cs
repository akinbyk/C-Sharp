using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    struct personel
    {
        public string ad;
        public string soyad;
        public int boy;
        public personel(string g_ad, string g_soyad, int g_boy)
        {
            ad = g_ad;
            soyad = g_soyad;
            boy = g_boy;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            personel per1;
            personel per2 = new personel();
            personel per3 = new personel("ekrem", "dürüst", 158);

            per1.ad = "Ali";
            per1.soyad = "Bilen";
            per1.boy = 177;
            Console.WriteLine(per1.ad + " " + per1.soyad + " " + per1.boy);

            Console.WriteLine(per2.ad + " " + per2.soyad + " " + per2.boy);
            per2.ad = "Kadir";
            per2.soyad = "Zorba";
            per2.boy = 144;
            Console.WriteLine(per2.ad + " " + per2.soyad + " " + per2.boy);

            Console.ReadKey();

        }
    }
}
