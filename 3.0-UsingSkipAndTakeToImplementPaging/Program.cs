using _2._7_ASampleOrderClassForLINQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_UsingSkipAndTakeToImplementPaging
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
            var orderline = new OrderLine()
            {
                Amount = 10,
                Product = produto

            };
            List<OrderLine> orderlines = new List<OrderLine>();
            orderlines.Add(orderline);

            var order = new Order()
            {
                OrderLines = orderlines
            };
            var order2 = new Order()
            {
                OrderLines = orderlines
            };
            var order3 = new Order()
            {
                OrderLines = orderlines
            };
            var order4 = new Order()
            {
                OrderLines = orderlines
            };

            orders.Add(order);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);

            var pageIndex = 1;
            var pageSize = 4;

            var pagedOrders = orders
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);

            foreach (var item in pagedOrders)
            {
                Console.WriteLine(item.OrderLines);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
