using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_Usingefault_T__with_a_generic_type_parameter
{
    public class Demo<T>
    {
        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
            Console.WriteLine(defaultValue);
        }

    }
}
