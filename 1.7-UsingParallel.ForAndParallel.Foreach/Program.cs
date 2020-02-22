using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParallel.ForAndParallel.Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel: Provides support for parallel loops and regions.
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("for: " + i);
                Thread.Sleep(500);
            });
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine("foreach: " + i);
                Thread.Sleep(500);
            });

            Console.ReadKey();
        }
    }
}
