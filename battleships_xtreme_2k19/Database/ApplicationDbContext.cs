﻿using battleships_xtreme_2k19.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_xtreme_2k19.Database
{
    public class ApplicationDbContext : DbContext
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private DbSet<Map> maps;
        //private DbSet<Turn> turns;
        #endregion

        #region Properties
        public DbSet<Map> MapDbSet
        {
            get { return maps; }
            set { maps = value; }
        }

        //public DbSet<Turn> TurnDbSet
        //{
          //  get { return turns; }
            //set { turns = value; }
        //}
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ApplicationDbContext()
        {
            DevResetDatabase();
        }
        #endregion

        #region StaticFunctions
        private void DevResetDatabase()
        {
            if (!this.Database.CompatibleWithModel(false))
            {
                this.Database.Delete();
                this.Database.Create();
            }
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
