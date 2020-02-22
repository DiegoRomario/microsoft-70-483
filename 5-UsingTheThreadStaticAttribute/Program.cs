using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTheThreadStaticAttribute
{

    public static class Program
    {

        //  USING THE THREAD STATIC ATTRIBUTE: [ThreadStatic] - Indicates that the value of a static field is unique for each thread.
        //  In other words, every thread has his own scope
        //  [ThreadStatic]
        //  public static int _field;


        [ThreadStatic]
        public static int _field;

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                    
                }
            }).Start();
            new Thread(() =>
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            _field++;
                            Thread.Sleep(1000);
                            Console.WriteLine("Thread B: {0}", _field);
                        }
                    }).Start();
            Console.ReadKey();
        }
    }
}
