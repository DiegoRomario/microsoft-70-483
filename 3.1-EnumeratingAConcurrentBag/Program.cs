using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnumeratingAConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(1);
                bag.Add(2);
                bag.Add(3);

                Thread.Sleep(2000);
                bag.Add(4);
                bag.Add(5);
            });
            Task.Run(() =>
            {
                while (true)
                {
                    foreach (int i in bag)
                        Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }).Wait();
            // Disp
            Console.ReadKey();
        }
    }
}
