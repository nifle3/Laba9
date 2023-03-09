using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal class Operand 
    {
        public object value { private set; get;} 

        public Operand(object NewValue)
        {
            value = NewValue;
        }
    }
}
