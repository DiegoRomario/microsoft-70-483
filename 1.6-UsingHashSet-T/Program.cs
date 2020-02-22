using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_UsingHashSet_T
{
    class Program
    {
        static void Main(string[] args)
        {
            UseHashSet();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static void UseHashSet()
        {
            HashSet<int> oddSet = new HashSet<int>();
            HashSet<int> evenSet = new HashSet<int>();
            for (int x = 1; x <= 10; x++)
            {
                if (x % 2 == 0)
                    evenSet.Add(x);
                else
                    oddSet.Add(x);
            }
            evenSet.Add(6); // não será duplicado!
            DisplaySet(oddSet);
            DisplaySet(evenSet);
            oddSet.UnionWith(evenSet);
            DisplaySet(oddSet);
        }
        private static void DisplaySet(HashSet<int> set)
        {
                foreach (int i in set)
                {
                    Console.Write("{0} | ", i);
                }
            Console.WriteLine("\n");
        }
    }
}
