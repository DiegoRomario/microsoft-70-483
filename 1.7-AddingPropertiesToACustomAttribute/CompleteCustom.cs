using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_AddingPropertiesToACustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}
