using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkanalyse
{
    internal class Resistances
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resistances"></param>
        public void write(double[] resistances)
        {
            using (var sr = new StreamWriter("resistances.dat"))
            {
                foreach (int value in resistances)
                {
                    sr.Write(value + ", ");
                }
           }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string readFile()
        {
            try
            {
                using(var sr = new StreamReader("resistances.dat"))
                {
                    string array = sr.ReadToEnd();
                    return array;
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("The File could not be read: ");
                Console.WriteLine(e.Message);
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double[] getInput()
        {
            //
            string file = readFile();
            string[] string_resistances = file.Split(",");
            double[] resistances = new double[string_resistances.Length - 1];

            //
            for(int i = 0; i < resistances.Length; i++)
            {
                resistances[i] = double.Parse(string_resistances[i]);
            }

            return resistances;
        }
    }
}
