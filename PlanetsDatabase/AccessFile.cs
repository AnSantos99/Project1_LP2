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

        private ICollection<Planet> inputContentCollPlanet;

        private HandleData handleData;

        private InputContent inputContent;

        public AccessFile() 
        {
            
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
            int count = 0;

            inputContentCollPlanet = new List<Planet>(count);


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
                    SplitContent(line);
                }
            }

            handleData = new HandleData(
                inputContentCollPlanet, count, inputContent);
            handleData.SetResultsPlanets();

        }

        /// <summary>
        /// This method splits the files contents by the "," on each line
        /// of the document
        /// </summary>
        /// <param name="line"> Receive every line read in document </param>
        public void SplitContent(string line)
        {
            inputContentCollPlanet = new List<Planet>();

            // Split Planet Content of the file and put each section
            // in an strings array
            string[] pl_name = line.Split(",");
            string planetName = ((pl_name[0]) != "") ? pl_name[0] : "N/A";

            string[] host_name = line.Split(",");
            string hostName = ((host_name[1]) != "") ? host_name[1] : "N/A";

            string[] dis_Method = line.Split(",");
            string discMethod = ((dis_Method[5]) != "") ? dis_Method[5] : "N/A";

            string[] disc_year = line.Split(",");
            string discYear = ((disc_year[6]) != "") ? disc_year[6] : "N/A";

            string[] pl_orber = line.Split(",");
            string plOrber = ((pl_orber[11]) != "") ? pl_orber[11] : "N/A";

            string[] pl_rade = line.Split(",");
            string plRade = ((pl_rade[13]) != "") ? pl_rade[13] : "N/A";

            string[] pl_masse = line.Split(",");
            string plMasse = ((pl_masse[15]) != "") ? pl_masse[15] : "N/A";

            string[] pl_Eqt = line.Split(",");
            string plEqt = ((pl_Eqt[20]) != "") ? pl_Eqt[20] : "-";

            string[] sy_Dist = line.Split(",");
            string syDist = ((sy_Dist[34]) != "") ? sy_Dist[34] : "-";

            //For testing
            //Console.WriteLine($"{planetName}\t{hostName}\t{discMethod}\t{discYear}\t{plOrber}\t{plRade}\t{plMasse}\t{plEqt}\t");

            

            //---------------------------------------------------------------//
        }

        /// <summary>
        /// This method splits the files contents by the "," on each line
        /// of the document
        /// </summary>
        /// <param name="line"> Receive every line read in document </param>
        public void SplitContent(string line)
        {
            inputContentCollPlanet = new List<Planet>();

            // Split Planet Content of the file and put each section
            // in an strings array
            string[] pl_name = line.Split(",");
            string planetName = ((pl_name[0]) != "") ? pl_name[0] : "N/A";

            string[] host_name = line.Split(",");
            string hostName = ((host_name[1]) != "") ? host_name[1] : "N/A";

            string[] dis_Method = line.Split(",");
            string discMethod = ((dis_Method[5]) != "") ? dis_Method[5] : "N/A";

            string[] disc_year = line.Split(",");
            string discYear = ((disc_year[6]) != "") ? disc_year[6] : "N/A";

            string[] pl_orber = line.Split(",");
            string plOrber = ((pl_orber[11]) != "") ? pl_orber[11] : "N/A";

            string[] pl_rade = line.Split(",");
            string plRade = ((pl_rade[13]) != "") ? pl_rade[13] : "N/A";

            string[] pl_masse = line.Split(",");
            string plMasse = ((pl_masse[15]) != "") ? pl_masse[15] : "N/A";

            string[] pl_Eqt = line.Split(",");
            string plEqt = ((pl_Eqt[20]) != "") ? pl_Eqt[20] : "-";

            string[] sy_Dist = line.Split(",");
            string syDist = ((sy_Dist[34]) != "") ? sy_Dist[34] : "-";

            //For testing
            //Console.WriteLine($"{planetName}\t{hostName}\t{discMethod}\t{discYear}\t{plOrber}\t{plRade}\t{plMasse}\t{plEqt}\t");



            //---------------------------------------------------------------//
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




        //dataNeeded = from data in sections
        //             where data.Contains("pl_") || data.Contains("st_")
        //             select data;


        //plDict = new Dictionary<string, string>();

        ////string planetName = ((sections[0]) != "") ? sections[0] : "N/A";

        //string planetName = "pl_name";

        //plDict.Add(planetName, sections[0]);

        ////string input = Console.ReadLine();

        
        //// To test if it works


        ////inputContentCollection.Add(new Planet(planetName));

        //foreach (KeyValuePair<string, string> item in plDict)
        //{
        //    Console.WriteLine(item.Value);
        //}


    }
}
