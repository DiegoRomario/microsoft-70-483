using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) =>
            {
                Console.WriteLine("Event raised: {0}", e.Value);
            };
            p.Raise();
            Console.ReadKey();
        }

        public static void Demo(object sender, MyArgs e)
        {
            Console.WriteLine("Event raised: {0}", e.Value);
        }
    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
    public class Pub
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }


}
