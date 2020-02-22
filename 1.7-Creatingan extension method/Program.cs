using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Creatingan_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }
    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }
    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
