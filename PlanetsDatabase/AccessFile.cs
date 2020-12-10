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

        public List<Planet> contentCollPlanet;

        private Planet plCamp;

        public ICollection<Stars> contentCollStars;

        public HandleData handleData;

        private InputContent inputContent;

        public AccessFile() 
        {
            // Create instance of Planet List and Stars
            contentCollStars = new List<Stars>();

            contentCollPlanet = new List<Planet>();

            plCamp = new Planet();

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
            try
            { 
                using (
                    
                    FileStream fs = new FileStream(
                path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        ReadContent(sr);
                    }  
                }  
            }
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
                    SplitContent(line);
                }
            }
            //handleData.GetPlanetItems(contentCollPlanet);

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
                ((sections[5]) != "") ? sections[5] : "N/A";

            plCamp.DiscYear = 
                ((sections[6]) != "") ? sections[6] : "N/A";

            plCamp.PlanetOrbper = 
                ((sections[11]) != "") ? sections[11] : "N/A";

            plCamp.Radius = 
                ((sections[13]) != "") ? sections[13] : "N/A";

            plCamp.Masse = 
                ((sections[15]) != "") ? sections[15] : "N/A";

            plCamp.PlanetEqt = 
                ((sections[20]) != "") ? sections[20] : "-";

            plCamp.SyDist = 
                ((sections[34]) != "") ? sections[34] : "-";

            // Cannot forget to add star camps

            // Add content to list of planets
            contentCollPlanet.Add(new Planet(plCamp.PlanetName,
                plCamp.PlanetOrbper, plCamp.Radius, plCamp.Masse, plCamp.PlanetEqt,
                plCamp.HostName, plCamp.DiscoveryMethod, plCamp.DiscYear,
                plCamp.SyDist));


            //handleData.GetSections(contentCollPlanet);

        }


        /* ----- Verification methods ----- */

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
