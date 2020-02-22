using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(4);
            bag.Add(5);
            bag.Add(3);
            bag.Add(278945454);
            bag.Add(1);
            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);
            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);

            Console.ReadKey();
        }
    }
}
