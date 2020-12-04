using System;
using System.IO;

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
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// This method splits the files contents by the "," on each line
        /// of the document
        /// </summary>
        /// <param name="line"> Receive every line read in document </param>
        public void SplitContentInLines(string line)
        {
            // Split Content of each line
            string[] sections = line.Split(",");

            SeperateSections(sections);
        }

        /// <summary>
        /// To seperate all sections from the file that we need and check
        /// if there is any information. If not then print on screen N/A
        /// </summary>
        /// <param name="sections"> section that are being split </param>
        public void SeperateSections(string[] sections) 
        {
            string planetName = (sections[0] != "" )? sections[0] : "N/A";

            float pl_orber = float.Parse((sections[11] != "" )? sections[11] : "N/A");

            float pl_rade = float.Parse((sections[13] != "" )? sections[13] : "N/A");

            float pl_masse = float.Parse((sections[15] != "" )? sections[15] : "N/A");

            uint pl_eqt = uint.Parse((sections[20] != "" )? sections[20] : "N/A");
        }
    }
}
