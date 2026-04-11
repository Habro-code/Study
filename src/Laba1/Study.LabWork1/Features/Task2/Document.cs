using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;

namespace Study.LabWork1.Features.Task2
{
    public class Document
    {
        private List<ConcreteElement> elements = new List<ConcreteElement>();

        public void AddElement(ConcreteElement elem) => elements.Add(elem);

        public void Export(IVisitor visitor)
        {
            foreach (var el in elements)
            {
                el.Accept(visitor);
            }
        }
    }
}
