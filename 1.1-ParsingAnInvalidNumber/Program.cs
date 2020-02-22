using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingAnInvalidNumber
{
    public static class Program
    {
        public static void Main()
        {
            string s = "NaN";
            int i = int.Parse(s);
        }
    }
}
