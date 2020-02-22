using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_UsingConvertWithANullValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i); // Displays 0
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
