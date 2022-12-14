using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;
using Netzwerkanalyse;
using System.Windows;
using System.Windows.Media.Media3D;

namespace Networkanalysis
{
    internal class Filling_Matrix_and_Gaus
    {
        // Gauß - Algorithmus nach form: A(Matrix) * x(vektor) = b(vektor)
        // A == Widerstände (Resistance)
        // x == Stromstärke (Current)
        // b == Spannung (Voltage)

        // NuGet install MathNet ? 

        /// <summary>
        /// A Method to fill up the matrix for the gaussian elimination method
        /// </summary>
        /// <returns></returns>
        public Matrix<double> Fill_up_resistances(double R4x)
        {
            Resistances data_resistance = new Resistances();

            double[] resistances_values = data_resistance.getInput();

            // Defining variables for simplicity
            double R1 = resistances_values[0];
            double R2 = resistances_values[1];
            double R3 = resistances_values[2];
            double R5 = resistances_values[3];
            double R6 = resistances_values[4];
            
            // cultivating the matrix
            var resistances = Matrix<double>.Build.DenseOfArray(new double[,] {
            { R1 + R2 + R3, R2, -R3 },
            { R2, R2 + R4x + R5, R4x },
            { -R3, R4x, R3 + R4x + R6 } });

            // MessageBox.Show(Convert.ToString(resistances));

            return resistances;
        }


        public Vector<double> Filling_up_Voltages(double Uq1)
        {
            var voltages = Vector<double>.Build.Dense(new double[] { Uq1, 0, 0});
            return voltages;
        }

        public Vector<double> Calculating_Currents_meshes(double R4x, double Uq1)
        {
            var currents_meshes = Fill_up_resistances(R4x).Solve(Filling_up_Voltages(Uq1));

            MessageBox.Show(Convert.ToString(currents_meshes));

            return currents_meshes;
        }
    }

}
