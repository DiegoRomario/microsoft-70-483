using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_CreatingAan_anonymous_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new
            {
                FirstName = "John",
                LastName = "Doe"
            };
            Console.WriteLine(person.GetType().Name);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
