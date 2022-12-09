using Sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class Timing
    {
        static void Main()
        {
            // new instances for each program
            Input_parsing input_Parsing = new Input_parsing();
            Algorithms sorting = new Algorithms();
            Stopwatch timer = new Stopwatch();
            Plotting plot = new Plotting();

            // get input array
            Console.WriteLine("Enter size of input-array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] inputs = input_Parsing.generating(size);
            double[] times = new double[5];
            int i = 0;

            // save each sorting-algorithm ín a List
            List<int[]> algorithm_list = new List<int[]> { sorting.Custom_Sort_Algorithm(inputs),
                                                           sorting.Bubble_Sort_Algorithm(inputs),
                                                           sorting.Merge_Sort_Algorithm(inputs),
                                                           sorting.Quick_Sort_Algorithm(inputs),
                                                           sorting.Built_in_Function(inputs)};

            foreach (int[] algorithm in algorithm_list)
            {
                // Starting the Stopwatch everytime new
                timer = Stopwatch.StartNew();

                // using placeholder for failredundancy -> calling the element in the list
                _ = algorithm;

                // stopping the stopwatch
                timer.Stop();

                // get total time passed
                TimeSpan timespan = timer.Elapsed;

                // output in millisec
                times[i] = timespan.TotalMilliseconds;
                i++;
            }

            // plotting the times
            plot.Bar_Graph(times);

            // output of each time -> from each algorithm
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Custom Designed Algorithm: " + times[0] + " ms");
            Console.WriteLine("Bubble Sort Algorithm: " + times[1] + " ms");
            Console.WriteLine("Merge Sort Algorithm: " + times[2] + " ms");
            Console.WriteLine("Quick Sort Algorithm: " + times[3] + " ms");
            Console.WriteLine("Built in Sort Function: " + times[4] + " ms");
            Console.WriteLine("-----------------------------------------\n");
        }
    }
}
