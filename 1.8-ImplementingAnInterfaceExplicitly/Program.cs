using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_ImplementingAnInterfaceExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface ILeft
    {
        void Move();
    }
    interface IRight
    {
        void Move();
    }
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Move() { }
    }
}
