using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask.WaitAll
{
    public static class Program
    {
        // Task.WaitAll: Wait for multiple Tasks to finish before continuing execution.Waits for all of the provided Task objects to complete execution.
        public static void Main()
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
