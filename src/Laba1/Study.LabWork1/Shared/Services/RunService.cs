using Study.LabWork1.Features.Task2;
using Study.LabWork1.Features.Task2.Elsements;
using Study.LabWork1.Features.Task2.Visitors;
using Study.LabWork1.Shared.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
public class RunService : IRunService
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public void RunTask1() => throw new NotImplementedException();

    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2(){
        // 
        var doc = new Document();
        doc.AddElement(new Paragraph("Tекст"));
        doc.AddElement(new Img("photo.jpg"));
        doc.AddElement(new Table("| 1 | 2 | 3 |"));

        Console.WriteLine("HTML:");
        doc.Export(new HtmlVisitor());

        Console.WriteLine("\nMarkdown:");
        doc.Export(new MarkdownVisitor());
    }

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
