using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_UsingTheAndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (teste.Process("parametro"))
            {
                Console.WriteLine("teste");
            }

            Console.ReadKey();

        }

        public static class teste { 

        public static bool Process(string input)
        {
                return (input != null) && teste.Starts(input); 
            // Do something with the result
        }

        public static bool Starts(string teste)
        {
                return teste.StartsWith("v");
        }


        }
    }
}
