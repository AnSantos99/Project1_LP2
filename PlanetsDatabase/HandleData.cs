using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        // Maximum contents that can be showed on the screen
        private const uint LINES_TO_DISPLAY_ON_SCREEN = 20;

        // Number of content found in file
        private int contentFoundInFile;

        // Save input from user
        private InputContent inputContent;

        // Variables to store each camp input
        private string hostname;
        private string discovMethod;
        private uint discYear;
        private float syDist;

        private string plName;
        private float plOrber;
        private float plRadius;
        private float plMasse;
        private float plEqt;

        private float starTemp;
        private float starRadius;
        private float starMass;
        private float starAge;
        private float starVsin;
        private float starRotq;

        private List<Planet> organizedContentsPlanets;
        private List<Stars> organizedContentsStars;

        public HandleData(ICollection<Planet> dataContents, int? numOfContents,
            InputContent inputContent) 
        {
            this.inputContent = inputContent;

            planetCollection = dataContents ?? null;

            contentFoundInFile = numOfContents ?? 0;

            hostname = inputContent.HostName;
            discovMethod = inputContent.DiscoveryMethod;
            discYear = uint.Parse(inputContent.DiscYear);
            syDist = float.Parse(inputContent.SyDist);

            plName = inputContent.PlanetName;
            plOrber = float.Parse(inputContent.PlanetOrbper);
            plRadius = float.Parse(inputContent.PlanetRadius);
            plMasse = float.Parse(inputContent.PlanetMasse);
            plEqt = float.Parse(inputContent.PlanetEqt);

            organizedContentsPlanets = new List<Planet>(contentFoundInFile);  
        }

        public HandleData(ICollection<Stars> dataContents, int? numOfContents,
            InputContent inputContent)
        {
            this.inputContent = inputContent;

            starsCollection = dataContents ?? null;

            contentFoundInFile = numOfContents ?? 0;

            hostname = inputContent.HostName;
            discovMethod = inputContent.DiscoveryMethod;
            discYear = uint.Parse(inputContent.DiscYear);
            syDist = float.Parse(inputContent.SyDist);

            starTemp = float.Parse(inputContent.StarTemperature);
            starRadius = float.Parse(inputContent.StarRadius);
            starMass = float.Parse(inputContent.StarMass);
            starAge = float.Parse(inputContent.StarAge);
            starVsin = float.Parse(inputContent.StarVsin);
            starRotq = float.Parse(inputContent.StarRotq);

            organizedContentsStars = new List<Stars>(contentFoundInFile);
        }

        
        /// <summary>
        /// 
        /// </summary>
        public void SetResultsPlanets()
        {
            Console.WriteLine(hostname);
            Console.WriteLine(discovMethod);
            Console.WriteLine(discYear);
            Console.WriteLine(syDist);

            Console.WriteLine(plName);
            Console.WriteLine(plOrber);
            Console.WriteLine(plRadius);
            Console.WriteLine(plMasse);
            Console.WriteLine(plEqt);

            Console.WriteLine(starTemp);
            Console.WriteLine(starRadius);
            Console.WriteLine(starMass);
            Console.WriteLine(starAge);
            Console.WriteLine(starVsin);
            Console.WriteLine(starRotq);

            organizedContentsPlanets =
                (from content in planetCollection
                 where (content.HostName).ToLower().
                 Contains(hostname.ToLower())
                 where (content.DiscoveryMethod).ToLower().
                 Contains(discovMethod.ToLower())
                 where (content.DiscYear.Equals(discYear))
                 where (content.SyDist).Equals(syDist)

                 where (content.PlanetName).ToLower().
                 Contains(plName.ToLower())
                 where (content.PlanetOrbper).Equals(plOrber)
                 where (content.PlanetOrbper).Equals(plOrber)
                 where (content.PlanetRadius).Equals(plRadius)
                 where (content.PlanetMasse).Equals(plMasse)
                 where (content.PlanetEqt).Equals(plEqt)

                 select new Planet(content.PlanetName, content.PlanetOrbper,
                 content.PlanetRadius, content.PlanetMasse, content.PlanetEqt,
                 content.HostName, content.DiscoveryMethod, content.DiscYear,
                 content.SyDist)).ToList();

            SortList(organizedContentsPlanets);
        }

        /// <summary>
        /// Sort the list by the planets name
        /// </summary>
        /// <param name="pl"></param>
        public void SortList(List<Planet> pl)
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
