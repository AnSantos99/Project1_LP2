using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// This class access the content of the file, splits its information
    /// and ignores camps that are not needed.
    /// </summary>
    class AccessFileContent
    {
        public void SplitLines(string line) 
        {
            // split lines by ","
            string[] sections = line.Split(",");

            //// Set corresponding info to right place (Planets)
            //string pl_name = sections[0];
            //string pl_orbper = sections[1];
            //string pl_orbpertr = sections[2];
        }
    }
}
