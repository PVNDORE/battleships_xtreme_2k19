using battleships_xtreme_2k19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.ViewModel
{
    public static class ComputerViewControl
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion
        
        #region StaticFunctions
        public static void ShipPlacement(Computer computer)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            foreach (var ship in computer.Ships)
            {
                Map map = computer.PlayerMap;
                bool shipPlacement = false;
                while (shipPlacement == false)
                {
                    int x = rand.Next(computer.PlayerMap.Size);
                    int y = rand.Next(1, computer.PlayerMap.Size + 1);
                    int direction = rand.Next(2);
                    if (direction == 0)
                    {
                        if (ship.Height + x < computer.PlayerMap.Size)
                        {
                            if (ship.Width + y < computer.PlayerMap.Size)
                            {
                                for (int i = x; i < ship.Height + x; i++)
                                {
                                    for (int j = y; j < ship.Width + y; j++)
                                    {
                                        if (map.Ocean[alphabet[i], j].IsWater())
                                        {
                                            Position shipPosition = new Position(alphabet[i], j);
                                            map.Ocean[alphabet[i], j] = new SquareShip(false, shipPosition, ship.ShipValue);
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
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ship.Height + y < computer.PlayerMap.Size)
                        {
                            if (ship.Width + x < computer.PlayerMap.Size)
                            {
                                for (int i = x; i < ship.Height + x; i++)
                                {
                                    for (int j = y; j < ship.Width + y; j++)
                                    {
                                        if (map.Ocean[alphabet[i], j].IsWater())
                                        {
                                            Position shipPosition = new Position(alphabet[i], j);
                                            map.Ocean[alphabet[i], j] = new SquareShip(false, shipPosition, ship.ShipValue);
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
                                }
                            }
                        }
                    }
                }
                if (shipPlacement)
                {
                    computer.PlayerMap = map;
                }
            }
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
