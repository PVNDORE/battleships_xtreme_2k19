using battleships_xtreme_2k19.Database;
using battleships_xtreme_2k19.Models;
using battleships_xtreme_2k19.UserControl;
using battleships_xtreme_2k19.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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
        private Map map;
        private Ship shipSelected;
        // Carrier
        private Char carrierX;
        private Char carrierY;
        // Battleship
        private Char battleShipX;
        // Submarine
        private Char submarineX;
        // Destroyer
        private Char destroyerX;
        #endregion

        #region Properties
        // Carrier
        public Char CarrierX
        {
            get { return carrierX; }
            set { carrierX = value; }
        }
        public Char CarrierY
        {
            get { return carrierY; }
            set { carrierY = value; }
        }

        // Battleship
        public Char BattleShipX
        {
            get { return battleShipX; }
            set { battleShipX = value; }
        }
        // Submarine
        public Char SubmarineX
        {
            get { return submarineX; }
            set { submarineX = value; }
        }
        // Destroyer
        public Char DestroyerX
        {
            get { return destroyerX; }
            set { destroyerX = value; }
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
        public Map Map
        {
            get { return map; }
            set { map = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ShipPlacement()
        {
        }

        public ShipPlacement(int mapSize, List<Ship> ships)
        {
            InitializeComponent();
            this.DataContext = this;
            this.MapSize = mapSize;
            this.Ships = ships;
            
            this.Map = new Map(MapSize);
            this.GenerateMap();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void GenerateMap()
        {
            this.gameGrid.Children.Clear();
            this.gameGrid.ColumnDefinitions.Clear();
            this.gameGrid.RowDefinitions.Clear();

            for (int i = 0; i < MapSize; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                this.gameGrid.ColumnDefinitions.Add(col);
            }

            for (int i = 0; i < MapSize; i++)
            {
                RowDefinition row = new RowDefinition();
                this.gameGrid.RowDefinitions.Add(row);
            }
            
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                        UserControl1 uc1 = new UserControl1(this.map.Ocean[i,j], i, j);
                        Grid.SetColumn(uc1, i);
                        Grid.SetRow(uc1, j);

                        this.gameGrid.Children.Add(uc1);
                }
            }
           
        }
        #endregion

        #region Events
        private void BtnConfirmShipPlacement_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                db.MapDbSet.Add(this.map);

                db.SaveChanges();

                System.Console.WriteLine("--------------------");

                System.Console.WriteLine(this.map.ToString());
            }

            Map playerMap = new Map();
            Map computerMap = new Map();
            Player player = new Player(playerMap, this.Ships);
            Computer computer = new Computer(Difficulty.easy, computerMap, this.Ships);
            ComputerViewControl.ShipPlacement(computer);
            bool shipPlacement = false;
            foreach (var ship in Ships)
            {
                if (ship.ShipType == ShipType.Carrier)
                {
                    if (PlayerViewControl.ShipPlacement(ship, CarrierX, CarrierY, player))
                    {
                        shipPlacement = true;
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }
                if (ship.ShipType == ShipType.Battleship)
                {
                    if (PlayerViewControl.ShipPlacement(ship, BatlleShipX, BatlleShipY, player))
                    {
                        shipPlacement = true;
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }
                if (ship.ShipType == ShipType.Submarine)
                {
                    if (PlayerViewControl.ShipPlacement(ship, SubmarineX, SubmarineY, player))
                    {
                        shipPlacement = true;
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }
                if (ship.ShipType == ShipType.Destroyer)
                {
                    if (PlayerViewControl.ShipPlacement(ship, DestroyerX, DestroyerY, player))
                    {
                        shipPlacement = true;
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }

                
            }
            if (shipPlacement)
            {
                (this.Parent as Window).Content = new BattleShips(player, computer);
            }
            


        }
        #endregion
        
        
    }
}
