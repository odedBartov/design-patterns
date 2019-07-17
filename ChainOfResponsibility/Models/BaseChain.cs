using ChainOfResponsibility.Interfaces;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public abstract class BaseChain : IChain
    {
        private IChain _nextChain;
        public int Calculate(Numbers request)
        {
            if (CanDo(request))
            {
                return InnerCalculate(request);
            }
            else if (_nextChain != null)
            {
                return _nextChain.Calculate(request);
            }
            else
            {
                throw new MatchingLogicNotFoundException();
            }

        }

        internal abstract int InnerCalculate(Numbers request);
        internal abstract bool CanDo(Numbers request);

        public void SetNextChain(IChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}
