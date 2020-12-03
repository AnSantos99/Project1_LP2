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
        public int DiscYear { get; }

        /// <summary>
        /// Distance between sun and star
        /// </summary>
        public int SyDist { get; }
    }
}
