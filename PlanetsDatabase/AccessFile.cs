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
        /// To access. open and read a file given by path
        /// </summary>
        private FileStream fs;

        /// <summary>
        /// To read the content of the file
        /// </summary>
        protected private StreamReader sr;


        /// <summary>
        /// Access file from path and open and read it
        /// </summary>
        public void AcessFile() 
        {
                            // --- CANT FORGET --- //
            //Meter exceptions and using thingy com o file correto
            path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop), "some.txt");

            fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            sr = new StreamReader(fs);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
        }   
    }
}
