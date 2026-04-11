using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;
using Study.LabWork1.Features.Task2.Elsements;

namespace Study.LabWork1.Features.Task2.Visitors
{
    public class MarkdownVisitor: IVisitor
    {
        public void VisitParagraph(Paragraph p) => Console.WriteLine(p.Text);
        public void VisitImage(Img img) => Console.WriteLine($"![]({img.Url})");
        public void VisitTable(Table t) => Console.WriteLine(t.Data);
    }
}
