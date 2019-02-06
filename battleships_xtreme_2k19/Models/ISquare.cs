using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Models
{
    public interface ISquare
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        bool IsWater();
        bool GotTargeted();
        int SquareValue();
        #endregion

        #region Events
        #endregion
    }
}
