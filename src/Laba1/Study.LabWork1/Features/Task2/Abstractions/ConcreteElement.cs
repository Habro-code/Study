using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork1.Features.Task2.Abstractions
{
    public abstract class ConcreteElement
    {
        public abstract void Accept(IVisitor visitor);
    }
}
