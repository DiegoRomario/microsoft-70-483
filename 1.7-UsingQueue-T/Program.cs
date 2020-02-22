using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_UsingQueue_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            foreach (string s in myQueue)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            var demo = myQueue.Dequeue();
            var demo2 = myQueue.Peek();
            foreach (string s in myQueue)
            {
                Console.Write(s + " ");
            }
            // Displays: Hello World From A Queue
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
