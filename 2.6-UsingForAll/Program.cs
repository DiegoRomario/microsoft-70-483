using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));
            Console.WriteLine("=============================================================");
            foreach (var item in parallelResult)
            {
                Console.WriteLine(item.ToString());
            }            Console.ReadKey();
        }
    }
}
