using battleships_xtreme_2k19.Models;
using battleships_xtreme_2k19.UserControl;
using battleships_xtreme_2k19.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    /// Logique d'interaction pour BattleShips.xaml
    /// </summary>
    public partial class BattleShips : Page
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private Player player;
        private Computer computer;
        private String coordinatesTarget;
        private List<ShipType> shipLeftPlayer;
        private List<ShipType> shipLeftComuputer;
        #endregion

        #region Properties
        public List<ShipType> ShipLeftComuputer
        {
            get { return shipLeftComuputer; }
            set { shipLeftComuputer = value; }
        }
        public List<ShipType> ShipLeftPlayer
        {
            get { return shipLeftPlayer; }
            set { shipLeftPlayer = value; }
        }
        public String CoordinatesTarget
        {
            get { return coordinatesTarget; }
            set { coordinatesTarget = value; }
        }
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
        public Computer Computer
        {
            get { return computer; }
            set { computer = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BattleShips()
        {
            InitializeComponent();
        }
        public BattleShips(Player player, Computer computer)
        {
            InitializeComponent();
            this.DataContext = this;
            this.Player = player;
            this.Computer = computer;
            GeneratePlayerMap(player.PlayerMap);
            GenerateComputerMap(computer.PlayerMap);
            this.ShipLeftPlayer = new List<ShipType>();
            this.ShipLeftComuputer = new List<ShipType>();
            ShipTypeLeft(this.Player, true);
            ShipTypeLeft(this.Computer, false);
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void ShipTypeLeft(Player player, bool human)
        {
            
            foreach (var ship in player.Ships)
            {
                if (human)
                {
                    this.shipLeftPlayer.Add(ship.ShipType);
                }
                else
                {
                    this.shipLeftComuputer.Add(ship.ShipType);
                }
            }
        }
        public void GeneratePlayerMap(Map map)
        {
            String display = "ok";
            this.playerGrid.Children.Clear();
            this.playerGrid.ColumnDefinitions.Clear();
            this.playerGrid.RowDefinitions.Clear();

            for (int i = 0; i < map.Size; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                this.playerGrid.ColumnDefinitions.Add(col);
            }

            for (int i = 0; i < map.Size; i++)
            {
                RowDefinition row = new RowDefinition();
                this.playerGrid.RowDefinitions.Add(row);
            }

            for (int i = 0; i < map.Size; i++)
            {
                for (int j = 0; j < map.Size; j++)
                {
                    
                    UserControl1 uc1 = new UserControl1(map.Ocean[i, j], i, j, display);
                    Grid.SetColumn(uc1, i);
                    Grid.SetRow(uc1, j);

                    this.playerGrid.Children.Add(uc1);
                }
            }

        }

        public void GenerateComputerMap(Map map)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.computerGrid.Children.Clear();
            this.computerGrid.ColumnDefinitions.Clear();
            this.computerGrid.RowDefinitions.Clear();

            for (int i = 0; i <= map.Size; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                this.computerGrid.ColumnDefinitions.Add(col);
            }

            for (int i = 0; i <= map.Size; i++)
            {
                RowDefinition row = new RowDefinition();
                this.computerGrid.RowDefinitions.Add(row);
            }

            for (int i = 0; i <= map.Size; i++)
            {
                for (int j = 0; j <= map.Size; j++)
                {
                    if (i == 0 && j == 0)
                    {

                    }
                    else if (i == 0)
                    {
                        String text = (j - 1) + "";
                        UserControl1 uc1 = new UserControl1(text);
                        Grid.SetColumn(uc1, i);
                        Grid.SetRow(uc1, j);

                        this.computerGrid.Children.Add(uc1);
                    }
                    else if (j == 0)
                    {
                        String text = alphabet[i - 1] + "";
                        UserControl1 uc1 = new UserControl1(text);
                        Grid.SetColumn(uc1, i);
                        Grid.SetRow(uc1, j);

                        this.computerGrid.Children.Add(uc1);
                    }
                    else 
                    {
                        UserControl1 uc1 = new UserControl1(map.Ocean[i - 1, j - 1], i - 1, j - 1, true);
                        Grid.SetColumn(uc1, i);
                        Grid.SetRow(uc1, j);

                        this.computerGrid.Children.Add(uc1);
                    }
                }
            }

        }

        public void ShipNumber(List<ShipType> shipList, Map map, bool player)
        {
            List<ShipType> shipTampon = new List<ShipType>();
            shipTampon = shipList;
            int carrierNumber = 0;
            int battleshipNumber = 0;
            int submarineNumber = 0;
            int destroyerNumber = 0;
            for (int i = 0; i < map.Size; i++)
            {
                for (int j = 0; j < map.Size; j++)
                {
                    if (map.Ocean[i, j].ShipIntValue.Equals(4))
                    {
                        carrierNumber++;
                    }
                    if (map.Ocean[i, j].ShipIntValue.Equals(3))
                    {
                        battleshipNumber++;
                    }
                    if (map.Ocean[i, j].ShipIntValue.Equals(2))
                    {
                        submarineNumber++;
                    }
                    if (map.Ocean[i, j].ShipIntValue.Equals(1))
                    {
                        destroyerNumber++;
                    }
                }
            }
            foreach (var ship in shipTampon)
            {
                switch (ship)
                {
                    case ShipType.Carrier:
                        if (carrierNumber == 0)
                        {
                            int index = shipTampon.IndexOf(ShipType.Carrier);
                            shipList.RemoveAt(index);
                            if (player)
                            {
                                System.Windows.MessageBox.Show("Votre Carrier a été coulé.");
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Vous avez coulé le Carrier de votre ennemi.");
                            }
                            
                        }
                        break;
                    case ShipType.Battleship:
                        if (battleshipNumber == 0)
                        {
                            int index = shipTampon.IndexOf(ShipType.Battleship);
                            shipList.RemoveAt(index);
                            if (player)
                            {
                                System.Windows.MessageBox.Show("Votre Battleship a été coulé.");
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Vous avez coulé le Battleship de votre ennemi.");
                            }

                        }
                        break;
                    case ShipType.Submarine:
                        if (submarineNumber == 0)
                        {
                            int index = shipTampon.IndexOf(ShipType.Submarine);
                            shipList.RemoveAt(index);
                            if (player)
                            {
                                System.Windows.MessageBox.Show("Votre Submarine a été coulé.");
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Vous avez coulé le Submarine de votre ennemi.");
                            }

                        }
                        break;
                    case ShipType.Destroyer:
                        if (destroyerNumber == 0)
                        {
                            int index = shipTampon.IndexOf(ShipType.Destroyer);
                            shipList.RemoveAt(index);
                            if (player)
                            {
                                System.Windows.MessageBox.Show("Votre Destroyer a été coulé.");
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Vous avez coulé le Destroyer de votre ennemi.");
                            }

                        }
                        break;
                }
                if (shipTampon.Count.Equals(0))
                {
                    if (player)
                    {
                        System.Windows.MessageBox.Show("Vous avez perdu!!");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Vous avez gagné!!");
                    }
                }
            }
        }
        #endregion

        #region Events
        #endregion

        private void btnConfirmtarget_Click(object sender, RoutedEventArgs e)
        {
            
            String yString = this.CoordinatesTarget.Substring(1);
            System.Console.WriteLine(yString);
            try
            {
                int y = Int32.Parse(yString);
                System.Console.WriteLine(y);
                Position target = new Position(this.CoordinatesTarget[0], y);
                PlayerViewControl.TargetFire(target, this.Computer);
                //ShipNumber(this.ShipLeftComuputer, this.Computer.PlayerMap, false);
                ComputerViewControl.IATargetFire(this.Player);
                //ShipNumber(this.ShipLeftPlayer, this.Player.PlayerMap, true);
                GeneratePlayerMap(this.Player.PlayerMap);
                GenerateComputerMap(this.Computer.PlayerMap);
            }
            catch (Exception)
            {

                System.Windows.MessageBox.Show("Veuillez entrer une cible valide. Les ingénieurs qui organisent le tir n'ont rien compris à votre demande.");
            }
            
            

        }
    }
}
