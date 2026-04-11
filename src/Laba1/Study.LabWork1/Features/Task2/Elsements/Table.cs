using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;

namespace Study.LabWork1.Features.Task2.Elsements
{
    public class Table: ConcreteElement
    {
        public string Data;
        public Table(string data) => Data = data;
        public override void Accept(IVisitor visitor) => visitor.VisitTable(this);
    }
}
