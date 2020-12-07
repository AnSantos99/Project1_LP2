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

        // Acess planet data
        private Planet planet;

        // List of plCamps
        private List<Planet> plCamp;

        /// <summary>
        /// To get the input of the user
        /// </summary>
        public string readInput { get; set; }

        public InputContent() 
        {
            planet = new Planet();

            plCamp = new List<Planet>();
        }


        public InputContent(AccessFile file)
        {
            this.file = file;
        }

        

        public void MainMenuInput(AccessFile file)
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

            plCamp.Add(new Planet(planet.PlanetName, planet.PlanetOrbper,
                planet.Radius, planet.Masse, planet.PlanetEqt, planet.HostName,
                planet.DiscoveryMethod, planet.DiscYear, planet.SyDist));

            DatabaseContent = new HandleData(plCamp, file);

        }

    }
}