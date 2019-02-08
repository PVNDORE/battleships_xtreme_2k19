using battleships_xtreme_2k19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.ViewModel
{
    public static class PlayerViewControl
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion


        #region StaticFunctions
        public static bool ShipPlacement(Ship ship, int x, int y, Player player, bool direction)
        {
            bool shipPlacement = false;
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Map map = player.PlayerMap;
            if (direction == true)
            {
                if (ship.Height + x < map.Size)
                {
                    if (ship.Width + y < map.Size)
                    {
                        for (int i = x; i < ship.Height + x; i++)
                        {
                            for (int j = y; j < ship.Width + y; j++)
                            {
                                if (map.Ocean[i, j].IsWater())
                                {
                                    Position shipPosition = new Position(alphabet[i], j);
                                    map.Ocean[i, j] = new SquareShip(false, shipPosition, ship.ShipValue);
                                }
                                else
                                {
                                    shipPlacement = false;
                                    break;
                                }
                            }
                            if (shipPlacement == false)
                            {
                                break;
                            }
                            shipPlacement = true;
                        }
                    }
                }
            }
            else
            {
                if (ship.Height + y < map.Size)
                {
                    if (ship.Width + x < map.Size)
                    {
                        for (int i = x; i < ship.Height + x; i++)
                        {
                            for (int j = y; j < ship.Width + y; j++)
                            {
                                if (map.Ocean[i, j].IsWater())
                                {
                                    Position shipPosition = new Position(alphabet[i], j);
                                    map.Ocean[i, j] = new SquareShip(false, shipPosition, ship.ShipValue);
                                }
                                else
                                {
                                    shipPlacement = false;
                                    break;
                                }
                            }
                            if (shipPlacement == false)
                            {
                                break;
                            }
                            shipPlacement = true;
                        }
                        
                    }
                }
            }
            return shipPlacement;
        }

        public static String TargetFire(Position position, Computer computer)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Map map = computer.PlayerMap;
            for (int i = 0; i < computer.PlayerMap.Size; i++)
            {
                for (int j = 0; j < computer.PlayerMap.Size; j++)
                {
                    if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[i, j].GotTargeted() == false)
                    {
                        map.Ocean[i, j].Targeted = true;
                        if (map.Ocean[i, j].IsWater())
                        {
                            computer.PlayerMap = map;
                            return "Vous avez tiré dans l'eau.";
                        }
                        else
                        {
                            computer.PlayerMap = map;
                            return "Vous avez touché un bateau!";
                        }
                    }
                    else if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[i, j].GotTargeted() == true)
                    {
                        return "Vous avez déjà tiré sur cette zone.";
                    }
                }
            }
            return "";
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
