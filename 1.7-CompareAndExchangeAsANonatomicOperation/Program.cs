using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompareAndExchangeAsANonatomicOperation
{
    class Program
    {

        static int value = 1;
        public static void Main()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 3)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(1000);
                    value = Interlocked.CompareExchange(ref value, 5, 3); 
                }
            });
            Task t2 = Task.Run(() =>
            {
                value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2
            Console.ReadKey();
        }
    }

}

