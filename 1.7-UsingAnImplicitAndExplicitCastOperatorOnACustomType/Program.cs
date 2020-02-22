using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_UsingAnImplicitAndExplicitCastOperatorOnACustomType
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;
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
    }
}
