using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionToCreateADelegate
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            var test = new StringWriter();
            Console.WriteLine(calc(1, 'a')); // Displays 98
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12

            //int asciiCode = (int)'a';
            //Console.WriteLine(asciiCode);

            Console.ReadKey();
        }
    }
}
