using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_UsingStack_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");
            foreach (string s in myStack)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            var demo = myStack.Pop();
            var demo2 = myStack.Peek();
            foreach (string s in myStack)
            {
                Console.Write(s + " ");
            }

            // Displays: Queue A From World Hello
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
