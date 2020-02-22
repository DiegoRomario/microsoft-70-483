using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_UsingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[10];
            for (int x = 0; x < arrayOfInt.Length; x++)
            {
                arrayOfInt[x] = x;
            }
            foreach (int i in arrayOfInt)
            {
                Console.Write(i); // Displays 0123456789
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
