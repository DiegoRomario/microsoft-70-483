﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask.WaitAny
{
    public static class Program
    {
        public static void Main()
        {
            // WaitAny: Instead of waiting until all tasks are finished, you can also wait until one of the tasks is finished. You use the WaitAny method for this
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() => {
                Thread.Sleep(1000);
                return 1;
            });
            tasks[1] = Task.Run(() => {
                Thread.Sleep(52000);
                return 2;
            });
            tasks[2] = Task.Run(() => {
                Thread.Sleep(2000);
                return 3;
            });
            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
                Console.ReadLine();
            }
        }
    }
}
