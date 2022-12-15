using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerk_analysis
{
    // 1. Data Gathering -> read File + User_input Main Window
    // 2. Data Manipulation -> Create Matrix | Create Vector -> Vector/ Array -> Currents in Mesh
    // 3. Currents in Mesh -> Currents in Junction
    // 4. Junction Comparision -> bool questioning
    // 5. Calculate Voltages at each Resistor -> Ohm´s Law
    // 6. Output -> Window | File | Image in MainWindow


    // Interface for Data Gathering -> Reading and Writing File and gathering MainWindow informations
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetData();
    }

    // Interface for Manipulation Data -> Currents in Junctions
    public interface IManipulator<T, V>
    {
        V Manipulate(T data);
    }

    // Interface for Data output
    public interface IWriter<T>
    {
        void Write(T data);
        string Read();
    }
}
