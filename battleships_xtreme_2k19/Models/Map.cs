﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace battleships_xtreme_2k19.Models
{
    public class Map
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int size;
        public ISquare[][] Ocean;
        #endregion

        #region Properties
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Map(int size)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.size = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    Position coordonates = new Position(alphabet[i], j);
                    this.Ocean[i][j] = new Water(false, coordonates);
                }

            }
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public override string ToString()
        {
            String str = "";
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j <= this.size; j++)
                {
                    if (j == (this.size))
                    {
                        str = str + "\n";
                    }
                    else
                    {
                        str = str + this.Ocean[i][j].GetString();
                    }
                }
            }
            return str;
        }
        #endregion

        #region Events
        #endregion


    }
}