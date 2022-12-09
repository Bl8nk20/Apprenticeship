using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.ALgorithms_Subprocesses
{
    public class Merge_Algo
    {
        /// <summary>
        /// Method for splitting the unsorted arrays in smaller subarrays with recursive calling again
        /// </summary>
        /// <param name="unsorted_array"> input array</param>
        /// <param name="left"> left border usually 0</param>
        /// <param name="right">right border usually array Length</param>
        /// <returns>-> sorted array</returns>
        public int[] Sort_Array(int[] unsorted_array)
        {
            int[] left = new int[unsorted_array.Length / 2], right = new int[unsorted_array.Length / 2];
            int[] sorted_array = new int[unsorted_array.Length];

            // returning array if length is 1 or emptpy -> because you cant sort something which is 1 thing
            if (unsorted_array.Length <= 1)
            {
                return unsorted_array;
            }
            else
            {   
                int middle = unsorted_array.Length / 2;
                
                // append to array on leftside
                for (int i = 0; i < middle; i++)
                {
                    left.Append(unsorted_array[i]);
                }

                // append to array on rightside
                for (int i = 0; i + middle < unsorted_array.Length; i++)
                {
                    right.Append(unsorted_array[i + middle]);
                }

                // recursive method calling 
                left = Sort_Array(left);
                right = Sort_Array(right);

                // calling method to merge subarrays together
                sorted_array = MergeArray(left, right);
            }
            return sorted_array;
        }

        /// <summary>
        /// Method for fusing the subarrays together in increasing order
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left">first value -> usually always 0</param>
        /// <param name="middle"></param>
        /// <param name="right">length of array</param>
        public int[] MergeArray(int[] left, int[] right)
        {
            int i = 0;

            // setting new array to original length
            int[] result = new int[left.Length + right.Length];

            // checking condition left size larger or right size larger
            while (left.Length > 0 || right.Length > 0)
            {
                // if left is over 0 values AND is larger add it to the array and reduce the array by 1
                if (left.Length > 0 && left[0] >= right[0])
                {
                    result[i] = left[0];
                    left = left.Skip(1).ToArray();
                }
                else
                {
                    result[i] = right[0];
                    right = right.Skip(1).ToArray();
                }
                i++;
            }
            return result;
        }
    }

    public class Quick_Algo
    {
        /// <summary>
        /// An Algorithm to split the array in 2 smaller arrays and a pivot -> means one random number in the middle of the array
        /// </summary>
        /// <param name="arr">->input array</param>
        /// <param name="left">left boundary usually 0</param>
        /// <param name="right">right boundary usually length of array</param>
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            // checking if left is smaller -> usually yes
            if (left < right)
            {
                // defining the pivor
                int pivot = Partition(arr, left, right);

                // recursive function calling to split the array even more and get multiple pivots at the end
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }
        /// <summary>
        /// defining a pivot -> a random number in the middle of the array that one subarray is larger then the other
        /// </summary>
        /// <param name="arr"> -> user input</param>
        /// <param name="left">left boundary usually 0</param>
        /// <param name="right">right boundary usually Length of array</param>
        /// <returns></returns>
        private static int Partition(int[] arr, int left, int right)
        {
            // defining a pivot
            int pivot = arr[left];
            // infinite loop
            while (true)
            {
                // running till array on left is same size as the pivot
                while (arr[left] < pivot)
                {
                    left++;
                }
                // running till array on right is same size as the pivot
                while (arr[right] > pivot)
                {
                    right--;
                }

                // when left boundary is smaller then right set value of array to the value of the right array
                if (left < right)
                {
                    if (arr[left] == arr[right])
                    {
                        return right;
                    }

                    // little bit of value swapping
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                // when left is the same size than right return right 
                else
                {
                    return right;
                }
            }
        }
    }
}
