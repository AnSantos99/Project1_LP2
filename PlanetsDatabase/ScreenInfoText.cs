using System;

namespace PlanetsDatabase
{
    /// <summary>
    /// This class is responsible for the output text on the console.
    /// </summary>
    class ScreenInfoText
    {
        public void IntroMenu() 
        {
            Console.WriteLine(
                "\t**Welcome to the NASA Exoplanet Archive**\n\n" +
                "\tPlease write down the file you would like to open:");
        }

        /// <summary>
        /// Main menu
        /// </summary>
        public void MainMenu() 
        {
            Console.WriteLine(
                "\t\tWhat would you like to search?\n" +
                "\t\t-Press '1' For more info about Planets-\n" +
                "\t\t-Press '2' For more info about Stars-\n\n" +
                "\t\tPress 'Q' To exit from the application.");
        }

        /// <summary>
        /// Secondary screen information on console by choosing option 1
        /// from Main Menu
        /// </summary>
        public void PlanetsStarsMenu() 
        {
            Console.WriteLine($"You can choose what camps you want to see." +
                "Add '+' after each camp if you want to see additional " +
                "information about a Planet\n" +
                "Available camps:\n" +
                "");
        }

        public void PlanetName() 
        {
            Console.WriteLine("Name a planet: ");
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
