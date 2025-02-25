﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_CreatingHelloWorldWithAnExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockExpression blockExpr = Expression.Block(
            Expression.Call(null,typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),Expression.Constant("Hello ")),
            Expression.Call(null,typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),Expression.Constant("World!")));
            Expression.Lambda<Action>(blockExpr).Compile()();
            Console.ReadKey();
        }
    }
}
