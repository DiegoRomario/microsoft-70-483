using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_UsingAStringBuilderInALoop
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }
             var ter = sb[50];
            Console.ReadKey();
        }
    }
}
