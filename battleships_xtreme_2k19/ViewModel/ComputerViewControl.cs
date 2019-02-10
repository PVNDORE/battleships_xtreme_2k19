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
                List<Position> positions = new List<Position>();
                Console.WriteLine(ship.ShipType);
                Map map = computer.PlayerMap;
                bool shipPlacement = false;
                while (shipPlacement == false)
                {
                    int x = rand.Next(computer.PlayerMap.Size);
                    int y = rand.Next(computer.PlayerMap.Size);
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
                                        if (map.Ocean[i, j].IsWater())
                                        {
                                            Position shipPosition = new Position(alphabet[i], j);
                                            map.Ocean[i, j] = new SquareShip(false, shipPosition, ship.ShipValue);
                                            shipPlacement = true;
                                            positions.Add(shipPosition);
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
                                shipPlacement = true;
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
                                        if (map.Ocean[i, j].IsWater())
                                        {
                                            Position shipPosition = new Position(alphabet[i], j);
                                            map.Ocean[i, j] = new SquareShip(false, shipPosition, ship.ShipValue);
                                            shipPlacement = true;
                                            positions.Add(shipPosition);
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
                                shipPlacement = true;
                            }
                        }
                    }
                }
                if (shipPlacement)
                {
                    computer.PlayerMap = map;
                    ship.ShipPositions = positions;
                }
            }
        }

        public static Position IATargetFire(Player player)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            bool process = true;
            Map map = player.PlayerMap;
            while (process)
            {
                int x = rand.Next(map.Size);
                int y = rand.Next(map.Size);
                if (map.Ocean[x, y].GotTargeted() == false)
                {
                    map.Ocean[x, y].Targeted = true;
                    process = false;
                    Position positionTarget = new Position(alphabet[x],y);
                    return positionTarget;
                }
            }
            player.PlayerMap = map;
            Position positionReturn = new Position('A',0);
            return positionReturn;
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
