using battleships_xtreme_2k19.Models;
using battleships_xtreme_2k19.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace battleships_xtreme_2k19.UserControl
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : INotifyPropertyChanged
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private ISquare square;
        private int x;
        private int y;
        private String direction;
        private String color;
        private Ship shipSelected;
        private String btnName;
        #endregion

        #region Properties
        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public ISquare Square
        {
            get { return square; }
            set { square = value; }
        }
        public String BtnName
        {
            get { return btnName; }
            set { btnName = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public UserControl1(ISquare square, int x, int y)
        {
            InitializeComponent();
            this.DataContext = this;
            this.Square = square;
            this.X = x;
            this.Y = y;
            this.BtnName = x.ToString() + "." +  y.ToString();
            if (Square.IsWater())
            {
                this.Color = "Blue";
            }
            else
            {
                this.Color = "Black";
            }
            
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Position position = new Position(alphabet[this.X], this.Y);
            this.square = new SquareShip(false, position, 1);
            
        }
        #endregion

        #region Property changed implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
        
    }
}
