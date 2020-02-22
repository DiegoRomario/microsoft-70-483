using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_ChangingACharacterWithAStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");
            sb[0] = 'B';

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
