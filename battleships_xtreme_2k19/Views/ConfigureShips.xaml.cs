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
    /// Logique d'interaction pour ConfigureShips.xaml
    /// </summary>
    public partial class ConfigureShips : Page
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int ship1Width;
        private int ship1Height;
        #endregion

        #region Properties
        public int Ship1Width
        {
            get { return ship1Width; }
            set { ship1Width = value; }
        }

        public int Ship1Height
        {
            get { return ship1Height; }
            set { ship1Height = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ConfigureShips()
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
        private void BtnConfirmShip1_Click(object sender, RoutedEventArgs e)
        {
            Ship ship1 = new Ship(0, ship1Width, ship1Height, false);
        }
        #endregion


    }
}
