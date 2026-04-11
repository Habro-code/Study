using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;

namespace Study.LabWork1.Features.Task2.Elsements
{
    public class Paragraph: ConcreteElement
    {
        public string Text;
        public Paragraph(string text) => Text = text;
        public override void Accept(IVisitor visitor) => visitor.VisitParagraph(this);
    }
}
