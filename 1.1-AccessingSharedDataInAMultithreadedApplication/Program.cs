using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingSharedDataInAMultithreadedApplication
{
    public class Program
    {
        static void Main()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++) { 
                    n++;
                }
            });
            for (int i = 0; i < 1000000; i++) { 
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
   
