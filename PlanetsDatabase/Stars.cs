﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class Stars that contains every feature a star has
    /// </summary>
    class Stars
    {
        /// <summary>
        /// Get Star temperature
        /// </summary>
        public float StarTemperature { get; }

        /// <summary>
        /// Get Star radius
        /// </summary>
        public float StarRadius { get; }

        /// <summary>
        /// Get Star mass
        /// </summary>
        public float StarMass { get; }

        /// <summary>
        /// Get Star Age
        /// </summary>
        public float StarAge { get; }

        /// <summary>
        /// Get Star rotation velocity in km/s 
        /// </summary>
        public float StarVsin { get; }

        /// <summary>
        /// Get Star rotation period in days
        /// </summary>
        public float StarRotq { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="starTemperatur"></param>
        /// <param name="starRadius"></param>
        /// <param name="starMass"></param>
        /// <param name="starAge"></param>
        /// <param name="starVsin"></param>
        /// <param name="starRotq"></param>
        public Stars(float starTemperatur, float starRadius, float starMass,
            float starAge, float starVsin, float starRotq) 
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
