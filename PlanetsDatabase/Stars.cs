using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class Stars that contains every feature a star has
    /// </summary>
    class Stars
    {
        public float StarTemperature { get; }
        public float StarRadius { get; }
        public float StarMass { get; }
        public float StarAge { get; }
        public float StarVsin { get; }
        public float StarRotq { get; }

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
