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

        List<Planet> newPlList;



        public void GetSections(List<Planet> contentList)
        {
            Console.WriteLine(contentList.Count);
            // To get access to the index of element of the list contents
            int index = 20;

            bool gone = true;

            newPlList = new List<Planet>();

            // a newlist tira 20 elementos à contentlist para aquela newlist
            newPlList = contentList.Take(index).ToList();
            
            while (count <= contentList.Count && gone)
            {
                for (int i = 0; i < 20; i++)
                {
                    
                    Console.WriteLine($"{count}:" + newPlList[i].ToString());
                    count++;

                    if (count == index)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Press 'n' to go to next page...");
                        Console.ReadLine();

                        //contentList.Skip(index).ToList();
                        newPlList.Clear();
           
                        index += 20;
                        newPlList = contentList.Skip(index).ToList();
                        
                        Console.WriteLine(newPlList.Count);
                    }

                    if (newPlList.Count < 20 && i >= newPlList.Count - 1)
                    {
                        gone = false;
                        break;
                    }
                }
            }

            if (newPlList.Count < 20)
            {
                for (int i = 0; i < newPlList.Count; i++)
                {
                    Console.WriteLine($"{count}:" + newPlList[i].ToString());
                    count++;
                }
            }
            
        }






        ///// <summary>
        ///// To store all camps for planets
        ///// </summary>
        //public ICollection<Planet> planetCollectionInFile;

        //// Maximum contents that can be showed on the screen
        //private const int LINES_TO_DISPLAY_ON_SCREEN = 20;

        //// Number of content found in file to tell user how many were found
        //private int contentFoundInFile;

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


        //public void PlanetDisplayContent() 
        //{
        //    int checkLenght = 0;

        //    int length = planetCollectionInFile.Count();

        //    int skipElements = 0;

        //    int i = 0;

        //    int counter = 1;

        //    List<Planet> newlist = new List<Planet>(LINES_TO_DISPLAY_ON_SCREEN);

        //    newlist = planetCollectionInFile.Take(LINES_TO_DISPLAY_ON_SCREEN).ToList();

        //    Console.WriteLine($"Found: {length} matching your search.");

        //    while (checkLenght <= length)
        //    {
        //        for (i = 0; i < 20; i++)
        //        {
        //            Console.Write(counter);
        //            Console.Write($"{newlist[i].PlanetName} | " +
        //                $"{newlist[i].PlanetOrbper} | {newlist[i].Radius} | " +
        //                $"{newlist[i].Masse} | {newlist[i].PlanetEqt} | " +
        //                $"{newlist[i].HostName} | {newlist[i].DiscoveryMethod} " +
        //                $"| {newlist[i].DiscYear} | {newlist[i].SyDist}");
        //        }
        //        counter++;
        //    }
        //    //DisplayChoosenContents(newlist, 4);

        //    i = 0;

        //    Console.WriteLine();
        //    Console.WriteLine("Press enter to see more.");
        //    Console.ReadKey();

        //    newlist.Clear();
        //    newlist = planetCollectionInFile.Skip(skipElements).ToList();

        //    skipElements += LINES_TO_DISPLAY_ON_SCREEN;
        //    checkLenght += LINES_TO_DISPLAY_ON_SCREEN;

        //    Console.Clear();
        //}
    }
}




