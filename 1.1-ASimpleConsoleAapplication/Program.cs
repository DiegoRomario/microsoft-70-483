using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace _1._1_ASimpleConsoleAapplication
{
    class Program
    {
        public static void Main()
        {

            var Name = new Person();
            Name.FirstName = "joe";
            Name.LastName = "silva";

            Console.WriteLine(Name);

            Log("teste");
#line 200 "Special"
            int i;
            int j;
#line default
            char c;
            float f;
#line hidden // numbering not affected
            string s;
            double d;

            Timer t = new Timer(TimerCallback, null, 0, 2000);

            Console.WriteLine("Normal line #1."); // Set break point here.
#line hidden
            Console.WriteLine("Hidden line.");
#line default
            Console.WriteLine("Normal line #2.");


#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore


#pragma warning disable 0162, 0168
            int y;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore 


            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            //#warning This code is obsolete
            //#if DEBUG
            //#error Debug build is not allowed
            //#endif

            Console.WriteLine("In TimerCallback: " + DateTime.Now);
#if DEBUG
            Console.WriteLine("Debug mode");
#else
                Console.WriteLine("Not debug");
#endif
            GC.Collect();
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
        [DebuggerDisplay("Demo = {FirstName + LastName} {LastName")]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
