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
            this.player = player;
            this.computer = computer;
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
