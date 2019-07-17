using System;
using System.Collections.Generic;
using System.Text;
using Visitor.interfaces;

namespace Visitor.Models
{
    public class Banana : IVisitable
    {
        public double Price { get; set; }

        public Banana(double price = 0)
        {
            Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
