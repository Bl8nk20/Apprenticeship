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
            int size = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[size];
            double[] times = new double[5];
            int i = 0;

            // save each sorting-algorithm ín a List
            List<int[]> algorithm_list = new List<int[]> { sorting.Custom_Sort_Algorithm(input),
                                                           sorting.Bubble_Sort_Algorithm(input),
                                                           sorting.Merge_Sort_Algorithm(input),
                                                           sorting.Quick_Sort_Algorithm(input),
                                                           sorting.Built_in_Function(input)};

            foreach (int[] algorithm in algorithm_list)
            {
                // Starting the Stopwatch everytime new
                timer = Stopwatch.StartNew();
                input = input_Parsing.generating(size);

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

            // calling plot method
            plot.Bar_Graph(times);


            // output of each time -> from each algorithm
            foreach (double element in times)
            {
                Console.WriteLine(element);
            }
        }
    }
}
