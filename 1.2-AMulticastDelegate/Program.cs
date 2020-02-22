using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cla = new Class1();
            cla.Multicast();
            Console.ReadKey();
        }
    }
}
