using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_IteratingOverAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Custom Value";
            foreach (char c in value)
                Console.WriteLine(c);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
