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


        #endregion

        #region Properties
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
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
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

        public void ShipNumber(Player gamer, Position target, bool player)
        {
            List<Ship> shipsTampon = new List<Ship>();
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int xTarget = alphabet.LastIndexOf(target.XPosition);
            shipsTampon = gamer.Ships;
            foreach (var ship in shipsTampon)
            {
                if (gamer.PlayerMap.Ocean[xTarget, target.YPosition].SquareValue() == 4)
                {
                    ship.NbrSquare--;
                    if (ship.NbrSquare == 0)
                    {
                        int index = gamer.Ships.IndexOf(ship);
                        gamer.Ships.RemoveAt(index);
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
                }
                if (gamer.PlayerMap.Ocean[xTarget, target.YPosition].SquareValue() == 3)
                {
                    ship.NbrSquare--;
                    if (ship.NbrSquare == 0)
                    {
                        int index = gamer.Ships.IndexOf(ship);
                        gamer.Ships.RemoveAt(index);
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
                }
                if (gamer.PlayerMap.Ocean[xTarget, target.YPosition].SquareValue() == 2)
                {
                    ship.NbrSquare--;
                    if (ship.NbrSquare == 0)
                    {
                        int index = gamer.Ships.IndexOf(ship);
                        gamer.Ships.RemoveAt(index);
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
                }
                if (gamer.PlayerMap.Ocean[xTarget, target.YPosition].SquareValue() == 1)
                {
                    ship.NbrSquare--;
                    if (ship.NbrSquare == 0)
                    {
                        int index = gamer.Ships.IndexOf(ship);
                        gamer.Ships.RemoveAt(index);
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
                if (gamer.PlayerMap.Ocean[xTarget, target.YPosition].SquareValue() == 0)
                {
                    break;
                }
                    System.Console.WriteLine("random count :" + gamer.Ships.Count);
            }
            if (gamer.Ships.Count == 0)
            {
                if (player)
                {
                    System.Windows.MessageBox.Show("Votre avez perdu!! Rekt par un PC en mode easy...");
                }
                else
                {
                    System.Windows.MessageBox.Show("Vous avez gagné!! Vous enflammez pas non plus c'était en mode easy...");
                }

            }

        }
        #endregion

        #region Events
        #endregion

        private void btnConfirmtarget_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String yString = this.CoordinatesTarget.Substring(1);
                try
                {
                    int y = Int32.Parse(yString);
                    Position target = new Position(this.CoordinatesTarget[0], y);
                    PlayerViewControl.TargetFire(target, this.Computer);
                    this.ShipNumber(this.Computer, target, false);
                    System.Console.WriteLine("PC count :"+this.Computer.Ships.Count);
                    if (this.Computer.Ships.Count != 0)
                    {
                        target = ComputerViewControl.IATargetFire(this.Player);
                        this.ShipNumber(this.Player, target, true);
                        GeneratePlayerMap(this.Player.PlayerMap);
                        GenerateComputerMap(this.Computer.PlayerMap);
                        System.Console.WriteLine("human count :" + this.Player.Ships.Count);
                    }
                    
                }
                catch (Exception)
                {

                    System.Windows.MessageBox.Show("Vos ingénieurs vont avoir du mal à savoir où viser si vous ne donnez qu'une seule coordonée.");
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Veuillez entrer une cible valide. Les ingénieurs qui organisent le tir n'ont rien compris à votre demande.");

            }
        }
    }
}
