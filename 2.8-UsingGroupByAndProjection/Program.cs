using _2._7_ASampleOrderClassForLINQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_UsingGroupByAndProjection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            var produto = new Product()
            {
                Description = "teste",
                Price = 10
            };
            var produto2 = new Product()
            {
                Description = "teste2",
                Price = 20
            };
            var orderline = new OrderLine()
            {
                Amount = 10,
                Product = produto

            };
            var orderline2 = new OrderLine()
            {
                Amount = 2,
                Product = produto2

            };
            List<OrderLine> orderlines = new List<OrderLine>();
            orderlines.Add(orderline);
            orderlines.Add(orderline2);

            var order = new Order()
            {
                OrderLines = orderlines
            };

            orders.Add(order);
            var result = from o in orders
                         from l in o.OrderLines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.Key,
                             Amount = p.Sum(x => x.Amount)
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item.Product.Description);
                Console.WriteLine(item.Amount);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
