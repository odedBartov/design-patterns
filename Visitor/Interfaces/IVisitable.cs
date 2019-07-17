using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.interfaces
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
