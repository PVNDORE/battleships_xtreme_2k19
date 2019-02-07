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

namespace battleships_xtreme_2k19.Views
{
    /// <summary>
    /// Logique d'interaction pour ConfigureMap.xaml
    /// </summary>
    public partial class ConfigureMap : Page
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
        public ConfigureMap()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void BtnConfirmMapSize_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map(mapSize);
            using (var db = new ApplicationDbContext())
            {
                db.MapDbSet.Add(map);

                db.SaveChanges();

                System.Console.WriteLine("--------------------");

                System.Console.WriteLine(map.ToString());
            }

            // vérifier que map existe
            (this.Parent as Window).Content = new ConfigureShips();
        }
        #endregion
    }
}
