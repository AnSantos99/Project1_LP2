using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    /// <summary>
    /// Central class of the program where everything happens
    /// </summary>
    class Motor
    {
        private AccessFile file;

        private UserInput input;

        private string readInput;

        
        public Motor() 
        {
            file = new AccessFile();
        }

        public void ExecuteProg() 
        {
            ScreenInfoText.MainMenu();

            readInput = Console.ReadLine().ToLower();

            switch (readInput)
            {
                case "1":
                    Console.WriteLine("Planets Info");
                    file.AcessFile();
                    // Some more conditions
                    break;

                case "2":
                    Console.WriteLine("Stars Info");
                    // Some more conditions
                    break;

                case "n":
                    Console.WriteLine("Next Page");
                    // Some more conditions
                    break;

                case "q":
                    Console.WriteLine("Thank you");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("" +
                        "\t\n**Invalid Input. Please choose a valid option**");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExecuteProg();
                    break;
            }


        }
    }
}
