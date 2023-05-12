using System.Diagnostics;
namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            int numberOfTasks = 2;
            Stopwatch stopwatch = Stopwatch.StartNew();
            await PerformCalculations(numberOfTasks);
            stopwatch.Stop();
            Console.WriteLine($"All {numberOfTasks} tasks completed in {stopwatch.ElapsedMilliseconds} milliseconds.");
        }
        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            // Implement long-running task simulation
            await Task.Delay(delayInSeconds * 1000);
            Console.WriteLine($"Simulated long-running task with {delayInSeconds} second delay completed.");
        }
        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                int delay = i + 1; // increase delay for each task
                tasks[i] = SimulateLongRunningTask(delay);
            }
            await Task.WhenAll(tasks);
        }
    }
}