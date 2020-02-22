using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingADeadlock
{
    public class Program
    {
        static void Main()
        {
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });
            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();
            Console.ReadKey();
        }
    }
}
