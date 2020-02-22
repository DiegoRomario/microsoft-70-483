using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoppingAThread
{
    class Program
    {
        public static void Main()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); 
            stopped = true;
            t.Join();
        }

        // Thread.Abort: To stop a thread, you can use the Thread.Abort method. 
        // However, because this method is executed by another thread, it can happen at any time. 
        // When it happens, a ThreadAbortException is thrown on the target thread. This can potentially leave a corrupt state and make your application unusable. 
        // A better way to stop a thread is by using a shared variable that both your target and your calling thread can access

        // ## Below the incorrect way to abort a thread ##

        //public static void Main()
        //{
        //    Thread newThread = new Thread(new ThreadStart(TestMethod));
        //    newThread.Start();
        //    Thread.Sleep(1000);

        //    // Abort newThread.
        //    Console.WriteLine("Main aborting new thread.");
        //    newThread.Abort("Information from Main.");

        //    // Wait for the thread to terminate.
        //    newThread.Join();
        //    Console.WriteLine("New thread terminated - Main exiting.");
        //}

        //static void TestMethod()
        //{
        //    try
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("New thread running.");
        //            Thread.Sleep(1000);
        //        }
        //    }
        //    catch (ThreadAbortException abortException)
        //    {
        //        Console.WriteLine((string)abortException.ExceptionState);
        //        Console.ReadKey();
        //    }
        //}
    }
}

