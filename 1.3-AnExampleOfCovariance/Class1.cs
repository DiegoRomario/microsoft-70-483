using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnExampleOfCovariance
{
    public class Class1
    {
        public delegate TextWriter CovarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }


        public void teste ()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
