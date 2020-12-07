using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    class InputContent
    {
        private AccessFile file;

        public HandleData DatabaseContent;

        public InputContent() { }


        public InputContent(AccessFile file)
        {
            this.file = file;
        }

        /// <summary>
        /// To get the input of the user
        /// </summary>
        public string readInput { get; set; }

        private Planet plCamp;

        public void MainMenuInput()
        {
            try
            {
                readInput = Console.ReadLine().ToLower();

                switch (readInput)
                {
                    case "1":
                        Console.WriteLine("Planets Info");
                        Console.WriteLine("Write down name:");
                        UserInputPlanet();
                        //DatabaseContent = new HandleData(file.ListOfContent, input);
                        //DatabaseContent.SetResults();

                        break;

                    case "2":
                        Console.WriteLine("Stars Info");
                        break;

                    case "q":
                        Console.WriteLine("Thank you");
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

        public void UserInputPlanet()
        {
            readInput = Console.ReadLine().ToLower();

            plCamp = new Planet(plCamp.PlanetName, plCamp.PlanetOrbper, 
                plCamp.Radius, plCamp.Masse, plCamp.PlanetEqt, plCamp.HostName,
                plCamp.DiscoveryMethod, plCamp.DiscYear, plCamp.SyDist);

            //DatabaseContent = new HandleData(Planet, File.list);

        }

    }
}