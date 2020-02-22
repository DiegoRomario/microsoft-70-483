using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_GettingTheValueOfAFieldThroughReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Demo demo = new Demo();
            Demo.DumpObject(test);
            Console.ReadKey();
        }


    }
}
