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
            Console.WriteLine(kareal(5));
            Console.WriteLine(kareal(5.1));
            Console.WriteLine(kareal("3"));
            Console.ReadKey();
        }
        static int kareal(int x) 
        {
            return (x * x);
        }
        static double kareal(double x) 
        {
            return (x * x);
        }
        static int kareal(string x)
        {
            return (Int32.Parse(x) * Int32.Parse(x));

        }

    
    }
}
