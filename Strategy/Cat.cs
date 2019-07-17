using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Cat : Animal
    {
        public Cat() : base(new CanNotFly())
        {
        }
    }
}
