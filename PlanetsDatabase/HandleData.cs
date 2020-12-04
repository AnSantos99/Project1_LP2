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

        public HandleData() 
        {
            planetCollection = new List<Planet>();
        }

        
    }
}
