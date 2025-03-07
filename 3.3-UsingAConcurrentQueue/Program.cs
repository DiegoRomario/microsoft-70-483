﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            queue.Enqueue(41);
            queue.Enqueue(456);
            queue.Enqueue(4);

            int result2;
            if (queue.TryPeek(out result2))
                Console.WriteLine("Peek: {0}", result2);

            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
            Console.ReadKey();
            // Dequeued: 42
        }
    }
}
