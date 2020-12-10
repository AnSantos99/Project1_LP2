using System;
using System.Diagnostics;

namespace PlanetsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // To access the main method to start the application
            Motor progMotor = new Motor();

            progMotor.ExecuteProg();

            // Taken from prof's code to check memory usage
            Console.WriteLine("\t=> Program is currently occupying " +
                ((Process.GetCurrentProcess().VirtualMemorySize64) / 1024 / 1024)
                + " megabytes of memory");
        }
    }
}
