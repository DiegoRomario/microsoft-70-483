using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_UsingTheDebugClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 46);
            Debug.WriteLineIf(i > 0, "i is greater than 0");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
