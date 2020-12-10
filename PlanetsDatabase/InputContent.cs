using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    /// <summary>
    /// Class based on the users input and its verification
    /// </summary>
    class InputContent
    {
        /// <summary>
        /// To get the input of the user
        /// </summary>
        public string ReadInput { get; private set; }

        /// <summary>
        /// Unchangeable array for the users input to search information
        /// about the planets/stars
        /// </summary>
        public string[] UserInputArr { get; private set; }

        /// <summary>
        /// To be able for the user to split search information using a + as
        /// the splitter between each camp
        /// </summary>
        /// <param name="search"></param>
        public void SplitSearch()
        {
            string[] aux = new string[] { };

            string[] final = new string[11];

            string hahah;

            UserInputArr = new string[] { };

            UserInputArr = ReadInput.Split("+");

            hahah = string.Join(null, UserInputArr);

            aux = hahah.Split(",");

            int j = 1;

            for (int i = 0; i < aux.Length; i++)
            {
                if (i % 2 == 0 && j < Convert.ToInt32(aux[i]))
                {
                    j = Convert.ToInt32(aux[i]);
                }
            }

            for (int i = 0; i <= aux.Length; i++)
            {       
                if (i % 2 == 0)
                {
                    int num = Array.IndexOf(aux, j.ToString());

                    final.SetValue(aux[num + 1], i);

                    j++;
                }
            }

            foreach(string str in final)
            {
                Console.WriteLine(str);
            }

            UserInputArr = final;
        }

        /// <summary>
        /// Metho that checks wether a string is null or doesnt present blank
        /// spaces
        /// </summary>
        /// <param name="input"> Console.ReadLine variable </param>
        public void CheckInput(string input) 
        {
            if (input != null)
                if (input != "" || input != " ")
                    ReadInput = input;
        }
    }
}