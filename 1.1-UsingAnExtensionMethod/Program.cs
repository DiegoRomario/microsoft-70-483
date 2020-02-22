using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_UsingAnExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine(x.Multiply(50)); // Displays 6

            Console.WriteLine(x.teste());
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public static class IntExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x * y;
        }
    }

    public static class Demo
    {
        public static string teste(this int x)
        {
            return $"teste: {x} ";
        }
    }
}
