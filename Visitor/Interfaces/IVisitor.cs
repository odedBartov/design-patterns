using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;

namespace Visitor.interfaces
{
    public interface IVisitor
    {
        double Visit(Banana banana);
        double Visit(Beer beer);
        double Visit(Bread bread);
    }
}
