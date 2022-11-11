/* Excersise:
 *      Create an custom sorting algorithm (Done)
 *      Implement it without using the built in C# Sorting-functions (Done)
 *      Reading Input-Array from .dat file. -> later on Dynamic searching for File
 *      Length of Input-Array == Output-Array (Done)
 *      Increasing order (Done)
 *      Implement BubbleSort (Done), QuickSort (Done), MergeSort (Done)
 *      Compare Runtimes (Done)
 *      Include Random (Not done) Length-Arrays with Random Values (Done)
 *      Plot Results in Realtime / Runtimes     
 */
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Sorting_Algorithms.ALgorithms_Subprocesses;

namespace Sorting
{
    public class Algorithms
    {
        /// <summary>
        /// Implementation of a Custom-Sort-Algorithm to Compare
        /// </summary>
        /// <param name="unsorted_array">reading the array from a file</param>
        /// <returns>sorted array with the Custom-Sort-Algorithm</returns>
        public int[] Custom_Sort_Algorithm(int[] unsorted_array)
        {
            // Declaring array
            int[] sorted_array = new int[unsorted_array.Length];

            // looping for the length of the array
            for(int i = 0; i < unsorted_array.Length; i++)
            {
                for(int j = 0; j < unsorted_array.Length; j++)
                {
                    // comparing every value with eachother
                    sorted_array[i] = Math.Min(unsorted_array[i], unsorted_array[j]);
                }
            }
            return sorted_array;
        }

        /// <summary>
        /// Implementation of a Bubble-Sort-Algorithm to Compare
        /// </summary>
        /// <param name="unsorted_array">reading the array from a file</param>
        /// <returns>sorted array with the Bubble-Sort-Algorithm</returns>
        public int[] Bubble_Sort_Algorithm(int[] unsorted_array)
        {
            int[] sorted_array = new int[unsorted_array.Length];

            // bool for checking if the array is in order
            bool is_Sorted;
            
            // outer loop for finding the highest number
            for (int i = sorted_array.Length - 1; i > 1; i--)
            {
                // setting bool to true that the program dont need to run longer than necessary
                is_Sorted = true;
            
                // inner loop for finding next higher values
                for (int j = 1; j < i; j++)
                {
                    // if for checking if previous value is larger then current one
                    if (unsorted_array[j - 1] > unsorted_array[j])
                    {
                        unsorted_array[j] = unsorted_array[j - 1];
                        is_Sorted = false;
                    }
                }
                
                // for breaking the looping early
                if (is_Sorted)
                {
                    return sorted_array;
                }
            }
            
            sorted_array = unsorted_array;
            return sorted_array;
        }

        /// <summary>
        /// Implementation of a Merge-Sort-Algorithm to Compare
        /// </summary>
        /// <param name="unsorted_array">reading the array from a file</param>
        /// <returns>sorted array with the Merge-Sort-Algorithm</returns>
        public int[] Merge_Sort_Algorithm(int[] unsorted_array)
        {
            // Calling Subprocess
            Merge_Algo merging = new Merge_Algo();

            // using Subprocess Method for Sorting the array
            int[] sorted_array = merging.Sort_Array(unsorted_array);

            return sorted_array;
        }

        /// <summary>
        /// Implementation of a Quick-Sort-Algorithm to Compare
        /// </summary>
        /// <param name="unsorted_array">reading the array from a file</param>
        /// <returns>sorted array with the Quick-Sort-Algorithm</returns>
        public int[] Quick_Sort_Algorithm(int[] unsorted_array)
        {
            int[] sorted_array = new int[unsorted_array.Length];

            Quick_Algo.Quick_Sort(unsorted_array, 0, unsorted_array.Length - 1);

            return sorted_array;
        }

        /// <summary>
        /// Implementation of the Built in Sorting Method
        /// </summary>
        /// <param name="unsorted_array"></param>
        /// <returns>sorted array with the Built-in Method</returns>
        public int[] Built_in_Function(int[] unsorted_array)
        {
            int[] sorted_array = new int[unsorted_array.Length];
         
            // calling in-built Sort method
            Array.Sort(unsorted_array);
            sorted_array = unsorted_array;
            
            return sorted_array;
        }
    }
}