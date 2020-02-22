    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_UsingIndexOfAndLastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p'); // returns 6
            int lastIndexOfm = value.LastIndexOf('m'); // returns 5
            Console.ReadKey();
        }
    }
}
