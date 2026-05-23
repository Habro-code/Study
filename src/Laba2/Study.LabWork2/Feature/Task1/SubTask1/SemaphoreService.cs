using System.Diagnostics;
using System.Diagnostics.Metrics;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 3. Использует Semaphore для синхронизации
/// </summary>
public sealed class SemaphoreService : IPrimeCounter
{
    private static Semaphore semaphore = new Semaphore(1, 1);
    private static int counter;
    private readonly List<int> listPrimes = [];

    public PrimeCountResultDto CountPrimes(int start, int end, int threadCount)
    {
        counter = 0;
        var stopwatch = Stopwatch.StartNew();

        int range = (end - start + 1) / threadCount;
        var listThreads = new Thread[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            int indexThread = i;
            int StartThread = start + indexThread * range;
            int EndThread;
            if (indexThread == threadCount - 1)
                EndThread = end;
            else
                EndThread = StartThread + range - 1;


            listThreads[i] = new Thread(() => Process(StartThread, EndThread, indexThread + 1));
            listThreads[i].Start();
        }

        foreach (var thread in listThreads)
            thread.Join();

        stopwatch.Stop();

        return new PrimeCountResultDto
        {
            PrimeCount = counter,
            ExecutionTime = stopwatch.Elapsed,
            ThreadCount = threadCount,
            SynchronizationType = GetVersionName(),
            FoundPrimes = listPrimes
        };
    }

    private void Process(int start, int end, int indexThread)
    {
        for (int num = start; num <= end; num++)
        {
            Console.WriteLine($"[Поток {indexThread}] Проверяем число {num}");

            if (!IsPrime(num))
                continue;

            Console.WriteLine($"Число {num} - простое число!");

            semaphore.WaitOne();
            try
            {
                counter++;
                listPrimes.Add(num);
            }
            finally
            {
                semaphore.Release();
            }
        }
    }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public string GetVersionName() => "Semaphore";
}
