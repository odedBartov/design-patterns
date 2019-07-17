using System;
using System.Collections.Generic;
using System.Text;
using Visitor.interfaces;

namespace Visitor.Models
{
    public class Beer : IVisitable
    {
        public double Price { get; set; }

        public Beer(double price = 0)
        {
            Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
