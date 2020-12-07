using System;
using System.IO;
using System.Collections;
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
        private string path;

        /// <summary>
        /// To store name of the file
        /// </summary>
        private string fileToOpen;

        public ICollection<Planet> contentCollPlanet;

        public ICollection<Stars> contentCollStars;

        private HandleData handleData;

        private InputContent inputContent;

        public AccessFile() 
        {
            // Create instance of Planet List and Stars
            
            contentCollStars = new List<Stars>();
        }

        /// <summary>
        /// Access file from path and open and read it
        /// </summary>
        public void AcessFile() 
        {
            // To get the name of the file
            fileToOpen = Console.ReadLine().ToLower();

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
        /// <param name="sr"></param>
        public void ReadContent(StreamReader sr) 
        {
            //int count = 0;

            //inputContentCollPlanet = new List<Planet>(count);


            // To read each line from document
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("#") || line.StartsWith(" "))
                {
                    continue;
                }

                else 
                {
                    SplitSections(line);
                }
            }

            //handleData = new HandleData(
            //    inputContentCollPlanet, count, inputContent);
            //handleData.SetResultsPlanets();

        }

        public void SplitSections(string line) 
        {
            string[] sections = line.Split(",");
            SplitContent(sections);
        }

        /// <summary>
        /// This method splits the files contents by the "," on each line
        /// of the document
        /// </summary>
        /// <param name="line"> Receive every line read in document </param>
        public void SplitContent(string[] sections)
        {
            int count = 0; 

            contentCollPlanet = new List<Planet>(count);

            // Split Contents of the file and put each section
            // in a position of a strings array
            string planetName = ((sections[0]) != "") ? sections[0] : "N/A";
            string hostName = ((sections[1]) != "") ? sections[1] : "N/A";
            string discMethod = ((sections[5]) != "") ? sections[5] : "N/A";
            string discYear = ((sections[6]) != "") ? sections[6] : "N/A";

            string plOrber = ((sections[11]) != "") ? sections[11] : "N/A";
            string plRade = ((sections[13]) != "") ? sections[13] : "N/A";
            string plMasse = ((sections[15]) != "") ? sections[15] : "N/A";
            string plEqt = ((sections[20]) != "") ? sections[20] : "-";
            string syDist = ((sections[34]) != "") ? sections[34] : "-";

            string stTeff = ((sections[23]) != "") ? sections[23] : "-";
            string stRad = ((sections[24]) != "") ? sections[24] : "-";
            string stMass = ((sections[25]) != "") ? sections[25] : "-";

            //string stAge = ((sections[34]) != "") ? sections[34] : "-";
            //string stVsin = ((sections[34]) != "") ? sections[34] : "-";
            //string stRotq = ((sections[34]) != "") ? sections[34] : "-";


            //For testing
            //Console.WriteLine($"{planetName}\t{hostName}\t{discMethod}\t" +
            //    $"{discYear}\t{plOrber}\t{plRade}\t{plMasse}\t{plEqt}\t" +
            //    $"{syDist}\t{stTeff}\t{stRad}\t{stMass}");



            contentCollPlanet.Add(new Planet(planetName, plOrber, plRade, 
                plMasse, plEqt, hostName, discMethod, discYear, syDist));

            handleData = new HandleData(contentCollPlanet,count, );
            handleData.SetResultsPlanets();

            ////////////////////////// CREATE PLANET LIST OF ALL OF THESE (public)

        }

        public void checkData(string[] sections)
        {
        
            // To go throught sections and store those 2 searched strings
            // in this variable
            IEnumerable<string> obligatoryCamps;

            // To go through file and see if it has this 2 obligatory camps
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
    }
}
