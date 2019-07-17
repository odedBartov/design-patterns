using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Numbers
    {
        private int _number1;
        private int _number2;
        private string _calculate;

        public Numbers(int Number1, int Number2, string Calculate)
        {
            _number1 = Number1;
            _number2 = Number2;
            _calculate = Calculate;
        }

        public int GetNumber1() { return _number1; }

        public int GetNumber2() { return _number2; }

        public string GetCalculate() { return _calculate; }
    }
}
