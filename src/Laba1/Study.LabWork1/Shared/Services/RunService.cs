using Study.LabWork1.Features.Task3;
using Study.LabWork1.Shared.Abstractions;

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
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3()
    {
        Node root = new Node("Уровень 1");

        Node branch1 = new Node("Уровень 2");
        Node branch2 = new Node("Уровень 2");
        Node branch3 = new Node("Уровень 2");

        branch1.ListChil.Add(new Node("Уровень 3"));
        branch1.ListChil.Add(new Node("Уровень 3"));

        Node branch4 = new Node("Уровень 3");
        branch4.ListChil.Add(new Node("Уровень 4"));

        branch2.ListChil.Add(branch4);
        branch2.ListChil.Add(new Node("Уровень 3"));

        root.ListChil.Add(branch1);
        root.ListChil.Add(branch2);
        root.ListChil.Add(branch3);

        Console.WriteLine("Вывод: ");
        root.PrintListChil();
    }
}
