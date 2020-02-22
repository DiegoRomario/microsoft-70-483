using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAConcurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);
            stack.Push(45);
            stack.Push(41);
            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);
            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[3];
            stack.TryPopRange(values);
            foreach (int i in values)
                Console.WriteLine(i);

                Console.ReadKey();
            // Popped: 42
            // 3
            // 2
        }
    }
}
