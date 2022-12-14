using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Networkanalysis
{
    internal class Currents_and_Voltages
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="R4x"></param>
        /// <param name="Uq1"></param>
        public void starting_calculations(double R4x, double Uq1)
        {
            Filling_Matrix_and_Gaus cultivating = new Filling_Matrix_and_Gaus();
            Vector<double> doubles = cultivating.Calculating_Currents_meshes(R4x, Uq1);
            Currents(doubles);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currents_meshes_calculated"></param>
        /// <returns></returns>
        public double[] Currents(Vector<double> currents_meshes_calculated)
        {
            double[] currents_array = new double[] { };

            return currents_array;
        }
    }
}
