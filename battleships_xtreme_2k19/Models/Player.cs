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
        private List<Ship> ships;
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
        public List<Ship> Ships
        {
            get { return ships; }
            set { ships = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player(String name, Map map, List<Ship> ships)
        {
            this.PlayerMap = map;
            this.Name = name;
            this.Ships = ships;
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
