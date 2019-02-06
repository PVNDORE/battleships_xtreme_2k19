using System;

namespace battleships_xtreme_2k19.Models
{
    public class Position
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private char xPosition;
        private int yPosition;
        #endregion

        #region Properties
        public char XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Position(char xPosition, int yPosition)
        {
            this.XPosition = xPosition;
            this.YPosition = yPosition;
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