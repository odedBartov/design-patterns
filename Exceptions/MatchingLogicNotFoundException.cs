using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MatchingLogicNotFoundException : Exception
    {
        public MatchingLogicNotFoundException():base("Can't find matching logic") { }
    }
}
