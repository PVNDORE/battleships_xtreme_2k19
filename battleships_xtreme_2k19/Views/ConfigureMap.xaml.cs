using battleships_xtreme_2k19.Database;
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
        private int mapSize;

        #endregion

        #region Properties
        public int MapSize
        {
            get { return mapSize; }
            set { mapSize = value; }
        }
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
            if (this.MapSize > 4 && this.MapSize < 26)
            {
                (this.Parent as Window).Content = new ConfigureShips(this.mapSize);
            }
            else
            {
                System.Windows.MessageBox.Show("Veuillez entrer une taille de carte entre 5 et 26");
            }
            
        }
        #endregion
    }
}
