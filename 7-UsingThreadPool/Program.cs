using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QueuingSomeWorkToTheThreadPool
{
    class Program
    {

        // Thread pools: When working directly with the Thread class, you create a new thread each time, and the thread dies when you’re finished with it.
        // The creation of a thread, however, is something that costs some time and resources.A thread pool is created to reuse those threads, 
        // similar to the way a database connection pooling works.Instead of letting a thread die, you send it back to the pool where it can be reused whenever a request comes in. 
        // When you work with a thread pool from .NET, you queue a work item that is then picked up by an available thread from the pool. 
        // Because the thread pool limits the available number of threads, you do get a lesser degree of parallelism than using the regular Thread class. 
        // But the thread pool also has many advantages.
        // It is shared throughout the framework not only in your application.

        // QueueUserWorkItem: Queues a method for execution.The method executes when a thread pool thread becomes available.
        // Control.Invoke Method: Executes a delegate on the thread that owns the control's underlying window handle.



        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }

        //public static void Main()
        //{
        //    // Queue the task.
        //    ThreadPool.QueueUserWorkItem(ThreadProc);
        //    Console.WriteLine("Main thread does some work, then sleeps.");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Main thread exits.");
        //    Console.ReadKey();

        //}

        // This thread procedure performs the task.
        static void ThreadProc(Object stateInfo)
        {
            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
            Console.WriteLine("Hello from the thread pool.");
            Console.ReadKey();
        }
    }
}
