using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask1;


[TestFixture]
public sealed class MonitorServiceTests
{
    /// <summary>
    /// Тест функции GetVersionName
    /// </summary>
    [Test]
    public void GetVersionNameTest()
    {
        var counter = new MonitorService();

        Assert.That(counter.GetVersionName(), Is.EqualTo("Monitor (lock)"));
    }

    /// <summary>
    /// Тест правильного подсчёта количества простых чисел
    /// </summary>
    [TestCase(1, 10, 2, 4)]
    [TestCase(1, 20, 4, 8)]
    [TestCase(10, 30, 3, 6)]
    public void PrimeCountTest(int start, int end, int threadCount, int expectedCount)
    {
        var service = new MonitorService();
        var result = service.CountPrimes(start, end, threadCount);

        Assert.That(result.PrimeCount, Is.EqualTo(expectedCount));
    }

    /// <summary>
    /// Тест правильного списока найденных простых чисел
    /// </summary>
    [Test]
    public void FoundPrimesTest()
    {
        var service = new MonitorService();
        var result = service.CountPrimes(1, 10, 2);
        var expected = new List<int> { 2, 3, 5, 7 };

        Assert.That(result.FoundPrimes, Is.EqualTo(expected));
    }

    /// <summary>
    /// Тест числа потоков
    /// </summary>
    [Test]
    public void ThreadCountTest()
    {
        var service = new MonitorService();
        var result = service.CountPrimes(1, 100, 5);

        Assert.That(result.ThreadCount, Is.EqualTo(5));
    }

    /// <summary>
    /// Тест типа синхронизации
    /// </summary>
    [Test]
    public void SynchronizationTypeTest()
    {
        var service = new MonitorService();
        var result = service.CountPrimes(1, 50, 2);

        Assert.That(result.SynchronizationType, Is.EqualTo("Monitor (lock)"));
    }

    /// <summary>
    /// Тест времи выполнения
    /// </summary>
    [Test]
    public void ExecutionTimeTest()
    {
        var service = new MonitorService();
        var result = service.CountPrimes(1, 1000, 4);

        Assert.That(result.ExecutionTime, Is.GreaterThan(TimeSpan.Zero));
    }

    /// <summary>
    /// Тест случия, когда простых чисел нет
    /// </summary>
    [Test]
    public void ReturnZeroTest()
    {
        var service = new MonitorService();
        var result = service.CountPrimes(0, 1, 2);

        Assert.That(result.PrimeCount, Is.EqualTo(0));
        Assert.That(result.FoundPrimes, Is.Empty);
    }

}
