using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravarianceWithDelegates
{
    public class Class1
    {
        void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        public delegate void ContravarianceDel2(StringWriter tw);
        public void teste ()
        {
            ContravarianceDel del = DoSomething;
            ContravarianceDel2 del2 = DoSomething;
        }
    }
}
