using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask.WhenAll
{
    class Program
    {
        public static void Main()
        {
            // WhenAll: Creates a task that will complete when all of the supplied tasks have completed. 
            int failed = 0;
            var tasks = new List<Task>();
            String[] urls = { "www.google.com", "www.uol.hcom.br", "www.fundamentus.com.br", "www.infomoney.com.br", "www.g1.com.br" };

            foreach (var value in urls)
            {
                var url = value;
                tasks.Add(Task.Run(() =>
                {
                    var png = new Ping();
                    try
                    {
                        var reply = png.Send(url);
                        if (!(reply.Status == IPStatus.Success))
                        {
                            Interlocked.Increment(ref failed);
                            throw new TimeoutException("Unable to reach " + url + ".");
                        }
                        else
                        {
                            Console.WriteLine($"{ url } : Pingued");
                        }
                    }
                    catch (PingException)
                    {
                        Interlocked.Increment(ref failed);
                        throw;
                    }
                }));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("All ping attempts succeeded.");
            }
            else if (t.Status == TaskStatus.Faulted)
            {
                Console.WriteLine("{0} ping attempts failed", failed);
            }

            Console.ReadKey();

        }
    }
}
