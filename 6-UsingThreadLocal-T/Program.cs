using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadLocal_T
{
    public static class Program
    {

        // UsingThreadLocal<T>:  If you want to use local data in a thread and initialize it for each thread, you can use the ThreadLocal<T> class. 
        // This class takes a delegate to a method that initializes the value.

        // Thread.CurrentThread: to ask for information about the thread that’s executing.This is called the thread’s execution context.
        // This property gives you access to properties like the thread’s current culture, principal, priority and other info.
        // When a thread is created, the runtime ensures that the initiating thread’s execution context is flowed to the new thread.
        // This way the new thread has the same privileges as the parent thread.
        // This copying of data does cost some resources, however. If you don’t need this data, you can disable this behavior by using the ExecutionContext.SuppressFlow method.


        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
            Console.ReadKey();
        }

        // https://vike.io/pt/239046/
    }
}
