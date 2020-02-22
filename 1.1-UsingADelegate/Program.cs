using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingADelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cla = new Class1();
            var teste = cla.Add(1, 1);
            cla.UseDelegate();
            Console.WriteLine(teste.ToString());
            Console.Read();
        }
    }
}
