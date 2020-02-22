using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _Parallel.Break
{
    class Program
    {

        // ParallelLoopState: Break and Stop: You can cancel the loop by using the ParallelLoopState object. 
        // You have two options to do this: Break or Stop. Break ensures that all iterations that are currently running will be finished. Stop just terminates everything

        static void Main(string[] args)
        {
            int count = 0;
            ParallelLoopResult result = Parallel.For(0, 100, (int i, ParallelLoopState loopState) =>
            {
                count += 1;
                Console.WriteLine($"Atual: {i}");
                if (i == 5)
                {
                    loopState.Stop();
                    //loopState.Break();
                    Console.WriteLine("Stopping loop");
                    Console.WriteLine($"Contagem: {count}");

                    //Console.WriteLine("Breaking loop");

                }
                return;
            });
            Console.ReadLine();
        }
    }
}
