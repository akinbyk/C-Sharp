using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class araba
        {
            public string marka;
            public string rengi;
            public int model;

            public void arabagoster()
            {
                Console.WriteLine("Arabanın Markası" + marka);
                Console.WriteLine("Arabanın Rengi" + rengi);
                Console.WriteLine("Arabanın Modeli" + model);
            }
        }
        class binekaraba : araba
        {
            public string kasatipi;
            public int motor_gucu;

            public void binekarabagoster()
            {
                arabagoster();
                Console.WriteLine("Arabanın KasaTipi" + kasatipi);
                Console.WriteLine("Arabanın MotorGücü" + motor_gucu);
            }
        }
        class ticariaraba : binekaraba
        {
            
            public int kilometre;
            public int koltuksayısı;

            public void ticariarabagoster()
            {
                Console.WriteLine("Arabanın Kilometre" + kilometre);
                Console.WriteLine("Arabanın Koltuk Sayısı" + koltuksayısı);
            }
                
        }

        static void Main(string[] args)
        {
            ticariaraba tc1 = new ticariaraba();
            tc1.marka="=Mercedes Benz";
            tc1.rengi = "=Gri";
            tc1.model = 2016;
            tc1.kasatipi = " =Sedan";
            tc1.motor_gucu = 400;
            tc1.koltuksayısı = 40;
            tc1.kilometre = 12000;
            
            tc1.arabagoster();
            tc1.binekarabagoster();
            tc1.ticariarabagoster();
            Console.ReadKey();
        }
    }
}
