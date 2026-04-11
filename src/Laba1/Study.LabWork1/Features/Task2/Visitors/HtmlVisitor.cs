using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task2.Abstractions;
using Study.LabWork1.Features.Task2.Elsements;

namespace Study.LabWork1.Features.Task2.Visitors
{
    public class HtmlVisitor: IVisitor
    {
        public void VisitParagraph(Paragraph p) => Console.WriteLine($"<p>{p.Text}</p>");
        public void VisitImage(Img img) => Console.WriteLine($"<img src=\"{img.Url}\"/>");
        public void VisitTable(Table t) => Console.WriteLine($"<table>{t.Data}</table>");
    }
}
