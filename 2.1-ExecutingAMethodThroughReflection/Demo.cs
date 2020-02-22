using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_ExecutingAMethodThroughReflection
{
    public static class Demo
    {
        //public static int i = 42;
        //public static MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo",
        //    new Type[] { typeof(int) });
        //public static int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
        public static MyType MyProp = new MyType("Diego", "Romário");
        public static MethodInfo FullNameMethod = MyProp.GetType().GetMethod("FullName", new Type[] { typeof(string) });
        public static string result = (string)FullNameMethod.Invoke(MyProp, new object[] { " - " });
    }

    public class MyType
    {
        public MyType(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string FullName (string separator)
        {
            return $"{Name} {separator} {LastName}";
        }
    }


}
