using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public class Computer : Player
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private Difficulty computerDifficulty;



        #endregion

        #region Properties
        public Difficulty ComputerDifficulty
        {
            get { return computerDifficulty; }
            set { computerDifficulty = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Computer(Difficulty computerDifficulty, String name, Map map) : base (name, map)
        {
            this.computerDifficulty = computerDifficulty;
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
