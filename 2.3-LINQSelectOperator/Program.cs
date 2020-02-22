using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_LINQSelectOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = from d in data
                         select d;
            var teste = string.Join(", ", result); // Displays 1, 2, 5, 8, 11
            Console.WriteLine(teste);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
