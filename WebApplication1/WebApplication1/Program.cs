using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // List to store tasks representing asynchronous operations
        List<Task> tasks = new List<Task>();

        // Start multiple asynchronous tasks to print numbers
        for (int i = 1; i <= 100; i++)
        {
            int number = i; // Capture the loop variable
            Task task = Task.Run(() => PrintNumberAsync(number, 1000)); // Add a number after 1 second
            tasks.Add(task);
        }

        // Wait for all tasks to complete
        await Task.WhenAll(tasks);

        Console.WriteLine("Print operation completed.");
        }

    static async Task PrintNumberAsync(int originalNumber, int extraNumberDelay)
    {
        // Simulate an asynchronous operation with Task.Delay
        await Task.Delay(extraNumberDelay);

        // Print the original number
        Console.WriteLine($"Original Number: {originalNumber}, Thread: {Environment.CurrentManagedThreadId}");

        // Add an extra number
        int extraNumber = originalNumber + 10;
        Console.WriteLine($"Extra Number: {extraNumber}, Thread: {Environment.CurrentManagedThreadId}");
    }
}
