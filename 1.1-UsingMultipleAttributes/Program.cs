using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_UsingMultipleAttributes
{
    class Program
    {
        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        static void MyMethod() { }
        static void Main(string[] args)
        {
        }
    }
}
