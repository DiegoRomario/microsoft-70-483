using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_CreatingAndImplementingAnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }
    }
    class ExampleImplementation : IExample
    {
        public string GetResult()
        {
            return "result";
        }
        public int Value { get; set; }
        public event EventHandler CalculationPerformed;
        public event EventHandler ResultRetrieved;
        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }
    }
}
