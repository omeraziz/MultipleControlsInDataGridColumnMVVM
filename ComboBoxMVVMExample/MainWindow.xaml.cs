﻿using ComboBoxMVVMExample.View;
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

namespace ComboBoxMVVMExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // MVVM Instantiation
            //DataContext = new ComboBoxMVVMExample.ViewModel.ExampleViewModel();
        }

        private void BtnMetadata_Click(object sender, RoutedEventArgs e)
        {
            new TimesheetView().ShowDialog();
        }

        private void BtnHetrogeneousGrid_Click(object sender, RoutedEventArgs e)
        {
            // https://stackoverflow.com/questions/18154839/wpf-datagrid-with-different-usercontrol-in-each-cell

            new DynamicDataView().ShowDialog();
        }

        private void BtnDynamicCascadingComboInGrid_Click(object sender, RoutedEventArgs e)
        {
            new DynamicCascadingComboInGridView().ShowDialog();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            new TestWindow().ShowDialog();
        }
    }
}
