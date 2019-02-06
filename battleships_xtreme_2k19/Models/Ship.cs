using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public class Ship
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion
        #region Attributs
        private ShipType shipType;
        private int width;
        private int height;
        private bool isSink;
        private List<Position> shipPositions;
        private int value;
        #endregion

        #region Properties
        public int Value
        {
            get { return value; }
            set { value = value; }
        }
        public bool IsSink
        {
            get { return isSink; }
            set { isSink = value; }
        }
        public List<Position> ShipPositions
        {
            get { return shipPositions; }
            set { shipPositions = value; }
        }
        public ShipType ShipType
        {
            get { return shipType; }
            set { shipType = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Ship(ShipType shipType, int width, int height, bool isSink, int value)
        {
            this.shipType = shipType;
            this.width = width;
            this.height = height;
            this.isSink = isSink;
            switch (shipType)
            {
                case "Carrier":
                    this.Value = 4;
                    break;
                case "Battleship":
                    this.Value = 3;
                    break;
                case "Submarine":
                    this.Value = 2;
                    break;
                case "Destroyer":
                    this.Value = 1;
                    break;
            }
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
