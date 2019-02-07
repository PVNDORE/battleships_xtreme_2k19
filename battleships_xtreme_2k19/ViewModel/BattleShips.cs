using battleships_xtreme_2k19.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.ViewModel
{
    public class BattleShips
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private ConfigureMap configMap;
        private ConfigureShips configShips;
        #endregion

        #region Properties
        public ConfigureMap ConfigMap
        {
            get { return configMap; }
            set { configMap = value; }
        }
        public ConfigureShips ConfigShips
        {
            get { return configShips; }
            set { configShips = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BattleShips()
        {
            
        }
        public BattleShips(ConfigureMap configMap, ConfigureShips configShips)
        {
            this.configMap = configMap;
            this.configShips = configShips;
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
