using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Interfaces
{
    public interface IChain
    {
        void SetNextChain(IChain nextChain);

        int Calculate(Numbers request);
    }
}
