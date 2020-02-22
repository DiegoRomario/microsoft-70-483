using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_GettingTheValueOfAFieldThroughReflection
{
    public class Demo
    {
        public static void DumpObject(object obj)
        {
           FieldInfo[] fields = obj.GetType().GetFields( BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }
}
