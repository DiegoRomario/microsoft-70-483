using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingAggregateException
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
                foreach (var item in e.InnerExceptions)
                {
                    Console.WriteLine(item.Message);
                }
                Console.ReadKey();
            }


        }
        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException(i.ToString());
            return i % 2 == 0;
        }
    }
}
