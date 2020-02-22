using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_UsingConvertToConvertFromDoubleToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i); // Displays 23
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
