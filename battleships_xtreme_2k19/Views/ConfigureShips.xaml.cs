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
        private List<Ship> ships;
        
        #endregion

        #region Properties
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
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void BtnConfirmShip1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = 10;
                Map map = new Map(size);

                int heightCarrier = Int32.Parse(this.CarrierHeight.Text);
                int widthCarrier = Int32.Parse(this.CarrierWidth.Text);
                Ship carrier = new Ship(0, widthCarrier, heightCarrier, false);
                
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        #endregion


    }
}
