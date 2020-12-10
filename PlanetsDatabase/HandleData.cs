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
        /// <summary>
        /// To use on linq
        /// </summary>
        IEnumerable<Planet> planetsQuery;

        /// <summary>
        /// To use on linq
        /// </summary>
        IEnumerable<Stars> starsQuery;

        // To count elements in collection
        private int count = 1;

        /// <summary>
        /// To create a newlist which will store a amount of elements from the
        /// original list
        /// </summary>
        private List<Planet> newPlList;

        /// <summary>
        /// To create a newlist which will store a amount of elements from the
        /// original list
        /// </summary>
        private List<Stars> newSTList;


        /// <summary>
        /// Constructor
        /// </summary>
        public HandleData() 
        {
            newPlList = new List<Planet>();

            newSTList = new List<Stars>();
        }


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

            // Take the first 20 items of the original list and save to the
            // new List
            newPlList = contentList.Take(index).ToList();
            
            // check the countent in the list and do the following while the
            // count of the elements in the list is not equal to the max
            // Elements of the orirginal list.
            while (count <= contentList.Count && isActive)
            {
                // Check remaining contents in the list and print out each one
                if (contentList.Count < 20)
                {
                    // Check results that are less than 20
                    for (int i = 0; i < contentList.Count; i++)
                    {
                        Console.WriteLine($"{count}: " + 
                            contentList[i].ToString());
                        count++;
                        isActive = false;
                        continue;
                    }
                }

                else
                {
                    for (int i = 0; i < 20; i++)
                    {
                        // Print out the elements with a number of the index of
                        // the element
                        Console.WriteLine($"{count}: " + 
                            newPlList[i].ToString());
                        count++;

                        // to check if the count is 20 to ask to see the next page
                        // of content
                        if (count == index)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Press any key to go to next " +
                                "page... ");
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

        /// <summary>
        /// Planets Query 
        /// </summary>
        /// <param name="planetContents"></param>
        /// <param name="list"></param>
        public void GetUserInputPlanets(string[] planetContents, List<Planet> list)
        {
            // Assigning incomping parameter list to existing list
            newPlList = list;

            // Query for the list of planet to manipulate the contents and
            // verifies if the content coming from the user in that section is
            // available or not and returns the content if there is a match 
            // with the original file and nothing if condition is false
            planetsQuery = (from items in newPlList
                              where ( 
                                planetContents[0] != null ?
                                items.PlanetName.ToLower().Contains
                                (planetContents[0].ToLower()) 
                                : items.PlanetName.ToLower().Contains("")
                              
                                && (planetContents[2] != null ?
                                items.PlanetOrbper.Contains(planetContents[2]) :
                                items.PlanetOrbper.Contains(""))

                                && (planetContents[4] != null ?
                                items.Radius.Contains(planetContents[4]) : 
                                items.Radius.Contains(""))

                                && (planetContents[6] != null ?
                                items.Masse.Contains(planetContents[6]) : 
                                items.Masse.Contains(""))

                                && (planetContents[8] != null ?
                                items.PlanetEqt.Contains(planetContents[8]) : 
                                items.PlanetEqt.Contains(""))

                                && (planetContents[10] != null ?
                                items.HostName.Contains(planetContents[10]) : 
                                items.HostName.Contains(""))

                                && (planetContents[10] != null ?
                                items.DiscoveryMethod.Contains
                                (planetContents[10]) : 
                                items.DiscoveryMethod.Contains(""))

                                && (planetContents[10] != null ?
                                items.DiscYear.Contains(planetContents[10]) : 
                                items.DiscYear.Contains(""))

                               && (planetContents[10] != null ?
                               items.SyDist.Contains(planetContents[10]) : 
                               items.SyDist.Contains(""))
                               )

            select new Planet(items.PlanetName, items.PlanetOrbper, 
            items.Radius, items.Masse, items.PlanetEqt, items.HostName, 
            items.DiscoveryMethod, items.DiscYear, items.SyDist)).ToList();

            // Gets the elements of the list from the query based on users
            // input
            GetPlanetItems(planetsQuery.ToList());
        }

        /* End of Planets code section
         * ====================================================================
         * ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
         * ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
         * ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
         * ====================================================================
         * Start of Stars Code Section
         */

        /// <summary>
        /// Stores the contents of the original list and skips through its
        /// content.
        /// </summary>
        /// <param name="contentList"> Get original list</param>
        public void GetStarsItems(List<Stars> contentList)
        {
            // To get access to the index of element of the list contents
            int index = 20;

            // Set false to exit while loop
            bool isActive = true;

            // Take the first 20 items of the original list and save to the
            // new List
            newSTList = contentList.Take(index).ToList();

            // check the countent in the list and do the following while the
            // count of the elements in the list is not equal to the max
            // Elements of the orirginal list.
            while (count <= contentList.Count && isActive)
            {
                // Check remaining contents in the list and print out each one
                if (contentList.Count < 20)
                {
                    // Check results that are less than 20
                    for (int i = 0; i < contentList.Count; i++)
                    {
                        Console.WriteLine($"{count}: " +
                            contentList[i].ToString());
                        count++;
                        isActive = false;
                        continue;
                    }
                }

                else
                {
                    for (int i = 0; i < 20; i++)
                    {
                        // Print out the elements with a number of the index of
                        // the element
                        Console.WriteLine($"{count}: " +
                            newSTList[i].ToString());
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
                            newSTList.Clear();

                            // Clear Console for a nice look
                            Console.Clear();

                            // Add 20 to the index so the next 20 elements are
                            // showed/added to the new list
                            index += 20;

                            // Skip the elements of the list by its index
                            newSTList = contentList.Skip(index).ToList();
                        }

                        // To check the last elements left in the list and break
                        // so it does not exceed the index bondaries on list
                        if (newSTList.Count < 20 && i >= newSTList.Count)
                        {
                            isActive = false;
                            break;
                        }
                    }
                }
            }
            // Check the remaining contents in the list and print out each one
            if (newSTList.Count < 20)
            {
                for (int i = 0; i < newSTList.Count; i++)
                {
                    Console.WriteLine($"{count}:" + newSTList[i].ToString());
                    count++;
                }
            }
        }

        /// <summary>
        /// Stars Query 
        /// </summary>
        /// <param name="planetContents"></param>
        /// <param name="list"></param>
        public void GetUserInputStars(string[] starsContents, List<Stars> list)
        {
            // Assigning incomping parameter list to existing list
            newSTList = list;

            // Query for the list of planet to manipulate the contents and
            // verifies if the content coming from the user in that section is
            // available or not and returns the content if there is a match 
            // with the original file and nothing if condition is false
            starsQuery = (from items in newSTList
                            where (
                            starsContents[0] != null ?
                                items.StarTemperature.ToLower().Contains
                                (starsContents[0].ToLower())
                                : items.StarTemperature.ToLower().Contains("")

                                && (starsContents[2] != null ?
                                items.Radius.Contains(starsContents[2]) :
                                items.Radius.Contains(""))

                                && (starsContents[4] != null ?
                                items.Masse.Contains(starsContents[4]) :
                                items.Masse.Contains(""))

                                && (starsContents[6] != null ?
                                items.StarAge.Contains(starsContents[6]) :
                                items.StarAge.Contains(""))

                                && (starsContents[8] != null ?
                                items.StarVsin.Contains(starsContents[8]) :
                                items.StarVsin.Contains(""))

                                && (starsContents[10] != null ?
                                items.StarRotq.Contains
                                (starsContents[10]) :
                                items.StarRotq.Contains(""))

                                && (starsContents[12] != null ?
                                items.HostName.ToLower().Contains
                                (starsContents[12].ToLower()) :
                                items.HostName.ToLower().Contains(""))

                                && (starsContents[14] != null ?
                                items.DiscYear.Contains(starsContents[14]) :
                                items.DiscYear.Contains(""))
                             

                                && (starsContents[16] != null ?
                                items.DiscoveryMethod.ToLower().Contains
                                (starsContents[16].ToLower()) :
                                items.DiscoveryMethod.ToLower().Contains(""))

                                && (starsContents[18] != null ?
                                items.SyDist.Contains
                                (starsContents[18].ToLower()) :
                                items.SyDist.Contains(""))
                                )

                            select new Stars(items.StarTemperature, items.Radius,
                            items.Masse, items.StarAge, items.StarVsin,
                            items.StarRotq, items.HostName, items.DiscYear,
                            items.DiscoveryMethod, items.SyDist)).ToList();

            // Gets the elements of the list from the query based on users
            // Input
            GetStarsItems(starsQuery.ToList());
        }
    }
}




