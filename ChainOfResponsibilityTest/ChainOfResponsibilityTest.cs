using System;
using ChainOfResponsibility;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;
using Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainOfResponsibilityTest
{
    [TestClass]
    public class ChainOfResponsibilityTest
    {
        IChain _chain;
        [TestInitialize]
        public void Init()
        {
            IChain addNumbers = new AddNumbers();
            IChain substractNumbers = new SubstractNumbers();
            IChain multypileNumbers = new MultypileNumbers();
            IChain divideNumbers = new DivideNumbers();

            addNumbers.SetNextChain(divideNumbers);
            divideNumbers.SetNextChain(multypileNumbers);
            multypileNumbers.SetNextChain(substractNumbers);
            _chain = addNumbers;
        }
        [TestMethod]
        public void TestAllLogic_ShouldReturnAllResults()
        {
            int number1 = 6;
            int number2 = 3;
            Numbers requestAdd = new Numbers(number1, number2, "Add");
            Numbers requestSub = new Numbers(number1, number2, "Subtract");
            Numbers requestMulty = new Numbers(number1, number2, "Multypile");
            Numbers requestDiv = new Numbers(number1, number2, "Divide");

            int AddResult = _chain.Calculate(requestAdd);
            int SubstractResult = _chain.Calculate(requestSub);
            int MultyResult = _chain.Calculate(requestMulty);
            int DivResult = _chain.Calculate(requestDiv);

            Assert.AreEqual(9, AddResult);
            Assert.AreEqual(3, SubstractResult);
            Assert.AreEqual(18, MultyResult);
            Assert.AreEqual(2, DivResult);

            
        }
        [TestMethod,ExpectedException(typeof(MatchingLogicNotFoundException))]
        public void WrongLogic_ShouldThrowException()
        {
            _chain.Calculate(new Numbers (1,2,"Bla"));
        }
    }
}
