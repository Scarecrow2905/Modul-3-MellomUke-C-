using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args[0] = "No issues";
            args[1] = "Velger fortsatt å ikke fungere :)";
            foreach (var argument in args)
            {
                Console.WriteLine("Dett er et argument: " + argument);
                Console.ReadLine();
            }

        }
    }
}