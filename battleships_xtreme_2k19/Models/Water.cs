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
        #endregion

        #region Properties
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
        public Water(bool targeted, Position coordonates)
        {
            this.targeted = targeted;
            this.coordonates = coordonates;
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
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
