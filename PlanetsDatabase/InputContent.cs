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
                        //UserInputPlanet();
                        //DatabaseContent = new HandleData(file.ListOfContent, input);
                        //DatabaseContent.SetResults();

                        break;

                    case "2":
                        Console.WriteLine("Stars Info");
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

        public void UserInputPlanet(List<Planet> plList)
        {

            //Console.WriteLine("1.PL_Name, 2.PL_orber");

            //readInput = Console.ReadLine();
            //if (readInput == "1.")
            //{
            //    readInput.
            //    readInput = planet.PlanetName;
            //}
            

            //if (planet.PlanetName.Contains(readInput))
            //{
            //    plList.Add(new Planet(planet.PlanetName));
            //}



            readInput = Console.ReadLine().ToLower();

            // Compare input with list content
            

            // if match, print out the compared input (maybe insert here
            // the method in handle data or ao contrario

            // ignore the rest of the camps

            // Ask user if he wants to know more information about a content
            // to pick up the number of the object



            plCamp.Add(new Planet(planet.PlanetName, planet.PlanetOrbper,
                planet.Radius, planet.Masse, planet.PlanetEqt, planet.HostName,
                planet.DiscoveryMethod, planet.DiscYear, planet.SyDist));

            //DatabaseContent = new HandleData(plCamp, file);
        }

    }
}