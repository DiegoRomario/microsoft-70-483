using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_TheIObjectContextAdapterInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public interface IObjectContextAdapter
    {
        ObjectContext ObjectContext { get; }

    }

    public static class teste
    {
        static DbContext ctx = new DbContext("teste");
        //var context = ctx.ObjectContext;
        public static ObjectContext abc = ((IObjectContextAdapter)ctx).ObjectContext;
    }
}
