using battleships_xtreme_2k19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.ViewModel
{
    class PlayerViewControl
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private Player humanPlayer;
        #endregion

        #region Properties

        public Player HumanPlayer
        {
            get { return humanPlayer; }
            set { humanPlayer = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PlayerViewControl(Player humanPlayer)
        {
            this.HumanPlayer = humanPlayer;
                
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void ShipPlacement(Ship ship, List<Position> positions)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var position in positions)
            {
                for (int i = 0; i < this.humanPlayer.PlayerMap.Size; i++)
                {
                    for (int j = 1; j < this.humanPlayer.PlayerMap.Size; j++)
                    {
                       
                    }
                }
            }
            
            
        }
        #endregion

        #region Events
        #endregion


    }
}
