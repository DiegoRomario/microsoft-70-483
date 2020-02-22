using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_UsingAWhereClauseOnAClassDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new MyClass<Demo>()
            {
               
            };

            teste.MyProperty = new Demo() { };
            teste.MyProperty.MyProperty = "teste";

        }
    }
}
