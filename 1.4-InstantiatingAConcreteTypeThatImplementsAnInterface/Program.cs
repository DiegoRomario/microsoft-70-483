using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_InstantiatingAConcreteTypeThatImplementsAnInterface
{
    class Program
    {
        IAnimal animal = new Dog();
        static void Main(string[] args)
        {
        }
    }

    interface IAnimal
    {
        void Move();
    }
    class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }
    
}
