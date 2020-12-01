using System;
using System.IO;

namespace PlanetsDatabase
{
    /// <summary>
    /// Access to content from files by opening the file
    /// </summary>
    class AccessFileContent
    {
        /// <summary>
        /// To save the path of the file
        /// </summary>
        private string path;
        
        /// <summary>
        /// 
        /// </summary>
        private FileStream fs;

        /// <summary>
        /// 
        /// </summary>
        private StreamReader sr;

        /// <summary>
        /// 
        /// </summary>
        public void AcessFile() 
        {
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
