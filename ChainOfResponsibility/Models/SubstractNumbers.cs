using ChainOfResponsibility.Interfaces;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class SubstractNumbers : BaseChain
    {
        internal override bool CanDo(Numbers request)
        {
            return request.GetCalculate() == "Subtract";
        }

        internal override int InnerCalculate(Numbers request)
        {
            return request.GetNumber1() - request.GetNumber2();
        }
    }
}
