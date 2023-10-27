using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Task that performs a simple calculation
        Task<int> calculationTask = Task.Run(() => Add(3, 4));
        int result = await calculationTask;
        Console.WriteLine("Result of calculation: " + result);

        // Task that simulates a time-consuming operation
        Task longRunningTask = LongRunningOperation();
        Console.WriteLine("This message may be printed before the LongRunningOperation completes.");

        // Task that uses Task.WhenAll to wait for multiple tasks
        Task task1 = DoSomethingAsync("Task 1");
        Task task2 = DoSomethingAsync("Task 2");
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Both tasks have completed");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static async Task LongRunningOperation()
    {
        Console.WriteLine("Long running operation started...");
        await Task.Delay(3000); // Simulate a 3-second delay
        Console.WriteLine("Long running operation completed.");
    }

    static async Task DoSomethingAsync(string taskName)
    {
        Console.WriteLine($"{taskName} started.");
        await Task.Delay(1000); // Simulate a 1-second delay
        Console.WriteLine($"{taskName} completed.");
    }

    static async Task ThrowExceptionAsync()
    {
        await Task.Delay(1000);
        throw new Exception("This is an exception!");
    }
}