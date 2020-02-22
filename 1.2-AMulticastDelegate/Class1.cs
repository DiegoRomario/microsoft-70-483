using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMulticastDelegate
{
    public class Class1
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
        public delegate void Del();
        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            Delegate[] list = d.GetInvocationList();
            int count = list.GetLength(0);

            Console.WriteLine($"count 1: {list.Count()} ");
            Console.WriteLine($"count 2: {count} ");
            d();
        }
        // Displays
        // MethodOne
        // MethodTwo
    }
}
