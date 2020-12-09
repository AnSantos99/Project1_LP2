using System;
using System.IO;

namespace PlanetsDatabase
{
    public class CheckOS
    {
        public static OperatingSystem checkOS = Environment.OSVersion;

        /// <summary>
        /// Method that checks the current OS to be able to open the file
        /// from the right path
        /// </summary>
        /// <param name="path"> Gets path of file </param>
        /// <param name="fileToOpen"> gets the file that needs to 
        /// be open </param>
        public static void CheckOperatingSystem(string path, string fileToOpen)
        {
            if(checkOS.Platform != PlatformID.Win32NT)
            {
               // Specified path to open the file on windows
                path = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonDesktopDirectory), fileToOpen);

                Console.WriteLine(path);
                Console.WriteLine("I am here the problem is the path!"); 
            }
        } 
    }
}