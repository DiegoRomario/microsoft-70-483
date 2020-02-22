using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_UsingThePrivateAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Accessibility
    {
        private string _myField;
        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }
}
