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
        private const int LINES_TO_DISPLAY_ON_SCREEN = 20;

        // Number of content found in file
        private int contentFoundInFile;

        // Save input from user
        private Planet inputContentPl;

        // Variables to store each camp input
        private string hostname;
        private string discovMethod;
        private string discYear;
        private string syDist;

        private string plName;
        private string plOrber;
        private string plRadius;
        private string plMasse;
        private string plEqt;

        private string starTemp;
        private string starRadius;
        private string starMass;
        private string starAge;
        private string starVsin;
        private string starRotq;

        private List<Planet> organizedContentsPlanets;
        private List<Stars> organizedContentsStars;

        public HandleData(List<Planet> dataContents, AccessFile file)
        {
            Planet inputContent = new Planet();

            int? numOfContents = 0;

            this.inputContentPl = inputContent;

            planetCollection = dataContents ?? null;

            contentFoundInFile = numOfContents ?? 0;

            hostname = inputContent.HostName;
            discovMethod = inputContent.DiscoveryMethod;
            discYear = inputContent.DiscYear;
            syDist = inputContent.SyDist;

            plName = inputContent.PlanetName;
            plOrber = inputContent.PlanetOrbper;
            plRadius = inputContent.Radius;
            plMasse = inputContent.Masse;
            plEqt = inputContent.PlanetEqt;

            organizedContentsPlanets = new List<Planet>(contentFoundInFile);
        }

        public HandleData(ICollection<Planet> dataContents, int? numOfContents,
            Planet inputContent)
        {
            this.inputContentPl = inputContent;

            planetCollection = dataContents ?? null;

            contentFoundInFile = numOfContents ?? 0;

            hostname = inputContent.HostName;
            discovMethod = inputContent.DiscoveryMethod;
            discYear = inputContent.DiscYear;
            syDist = inputContent.SyDist;

            plName = inputContent.PlanetName;
            plOrber = inputContent.PlanetOrbper;
            plRadius = inputContent.Radius;
            plMasse = inputContent.Masse;
            plEqt = inputContent.PlanetEqt;

            organizedContentsPlanets = new List<Planet>(contentFoundInFile);
        }

        //public HandleData(ICollection<Stars> dataContents, int? numOfContents,
        //    InputContent inputContent)
        //{
        //    this.inputContent = inputContent;

        //    starsCollection = dataContents ?? null;

        //    contentFoundInFile = numOfContents ?? 0;

        //    hostname = inputContent.HostName;
        //    discovMethod = inputContent.DiscoveryMethod;
        //    discYear = uint.Parse(inputContent.DiscYear);
        //    syDist = float.Parse(inputContent.SyDist);

        //    starTemp = float.Parse(inputContent.StarTemperature);
        //    starRadius = float.Parse(inputContent.StarRadius);
        //    starMass = float.Parse(inputContent.StarMass);
        //    starAge = float.Parse(inputContent.StarAge);
        //    starVsin = float.Parse(inputContent.StarVsin);
        //    starRotq = float.Parse(inputContent.StarRotq);

        //    organizedContentsStars = new List<Stars>(contentFoundInFile);
        //}


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
                 where (content.Radius).Equals(plRadius)
                 where (content.Masse).Equals(plMasse)
                 where (content.PlanetEqt).Equals(plEqt)

                 select new Planet(content.PlanetName, content.PlanetOrbper,
                 content.Radius, content.Masse, content.PlanetEqt,
                 content.HostName, content.DiscoveryMethod, content.DiscYear,
                 content.SyDist)).ToList();

            PageContents(organizedContentsPlanets);
            planetCollection.Clear();
        }

        public void PageContents(List<Planet> content)
        {
            // To check length of the organized titles
            uint lenghtCheck = 0;

            // Count amount of titles
            int length = organizedContentsPlanets.Count();

            // this initialises the variable for the skip value
            int skipValue = 0;

            // Loop checker declared outside for loop to have acess to it 
            // on while condition
            int conditionChecker = 0;

            int counter = 1;

            // Take x amount of content and save it to a new list
            List<Planet> newList = new List<Planet>(contentFoundInFile);

            newList = organizedContentsPlanets.Take(contentFoundInFile).ToList();

            Console.WriteLine("We found" + length + "Matching your search!");

            Console.WriteLine("Pl_name | Pl_Orber | PL_Radius | Pl_Masse | " +
                "Pl_Eqt | HostName | Discoverymethod | Disc. Year | SyDist");

            // Stay true while the lenghtChecker is smaller or equals the
            // amount of titles
            while (lenghtCheck <= length)
            {
                for (conditionChecker = 0; conditionChecker < 30;
                    conditionChecker++)
                {
                    Console.Write(counter);
                    Console.Write(newList[conditionChecker].PlanetName);
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].PlanetOrbper);
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].Radius?.ToString());
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].Masse?.ToString());
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].PlanetEqt?.ToString());
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].HostName);
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].DiscoveryMethod);
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].DiscYear);
                    Console.Write(" | ");
                    Console.Write(newList[conditionChecker].SyDist);
                    Console.WriteLine();
                }
                counter++;
            }
            DisplayChosenTitle(newList, 4);

            // reset value so next loop starts at 0
            conditionChecker = 0;

            // Ask user if he wants to see the next contents
            Console.WriteLine();
            Console.WriteLine("Press enter to see more.");
            Console.ReadKey();

            // Clear old list to save memory
            newList.Clear();

            // Create a new list but skip the already shown
            newList = organizedContentsPlanets.Skip(skipValue).ToList();

            // increase the value to allow access to the list's next results
            skipValue += LINES_TO_DISPLAY_ON_SCREEN;

            // add 30 each time to stop loop after last value is written
            lenghtCheck += LINES_TO_DISPLAY_ON_SCREEN;

            Console.Clear();
        }

        /// <summary>
        /// bugged placeholder to give user info from chosen title in list
        /// </summary>
        /// <param name="currentSkipValue"></param>
        /// <param name="UserValue"></param>
        public void DisplayChosenTitle(List<Planet> newList, int UserValue)
        {
            // later - add condition for person to choose item
            // placeholder - test chosen item to display info

            int indexOfTitle = UserValue - 1;
            Console.WriteLine("Info from number" /*+ count*/);

            Console.WriteLine("Number: " + newList[indexOfTitle].PlanetName + UserValue);
            //etc

            // later when title info display is in separate place to show better


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
