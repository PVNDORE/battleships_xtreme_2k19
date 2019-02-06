using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public class SquareShip : ISquare
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private bool targeted;
        private Position coordonates;
        private int shipNumber;
        #endregion

        #region Properties
        public bool Targeted
        {
            get { return targeted; }
            set { targeted = value; }
        }
        public Position Coordonates
        {
            get { return coordonates; }
            set { coordonates = value; }
        }
        public int ShipNumber
        {
            get { return shipNumber; }
            set { shipNumber = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public SquareShip(bool targeted, Position coordonates, int shipNumber)
        {
            this.targeted = targeted;
            this.coordonates = coordonates;
            this.shipNumber = shipNumber;
        }

        public bool GotTargeted()
        {
            return this.Targeted;
        }

        public bool IsWater()
        {
            return false;
        }

        public int SquareValue()
        {
            return this.ShipNumber;
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
