using System;

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
        /// To be able for the user to split search information using a + and ,
        /// as the splitter between each camp and index
        /// </summary>
        public void SplitSearch()
        {
            // Array of strings aux lenght
            string[] aux = new string[] { };

            // Array of string to save final lenght of input content
            string[] final = new string[20];

            // For the secondary split
            string secSplit;

            // Assignment of original array
            UserInputArr = new string[] { };

            // Split the incoming content with a +
            UserInputArr = ReadInput.Split("+");

            // Assign to the secpSplit the combination of the first split
            secSplit = string.Join(null, UserInputArr);

            // Assign the secondary split to the aux Array
            aux = secSplit.Split(",");

            // Outside Loop variable to manipulate the index
            int j = 1;

            // Return every odd index element of the contents saved in the
            // Array from the input of the user
            for (int i = 0; i < aux.Length; i++)
            {
                if (i % 2 == 0 && j < Convert.ToInt32(aux[i]))
                {
                    j = Convert.ToInt32(aux[i]);
                }
            }

            // Do the same but this time revert
            for (int i = 0; i <= aux.Length; i++)
            {       
                if (i % 2 == 0)
                {
                    int num = Array.IndexOf(aux, j.ToString());

                    final.SetValue(aux[num + 1], i);

                    j++;
                }
            }

            // Assignment of the original to the last array with the splits
            UserInputArr = final;
        }

        /// <summary>
        /// Method that checks wether a string is null or doesnt present blank
        /// spaces and return the content given by the user
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