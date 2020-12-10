using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class that sorts contents from the elements in file
    /// </summary>
    class ContentSorter
    {
        /// <summary>
        /// Sort the list by the planets name
        /// </summary>
        /// <param name = "pl" ></ param >
        public void SortList(IEnumerable<Planet> pl)
        {
            pl.OrderByDescending(name => name.PlanetName);
        }

        /// <summary>
        /// Sort the list by the planets name
        /// </summary>
        /// <param name="pl"></param>
        public void SortList(List<Stars> st)
        {
            st.OrderByDescending(name => name.HostName);
        }

    }
}
