using _2._7_ASampleOrderClassForLINQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9_UsingJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Product()
            {
                Description = "A",
                Price = 10
            };
            var produto2 = new Product()
            {
                Description = "B",
                Price = 20
            };

            List<Product> products = new List<Product>();
            products.Add(produto);
            products.Add(produto2);

            string[] popularProductNames = {"A", "B" };


            var popularProducts = from p in products
                                  join l in popularProductNames on p.Description equals l
                                  select p;

            foreach (var item in popularProducts)
            {
                Console.WriteLine(item.Description);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
