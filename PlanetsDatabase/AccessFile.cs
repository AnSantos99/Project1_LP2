using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

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

        //private ICollection<Planet> inputContentCollection;

        public AccessFile() 
        {
            //inputContentCollection = new List<Planet>();
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
                    //Console.WriteLine(line);
                    SplitContent(line);
                }
            }
        }

        /// <summary>
        /// This method splits the files contents by the "," on each line
        /// of the document
        /// </summary>
        /// <param name="line"> Receive every line read in document </param>
        public void SplitContent(string line)
        {
            // Split Content of each line
            string[] sections = line.Split(",");

            SeperateSections(sections);
        }

        Dictionary<string, string> plDict;


        /// <summary>
        /// To seperate all sections from the file that we need and check
        /// if there is any information. If not then print on screen N/A
        /// </summary>
        /// <param name="sections"> section that are being split </param>
        public void SeperateSections(string[] sections)
        {
            plDict = new Dictionary<string, string>();

            //string planetName = ((sections[0]) != "") ? sections[0] : "N/A";

            string planetName = "pl_name";

            plDict.Add(planetName, sections[0]);

            //string input = Console.ReadLine();

            //string hostName = ((sections[1]) != "" )? sections[1] : "N/A";

            //float pl_rade = float.Parse((sections[13] != "" )? sections[13] : "N/A");

            //float pl_masse = float.Parse((sections[15] != "" )? sections[15] : "N/A");

            //uint pl_eqt = uint.Parse((sections[20] != "" )? sections[20] : "N/A");

            // To test if it works


            //inputContentCollection.Add(new Planet(planetName));

            foreach (KeyValuePair<string, string> item in plDict)
            {
                Console.WriteLine(item.Value);
            }
        }


    }
}
