using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                if (i == 5)
                {
                    goto Demo;

                }
            }
        Demo:
            { Console.WriteLine("Demo called"); }

        }
    }
}
