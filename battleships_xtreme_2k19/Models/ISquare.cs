﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public interface ISquare
    {
        bool Targeted
        {
            get;
            set;
        }
        bool WasAShip
        {
            get;
            set;
        }
        Position Coordonates
        {
            get;
            set;
        }
        int ShipIntValue
        {
            get;
            set;
        }
        bool IsWater();
        bool GotTargeted();
        int SquareValue();
        String GetString();
    }
}
