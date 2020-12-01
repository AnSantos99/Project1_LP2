using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class Planet which handles every feature a planet presents
    /// </summary>
    class Planet
    {
        /// <summary>
        /// Get Planet name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Get Orbital period in days
        /// </summary>
        public float PlanetOrbper { get; }

        /// <summary>
        /// Get planet radius comparing to planet earth
        /// </summary>
        public float PlanetRadius { get; }

        /// <summary>
        /// Get planet Mass comparing comparing to earth
        /// </summary>
        public float PlanetMasse { get; }

        /// <summary>
        /// Get planet temperature in kelvins
        /// </summary>
        public float PlanetEqt { get; }

        /// <summary>
        /// To invoke
        /// </summary>
        /// <param name="name"> Name of Planet </param>
        /// <param name="planetOrbper"> Orbital period in days </param>
        /// <param name="planetRade"> Radius of planet </param>
        /// <param name="planetMasse"> Masse of planet </param>
        /// <param name="planetEqt"> Planet temperature </param>
        public Planet(string name, float planetOrbper, float planetRadius,
            float planetMasse, float planetEqt)
        {
            Name = name;
            PlanetOrbper = planetOrbper;
            PlanetRadius = planetRadius;
            PlanetMasse = planetMasse;
            PlanetEqt = planetEqt;
        }

    }
}
