﻿using battleships_xtreme_2k19.Models;
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
        public static bool ShipPlacement(Ship ship, List<Position> positions, Player player)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Map map = player.PlayerMap;
            foreach (var position in positions)
            {
                for (int i = 0; i < player.PlayerMap.Size; i++)
                {
                    for (int j = 1; j < player.PlayerMap.Size; j++)
                    {
                        if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[alphabet[i], j].IsWater())
                        {
                            Position coordonates = new Position(alphabet[i], j);
                            map.Ocean[alphabet[i], j] = new SquareShip(false, coordonates, ship.ShipValue);
                        }
                        else if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[alphabet[i], j].IsWater() == false)
                        {
                            return false;
                        }
                    }
                }
            }
            player.PlayerMap = map;
            return true;
        }

        public static String TargetFire(Position position, Computer computer)
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Map map = computer.PlayerMap;
            for (int i = 0; i < computer.PlayerMap.Size; i++)
            {
                for (int j = 1; j < computer.PlayerMap.Size; j++)
                {
                    if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[alphabet[i], j].GotTargeted() == false)
                    {
                        map.Ocean[alphabet[i], j].Targeted = true;
                        if (map.Ocean[alphabet[i], j].IsWater())
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
                    else if (position.XPosition.Equals(alphabet[i]) && position.YPosition.Equals(j) && map.Ocean[alphabet[i], j].GotTargeted() == true)
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
