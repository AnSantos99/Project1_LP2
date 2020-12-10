using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsDatabase
{
    /// <summary>
    /// Access to content from files by opening the file
    /// </summary>
    class AccessFile
    {
        /// <summary>
        /// To save the path of the file
        /// </summary>
        public string path;

        /// <summary>
        /// To store name of the file
        /// </summary>
        public string fileToOpen;

        /// <summary>
        /// List that saves the content of the Planets in a list
        /// </summary>
        public List<Planet> contentCollPlanet;

        /// <summary>
        /// To access the planets properties
        /// </summary>
        private Planet plCamp;

        /// <summary>
        /// List that saves the content of the Stars in a list
        /// </summary>
        public List<Stars> contentCollStars;

        /// <summary>
        /// To access the planets properties
        /// </summary>
        private Stars stCamp;

        public HandleData handleData;

        public AccessFile() 
        {
            contentCollPlanet = new List<Planet>();

            plCamp = new Planet();

            contentCollStars = new List<Stars>();

            stCamp = new Stars();

            handleData = new HandleData();
        }

        /// <summary>
        /// Access file from path and open and read it
        /// </summary>
        public void AccessTheFile() 
        {
            // To get the name of the file
            fileToOpen = Console.ReadLine();

            // To check the files extension
            CheckFileValidation(fileToOpen);

            // Specified path to open the file
            path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop), fileToOpen);

            // Try to execute aka to open the specific file and its content
            try
            { 
                using (FileStream fs = new FileStream(
                    path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        ReadContent(sr);
                    }  
                }  
            }
            // Throw exception if file could not be found
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File could not be found in {path}.");
            } 
        }

        /// <summary>
        /// Its only purpose is to read the files content
        /// </summary>
        /// <param name="sr"> receives content of file </param>
        public void ReadContent(StreamReader sr) 
        {
            // To store every line from file
            string line;

            // Read until there is no more line
            while ((line = sr.ReadLine()) != null)
            {
                //Check in lines this specifications and ignore them
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                else
                {
                    // Split the contents from all lines
                    SplitContent(line);
                }
            }
        }

        /// <summary>
        /// Method that splits the contents from each line by comma
        /// </summary>
        /// <param name="line"> receive a line from the file </param>
        public void SplitContent(string line) 
        {
            // Store the content of each line in a array of strings
            string[] sections = line.Split(",");
            SplitSections(sections);
        }

        
        /// <summary>
        /// Content spliter to each sections
        /// </summary>
        /// <param name="sections"></param>
        public void SplitSections(string[] sections)
        {
            plCamp.PlanetName = 
                ((sections[0]) != "") ? sections[0] : "N/A";

            plCamp.HostName = 
                ((sections[1]) != "") ? sections[1] : "N/A";

            plCamp.DiscoveryMethod = 
                ((sections[11]) != "") ? sections[11] : "N/A";

            plCamp.DiscYear = 
                ((sections[12]) != "") ? sections[12] : "N/A";

            plCamp.PlanetOrbper = 
                ((sections[30]) != "") ? sections[30] : "N/A";

            plCamp.Radius = 
                ((sections[34]) != "") ? sections[34] : "N/A";

            plCamp.Masse = 
                ((sections[38]) != "") ? sections[38] : "N/A";

            plCamp.PlanetEqt = 
                ((sections[49]) != "") ? sections[49] : "-";

            plCamp.SyDist = 
                ((sections[118]) != "") ? sections[118] : "-";

            // Add content to list of planets
            contentCollPlanet.Add(new Planet(plCamp.PlanetName,
                plCamp.PlanetOrbper, plCamp.Radius, plCamp.Masse, plCamp.PlanetEqt,
                plCamp.HostName, plCamp.DiscoveryMethod, plCamp.DiscYear,
                plCamp.SyDist));

            // Cannot forget to add star camps

            stCamp.SyDist =
                ((sections[118]) != "") ? sections[118] : "-";

            stCamp.DiscoveryMethod =
                ((sections[11]) != "") ? sections[11] : "-";

            stCamp.DiscYear =
                ((sections[12]) != "") ? sections[12] : "-";

            stCamp.HostName =
                ((sections[1]) != "") ? sections[1] : "-";

            stCamp.StarRotq =
                ((sections[101]) != "") ? sections[101] : "-";

            stCamp.StarVsin =
                ((sections[99]) != "") ? sections[99] : "-";

            stCamp.StarAge =
                ((sections[95]) != "") ? sections[95] : "-";

            stCamp.Masse =
                ((sections[86]) != "") ? sections[86] : "-";

            stCamp.Radius =
                ((sections[84]) != "") ? sections[84] : "-";

            stCamp.StarTemperature =
                ((sections[23]) != "") ? sections[23] : "-";

            // Add content to list of planets
            contentCollStars.Add(new Stars(stCamp.StarTemperature, 
                stCamp.Radius, stCamp.Masse, stCamp.StarAge, stCamp.StarVsin, 
                stCamp.StarRotq, stCamp.HostName, stCamp.DiscYear, 
                stCamp.DiscoveryMethod, stCamp.SyDist));
        }


        /* ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
         * ----------------------Verification methods--------------------------
         * ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
         */

        /// <summary>
        /// Checks the files ending. If it's not .csv
        /// Throw a exception
        /// </summary>
        /// <param name="fileToOpen"> Get the file name </param>
        public void CheckFileValidation(string fileToOpen)
        {
            try
            {
                if (!fileToOpen.EndsWith(".csv"))
                {
                    Console.WriteLine($"The file you tried to open: " +
                        $"{fileToOpen} is invalid due to it's " +
                        $"extension.\n");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Only files with the .csv " +
                    "extensions are allowed.");
            }
        }

        /// <summary>
        /// To check if the file contains to types of necessary camps
        /// </summary>
        /// <param name="sections"> Receives content of file </param>
        public void checkData(string[] sections)
        {
            // To go throught sections and store those 2 searched strings
            // in this variable
            IEnumerable<string> obligatoryCamps;

            // Query to go through file and see if obligatory camps are there
            obligatoryCamps = from lines in sections
                              where lines.Contains("pl_name".ToLower()) ||
                              lines.Contains("hostname".ToLower())
                              select lines;

            if (!obligatoryCamps.Any())
            {
                Console.Write("This file does not contain the obligatory" +
                "Camps needed in order to use this program properly.\n" +
                "Obligatory camps are:\npl_name (Planet names) and " +
                "hostname.\n");
            }
        }
    }
}
