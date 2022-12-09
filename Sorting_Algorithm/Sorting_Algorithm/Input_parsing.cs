using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Input_parsing
    {
        
        /// <summary>
        /// A method to generate random Numbers and add it to a user given size array
        /// </summary>
        /// <param name="size"> -> user input -> length of array</param>
        /// <param name="range_min"></param>
        /// <param name="range_max"></param>
        /// <returns> -> array of random generated ints</returns>
        public int[] GeneratingRandom(int size, int range_min = -100, int range_max = 100)
        {
            // creating new Instance of random
            Random random = new Random();

            // setting array the size of user_input
            int[] random_generated = new int[size];

            // generating random integers in range of range_min and range_max
            for (int i = 0; i < size; i++)
            {
                random_generated[i] = random.Next(range_min, range_max);
            }

            // trying writing the array to an csv file
            //using (var writer = new StreamWriter("random_array_generated.csv"))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csv.WriteRecords(random_generated);
            //}

            return random_generated;
        }

        /// <summary>
        /// a Method to open and write a file and write an array to given file
        /// </summary>
        /// <param name="size"> -> user input</param>
        public void TryGenerating(int size, string filepath)
        {
            int[] array = GeneratingRandom(size);

            try
            {
                // using a Stream to write each element in the array to a file
                using (StreamWriter smyWriterw = new StreamWriter(filepath))
                {
                    foreach (int element in array)
                    {
                        if (element == array[array.Length - 1])
                        {
                            smyWriterw.Write(element);
                        }
                        else
                        {
                            smyWriterw.Write(element + " ");
                        }
                    }
                }
            }
            // Exceptions, if file is not available
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        /// <summary>
        /// Reading a file, previously generated and returning it as an array
        /// </summary>
        /// <param name="filepath"> -> filepath, where the file is stored</param>
        /// <returns></returns>
        public int[] ReadFile(string filepath)
        {
            // declaring variables
            string arrays = File.ReadAllText(filepath);
            string[] numbers = arrays.Split();
            int[] array_of_numbers = new int[numbers.Length];

            // trying to Convert each number and add it to an array
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    array_of_numbers[i] = Convert.ToInt32(numbers[i]);
                }
            }
            // if not possible throw a Detailed Message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return array_of_numbers;
        }
    }
}
