using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class CanNotFly : IFlyable
    {
        public string Fly()
        {
            return "I can not fly! I am groundded";
        }
    }
}
