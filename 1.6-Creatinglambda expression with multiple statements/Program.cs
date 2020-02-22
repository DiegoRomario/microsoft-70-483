using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatinglambda_expression_with_multiple_statements
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {
            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };         
            int result = calc(3, 4);
            Console.WriteLine(result);
            Console.ReadKey();
            // Displays
            // Adding numbers
        }
    }
}
