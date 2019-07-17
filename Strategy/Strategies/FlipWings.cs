using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class FlipWings : IFlyable
    {
        public string Fly()
        {
            return "I am flipping my wings but not actualy fly...";
        }
    }
}
