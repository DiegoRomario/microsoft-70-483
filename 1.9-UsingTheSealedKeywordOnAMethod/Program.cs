using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_UsingTheSealedKeywordOnAMethod
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
            var testre = string.Concat("To box or not box", 42, true);
            return 42;
        }
    }
    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
    class Derived2 : Derived
    {
        // This line would give a compile error
        // public override int MyMethod() { return 1;}
    }
}
