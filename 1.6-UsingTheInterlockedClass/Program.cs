using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._6_UsingTheInterlockedClass
{
    public class Program
    {
        static void Main()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });
            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
