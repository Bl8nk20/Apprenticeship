using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Netzwerk_analysis
{
    /// <summary>
    /// Interaktionslogik für Resistances_change_window.xaml
    /// </summary>
    public partial class Resistances_change_window : Window
    {
        public Resistances_change_window()
        {
            InitializeComponent();
        }

        // Write the resistance Values to an array
        private double[] GetInput()
        {
            double[] input = new double[5];
            try
            {
                input[0] = Convert.ToDouble(R1.Text);
                input[1] = Convert.ToDouble(R2.Text);
                input[2] = Convert.ToDouble(R3.Text);
                input[3] = Convert.ToDouble(R5.Text);
                input[4] = Convert.ToDouble(R6.Text);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return input;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resistance_W_a_R resistance_W = new Resistance_W_a_R("resistances_input.dat");
            resistance_W.Write(GetInput());
            Close();
        }
    }
}
