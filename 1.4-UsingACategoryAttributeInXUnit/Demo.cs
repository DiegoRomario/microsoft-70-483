using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1._4_UsingACategoryAttributeInXUnit
{
    public class Demo
    {
        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest()
        { }
        [Fact]
        [Trait("Category", "Integration Test")]
        public void MyIntegrationTest()
        { }
    }
   
}
