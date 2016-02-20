using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Exceptions
{
    class UnhandledResultType : Exception
    {
        public UnhandledResultType() : base("Wrong Result Type")
        {
            
        }
    }
}
