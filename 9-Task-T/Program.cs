using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingATaskThatReturnsAValue
{
    public static class Program
    {
        // TASK<T>: Using a Task that returns a value
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result); // Displays 42
            Console.ReadKey();
        }
    }
}
