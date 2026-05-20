using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

public static class Program
{
    public static void Main()
    {
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
