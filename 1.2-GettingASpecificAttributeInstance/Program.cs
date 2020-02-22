using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_GettingASpecificAttributeInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(typeof(Person),typeof(ConditionalAttribute));
            string condition = conditionalAttribute?.ConditionString; // returns CONDITION1
            Console.WriteLine(condition);

            Console.ReadKey();
        }
    }
    [Serializable]
    class Person { }
}
