using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTheEventKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
            Console.Read();
        }
    }
}
