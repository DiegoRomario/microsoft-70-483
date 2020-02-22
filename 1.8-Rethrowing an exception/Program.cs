using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethrowingAnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                throw; // rethrow the original exception
            }
        }
    }
}
