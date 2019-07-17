using Strategy.Interfaces;
using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class Sparrow : Animal
    {
        public Sparrow() : base(new CanFly())
        {
        }
    }
}
