using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            sontur nesne2 = new sontur("Bu Bir Messagedir");

        }
    }
    class anasinif
    {
        public anasinif()
        {
            Console.WriteLine("Bu anasınıfına ait yapılandırıcıyı çalıştırır");
        }
        public anasinif(string m)
        {
            Console.WriteLine("Ben Anasınıfı mesajım" + m);
        }
    }
    class tureyensınıf : anasinif
    {
        public tureyensınıf()
        {
            Console.WriteLine("Bu Türeyen sınıfa ait yapılandırıcıyı çalıştırır");
        }
        public tureyensınıf(string msg,int sayi):base(msg)
        {
            for (int i = 0; i < sayi; i++)
                Console.WriteLine(msg);
        }
    }
    class sontur : tureyensınıf
    {
        public sontur()
        {
            Console.WriteLine("Bu sontur sınıfına ait yapılandırıcıyı çalıştırır");
        }
        public sontur(string mesaj) : base(mesaj,5)
        {
            Console.WriteLine(mesaj + "Ben Sontur Sınıfıyım");
            Console.ReadKey();
        }
    }
}
			

