using System;

namespace MyStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a stop watch. Type 'start' to start it & 'stop' to stop it.");
            var stopwatch = new Stopwatch();

            while (true)
            {
                var input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "start":
                        stopwatch.Start();
                        break;
                    case "stop":
                        Console.WriteLine(stopwatch.Stop());
                        break;
                    default:
                        Console.WriteLine("Sorry I don't recognize that.");
                        break;
                }
            }
        }
    }
}
