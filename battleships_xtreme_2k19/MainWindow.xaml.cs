﻿using battleships_xtreme_2k19.Database;
using battleships_xtreme_2k19.Models;
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

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
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
                using (var db = new ApplicationDbContext())
                {
                    db.MapDbSet.Add(map);

                    db.SaveChanges();

                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnReturnHomeOpt_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Hidden;
            Home.Visibility = Visibility.Visible;
        }
        #endregion


    }
}
