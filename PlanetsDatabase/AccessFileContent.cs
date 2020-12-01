using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    class AccessFileContent
    {
        private ICollection<Planet> planetContent;

        public void SplitContent(string line) 
        {
            // split lines by ","
            string[] sections = line.Split(",");

            // Set corresponding info to right place (Planets)
            string pl_name = sections[0];
            string pl_orbper = sections[1];
            string pl_orbpertr = sections[1];
        }
    }
}
