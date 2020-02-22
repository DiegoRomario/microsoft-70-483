using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_LINQMultipleFromStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };
            var result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;
            Console.WriteLine(string.Join(", ", result)); // Displays 2, 4, 6, 4, 8, 12, 10, 20, 30
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
