using battleships_xtreme_2k19.Models;
using battleships_xtreme_2k19.UserControl;
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
        
        #endregion

        #region Properties
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
                    UserControl1 uc1 = new UserControl1(map.Ocean[i, j], i, j);
                    Grid.SetColumn(uc1, i);
                    Grid.SetRow(uc1, j);

                    this.playerGrid.Children.Add(uc1);
                }
            }

        }

        public void GenerateComputerMap(Map map)
        {
            this.computerGrid.Children.Clear();
            this.computerGrid.ColumnDefinitions.Clear();
            this.computerGrid.RowDefinitions.Clear();

            for (int i = 0; i < map.Size; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                this.computerGrid.ColumnDefinitions.Add(col);
            }

            for (int i = 0; i < map.Size; i++)
            {
                RowDefinition row = new RowDefinition();
                this.computerGrid.RowDefinitions.Add(row);
            }

            for (int i = 0; i < map.Size; i++)
            {
                for (int j = 0; j < map.Size; j++)
                {
                    UserControl1 uc1 = new UserControl1(map.Ocean[i, j], i, j);
                    Grid.SetColumn(uc1, i);
                    Grid.SetRow(uc1, j);

                    this.computerGrid.Children.Add(uc1);
                }
            }

        }
        #endregion

        #region Events
        #endregion

    }
}
