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
            roman rm = new roman();
            rm.ad = "Sefiller";
            rm.yazar_ad = "Victor Hugo";
            rm.fiyat = 25;
            Console.WriteLine("Kitap Adı :"+rm.ad);
            Console.WriteLine("Kitap Yazarı :"+rm.yazar_ad);
            Console.WriteLine("Kitap Sayfa Sayısı :"+rm.sayfa_sayisi);
            Console.ReadKey();
        }
    }
    public interface Ikitap
    {
        string ad { get; set; }
        string yazar_ad { get; set; }
        int sayfa_sayisi { get; }
        int fiyat { set; }
    }
}
