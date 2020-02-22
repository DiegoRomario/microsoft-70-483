using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_ImplementingTheIComparableInterface
{
    class Program
    {
        static List<Order> orders = new List<Order>
        {
        new Order { Created = new DateTime(2020, 1, 1 )},
        new Order { Created = new DateTime(2030, 1, 1 )},
        new Order { Created = new DateTime(2020, 1, 1 )},
        new Order { Created = new DateTime(2030, 1, 1 )},
        };
        
        static void Main(string[] args)
        {
            orders.Sort();
            foreach (var item in orders)
            {
                Console.WriteLine(item.Created);
                
            }
            Console.ReadKey();
        }
    }


    public class Order : IComparable<Order>
    {
        public DateTime Created { get; set; }

        public int CompareTo(Order obj)
        {


            if (obj == null) return 1;
            Console.WriteLine("COMPARAÇÃO");
            Console.WriteLine($"1º objeto (recebido por parametro) avalidado: {obj.Created.ToString()}");
            Console.WriteLine($"2º objeto (propriedade da classe) avalidado: {this.Created.ToString()}");
            if (obj == null)
            {
                throw new ArgumentException("Object is not an Order");
            }
            var teste = this.Created.CompareTo(obj.Created); // -1 SE O objeto recebido por parametro for maior, 0 se for igual e 1 se for menor...
            Console.WriteLine("RESULTADO: " + teste);
            return this.Created.CompareTo(obj.Created);
        }
    }
    //public class Order : IComparable
    //{
    //    public DateTime Created { get; set; }

    //    public int CompareTo(object obj)
    //    {


    //        if (obj == null) return 1;
    //        Order o = obj as Order;
    //        Console.WriteLine("COMPARAÇÃO");
    //        Console.WriteLine($"1º objeto (recebido por parametro) avalidado: {o.Created.ToString()}");
    //        Console.WriteLine($"2º objeto (propriedade da classe) avalidado: {this.Created.ToString()}");
    //        if (o == null)
    //        {
    //            throw new ArgumentException("Object is not an Order");
    //        }
    //        var teste = this.Created.CompareTo(o.Created); // -1 SE O objeto recebido por parametro for maior, 0 se for igual e 1 se for menor...
    //        Console.WriteLine("RESULTADO: " + teste);
    //        return this.Created.CompareTo(o.Created);
    //    }
    //}







}
