using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_DisplayingANumberWithACurrencyFormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C",
             new CultureInfo("pt-BR")));
            // Displays $1,234.56
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
