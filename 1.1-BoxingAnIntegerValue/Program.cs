using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_BoxingAnIntegerValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            object o = i;
            int x = (int)o;
        }
    }
}
