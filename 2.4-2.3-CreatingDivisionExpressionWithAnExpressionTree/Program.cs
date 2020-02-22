using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_CreatingDivisionExpressionWithAnExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAMBDA EXPRESSION");
            Func<float, float> metade = quo => quo / 2;
            Console.WriteLine($"Metade de 10 é {metade(10)}");
            Console.WriteLine("######################################################");

            ParameterExpression quociente = Expression.Parameter(typeof(float), "quo");
            ConstantExpression divisior = Expression.Constant(2f, typeof(float));
            BinaryExpression operacao = Expression.Divide(quociente, divisior);

            Expression<Func<float, float>> expressaoDivisao = Expression.Lambda<Func<float, float>>(operacao, new ParameterExpression[] { quociente });
            var empressaoCompilada = expressaoDivisao.Compile();
            Console.WriteLine("TREE EXPRESSION");
            Console.WriteLine($"A Metade de 20 é {empressaoCompilada(20)}");
            Console.ReadKey();
            Console.WriteLine("######################################################");

        }
    }
}
