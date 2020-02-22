using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_ShowsHowToUseSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";
            string subString = value.Substring(3, 6); // Returns ‘Sample’
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
