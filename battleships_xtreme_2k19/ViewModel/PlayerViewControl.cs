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
        public bool ShipPlacement(Ship ship, List<Position> positions, Player player)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Map map = player.PlayerMap;
            foreach (var position in positions)
            {
                for (int i = 0; i < this.humanPlayer.PlayerMap.Size; i++)
                {
                    for (int j = 1; j < this.humanPlayer.PlayerMap.Size; j++)
                    {
                        if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[alphabet[i],j].IsWater())
                        {
                            Position coordonates = new Position(alphabet[i], j);
                            map.Ocean[alphabet[i],j] = new SquareShip(false, coordonates, ship.ShipValue);
                        }
                        else if (!map.Ocean[alphabet[i], j].IsWater())
                        {
                            return false;
                        }
                    }
                }
            }
            player.PlayerMap = map;
            return true;
            
        }
        #endregion

        #region Events
        #endregion


    }
}
