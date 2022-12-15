using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerk_analysis
{
    /// <summary>
    /// 
    /// </summary>
    public class Resistance_W_a_R : IWriter<double[]>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly string _filename;
        private readonly Stream _fileStream;
        private readonly StreamWriter _streamWriter;
        private readonly StreamReader _streamReader;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public Resistance_W_a_R(string filename)
        {
            _filename = filename;
            Directory.CreateDirectory("Given_Values");
            _fileStream = new FileStream($"Given_Values/{filename}", FileMode.OpenOrCreate);
            _streamWriter = new StreamWriter(_filename);
            _streamReader = new StreamReader(_fileStream);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _streamWriter.Flush();
            _streamWriter.Dispose();
            _streamReader.Dispose();
            _fileStream.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resistances"></param>
        public void Write(double[] resistances)
        {
            foreach(double value in resistances)
            {
                _streamWriter.Write(value + ", ");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Read()
        {
            //
            string read_resistances = _streamReader.ReadToEnd();

            return  read_resistances;
        }
    }
}
