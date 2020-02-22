using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_FlagAttributeForAnEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            var readingDays = Days.Monday | Days.Saturday; 
            Console.WriteLine(readingDays);
            Console.ReadKey();
        }
    }
}
