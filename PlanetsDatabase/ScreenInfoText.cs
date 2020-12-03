using System;

namespace PlanetsDatabase
{
    /// <summary>
    /// This class is responsible for the output text on the console.
    /// It is static because it's methods are not going to be associated
    /// with specific objects in the program.
    /// </summary>
    class ScreenInfoText
    {
        /// <summary>
        /// First screen information on Console
        /// </summary>
        public void MainMenu() 
        {
            Console.WriteLine(
                "\t**Welcome to the NASA Exoplanet Archive**\n\n" +
                "\t\tWhat would you like to search?\n" +
                "-Press '1' if you want to know more about Planets\n" +
                "-Press '2' if you want to know more about Stars\n\n\n" +
                "Press 'Q' To exit from the application.");
        }

        /// <summary>
        /// Secondary screen information on console by choosing option 1
        /// from Main Menu
        /// </summary>
        public void PlanetsMenu() 
        {
            Console.WriteLine();
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
