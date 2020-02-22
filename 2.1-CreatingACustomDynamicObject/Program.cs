using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_CreatingACustomDynamicObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty); // Displays ‘SomeProperty’
            Console.Read();
        }
    }
    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;
            return true;
        }

    }
}
