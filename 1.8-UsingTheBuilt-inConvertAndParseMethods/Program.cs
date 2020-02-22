using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_UsingTheBuilt_inConvertAndParseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("80", out value);
        }
    }
}
