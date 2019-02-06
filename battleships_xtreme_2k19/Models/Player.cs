using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public class Player
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String name;
        private Map mapPlacement;
        private Map mapTarget;
        #endregion

        #region Properties
        public Map MapTarget
        {
            get { return mapTarget; }
            set { mapTarget = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Map MapPlacement
        {
            get { return mapPlacement; }
            set { mapPlacement = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player()
        {

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
