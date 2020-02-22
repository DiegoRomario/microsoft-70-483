using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_CreatingAFuncTypeWithALambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(addFunc(2, 3));
            Console.ReadKey();
        }
    }
}
