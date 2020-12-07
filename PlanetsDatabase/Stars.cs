using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class Stars that contains every feature a star has
    /// </summary>
    class Stars : IAdditionalCamps
    {
        /// <summary>
        /// Get Star temperature
        /// </summary>
        public string StarTemperature { get; }

        /// <summary>
        /// Get Star radius
        /// </summary>
        public string StarRadius { get; }

        /// <summary>
        /// Get Star mass
        /// </summary>
        public string StarMass { get; }

        /// <summary>
        /// Get Star Age
        /// </summary>
        public string StarAge { get; }

        /// <summary>
        /// Get Star rotation velocity in km/s 
        /// </summary>
        public string StarVsin { get; }

        /// <summary>
        /// Get Star rotation period in days
        /// </summary>
        public string StarRotq { get; }

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
        /// 
        /// </summary>
        /// <param name="starTemperatur"></param>
        /// <param name="starRadius"></param>
        /// <param name="starMass"></param>
        /// <param name="starAge"></param>
        /// <param name="starVsin"></param>
        /// <param name="starRotq"></param>
        public Stars(string starTemperatur, string starRadius, string starMass,
            string starAge, string starVsin, string starRotq) 
        {
            StarTemperature = starTemperatur;
            StarRadius = starRadius;
            StarMass = starMass;
            StarAge = starAge;
            StarVsin = starVsin;
            StarRotq = starRotq;
        }
    }
}
