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
            dortgen dort = new dortgen();
            Console.Write("Kısa Kenarı Giriniz: ");
            dort.Kısakenaru = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarı Giriniz: ");
            dort.Uzunkenaru = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar Uzunluğu = {0} × {1}",dort.Kısakenaru,dort.Uzunkenaru);
            Console.WriteLine("DortgenTipi = {0}",dort.dortgentipi);
            Console.ReadKey();
        }
    }
    class dortgen
    {
        private int kısakenaru;
        private int uzunkenaru;

        public int Kısakenaru
        {
            get { return kısakenaru; }
            set { kısakenaru = value; }
        }
        public int Uzunkenaru
        {
            get { return uzunkenaru; }
            set { uzunkenaru = value; }
        }

        public string dortgentipi
        {
            get
            {
                string tip = "";
                if (kısakenaru == uzunkenaru)
                    tip = " Kare ";
                else
                    tip = " Dikdörtgen";
                return tip;
            }
        }
    }
}

