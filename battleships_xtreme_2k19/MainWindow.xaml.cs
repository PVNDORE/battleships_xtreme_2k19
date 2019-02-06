﻿using battleships_xtreme_2k19.Models;
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

namespace battleships_xtreme_2k19
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Hidden;
            Play.Visibility = Visibility.Visible;
        }

        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Hidden;
            Options.Visibility = Visibility.Visible;
        }

        private void BtnConfirmMapSize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = Int32.Parse(this.mapSize.Text);
                Map map = new Map(size);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }            
        }
    }
}
