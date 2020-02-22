using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingANewTask
{

    public static class Program
    {
        // TASKS: Represents an asynchronous operation.
        public static void Main()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                    
                }
                Console.ReadKey();
            });
            t.Wait();

            // Wait: Calling Wait is equivalent to calling Join on a thread. It waits till the Task is finished before exiting the application
        }
    }
}

