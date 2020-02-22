using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_ImplementingAnInterfaceExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {

            Implementation teste = new Implementation();
            string myvar = ((IInterfaceA)teste).MyMethod();

        }

    }
    interface IInterfaceA
    {
        string MyMethod();
    }
    class Implementation : IInterfaceA
    {
        //public string MyMethod()
        //{
        //    return "teste";
        //}
        string IInterfaceA.MyMethod() { return "teste"; }
    }

}
