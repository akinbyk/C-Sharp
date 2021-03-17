using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    abstract class ucunkus
    {
        abstract public void cins();
        public void renk()
        {
            Console.WriteLine("Turkuaz");
        }
    }
    class evcil : ucunkus
    {
        public override void cins()
        {
            Console.WriteLine("Martı");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ucankuc uck =new ucunkus(); //Kullanılamaz. Sadece Kalıtım Alınabilir !
            evcil evc = new evcil();
            evc.cins();
            evc.renk();
            Console.ReadKey();

        }
    }
}
