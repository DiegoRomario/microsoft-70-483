using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1._7_ValidateAZIPCodeWithARegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            string input = "1 2 3  4  5";
            string result = regex.Replace(input, "_");
            Console.WriteLine(result); // Displays 1 2 3 4 5 
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
