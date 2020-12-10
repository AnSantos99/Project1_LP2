using System;
using System.Threading;

namespace PlanetsDatabase
{
    /// <summary>
    /// Central class of the program where almost everything is called
    /// </summary>
    class Motor
    {
        /// <summary>
        /// To be able to get access to the original list of contents.
        /// </summary>
        private AccessFile file;

        /// <summary>
        /// To be able to get the methods that are responsible for the output
        /// of text on the console.
        /// </summary>
        private ScreenInfoText printText;

        /// <summary>
        /// To be able to get the methods that are responsible for the input
        /// of the user on the console.
        /// </summary>
        private InputContent inputCont;

        /// <summary>
        /// To be able to get the methods that are responsible for the
        /// manipulation of data from the file of the user on the console.
        /// </summary>
        private HandleData handleData;

        private string readInput;

        /// <summary>
        /// Used to initialize variables
        /// </summary>
        public Motor()
        {
            file = new AccessFile();

            printText = new ScreenInfoText();

            inputCont = new InputContent();

            handleData = file.handleData;
        }

        public void ExecuteProg()
        {
            // Intro menu (welcome to...) Text
            printText.IntroMenu();

            // To access the wished file
            file.AccessTheFile();

            // PrintOut the Main Menu text
            printText.MainMenu();

            // Execute the main interaction menu
            MainMenuInput(file);
        }

        /// <summary>
        /// Main menu functionality with switch case to control the input and
        /// Output
        /// </summary>
        public void MainMenuInput(AccessFile file)
        {
            try
            {
                readInput = Console.ReadLine().ToLower();

                switch (readInput)
                {
                    case "1":
                        printText.PlanetMenu();
                        PlanetsSearch();
                        break;

                    case "2":
                        printText.StarsMenu();
                        StarSearch();
                        break;

                    case "q":
                        Console.WriteLine("Exiting application.\n" +
                            "Thank you for your time!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;

                    default:
                        throw new FormatException(
                            $"{readInput} is invalid.\n");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please choose the options available ", e);
            }
        }

        /// <summary>
        /// Method that calls other properties and methods in order to be able
        /// to search for planets
        /// </summary>
        public void PlanetsSearch()
        {
            // Get user input
            readInput = Console.ReadLine().ToLower();

            // Checkinput to see if its null
            inputCont.CheckInput(readInput);

            // Take the input 
            inputCont.SplitSearch();

            // Method that calls the user input specifications and the original
            // contents from the file for the planets
            handleData.GetUserInputPlanets(inputCont.UserInputArr, 
                file.contentCollPlanet);
        }

        /// <summary>
        /// Method that calls other properties and methods in order to be able
        /// to search for stars
        /// </summary>
        public void StarSearch() 
        {
            // Get user input
            readInput = Console.ReadLine().ToLower();

            // Checkinput to see if its null
            inputCont.CheckInput(readInput);

            // Take the input 
            inputCont.SplitSearch();

            // Method that calls the user input specifications and the original
            // contents from the file for the stars
            handleData.GetUserInputStars(inputCont.UserInputArr, 
                file.contentCollStars);
        }
    }
}