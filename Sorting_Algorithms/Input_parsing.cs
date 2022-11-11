using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Input_parsing
    {
        /// <summary>
        /// method to get an array out of a string to test the algorithms
        /// </summary>
        /// <returns> -> array of integers </returns>
        /// <exception cref="Exception"></exception>
        public int[] input_parsing()
        {
            try
            {
                // Reading .dat file
                string input = System.IO.File.ReadAllText(@"C:\Users\ms85866\Desktop\Programme_Codes\ArbeitsCodes\Skripte_waehrend_Praxis\Fertige_Projekte\Sorting_Algorithms\bin\Debug\net6.0\array_input.dat");
                // splitting the string in an char array
                string[] text_splitted = input.Split(",");
                int[] input_array = new int[text_splitted.Length];
                int i = 0;
                // looping for each element in my char array
                foreach(string element in text_splitted)
                {
                    input_array[i] = int.Parse(element);
                }
                return input_array;
            }
            catch
            {
                // throw an exception, when the file doesnt exist
                throw new Exception("The file doesn't exist or doesn't exist at the specified location. Check the path and the spelling of the file name.");
            }
        }

        /// <summary>
        /// method to generate random integers and add it to an array -> going to save the array to a file
        /// </summary>
        /// <param name="size">size of the array</param>
        /// <param name="range">range of the numbers usually range = 100</param>
        /// <returns> currently returning an array -> going to be changed to void type and safe to file</returns>
        public int[] generating(int size, int range = 100)
        {
            Random random = new Random();

            int[] random_generatet = new int[size];
            
            for(int i = 0; i < size; i++)
            {
                random_generatet[i] = random.Next(range);
            }

            // deleting if
            return random_generatet;
        }
    }
}
