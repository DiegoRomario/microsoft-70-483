using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_DefiningTheTargetsForACustomAttribute
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MyMethodAndParameterAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] // Setting the AllowMultiple parameter for a custom attribute
    class MyMultipleUsageAttribute : Attribute { }
}
