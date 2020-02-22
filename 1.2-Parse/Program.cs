using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b); // displays True

            string value2 = "1";
            int result;
            bool success = int.TryParse(value2, out result);
            if (success)
            {
                // value is a valid integer, result contains the value
            }
            else
            {
                // value is not a valid integer
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
