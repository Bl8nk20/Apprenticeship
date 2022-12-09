using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Plotting
    {
        /// <summary>
        /// method to plot a bar_graph out of the timing output from the sorting algorithms
        /// </summary>
        /// <param name="dataset"> -> output array from the algorithms</param>
        public void Bar_Graph(double[] dataset)
        {
            // creating labels and defining the fixed positions for the bar graphs
            string[] labels = { "Custom", "Bubble-Sort", "Merge-Sort", "Quick-Sort", "Built-In" };
            double[] positions = { 10, 20, 30, 40, 50 };

            // initialize a new scottplot instanze and add the bars
            var plt = new ScottPlot.Plot(1920, 1080);

            // add a bar graph to the plot and customize it to render horizontally
            var bar = plt.AddBar(dataset, positions);
            bar.Orientation = Orientation.Horizontal;

            // defining the bar width and the orientation to horizontal
            bar.BarWidth = (positions[1] - positions[0]);
            plt.YTicks(positions, labels);
            plt.SetAxisLimits(xMin: 0);

            // saving the plot as .png
            plt.SaveFig(@"C:\#Moritz\#Ausbildungsskripte\EInführung\Sorting_Algorithm\horizontal_bars.png");
        }
    }
}
