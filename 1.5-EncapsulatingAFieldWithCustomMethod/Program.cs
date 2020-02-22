using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_EncapsulatingAFieldWithCustomMethod
{
    class Program
    {
        private int _field;
        public void SetValue(int value) { _field = value; }
        public int GetValue() { return _field; }
        static void Main(string[] args)
        {
        }
    }
    class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                _firstName = value;
            }
        }
    }
}
