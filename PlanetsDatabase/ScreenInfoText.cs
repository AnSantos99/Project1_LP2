using System;

namespace PlanetsDatabase
{
    /// <summary>
    /// This class is responsible for the output text on the console.
    /// </summary>
    class ScreenInfoText
    {
        /// <summary>
        /// First screen information on Console
        /// </summary>
        public static void MainMenu() 
        {
            Console.WriteLine(
                "\t**Welcome to the NASA Exoplanet Archive**\n\n" +
                "\t\tWhat would you like to search?\n" +
                "-Press '1' For more info about Planets-\n" +
                "-Press '2' For more info about Stars-\n\n\n" +
                "Press 'Q' To exit from the application.");
        }

        /// <summary>
        /// Secondary screen information on console by choosing option 1
        /// from Main Menu
        /// </summary>
        public void PlanetsStarsMenu(string PorS) 
        {
            Console.WriteLine($"You can choose what camps you want to see. If" +
                "Add '+' after each camp if you want to see additional " +
                "information about a {PorS}\n" +
                "");
        }

        /// <summary>
        /// Secondary screen information on console by choosing option 2
        /// from Main Menu
        /// </summary>
        public void StarsMenu() 
        {
            Console.WriteLine();
        }
    }
}
