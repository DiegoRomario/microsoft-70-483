using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAContinuation
{
    public static class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }

        // t.Result = Attempting to read the Result property on a Task will force the thread that’s trying to  read the result to wait until the Task is finished before continuing. 
        // As long as the Task has not finished, it is impossible to give the result. If the Task is not finished, this call will block the current thread.

        // ContinueWith: This means that you want another operation to execute as soon as the Task finishes. 
        // The ContinueWith method has a couple of overloads that you can use to configure when the continuation will run.
        // This way you can add different continuation methods that will run when an exception happens, the Task is canceled, or the Task completes successfully

        //TaskContinuationOptions:
        //None = 0,
        //PreferFairness = 1,
        //LongRunning = 2,
        //AttachedToParent = 4,
        //DenyChildAttach = 8,
        //HideScheduler = 16,
        //LazyCancellation = 32,
        //RunContinuationsAsynchronously = 64,
        //NotOnRanToCompletion = 65536,
        //NotOnFaulted = 131072,
        //OnlyOnCanceled = 196608,
        //NotOnCanceled = 262144,
        //OnlyOnFaulted = 327680,
        //OnlyOnRanToCompletion = 393216,
        //ExecuteSynchronously = 524288


    }
}
