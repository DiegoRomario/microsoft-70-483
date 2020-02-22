using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingADelegate
{
    public class Class1
    {
        public delegate int Calculate(int x, int y);
        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }
        public void UseDelegate()
        {
            //Calculate calc = Add;
            Calculate calc = (int x, int y) => {
                return 666;
            };
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
