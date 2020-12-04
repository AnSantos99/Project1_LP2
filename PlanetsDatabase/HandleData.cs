using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// To handle the data into its specific place
    /// </summary>
    class HandleData
    {
        /// <summary>
        /// To store all camps for planets
        /// </summary>
        private ICollection<Planet> planetCollection;

        /// <summary>
        /// To store all camps that belong to the stars
        /// </summary>
        private ICollection<Stars> starsCollection;

        /// <summary>
        /// To save the found results into this collection
        /// </summary>
        private ICollection<Planet> organnizedPlanetCollection;

        // Maximum contents that can be showed on the screen
        private const uint LINES_TO_DISPLAY_ON_SCREEN = 20;

        // Number of content found in file
        private uint contentFoundInFile;

        // Save input from user
        private string searchedName;



        public HandleData(ICollection<Planet> planetCollection,
            int? foundIn) 
        {
            planetCollection = new List<Planet>();
        }

        public void PlanetsData() 
        {
            string[] data;

            //string planetName = data[0];

            //float pl_orber = float.Parse((sections[11] != "") ? sections[11] : "N/A");

            //float pl_rade = float.Parse((sections[13] != "") ? sections[13] : "N/A");

            //float pl_masse = float.Parse((sections[15] != "") ? sections[15] : "N/A");

            //uint pl_eqt = uint.Parse((sections[20] != "") ? sections[20] : "N/A");

            //planetCollection.Add(new Planet());
        }

        
    }
}
