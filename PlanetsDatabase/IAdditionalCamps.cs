namespace PlanetsDatabase
{
    interface IAdditionalCamps
    {
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

        public string Radius { get; }

        public string Masse { get; }
    }
}
