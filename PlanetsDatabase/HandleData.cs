using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace PlanetsDatabase
{
    /// <summary>
    /// Contains the content of all contents the program found related to the
    /// users input.
    /// </summary>
    class HandleData
    {
        private InputContent userInput;

        private ConsoleKey nextPageKey = ConsoleKey.N;

        // To count elements in collection
        private int count = 1;

        // Max element that can be shown from collection on display
        private const int MAX_CONTENTS = 20;

        private int SKIP_CONTENTS = 0;

        public void GetSections(List<Planet> contentList) 
        {
            // To the content amount of planets
            int contentLenght = contentList.Count();

            int lenght = 0;

            List<Planet> newPlList = new List<Planet>(MAX_CONTENTS);

            newPlList = contentList.Take(MAX_CONTENTS).ToList();

            int checkCondition;

            while (lenght <= contentLenght)
            {
                for (checkCondition = 0; checkCondition < 20; checkCondition++)
                {
                    Console.WriteLine($"{count}: " + 
                        newPlList[checkCondition].ToString());
                }

                count++;

                Console.WriteLine();
                Console.WriteLine("Press 'n' to go to next page...");
                Console.ReadKey();

                newPlList.Clear();

                newPlList = contentList.Skip(SKIP_CONTENTS).ToList();

                SKIP_CONTENTS += MAX_CONTENTS;
                lenght += MAX_CONTENTS;

                Console.Clear();


            }






            //if (contentList.Count == MAX_CONTENTS)
            //{
            //    foreach (Planet item in contentList)
            //    {
            //        Console.WriteLine($"{count}:" + item.ToString());
            //        count++;

            //        if (count == MAX_CONTENTS)
            //        {
            //            count = MAX_CONTENTS;

            //            Console.WriteLine();
            //            Console.WriteLine("Press 'n' to go to next page...");
            //            if (Console.ReadKey().Key != ConsoleKey.N)
            //            {
            //                Console.WriteLine("Please press n to view next" +
            //                    "content");
            //            }
            //            else
            //            {

            //            }
            //        }
            //    }
            //}  
        }











































        /// <summary>
        /// To store all camps for planets
        /// </summary>
        private ICollection<Planet> planetCollection;

        // Maximum contents that can be showed on the screen
        private const int LINES_TO_DISPLAY_ON_SCREEN = 20;

        // Number of content found in file to tell user how many were found
        private int contentFoundInFile;

        // Save input from user
        //private Planet inputContentPl;

        // Variables to store each camp to compare with the lists content
        private string searchedHostname;
        private string searchedDiscovMethod;
        private string searchedDiscYear;
        private string searchedSyDist;

        private string searchedPlName;
        private string searchedPlOrber;
        private string searchedPlRadius;
        private string searchedPlMasse;
        private string searchedPlEqt;

        //private string starTemp;
        //private string starRadius;
        //private string starMass;
        //private string starAge;
        //private string starVsin;
        //private string starRotq;

        public Planet searchedItem;

        private ICollection<Planet> organizedPlContent;

        public HandleData() 
        { }

        //public void CompareContents(ICollection<Planet> plContentinFile, 
        //   int? numContentFound) 
        //{
        //   Planet searchedItem;

        //   this.searchedItem = searchedItem;

        //   planetCollection = plContentinFile ?? null;
        //   contentFoundInFile = numContentFound ?? 0;

        //   searchedPlName = searchedItem.PlanetName;
        //   searchedPlOrber = searchedItem.PlanetOrbper;
        //   searchedPlRadius = searchedItem.Radius;
        //   searchedPlMasse = searchedItem.Masse;
        //   searchedPlEqt = searchedItem.PlanetEqt;

        //   organizedPlContent = new List<Planet>(contentFoundInFile);
        //}


        public HandleData(ICollection<Planet> plContents) 
        {
            
        }

        /// <summary>
        /// This method is for comparing the input with the lists content
        /// </summary>
        /// <param name="dataContents"></param>
        /// <param name="inputContent"></param>
        ////////public HandleData(ICollection<Planet> dataContents, )
        ////////{
        ////////    InputContent inputContentPl = new InputContent();

        ////////    inputContentPl = inputContent;

        ////////    planetCollection = dataContents ?? null;

        ////////    contentFoundInFile = numOfContents ?? 0;

        ////////    hostname = inputContent.HostName;
        ////////    discovMethod = inputContent.DiscoveryMethod;
        ////////    discYear = inputContent.DiscYear;
        ////////    syDist = inputContent.SyDist;

        ////////    plName = inputContent.PlanetName;
        ////////    plOrber = inputContent.PlanetOrbper;
        ////////    plRadius = inputContent.Radius;
        ////////    plMasse = inputContent.Masse;
        ////////    plEqt = inputContent.PlanetEqt;

        ////////    organizedContentsPlanets = new List<Planet>(contentFoundInFile);
        ////////}

        ///// <summary>
        ///// 
        ///// </summary>
        //public void SetResultsPlanets()
        //{
        //    Console.WriteLine(hostname);
        //    Console.WriteLine(discovMethod);
        //    Console.WriteLine(discYear);
        //    Console.WriteLine(syDist);

        //    Console.WriteLine(plName);
        //    Console.WriteLine(plOrber);
        //    Console.WriteLine(plRadius);
        //    Console.WriteLine(plMasse);
        //    Console.WriteLine(plEqt);

        //    //Console.WriteLine(starTemp);
        //    //Console.WriteLine(starRadius);
        //    //Console.WriteLine(starMass);
        //    //Console.WriteLine(starAge);
        //    //Console.WriteLine(starVsin);
        //    //Console.WriteLine(starRotq);

        //    organizedContentsPlanets =
        //        (from content in planetCollection
        //         where (content.HostName).ToLower().
        //         Contains(hostname.ToLower())
        //         where (content.DiscoveryMethod).ToLower().
        //         Contains(discovMethod.ToLower())
        //         where (content.DiscYear.Equals(discYear))
        //         where (content.SyDist).Equals(syDist)

        //         where (content.PlanetName).ToLower().
        //         Contains(plName.ToLower())
        //         where (content.PlanetOrbper).Equals(plOrber)
        //         where (content.PlanetOrbper).Equals(plOrber)
        //         where (content.Radius).Equals(plRadius)
        //         where (content.Masse).Equals(plMasse)
        //         where (content.PlanetEqt).Equals(plEqt)

        //         select new Planet(content.PlanetName, content.PlanetOrbper,
        //         content.Radius, content.Masse, content.PlanetEqt,
        //         content.HostName, content.DiscoveryMethod, content.DiscYear,
        //         content.SyDist)).ToList();

        //    PageContents(organizedContentsPlanets);
        //    planetCollection.Clear();
        //}
    }
}
