using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace _1._5_CreatingACustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CategoryAttribute : ITraitAttribute
    {
        public CategoryAttribute(string value)
        { }
    }
    public class UnitTestAttribute : CategoryAttribute
    {
        public UnitTestAttribute()
        : base("Unit Test")
        { }
    }
    //[Fact]
    //[UnitTestAttribute]
    //public void MySecondUnitTest()
    //{ }

}
