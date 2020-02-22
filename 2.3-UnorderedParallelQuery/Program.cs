using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedParallelQuery
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 1000);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
