using System;
using System.Diagnostics;

namespace PlanetsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor progMotor = new Motor();

            progMotor.ExecuteProg();

            //// taken from prof's code to test memory usage
            //Console.WriteLine("\t=> Program is currently occupying " +
            //    ((Process.GetCurrentProcess().VirtualMemorySize64) / 1024 / 1024)
            //    + " megabytes of memory");
        }
    }
}
