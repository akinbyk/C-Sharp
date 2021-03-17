using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir Sayı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Çifttir");
            }
            else
                Console.WriteLine("Girdiğiniz Sayı Tektir");
            Console.ReadKey();
            }
        }
    }
