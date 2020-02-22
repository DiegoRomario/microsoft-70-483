using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_UsingAWhereClauseOnAClassDefinition
{
    public class MyClass<T>
    where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }
        public T MyProperty { get; set; }
    }
}
