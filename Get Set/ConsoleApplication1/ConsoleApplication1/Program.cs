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
            Tornavida vida = new Tornavida();
            vida.SapRengi = "Cyan ";
            // Console.Writeline(vida.YazText); hata yanlızca yazılabilir özellik
            // vida.Text = "Çakma"; hata yanlızca okunabilir özellik
            vida.YazText = "Yıldızlar";
            Console.WriteLine(vida.SapRengi);
            Console.WriteLine(vida.Text);

            Tornavida vidivodo = new Tornavida();
            vidivodo.SapRengi = "YellowCyan";
            Console.WriteLine("Saprengi :"+vidivodo.SapRengi);
            vidivodo.YazText = "Nice calite";
            Console.WriteLine("Özelliği :"+vidivodo.Text);
            Console.ReadKey();





        }
    }
    class Tornavida
    {
        private string saprengi;
        private string text;
        public string SapRengi
        {
            get { return saprengi; }
            set { saprengi = value; }
        }
        public string Text
        {
            get { return text; }
        }
        public string YazText
        {
            set { text = value; }
        }
    }

}
