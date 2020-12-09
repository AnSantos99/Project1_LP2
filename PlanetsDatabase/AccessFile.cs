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

        private Planet camp;

        public ICollection<Stars> contentCollStars;

        private HandleData handleData;

        private InputContent inputContent;

        public AccessFile() 
        {
            // Create instance of Planet List and Stars
            contentCollStars = new List<Stars>();
            contentCollPlanet = new List<Planet>();

            camp = new Planet();
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
                using (FileStream fs = new FileStream(
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

        

        public void SplitSections(string[] sections)
        {
            camp.PlanetName = 
                ((sections[0]) != "") ? sections[0] : "N/A";

            camp.HostName = 
                ((sections[1]) != "") ? sections[1] : "N/A";

            camp.DiscoveryMethod = 
                ((sections[5]) != "") ? sections[5] : "N/A";

            camp.DiscYear = 
                ((sections[6]) != "") ? sections[6] : "N/A";

            camp.PlanetOrbper = 
                ((sections[11]) != "") ? sections[11] : "N/A";

            camp.Radius = 
                ((sections[13]) != "") ? sections[13] : "N/A";

            camp.Masse = 
                ((sections[15]) != "") ? sections[15] : "N/A";

            camp.PlanetEqt = 
                ((sections[20]) != "") ? sections[20] : "-";

            camp.SyDist = 
                ((sections[34]) != "") ? sections[34] : "-";

            // Add content to list of planets
            contentCollPlanet.Add(new Planet(camp.PlanetName, 
                camp.PlanetOrbper, camp.Radius, camp.Masse, camp.PlanetEqt, 
                camp.HostName, camp.DiscoveryMethod, camp.DiscYear, 
                camp.SyDist));

            
            handleData.GetSections(contentCollPlanet);
        }


        /////////////// <summary>
        /////////////// Organizes the content to its specific section and creates a list
        /////////////// of planets and stars to save its sections into it
        /////////////// </summary>
        /////////////// <param name="sections"> receives the array of strings that has
        /////////////// the content of the file </param>
        ////////////public void SplitSections(string[] sections)
        ////////////{
        ////////////    // For counting contents

        ////////////    // Instance of list of planets


        ////////////    // Organization of section by giving a name of each section and its
        ////////////    // contents fot planets and stars and asking if there is any type
        ////////////    // of information. Returns information if true and N/A or '-' if
        ////////////    // thats not the case
        ////////////    string planetName = ((sections[0]) != "") ? sections[0] : "N/A";
        ////////////    string hostName = ((sections[1]) != "") ? sections[1] : "N/A";
        ////////////    string discMethod = ((sections[5]) != "") ? sections[5] : "N/A";
        ////////////    string discYear = ((sections[6]) != "") ? sections[6] : "N/A";

        ////////////    string plOrber = ((sections[11]) != "") ? sections[11] : "N/A";
        ////////////    string plRade = ((sections[13]) != "") ? sections[13] : "N/A";
        ////////////    string plMasse = ((sections[15]) != "") ? sections[15] : "N/A";
        ////////////    string plEqt = ((sections[20]) != "") ? sections[20] : "-";
        ////////////    string syDist = ((sections[34]) != "") ? sections[34] : "-";

        ////////////    string stTeff = ((sections[23]) != "") ? sections[23] : "-";
        ////////////    string stRad = ((sections[24]) != "") ? sections[24] : "-";
        ////////////    string stMass = ((sections[25]) != "") ? sections[25] : "-";

        ////////////    //string stAge = ((sections[34]) != "") ? sections[34] : "-";
        ////////////    //string stVsin = ((sections[34]) != "") ? sections[34] : "-";
        ////////////    //string stRotq = ((sections[34]) != "") ? sections[34] : "-";


        ////////////    //For testing to print out all contents saved in those variables
        ////////////    //Console.WriteLine($"{planetName}\t{hostName}\t{discMethod}\t" +
        ////////////    //$"{discYear}\t{plOrber}\t{plRade}\t{plMasse}\t{plEqt}\t" +
        ////////////    //$"{syDist}\t{stTeff}\t{stRad}\t{stMass}");

        ////////////    // Add content to list of planets
        ////////////    contentCollPlanet.Add(new Planet(planetName, plOrber, plRade,
        ////////////        plMasse, plEqt, hostName, discMethod, discYear, syDist));

        ////////////    foreach (var item in contentCollPlanet)
        ////////////    {
        ////////////        Console.WriteLine(item);
        ////////////    }

        ////////////    //handleData.GetSections(new List<Planet>(contentCollPlanet));


        ////////////    //handleData = new HandleData(contentCollPlanet, count, null);
        ////////////    //handleData.SetResultsPlanets();

        ////////////    ////////////////////////// CREATE PLANET LIST OF ALL OF THESE (public)
        ////////////}


        /* ----- Verification methods ----- */

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

            //if (!obligatoryCamps.Any())
            //{
            //    Console.Write("This file does not contain the obligatory" +
            //    "Camps needed in order to use this program properly.\n" +
            //    "Obligatory camps are:\npl_name (Planet names) and " +
            //    "hostname.\n");
            //}
        }

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

    }
}
