using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_UsingStartsWithAndEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "< mycustominput >";
            if (value.StartsWith("<"))
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }
            if (value.EndsWith("<"))
            {
               Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
