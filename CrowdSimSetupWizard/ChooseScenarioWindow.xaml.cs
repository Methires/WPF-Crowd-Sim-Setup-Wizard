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
using System.Windows.Shapes;

namespace CrowdSimSetupWizard
{
    /// <summary>
    /// Interaction logic for ChooseScenarioWindow.xaml
    /// </summary>
    public partial class ChooseScenarioWindow : Window
    {
        public ChooseScenarioWindow()
        {
            InitializeComponent();
        }

        private void Prev_Step_Button_Click(object sender, RoutedEventArgs e)
        {
            ChooseActionsWindow actionsWindow = new ChooseActionsWindow();
            actionsWindow.Show();
            Close();
        }

        private void Next_StepButton_Click(object sender, RoutedEventArgs e)
        {
            ConfigureResultsWindow resultsWindow = new ConfigureResultsWindow();
            resultsWindow.Show();
            Close();
        }
    }
}
