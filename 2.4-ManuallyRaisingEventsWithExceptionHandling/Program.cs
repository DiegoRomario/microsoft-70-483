using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_ManuallyRaisingEventsWithExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();
            Console.Read();
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
                => { throw new Exception(); };
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");
            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
        // Displays
        // Subscriber 1 called
        // Subscriber 3 called
        // 1
    }



    public class Pub
    {
        public event EventHandler OnChange;
        public void Raise()
        {
            var exceptions = new List<Exception>();
            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                 }
            }
            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
