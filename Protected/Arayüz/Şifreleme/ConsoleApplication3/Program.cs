using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        interface Isifre
        {
            string karaktersifrele(string metin);
            string sifrecoz(string metin);
        }
        class Basitsifri : Isifre
        {
            public string karaktersifrele(string metin)
            {
                string tmp = " ";
                foreach (char c in metin)
                    tmp += (char)(c + 10);
                return tmp;
            }
            public string sifrecoz(string metin)
            {
                string tmp = " ";
                foreach (char c in metin)
                    tmp += (char)(c - 10);
                return tmp;
            }
        }
        class zorsifre : Isifre
        {
            private int Key;
            public zorsifre(int key)
            {
                this.Key = key;
            }
            public string karaktersifrele(string metin)
            {
                string tmp = " ";
                foreach (char c in metin)
                    tmp += (char)(c + Key);
                return tmp;
            }
            public string sifrecoz(string metin)
            {
                string tmp = " ";
                foreach (char c in metin)
                    tmp += (char)(c - Key);
                return tmp;
            }

        }
        static void Main(string[] args)
        {
            zorsifre zsr = new zorsifre(20);
            Basitsifri bsr = new Basitsifri();
            Console.WriteLine(zsr.karaktersifrele("ALI"));
            Console.WriteLine(bsr.karaktersifrele("MESUT"));
            Console.Write("Çözülecek Metin  :");
            Console.WriteLine(zsr.sifrecoz(Console.ReadLine()));
            Console.Write("Çözülecek Metin  :");
            Console.WriteLine(bsr.sifrecoz(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}





        
