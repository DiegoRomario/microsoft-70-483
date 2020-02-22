using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_ImplementingAnImplicitAndExplicitConversionOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Money(new decimal(10.54));
            int teste = (int)demo.Amount;

            string tico = demo;

            Console.WriteLine(tico);
            Console.ReadKey();

        }
    }

    class Money
    {
        public Money(decimal amount)
        {
            Amount = amount;
        }
        public decimal Amount { get; set; }
        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

        public static implicit operator string (Money money)
        {
            return money.Amount.ToString();
        }
    }
}
