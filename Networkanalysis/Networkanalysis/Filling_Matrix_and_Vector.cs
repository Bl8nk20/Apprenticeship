using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;

namespace Networkanalysis
{
    internal class Filling_Matrix_and_Vector
    {
        // Gauß - Algorithmus nach form: A(Matrix) * x(vektor) = b(vektor)
        // A == Widerstände (Resistance)
        // x == Stromstärke (Current)
        // b == Spannung (Voltage)

        // NuGet install MathNet ? 

        public static int num_of_rows, num_of_columns;

        // create a dense zero-matrix of length num_of_rows and width num_of_columns
        Matrix<double> resistance_matrix = Matrix<double>.Build.Dense(num_of_rows, num_of_columns);

        // create a dense zero-vector of length num_of_rows
        Vector<double> currents_vector = Vector<double>.Build.Dense(num_of_rows);
        Vector<double> voltage_vector = Vector<double>.Build.Dense(num_of_rows);


        /// <summary>
        /// a method for collecting each resistance and add it to the vector
        /// </summary>
        /// <returns>a filled matrix</returns>
        private Matrix<double> cultivating_resistances(Matrix<double> resistance_matrix,
            int num_of_rows, int num_of_columns)
        {
            for (int rows = 0;rows <= num_of_rows; rows++)
            {
                for (int columns = 0; columns <= num_of_columns; columns++)
                {

                }
            }

            return resistance_matrix;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Vector<double> cultivating_currents(Vector<double> currents_vector, int num_of_rows)
        {
            for (; ; )
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Vector<double> cultivating_voltages(Vector<double> voltages_vector, int num_of_rows)
        {
            for (; ; )
            {

            }
        }
    }

}
