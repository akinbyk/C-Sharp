using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface Ideneme
    {
        void bilgigirisi(string ad, string soyad);
        void bilgigoster();
    }
    class denemesınıfı : Ideneme
    {
        private string ad, soyad;
        public void bilgigirisi(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;

        }
        public void bilgigoster()
        {
            Console.WriteLine(ad + " " + soyad);
        }
    }
    class denemeb : Ideneme
    {
        private string ad, soyad;
        public void bilgigirisi(string ad, string soyad)
        {
            this.ad = ad.ToUpper();
            this.soyad = soyad.ToUpper();
            
        }
        public void bilgigoster()
        {
            Console.WriteLine(ad + " " + soyad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            denemesınıfı n =new denemesınıfı();
            n.bilgigirisi("Mesut", "mesut");
            n.bilgigoster();
            denemeb db = new denemeb();
            db.bilgigirisi("×Niegara×", "×Asoka×");
            db.bilgigoster();
            denemeb bd = new denemeb();
            Ideneme idi = bd;
            idi.bilgigirisi("Duran", "Durmuş");
            idi.bilgigoster();

            Console.ReadKey();
                
        }
    }
}
