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
        // To count elements in collection
        private int count = 1;

        /// <summary>
        /// To create a newlist which will store a amount of elements from the
        /// original list
        /// </summary>
        List<Planet> newPlList;


        /// <summary>
        /// Stores the contents of the original list and skips through its
        /// content.
        /// </summary>
        /// <param name="contentList"> Get original list</param>
        public void GetPlanetItems(List<Planet> contentList)
        {
            // To get access to the index of element of the list contents
            int index = 20;

            // Set false to exit while loop
            bool isActive = true;

            // Create new list to save 20 elements of the original list
            newPlList = new List<Planet>();

            // Take the first 20 items of the original list and save to the
            // new List
            newPlList = contentList.Take(index).ToList();
            
            // check the countent in the list and do the following while the
            // count of the elements in the list is not equal to the max
            // Elements of the orirginal list.
            while (count <= contentList.Count && isActive)
            {
                for (int i = 0; i < 20; i++)
                {
                    // Print out the elements with a number of the index of
                    // the element
                    Console.WriteLine($"{count}:" + newPlList[i].ToString());
                    count++;

                    // to check if the count is 20 to ask to see the next page
                    // of content
                    if (count == index)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Press any key to go to next " +
                            "page...");
                        Console.ReadLine();

                        // Clear the elements in the list to print out new ones
                        newPlList.Clear();
                        
                        // Clear Console for a nice look
                        Console.Clear();

                        // Add 20 to the index so the next 20 elements are
                        // showed/added to the new list
                        index += 20;

                        // Skip the elements of the list by its index
                        newPlList = contentList.Skip(index).ToList();
                    }

                    // To check the last elements left in the list and break
                    // so it does not exceed the index bondaries on list
                    if (newPlList.Count < 20 && i >= newPlList.Count)
                    {
                        isActive = false;
                        break;
                    } 
                }
            }
            // Check the remaining contents in the list and print out each one
            if (newPlList.Count < 20)
            {
                for (int i = 0; i < newPlList.Count; i++)
                {
                    Console.WriteLine($"{count}:" + newPlList[i].ToString());
                    count++;
                }
            }
        }


        public void GetPlanetCampsForInput() 
        {
            // Get the properties
            Planet plProperties;


        }







        //// Save input from user
        ////private Planet inputContentPl;

        //// Variables to store each camp to compare with the lists content
        //private string searchedHostname;
        //private string searchedDiscovMethod;
        //private string searchedDiscYear;
        //private string searchedSyDist;

        //private string searchedPlName;
        //private string searchedPlOrber;
        //private string searchedPlRadius;
        //private string searchedPlMasse;
        //private string searchedPlEqt;

        ////private string starTemp;
        ////private string starRadius;
        ////private string starMass;
        ////private string starAge;
        ////private string starVsin;
        ////private string starRotq;

        //public Planet searchedItem;

        //int? foundInFile = 0;

        //public HandleData(List<Planet> planetsInFile) 
        //{

        //    planetCollectionInFile = planetsInFile ?? null;

        //    contentFoundInFile = foundInFile ?? 0;

        //    searchedPlName = searchedItem.PlanetName;
        //    searchedPlOrber = searchedItem.PlanetOrbper;
        //    searchedPlRadius = searchedItem.Radius;
        //    searchedPlMasse = searchedItem.Masse;
        //    searchedPlEqt = searchedItem.PlanetEqt;
        //    searchedHostname = searchedItem.HostName;
        //    searchedDiscovMethod = searchedItem.DiscoveryMethod;
        //    searchedDiscYear = searchedItem.DiscYear;
        //    searchedSyDist = searchedItem.SyDist;

        //    planetCollectionInFile = new List<Planet>(contentFoundInFile);

        //    SetResultsPlanets();
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public void SetResultsPlanets()
        //{
        //    Console.WriteLine(searchedHostname);
        //    Console.WriteLine(searchedDiscovMethod);
        //    Console.WriteLine(searchedDiscYear);
        //    Console.WriteLine(searchedSyDist);

        //    Console.WriteLine(searchedPlName);
        //    Console.WriteLine(searchedPlOrber);
        //    Console.WriteLine(searchedPlRadius);
        //    Console.WriteLine(searchedPlMasse);
        //    Console.WriteLine(searchedPlEqt);

        //    //Console.WriteLine(starTemp);
        //    //Console.WriteLine(starRadius);
        //    //Console.WriteLine(starMass);
        //    //Console.WriteLine(starAge);
        //    //Console.WriteLine(starVsin);
        //    //Console.WriteLine(starRotq);

        //    planetCollectionInFile =
        //        (from content in planetCollectionInFile
        //         where (content.HostName).ToLower().Contains(content.HostName.ToLower())
        //         where (content.DiscoveryMethod).ToLower().
        //         Contains(content.DiscoveryMethod.ToLower())
        //         where (content.DiscYear.Equals(content.DiscYear))
        //         where (content.SyDist).Equals(content.SyDist)

        //         where (content.PlanetName).ToLower().
        //         Contains(content.PlanetName.ToLower())
        //         where (content.PlanetOrbper).Equals(content.PlanetOrbper)
        //         where (content.Radius).Equals(content.Radius)
        //         where (content.Masse).Equals(content.Masse)
        //         where (content.PlanetEqt).Equals(content.PlanetEqt)

        //         select new Planet(content.PlanetName, content.PlanetOrbper,
        //         content.Radius, content.Masse, content.PlanetEqt,
        //         content.HostName, content.DiscoveryMethod, content.DiscYear,
        //         content.SyDist)).ToList();


        //    PlanetDisplayContent();
        //    planetCollectionInFile.Clear();
        //}
    }
}




