﻿using System;
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
        public string StarTemperature { get; set; }

        /// <summary>
        /// Get Star radius
        /// </summary>
        public string Radius { get; set; }

        /// <summary>
        /// Get Star mass
        /// </summary>
        public string Masse { get; set; }

        /// <summary>
        /// Get Star Age
        /// </summary>
        public string StarAge { get; set; }

        /// <summary>
        /// Get Star rotation velocity in km/s 
        /// </summary>
        public string StarVsin { get; set; }

        /// <summary>
        /// Get Star rotation period in days
        /// </summary>
        public string StarRotq { get; set; }

        /// <summary>
        /// Get host name of star that orbits the planet
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Discovery method
        /// </summary>
        public string DiscoveryMethod { get; set; }

        /// <summary>
        /// Get Discovery year
        /// </summary>
        public string DiscYear { get; set; }

        /// <summary>
        /// Distance between sun and star
        /// </summary>
        public string SyDist { get; set; }

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
            string starAge, string starVsin, string starRotq, string hostName,
            string disYear, string discMethtod, string syDist) 
        {
            StarTemperature = starTemperatur;
            Radius = starRadius;
            Masse = starMass;
            StarAge = starAge;
            StarVsin = starVsin;
            StarRotq = starRotq;
            HostName = hostName;
            DiscYear = disYear;
            DiscoveryMethod = discMethtod;
            SyDist = syDist;
        }

        public override string ToString()
        {
            return $"{StarTemperature} | {Radius} | {Masse} | {StarAge} | " +
                $"{StarVsin} | {StarRotq} | {HostName} | {DiscoveryMethod} | " +
                $"{DiscYear} | {SyDist}";
        }
    }
}
