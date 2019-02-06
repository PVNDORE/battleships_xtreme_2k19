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
        private String xPosition;
        private int yPosition;
        #endregion

        #region Properties
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public String XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Position()
        {

        }
        public Position(string xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
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