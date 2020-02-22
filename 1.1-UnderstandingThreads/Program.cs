using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingAThreadWithTheThreadClass
{
    public static class Program
    {
        // ###############################################################################################################################
        // CONTEXT SWITCH: is a procedure that a computer's CPU (central processing unit) follows to change from one task (or process) 
        // to another while ensuring that the tasks do not conflict. 
        // Effective context switching is critical if a computer is to provide user-friendly multitasking.

        // SYNCHRONIZATION: is the mechanism of ensuring that two threads don’t execute a specific portion of your program at the same time


        // JOIN(): Blocks the calling thread until the thread represented by this instance terminates, while continuing to perform standard COM and SendMessage pumping.

        //      A: "I am thread X and I will wait for thread Y to finish"
        //      t.Join();
        //      A: "I'm thread X and waited until thread Y finished"

        //      Join(1000): …
        //      Join(TimeSpan(...)): …

        // Sleep(1000) : Suspends the current thread for the specified number of milliseconds.
        // Sleep(TimeSpan(...)): Suspends the current thread for the specified amount of time.



        // ###############################################################################################################################


        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0} | Thread ID {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(2000);
            }
        }
        public static void Main()
        {
            Thread t = new Thread (new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work. | Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            Console.WriteLine("I will wait");
            t.Join();
            Console.WriteLine("Ready, I've waited");
            Console.ReadKey();
        }
    }
}
