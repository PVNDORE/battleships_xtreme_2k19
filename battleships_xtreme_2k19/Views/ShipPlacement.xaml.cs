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
    /// Logique d'interaction pour ShipPlacement.xaml
    /// </summary>
    public partial class ShipPlacement : Page
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int mapSize;
        private List<Ship> ships;
        Grid grid = new Grid();
        #endregion

        #region Properties
        public int MapSize
        {
            get { return mapSize; }
            set { mapSize = value; }
        }
        public List<Ship> Ships
        {
            get { return ships; }
            set { ships = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ShipPlacement()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public ShipPlacement(int mapSize, List<Ship> ships)
        {
            InitializeComponent();
            this.DataContext = this;
            this.mapSize = mapSize;
            this.ships = ships;
            for (int i = 0; i < MapSize; i++)
            {
                this.grid.ColumnDefinitions.Add(new ColumnDefinition());
                this.grid.RowDefinitions.Add(new RowDefinition());
            }
            foreach (var g in this.grid.RowDefinitions)
            {
                g.Height = new GridLength(100);
            }
            foreach(var g in this.grid.ColumnDefinitions)
            {
                g.Width = new GridLength(100);
            }
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion

    }
}
