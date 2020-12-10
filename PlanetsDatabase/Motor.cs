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

        private ScreenInfoText printText;

        private InputContent inputCont;

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
            // Intro menu (welcome to...)
            printText.IntroMenu();

            // Access the wished file
            file.AccessTheFile();

            // PrintOut the Main Menu
            printText.MainMenu();

            ////////////////////// SEND FILE TO INPUT CONTENT
            MainMenuInput(file);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void MainMenuInput(AccessFile file)
        {
            try
            {
                readInput = Console.ReadLine().ToLower();

                switch (readInput)
                {
                    case "1":
                        printText.PlanetMenu();
                        Search();
                        // Percorrer la lista somehow?
                        break;

                    case "2":
                        printText.StarsMenu();
                        Search();
                        // Percorrer la lista somehow?
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

        public void Search()
        {
            string[] auxArr;

            // Get user input
            readInput = Console.ReadLine().ToLower();

            // Checkinput to see if its null
            inputCont.CheckInput(readInput);

            // Take the input 
            inputCont.SplitSearch();


            handleData.GetUserInputPlanets(inputCont.UserInputArr, file.contentCollPlanet);


            //handleData.GetUserInputPlanets();

            //DatabaseContent = new HandleData(file.ListOfContent, input);
            //DatabaseContent.SetResults();
        }
    }
}