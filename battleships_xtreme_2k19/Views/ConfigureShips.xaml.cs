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
        private List<Ship> ships;
        private int mapSize;
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
        public ConfigureShips()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public ConfigureShips(int mapSize)
        {
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
            Ship ship1 = new Ship(0, ship1Width, ship1Height, false);
            try
            {

                int heightCarrier = Int32.Parse(this.CarrierHeight.Text);
                int widthCarrier = Int32.Parse(this.CarrierWidth.Text);
                int heightBattleship = Int32.Parse(this.BattleshipHeight.Text);
                int widthBattleship = Int32.Parse(this.BattleshipWidth.Text);
                int heightSubmarine = Int32.Parse(this.SubmarineHeight.Text);
                int widthSubmarine = Int32.Parse(this.SubmarineWidth.Text);
                int heightDestroyer = Int32.Parse(this.DestroyerHeight.Text);
                int widthDestroyer = Int32.Parse(this.DestroyerWidth.Text);
                Ship carrier = new Ship(ShipType.Carrier, widthCarrier, heightCarrier, false);
                this.Ships.Add(carrier);
                Ship battleship = new Ship(ShipType.Battleship, widthBattleship, heightBattleship, false);
                this.Ships.Add(battleship);
                Ship submarine = new Ship(ShipType.Submarine, widthSubmarine, heightSubmarine, false);
                this.Ships.Add(submarine);
                Ship destroyer = new Ship(ShipType.Destroyer, widthDestroyer, heightDestroyer, false);
                this.Ships.Add(destroyer);
                (this.Parent as Window).Content = new ShipPlacement(this.mapSize, this.Ships);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        #endregion


    }
}
