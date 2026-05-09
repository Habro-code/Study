<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [MonitorServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests')
  - [ExecutionTimeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ExecutionTimeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.ExecutionTimeTest')
  - [FoundPrimesTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-FoundPrimesTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.FoundPrimesTest')
  - [GetVersionNameTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-GetVersionNameTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.GetVersionNameTest')
  - [PrimeCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32- 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.PrimeCountTest(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [ReturnZeroTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ReturnZeroTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.ReturnZeroTest')
  - [SynchronizationTypeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-SynchronizationTypeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.SynchronizationTypeTest')
  - [ThreadCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ThreadCountTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.ThreadCountTest')
- [MutexServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests')
  - [ExecutionTimeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ExecutionTimeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.ExecutionTimeTest')
  - [FoundPrimesTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-FoundPrimesTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.FoundPrimesTest')
  - [GetVersionNameTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-GetVersionNameTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.GetVersionNameTest')
  - [PrimeCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32- 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.PrimeCountTest(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [ReturnZeroTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ReturnZeroTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.ReturnZeroTest')
  - [SynchronizationTypeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-SynchronizationTypeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.SynchronizationTypeTest')
  - [ThreadCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ThreadCountTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.ThreadCountTest')
- [SemaphoreServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests')
  - [ExecutionTimeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ExecutionTimeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.ExecutionTimeTest')
  - [FoundPrimesTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-FoundPrimesTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.FoundPrimesTest')
  - [GetVersionNameTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-GetVersionNameTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.GetVersionNameTest')
  - [PrimeCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32- 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.PrimeCountTest(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [ReturnZeroTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ReturnZeroTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.ReturnZeroTest')
  - [SynchronizationTypeTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-SynchronizationTypeTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.SynchronizationTypeTest')
  - [ThreadCountTest()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ThreadCountTest 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.ThreadCountTest')

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests'></a>
## MonitorServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ExecutionTimeTest'></a>
### ExecutionTimeTest() `method`

##### Summary

Тест времи выполнения

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-FoundPrimesTest'></a>
### FoundPrimesTest() `method`

##### Summary

Тест правильного списока найденных простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-GetVersionNameTest'></a>
### GetVersionNameTest() `method`

##### Summary

Тест функции GetVersionName

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### PrimeCountTest() `method`

##### Summary

Тест правильного подсчёта количества простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ReturnZeroTest'></a>
### ReturnZeroTest() `method`

##### Summary

Тест случия, когда простых чисел нет

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-SynchronizationTypeTest'></a>
### SynchronizationTypeTest() `method`

##### Summary

Тест типа синхронизации

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-ThreadCountTest'></a>
### ThreadCountTest() `method`

##### Summary

Тест числа потоков

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests'></a>
## MutexServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ExecutionTimeTest'></a>
### ExecutionTimeTest() `method`

##### Summary

Тест времи выполнения

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-FoundPrimesTest'></a>
### FoundPrimesTest() `method`

##### Summary

Тест правильного списока найденных простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-GetVersionNameTest'></a>
### GetVersionNameTest() `method`

##### Summary

Тест функции GetVersionName

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### PrimeCountTest() `method`

##### Summary

Тест правильного подсчёта количества простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ReturnZeroTest'></a>
### ReturnZeroTest() `method`

##### Summary

Тест случия, когда простых чисел нет

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-SynchronizationTypeTest'></a>
### SynchronizationTypeTest() `method`

##### Summary

Тест типа синхронизации

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-ThreadCountTest'></a>
### ThreadCountTest() `method`

##### Summary

Тест числа потоков

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests'></a>
## SemaphoreServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ExecutionTimeTest'></a>
### ExecutionTimeTest() `method`

##### Summary

Тест времи выполнения

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-FoundPrimesTest'></a>
### FoundPrimesTest() `method`

##### Summary

Тест правильного списока найденных простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-GetVersionNameTest'></a>
### GetVersionNameTest() `method`

##### Summary

Тест функции GetVersionName

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-PrimeCountTest-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### PrimeCountTest() `method`

##### Summary

Тест правильного подсчёта количества простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ReturnZeroTest'></a>
### ReturnZeroTest() `method`

##### Summary

Тест случия, когда простых чисел нет

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-SynchronizationTypeTest'></a>
### SynchronizationTypeTest() `method`

##### Summary

Тест типа синхронизации

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-ThreadCountTest'></a>
### ThreadCountTest() `method`

##### Summary

Тест числа потоков

##### Parameters

This method has no parameters.
