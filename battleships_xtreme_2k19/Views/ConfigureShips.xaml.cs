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
        // Carrier
        private int carrierWidth;
        private int carrierHeight;
        // Battleship
        private int battleshipWidth;
        private int battleshipHeight;
        // Submarine
        private int submarineWidth;
        private int submarineHeight;
        // Destroyer
        private int destroyerWidth;
        private int destroyerHeight;

        private List<Ship> ships;
        private int mapSize;
        #endregion

        #region Properties
        // Carrier
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
        // Battleship
        public int BattleshipWidth
        {
            get { return battleshipWidth; }
            set { battleshipWidth = value; }
        }
        public int BattleshipHeight
        {
            get { return battleshipHeight; }
            set { battleshipHeight = value; }
        }
        // Submarine
        public int SubmarineWidth
        {
            get { return submarineWidth; }
            set { submarineWidth = value; }
        }
        public int SubmarineHeight
        {
            get { return submarineHeight; }
            set { submarineHeight = value; }
        }
        // Destroyer
        public int DestroyerWidth
        {
            get { return destroyerWidth; }
            set { destroyerWidth = value; }
        }
        public int DestroyerHeight
        {
            get { return destroyerHeight; }
            set { destroyerHeight = value; }
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
            this.Ships = new List<Ship>();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void BtnConfirmShips_Click(object sender, RoutedEventArgs e)
        {
            int nbrEmpty = this.MapSize * this.MapSize;
            int nbrShip = (this.CarrierWidth * this.CarrierWidth) + (this.BattleshipHeight * this.BattleshipWidth) + (this.SubmarineHeight * this.SubmarineWidth) + (this.DestroyerHeight * this.DestroyerWidth);
            if ((this.CarrierWidth * this.CarrierWidth) == 0 || (this.BattleshipHeight * this.BattleshipWidth) == 0 || (this.SubmarineHeight * this.SubmarineWidth) == 0 || (this.DestroyerHeight * this.DestroyerWidth) == 0)
            {
                System.Windows.MessageBox.Show("Un de vos bateaux est invisible, il va être dur à placer...");
            }
            else
            {
                if (nbrEmpty > nbrShip)
                {
                    // Carrier
                    Ship carrier = new Ship(ShipType.Carrier, this.CarrierWidth, this.CarrierHeight, false);
                    this.Ships.Add(carrier);
                    // Battleship
                    Ship battleship = new Ship(ShipType.Battleship, this.BattleshipWidth, this.BattleshipHeight, false);
                    this.Ships.Add(battleship);
                    // Submarine
                    Ship submarine = new Ship(ShipType.Submarine, this.SubmarineWidth, this.SubmarineHeight, false);
                    this.Ships.Add(submarine);
                    // Destroyer
                    Ship destroyer = new Ship(ShipType.Destroyer, this.DestroyerWidth, this.DestroyerHeight, false);
                    this.Ships.Add(destroyer);

                    (this.Parent as Window).Content = new ShipPlacement(this.mapSize, this.Ships);

                }
                else
                {
                    System.Windows.MessageBox.Show("Vos bateaux sont trop gros, ils dépassent la taille de l'océan.");
                }
            }
            
            
        
        }
        #endregion


    }
}
