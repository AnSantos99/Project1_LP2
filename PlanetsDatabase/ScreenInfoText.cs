using System;

namespace PlanetsDatabase
{
    /// <summary>
    /// This class is responsible for the output text on the console.
    /// </summary>
    class ScreenInfoText
    {
        /// <summary>
        /// Text to appear in the beginning of the application.
        /// </summary>
        public void IntroMenu() 
        {
            Console.WriteLine(
                "\t**Welcome to the NASA Exoplanet Archive**\n\n" +
                "\tPlease write down the file you would like to open:");
        }

        /// <summary>
        /// Text that appears after file access suceeded.
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
        /// Screen information on application by choosing option 1 for planet
        /// search from Main Menu.
        /// Displaying the needed information for the user to be able to make
        /// his wished research
        /// </summary>
        public void PlanetMenu() 
        {
            Console.WriteLine($"You can choose what camps you want to see." +
                "Add '+' after each word if you want to see additional " +
                "information in the following order:\n" +
                "Planet name + Planet Orber + Radius + Masse + Planet Eqt + " +
                "Hostname + Discovery Method + Discovery Year + SyDist\n");
        }

        /// <summary>
        /// Screen information on application by choosing option 1 for planet
        /// search from Main Menu.
        /// Displaying the needed information for the user to be able to make
        /// his wished research
        /// </summary>
        public void StarsMenu()
        {
            Console.WriteLine($"You can choose what camps you want to see.\n" +
                "Add '+' after each word if you want to see additional " +
                "information in the following order:\n" +
                "Star Temperature + Radius + Masse + StarMass + Star Vsin " +
                "Star Rotq + Hostname + Discovery Year + Discovery Method +" +
                "SyDist\n");
        }

        /// <summary>
        /// Menu that appears in all other screens so the player is able to go
        /// back.
        /// </summary>
        public void ContentMenuMenu() 
        {
            Console.WriteLine(
                "Press 'Enter' to go back to main Menu.\n" +
                "Press 'Q' To exit from the application.");
        }
    }
}
