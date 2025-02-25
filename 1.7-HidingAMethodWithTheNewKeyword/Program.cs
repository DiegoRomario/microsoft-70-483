﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_HidingAMethodWithTheNewKeyword
{
    class Base
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }
    class Derived : Base
    {
        public new void Execute() { Console.WriteLine("Derived.Execute"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();
            Console.Read();
        }
    }
}
