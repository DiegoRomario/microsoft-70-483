using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTheEventKeyword
{
    public class Pub
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }
}

