﻿using Networkanalysis;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Netzwerkanalyse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Resistences_Click(object sender, RoutedEventArgs e)
        {
            ChangeResistances changeResistances = new ChangeResistances();
            changeResistances.Show();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Filling_Matrix_and_Gaus gaus = new Filling_Matrix_and_Gaus();
            gaus.Calculating_Currents_meshes(Convert.ToDouble(R4x.Text), Convert.ToDouble(Uq1.Text));
        }
    }
}
