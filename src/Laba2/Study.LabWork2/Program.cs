using Study.LabWork2.Feature.Task1.SubTask2;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

public static class Program
{
    public static void Main()
    {
        var processor = new NumberSetProcessor();

        processor.Process();

        var result = processor.GetResult();

        foreach (var item in result.Results)
        {
            Console.WriteLine(
                $"Набор {item.SetNumber}: сумма = {item.Sum}, поток = {item.ThreadId}");
        }

        Console.WriteLine($"\nОбщий итог: {result.TotalSum}");
        Console.WriteLine($"Время выполнения: {result.ExecutionTime.TotalMilliseconds} мс");
        int countThread = Environment.ProcessorCount;

        IPrimeCounter[] serv =
        [
            new MonitorService(),
            new MutexService(),
            new SemaphoreService()
        ];

        foreach (var s in serv)
        {
            var res = s.CountPrimes(1, 10000, countThread);
            Console.WriteLine($"\n{res}\n");
            Console.WriteLine("Нажмите на любую клавишу!");
            Console.ReadKey();
        }
    }
}
