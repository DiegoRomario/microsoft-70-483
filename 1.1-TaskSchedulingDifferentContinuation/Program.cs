using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingDifferentContinuationTasks
{
    public static class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();


            //DemoEntity demo = new DemoEntity();
            //demo.Demo1 = 10;
            //Console.WriteLine(demo.Demo1);

            Console.ReadKey();
        }

            //TaskContinuationOptions:
            //None = 0,
            //PreferFairness = 1,
            //LongRunning = 2,
            //AttachedToParent = 4,
            //DenyChildAttach = 8,
            //HideScheduler = 16,
            //LazyCancellation = 32,
            //RunContinuationsAsynchronously = 64,
            //NotOnRanToCompletion = 65536,
            //NotOnFaulted = 131072,
            //OnlyOnCanceled = 196608,
            //NotOnCanceled = 262144,
            //OnlyOnFaulted = 327680,
            //OnlyOnRanToCompletion = 393216,
            //ExecuteSynchronously = 524288


    }
}
