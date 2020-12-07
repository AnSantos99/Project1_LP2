using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class Planet which handles every feature a planet presents
    /// </summary>
    class Planet : IAdditionalCamps
    {
        /// <summary>
        /// Get Planet name
        /// </summary>
        public string PlanetName { get; }

        /// <summary>
        /// Get Orbital period in days
        /// </summary>
        public string PlanetOrbper { get; }

        /// <summary>
        /// Get planet radius comparing to planet earth
        /// </summary>
        public string PlanetRadius { get; }

        /// <summary>
        /// Get planet Mass comparing comparing to earth
        /// </summary>
        public string PlanetMasse { get; }

        /// <summary>
        /// Get planet temperature in kelvins
        /// </summary>
        public string PlanetEqt { get; }

        /// <summary>
        /// Get host name of star that orbits the planet
        /// </summary>
        public string HostName { get; }

        /// <summary>
        /// Discovery method
        /// </summary>
        public string DiscoveryMethod { get; }

        /// <summary>
        /// Get Discovery year
        /// </summary>
        public string DiscYear { get; }

        /// <summary>
        /// Distance between sun and star
        /// </summary>
        public string SyDist { get; }


        /// <summary>
        /// To invoke
        /// </summary>
        /// <param name="name"> Name of Planet </param>
        /// <param name="planetOrbper"> Orbital period in days </param>
        /// <param name="planetRade"> Radius of planet </param>
        /// <param name="planetMasse"> Masse of planet </param>
        /// <param name="planetEqt"> Planet temperature </param>
        public Planet(string planetName, string planetOrbper, string planetRadius,
            string planetMasse, string planetEqt,string hostname, 
            string discoveryMeth, string discYear, string syDist)
        {
            PlanetName = planetName;
            PlanetOrbper = planetOrbper;
            PlanetRadius = planetRadius;
            PlanetMasse = planetMasse;
            PlanetEqt = planetEqt;
            HostName = hostname;
            DiscoveryMethod = discoveryMeth;
            DiscYear = discYear;
            SyDist = syDist;
        }

        public Planet() { }

    }
}
