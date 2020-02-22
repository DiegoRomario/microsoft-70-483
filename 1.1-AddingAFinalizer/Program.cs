using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_AddingAFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            // {Forcing a garbage collection
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            // } When running this piece of code in Release mode, the garbage collector will see that there are no more references to stream, and it will free any memory associated with the StreamWriter instance. 
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.
        }
        ~Program()
        {
            // This code is called when the finalize method executes
        }
    }
}
