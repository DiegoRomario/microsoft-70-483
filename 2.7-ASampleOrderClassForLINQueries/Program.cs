using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_ASampleOrderClassForLINQueries
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

            orders.Add(order);



            var averageNumberOfOrderLines = orders.Average(o => o.OrderLines.Count);

            Console.WriteLine(averageNumberOfOrderLines);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}
