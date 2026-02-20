```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.22000.2538/21H2/SunValley)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256 [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256


```
| Method                | Mean     | Error     | StdDev    | Rank | Allocated |
|---------------------- |---------:|----------:|----------:|-----:|----------:|
| Sort_Shella_10        | 2.564 μs | 0.0343 μs | 0.0446 μs |    1 |         - |
| Sort_bubble_10        | 4.520 μs | 0.0777 μs | 0.0727 μs |    2 |         - |
| Sort_direct_choice_10 | 5.652 μs | 0.1094 μs | 0.1075 μs |    3 |         - |
