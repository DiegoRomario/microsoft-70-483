using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_ALINQSelectQuery
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] dados = { 50, 20, 20, 8, 2, 21, 13, 55 };

            var resultado = from d in dados
                            where d % 2 == 0
                            select d;
            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
