using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Study.LabWork1.Features.Task2.Elsements;
using static System.Net.Mime.MediaTypeNames;

namespace Study.LabWork1.Features.Task2.Abstractions
{
    public interface IVisitor
    {
        void VisitParagraph(Paragraph paragraph);
        void VisitImage(Img image);
        void VisitTable(Table table);
    }
}
