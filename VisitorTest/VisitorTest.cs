using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using Visitor.Models;

namespace VisitorTest
{
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void CalcBananaPriceTaxShould()
        {
            Banana banana = new Banana(30);

            double taxedPrice = banana.Accept(TaxVisitor.Instance);

            Assert.AreEqual(60, taxedPrice);
        }

        [TestMethod]
        public void GetBearPriceWithVisitor()
        {
            Beer beer = new Beer(10);

            double taxedPrice = beer.Accept(TaxVisitor.Instance);

            Assert.AreEqual(30, taxedPrice);
        }

        [TestMethod]
        public void GetBreadPriceWithVisitor()
        {
            Bread bread = new Bread(1);

            double taxedPrice = bread.Accept(TaxVisitor.Instance);

            Assert.AreEqual(1.234, taxedPrice);
        }
    }
}
