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
        private int shipValue;
        private bool wasAShip;
        private int shipIntValue;
        #endregion

        #region Properties
        public bool WasAShip
        {
            get { return wasAShip; }
            set { wasAShip = value; }
        }
        public int ShipIntValue
        {
            get { return shipIntValue; }
            set { shipIntValue = value; }
        }
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
        public int ShipValue
        {
            get { return shipValue; }
            set { shipValue = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public SquareShip(bool targeted, Position coordonates, int shipValue)
        {
            this.targeted = targeted;
            this.coordonates = coordonates;
            this.shipValue = shipValue;
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
            return this.ShipValue;
        }
        public string GetString()
        {
            return this.shipValue+" ";
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
