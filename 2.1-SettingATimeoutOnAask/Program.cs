using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SettingATimeoutOnTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            int index = Task.WaitAny(new[] { longRunning }, 5000);
            if (index == -1)
                Console.WriteLine("Task timed out");

            Console.ReadKey();
        }
    }
}
