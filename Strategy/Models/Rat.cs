using Strategy.Interfaces;
using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class Rat : Animal
    {
        public Rat() : base(new CanNotFly())
        {
        }
    }
}
