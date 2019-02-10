using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public class Water : ISquare
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
        private bool wasAShip;
        private int shipIntValue;
        #endregion

        #region Properties
        public int ShipIntValue
        {
            get { return shipIntValue; }
            set { shipIntValue = value; }
        }
        public bool WasAShip
        {
            get { return wasAShip; }
            set { wasAShip = value; }
        }
        public Position Coordonates
        {
            get { return coordonates; }
            set { coordonates = value; }
        }
        public bool Targeted
        {
            get { return targeted; }
            set { targeted = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Water(bool targeted, Position coordonates, bool wasAship)
        {
            this.Targeted = targeted;
            this.Coordonates = coordonates;
            this.WasAShip = false;
        }

        public bool GotTargeted()
        {
            return this.Targeted;
        }

        public bool IsWater()
        {
            return true;
        }

        public int SquareValue()
        {
            return 0;
        }

        public string GetString()
        {
            return "0 ";
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
