using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Su1m(int x, int y)
        {
            Console.WriteLine(x + y);
        }


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Action<int, int> teste = (int x, int y) => { Console.WriteLine(x + y); };

            teste(1, 2);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
