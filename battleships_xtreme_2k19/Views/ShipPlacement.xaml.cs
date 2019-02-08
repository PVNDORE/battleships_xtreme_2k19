using battleships_xtreme_2k19.Database;
using battleships_xtreme_2k19.Models;
using battleships_xtreme_2k19.UserControl;
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
        public UserControl1 Uc1
        {
            get { return this.Uc1; }
            set
            {
                this.Uc1 = value;
            }
        }
        #endregion

        #region Attributs

        private int mapSize;
        private List<Ship> ships;
        Grid grid = new Grid();
        private Map map;
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
            InitializeComponent();
            this.DataContext = this;
        }

        public ShipPlacement(int mapSize, List<Ship> ships)
        {
            InitializeComponent();
            this.DataContext = this;
            this.mapSize = mapSize;
            this.ships = ships;
            this.Uc1.DataContext = this.Uc1;
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

            Task.Factory.StartNew(() =>
            {
                Map map = new Map();
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new ThreadStart(delegate
                        {
                            UserControl1 uc1 = new UserControl1(map.Ocean[i,j]);

                            Grid.SetColumn(uc1, i);
                            Grid.SetRow(uc1, j);

                            this.gameGrid.Children.Add(uc1);
                        }));
                    }
                }
            });
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
        }
        #endregion
    }
}
