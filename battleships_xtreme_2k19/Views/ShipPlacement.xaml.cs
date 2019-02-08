﻿using battleships_xtreme_2k19.Database;
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
        // Carrier
        private int carrierX;
        private int carrierY;
        private bool carrierDirection;
        // Battleship
        private int battleShipX;
        private int battleShipY;
        private bool battleShipDirection;
        // Submarine
        private int submarineX;
        private int submarineY;
        private bool submarineDirection;
        // Destroyer
        private int destroyerX;
        private int destroyerY;
        private bool destroyerDirection;
        #endregion

        #region Properties
        // Carrier
        public int CarrierX
        {
            get { return carrierX; }
            set { carrierX = value; }
        }
        public int CarrierY
        {
            get { return carrierY; }
            set { carrierY = value; }
        }
        public bool CarrierDirection
        {
            get { return carrierDirection; }
            set { carrierDirection = value; }
        }
        // Battleship
        public int BattleShipX
        {
            get { return battleShipX; }
            set { battleShipX = value; }
        }
        public int BattleShipY
        {
            get { return battleShipY; }
            set { battleShipY = value; }
        }
        public bool BattleShipDirection
        {
            get { return battleShipDirection; }
            set { battleShipDirection = value; }
        }
        // Submarine
        public int SubmarineX
        {
            get { return submarineX; }
            set { submarineX = value; }
        }
        public int SubmarineY
        {
            get { return submarineY; }
            set { submarineY = value; }
        }
        public bool SubmarineDirection
        {
            get { return submarineDirection; }
            set { submarineDirection = value; }
        }
        // Destroyer
        public int DestroyerX
        {
            get { return destroyerX; }
            set { destroyerX = value; }
        }
        public int DestroyerY
        {
            get { return destroyerY; }
            set { destroyerY = value; }
        }
        public bool DestroyerDirection
        {
            get { return destroyerDirection; }
            set { destroyerDirection = value; }
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
            Map playerMap = this.Map;
            Map computerMap = this.Map;
            Player player = new Player(playerMap, this.Ships);
            Computer computer = new Computer(Difficulty.easy, computerMap, this.Ships);
            ComputerViewControl.ShipPlacement(computer);
            System.Console.WriteLine(computer.PlayerMap.ToString());
            bool shipPlacement = false;
            Console.WriteLine("test2");
            foreach (var ship in Ships)
            {
                if (ship.ShipType == ShipType.Carrier)
                {
                    if (PlayerViewControl.ShipPlacement(ship, CarrierX, CarrierY, player, CarrierDirection))
                    {
                        Console.WriteLine("CarrierY: "+CarrierY);
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
                    if (PlayerViewControl.ShipPlacement(ship, BattleShipX, BattleShipY, player, BattleShipDirection))
                    {
                        shipPlacement = true;
                        Console.WriteLine("CarrierY: " + BattleShipY);
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }
                if (ship.ShipType == ShipType.Submarine)
                {
                    if (PlayerViewControl.ShipPlacement(ship, SubmarineX, SubmarineY, player, SubmarineDirection))
                    {
                        shipPlacement = true;
                        Console.WriteLine("CarrierY: " + SubmarineY);
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }
                if (ship.ShipType == ShipType.Destroyer)
                {
                    if (PlayerViewControl.ShipPlacement(ship, DestroyerX, DestroyerY, player, DestroyerDirection))
                    {
                        shipPlacement = true;
                        Console.WriteLine("CarrierY: " + DestroyerY);
                    }
                    else
                    {
                        shipPlacement = false;
                        break;
                    }
                }

                
            }
            using (var db = new ApplicationDbContext())
            {
                db.MapDbSet.Add(this.map);

                db.SaveChanges();

                System.Console.WriteLine("--------------------");

                System.Console.WriteLine(this.map.ToString());
            }
            if (shipPlacement)
            {
                (this.Parent as Window).Content = new BattleShips(player, computer);
            }
            


        }
        #endregion
        
        
    }
}
