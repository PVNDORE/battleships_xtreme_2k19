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
        private int carrierWidth;
        private int carrierHeight;
        private List<Ship> ships;
        private int mapSize;
        #endregion

        #region Properties
        public int CarrierWidth
        {
            get { return carrierWidth; }
            set { carrierWidth = value; }
        }

        public int CarrierHeight
        {
            get { return carrierHeight; }
            set { carrierHeight = value; }
        }

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
        public ConfigureShips()
        {
            
        }

        public ConfigureShips(int mapSize)
        {
            InitializeComponent();
            this.DataContext = this;
            this.mapSize = mapSize;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void BtnConfirmShip1_Click(object sender, RoutedEventArgs e)
        {

            Ship carrier = new Ship(ShipType.Carrier, carrierWidth, carrierHeight, false);
            this.Ships.Add(carrier);

            //Ship battleship = new Ship(ShipType.Battleship, widthBattleship, heightBattleship, false);
            //this.Ships.Add(battleship);
            //Ship submarine = new Ship(ShipType.Submarine, widthSubmarine, heightSubmarine, false);
            //this.Ships.Add(submarine);
            //Ship destroyer = new Ship(ShipType.Destroyer, widthDestroyer, heightDestroyer, false);
            //this.Ships.Add(destroyer);

            (this.Parent as Window).Content = new ShipPlacement(this.mapSize, this.Ships);
        
        }
        #endregion


    }
}
