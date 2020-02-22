using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttachingChildTasksToAParentTask
{
    public static class Program
    { 
        public static void Main()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(
               parentTask =>
               {
                   foreach (int i in parentTask.Result)
                       Console.WriteLine(i);
               });
            Console.ReadLine();
            finalTask.Wait();

        }

        // A Task can also have several child Tasks. The parent Task finishes when all the child tasks are ready.

        //TaskCreationOptions:
        //None = 0,
        //PreferFairness = 1,
        //LongRunning = 2,
        //AttachedToParent = 4,
        //DenyChildAttach = 8,
        //HideScheduler = 16,
        //RunContinuationsAsynchronously = 64

    }
}
        
