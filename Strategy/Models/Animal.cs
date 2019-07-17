using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public abstract class Animal
    {
        IFlyable _fly;

        public Animal(IFlyable fly)
        {
            _fly = fly;
        }

        public void SetFlyable(IFlyable fly)
        {
            _fly = fly;
        }

        public string TryTFly()
        {
            return _fly.Fly();
        }
    }
}
