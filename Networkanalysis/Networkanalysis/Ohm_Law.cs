using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networkanalysis
{
    internal class Ohm_Law
    {
        // U = R * I
        // U = Spannung (Voltage)
        // R = Widerstand (Resistance)
        // I = Stromstärke (Current)
        // Umstellmöglichkeiten: R = U/I, I=U/R,

        /// <summary>
        /// Calculation of the Voltage, when the Current an the Resistance is given
        /// </summary>
        /// <param name="current_given"></param>
        /// <param name="resistance_given"></param>
        /// <returns>a value for the Voltage with the datatype double</returns>
        internal double Calculating_Voltage(double current_given, double resistance_given)
        {
            double voltage = current_given * resistance_given;
            return voltage;
        }

        /// <summary>
        /// Calculation of the Current, when the Voltage an the Resistance is given
        /// </summary>
        /// <param name="voltage_given"></param>
        /// <param name="resistance_given"></param>
        /// <returns>a value for the Current with the datatype double</returns>
        internal double Calculating_Current(double voltage_given, double resistance_given)
        {
            double current = voltage_given / resistance_given;
            return current;
        }

        /// <summary>
        /// Calculation of the Resistance, when the Voltage an the Current is given
        /// </summary>
        /// <param name="voltage_given"></param>
        /// <param name="current_given"></param>
        /// <returns>a value for the Resistance with the datatype double</returns>
        internal double Calculating_Resistance(double voltage_given, double current_given)
        {
            double resistance = voltage_given / current_given;
            return resistance;
        }
    }
}
