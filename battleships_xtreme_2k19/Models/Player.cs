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
        private Map playerMap;
        
        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Map PlayerMap
        {
            get { return playerMap; }
            set { playerMap = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player(String name)
        {
            this.name = name;
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
