using System;
using System.Collections.Generic;


namespace _3._1_ImplementingWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demo = { 1, 2, 3, 4, 5, 6 };
            var teste = demo.Where((i) => i % 2 == 0);
            foreach (var item in teste)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }

    }
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
