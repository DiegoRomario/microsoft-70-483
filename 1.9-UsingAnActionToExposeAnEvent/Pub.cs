using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAnActionToExposeAnEvent
{
    public class Pub
    {
        public Action OnChange { get; set; }
        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }
}
