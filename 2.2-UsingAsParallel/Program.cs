using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 200);
            var parallelResult = numbers    
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item.ToString()); ;
            }

            Console.ReadLine();
        }
    }
}
