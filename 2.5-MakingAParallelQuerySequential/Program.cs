using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAParallelQuerySequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 200);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
