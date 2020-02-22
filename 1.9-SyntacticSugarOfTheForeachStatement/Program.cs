using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_SyntacticSugarOfTheForeachStatement
{
    class Program
    {
        public static List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };

        static void Main(string[] args)
        {
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
                
            }
            Console.ReadKey();
        }
    }
}
