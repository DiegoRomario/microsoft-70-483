using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_OverridingAVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        protected virtual void Execute()
        { }
    }
    class Derived : Base
    {
        protected override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }
        private void Log(string message) { /* some logging code */ }
    }
}
