﻿using System;
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

namespace Questionnaire
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        public Results()
        {
            InitializeComponent();
            LoadPieChartData();
        }
        private void LoadPieChartData()
        {
            ((System.Windows.Controls.DataVisualization.Charting.PieSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("Project Manager", 12),
            new KeyValuePair<string, int>("CEO", 25),
            new KeyValuePair<string, int>("Software Engg.", 5),
            new KeyValuePair<string, int>("Team Leader", 6),
            new KeyValuePair<string, int>("Project Leader", 10),
            new KeyValuePair<string, int>("Developer", 4) };
        }
    }
}
