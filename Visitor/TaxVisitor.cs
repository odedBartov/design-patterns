using System;
using System.Collections.Generic;
using System.Text;
using Visitor.interfaces;
using Visitor.Models;

namespace Visitor
{
    public sealed class TaxVisitor : IVisitor
    {
        private static object _obj = new object();
        private volatile static TaxVisitor _taxVisitor;
        private TaxVisitor() { }

        public static TaxVisitor Instance
        {
            get
            {
                if (_taxVisitor == null)
                {
                    lock (_obj)
                    {
                        if (_taxVisitor == null)
                        {
                            _taxVisitor = new TaxVisitor();
                        }
                    }
                }
                return _taxVisitor;
            }
        }

        public double Visit(Banana banana)
        {
            return banana.Price * 2;
        }

        public double Visit(Beer beer)
        {
            return beer.Price * 3;
        }

        public double Visit(Bread bread)
        {
            return bread.Price * 1.234;
        }
    }
}
