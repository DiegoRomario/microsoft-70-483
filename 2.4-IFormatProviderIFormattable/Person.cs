using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_IFormatProviderIFormattable
{
    public class Person : IFormatProvider, IFormattable
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            var teste = int.Parse(firstName, NumberStyles.Currency);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public object GetFormat(Type formatType)
        {
            return System.Globalization.CultureInfo.CurrentCulture.GetType();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }


    }
}
