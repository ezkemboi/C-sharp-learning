using System;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nwhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}");
            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
