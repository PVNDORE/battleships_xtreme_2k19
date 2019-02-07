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
        #endregion

        #region Properties
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
                int size = Int32.Parse(this.Ship1Height.Text);
                Map map = new Map(size);

                int height = Int32.Parse(this.Ship1Height.Text);
                int width = Int32.Parse(this.Ship1Width.Text);

                Ship ship1 = new Ship(0, width, height, false);

            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        #endregion


    }
}
