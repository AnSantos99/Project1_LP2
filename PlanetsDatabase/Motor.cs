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

        private string readInput;

        private ScreenInfoText printText;


        public Motor() 
        {
            file = new AccessFile();

            printText = new ScreenInfoText();
        }

        public void ExecuteProg() 
        {
            printText.IntroMenu();
            
            file.AcessFile();

            //file.AcessFile();

            //printText.MainMenu();

            //try
            //{
            //    readInput = Console.ReadLine().ToLower();

            //    switch (readInput)
            //    {
            //        case "1":
            //            Console.WriteLine("Planets Info");

            //            // Some more conditions
            //            break;

            //        case "2":
            //            Console.WriteLine("Stars Info");
            //            // Some more conditions
            //            break;

            //        case "n":
            //            Console.WriteLine("Next Page");
            //            // Some more conditions
            //            break;

            //        case "q":
            //            Console.WriteLine("Thank you");
            //            Thread.Sleep(3000);
            //            Environment.Exit(0);
            //            break;

            //        default:
            //            throw new FormatException(
            //                $"{readInput} is invalid.\n");
            //    }
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine($"Please choose the options available {e}");
            //}         
        }
    }
}
