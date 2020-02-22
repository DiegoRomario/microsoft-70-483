using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _1._8_CreatingAnInterfaceThatCanBeFoundThroughReflection
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(Application application);
    }

    //public class MyPlugin : IPlugin
    //{
    //    public string Name => throw new NotImplementedException();

    //    public string Description => throw new NotImplementedException();

    //    //public bool Load(Application application)
    //    //{
    //    //    throw new NotImplementedException();
    //    //}
    //}
}
