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
            List<Position> positions = new List<Position>();
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
                            shipPlacement = true;
                        }
                        
                    }
                }
            }
            if (shipPlacement)
            {
                ship.ShipPositions = positions;
            }
            return shipPlacement;
        }

        public static bool TargetFire(Position position, Computer computer)
        {
            bool placementOk = false;
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
            int xPosition = alphabet.LastIndexOf(position.XPosition);
            Map map = computer.PlayerMap;
            if (xPosition >= 0 && xPosition < 26)
            {
                System.Console.WriteLine("y: "+position.YPosition);
                System.Console.WriteLine("mapsize: " + map.Size);
                if (position.YPosition > 0 || position.YPosition <= map.Size)
                {
                    if (map.Ocean[xPosition, position.YPosition].GotTargeted() == false)
                    {
                        map.Ocean[xPosition, position.YPosition].Targeted = true;
                        if (!map.Ocean[xPosition, position.YPosition].IsWater())
                        {
                            map.Ocean[xPosition, position.YPosition].WasAShip = true;
                            map.Ocean[xPosition, position.YPosition].ShipIntValue = 0;
                        }
                        placementOk = true;

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Vous avez déjà tiré dans cette zone.");
                    }

                }
                else
                {
                    System.Windows.MessageBox.Show("Veuillez entrer une cible valide. Votre chiffre sort des limites du tableau.");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Veuillez entrer une cible valide. avec la première coordonnée en majuscule");
            }
            computer.PlayerMap = map;
            return placementOk;
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
