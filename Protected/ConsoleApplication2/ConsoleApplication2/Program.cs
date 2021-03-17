using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    class Ev
    {
        protected string Semt;
        protected int Alan;
        protected string Adres;
        public void Evbilgi(string semt, int alan, string adres)
        {
            this.Semt = semt;
            this.Alan = alan;
            this.Adres = adres;
        }
        virtual public void evGoster()
        {
            Console.WriteLine("Evin özellikleri ; \n Semti: {0} \n Alanı : {1} \n Adresi: {2}", Semt, Alan, Adres);
        }
    }
    class satilikev : Ev
    {
        protected int satisfiyati;
        public void Satilikevbilgi(string semt, int alan, string adres, int sfiyat)
        {
            this.Semt = semt;
            this.Alan = alan;
            this.Adres = adres;
            this.satisfiyati = sfiyat;
        }
        public override void evGoster()
        {
            base.evGoster();
            Console.WriteLine("Satış Fiyatı :" + satisfiyati.ToString());
        }
    }
    class kiralikev : Ev
    {
        protected int kirabedeli;
        public void kiralikevbilgi(string semt, int alan, string adres, int kfiyat)
        {
            this.Semt = semt;
            this.Alan = alan;
            this.Adres = adres;
            this.kirabedeli = kfiyat;
        }
        public override void evGoster()
        {
            base.evGoster();
            Console.WriteLine("Kira Bedeli : " + kirabedeli.ToString());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Ev ramazaninevi = new Ev();
            ramazaninevi.Evbilgi(" Eryaman", 120, "Göldekent Sitesi");
            ramazaninevi.evGoster();
            Console.WriteLine("-----------------");
            satilikev ayseninevi = new satilikev();
            ayseninevi.Satilikevbilgi("Eryaman ", 170, "Özaykent", 250000);
            ayseninevi.evGoster();
            Console.WriteLine("-------------------");
            kiralikev meteninevi = new kiralikev();
            meteninevi.kiralikevbilgi("Eryaman", 100, "MaviÇam Sitesi", 250);
            meteninevi.evGoster();
            Console.ReadKey();
        }
    }
}
  