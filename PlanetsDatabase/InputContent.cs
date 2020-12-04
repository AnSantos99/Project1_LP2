using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    class InputContent
    {
        private string readInput;

        private Planet pl;


        public InputContent() 
        {
            
        }
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
