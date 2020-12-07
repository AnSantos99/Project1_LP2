using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    class InputContent
    {
        public string readInput { get; set; }

        // General search for planet camps
        public string PlanetName { get; set; }
        public string PlanetOrbper { get; set; }
        public string PlanetRadius { get; set; }
        public string PlanetMasse { get; set; }
        public string PlanetEqt { get; set; }


        // General search for star camps
        public string StarTemperature { get; set; }
        public string StarRadius { get; set; }
        public string StarMass { get; set; }
        public string StarAge { get; set; }
        public string StarVsin { get; set; }
        public string StarRotq { get; set; }



        //General camps for search
        public string HostName { get; set; }
        public string DiscoveryMethod { get; set; }
        public string DiscYear { get; set; }
        public string SyDist { get; set; }


        public void MainMenuInput() 
        {
            try
            {
                readInput = Console.ReadLine().ToLower();

                switch (readInput)
                {
                    case "1":
                        Console.WriteLine("Planets Info");
                        Console.WriteLine("Write Down name:");
                        PlanetInput();
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

        public void PlanetInput()
        {
            readInput = Console.ReadLine().ToLower();
        }

    }
}
