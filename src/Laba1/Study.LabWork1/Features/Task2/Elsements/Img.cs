using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;

namespace Study.LabWork1.Features.Task2.Elsements
{
    public class Img: ConcreteElement
    {
        public string Url;
        public Img(string url) => Url = url;
        public override void Accept(IVisitor visitor) => visitor.VisitImage(this);
    }
}
