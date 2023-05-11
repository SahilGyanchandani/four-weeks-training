using System;
using System.Diagnostics;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] data = Enumerable.Range(1, 100).ToArray();
        Stopwatch stopwatch = Stopwatch.StartNew();
        var result = data.Where(x => x % 3 == 0).Select(x => x * x).ToList();
        stopwatch.Stop();
        Console.WriteLine($"Original query execution time: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Restart();
        var optimizedResult = data.AsParallel()
                                  .Where(x => x % 3 == 0)
                                  .Select(x => x * x)
                                  .ToList();
        stopwatch.Stop();
        Console.WriteLine($"Optimized query execution time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Original query result count: {result.Count}");
        Console.WriteLine($"Optimized query result count: {optimizedResult.Count}");
        Console.WriteLine($"Results are equal: {result.SequenceEqual(optimizedResult)}");
    }
}