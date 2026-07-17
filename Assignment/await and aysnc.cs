using System;
using System.Threading.Tasks;

class Program
{
    static async Task DisplayMessage()
    {
        Console.WriteLine("Processing...");
        await Task.Delay(3000);
        Console.WriteLine("Completed");
    }

    static async Task Main()
    {
        await DisplayMessage();
    }
}