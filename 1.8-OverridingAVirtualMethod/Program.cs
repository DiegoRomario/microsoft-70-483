using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_OverridingAVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
