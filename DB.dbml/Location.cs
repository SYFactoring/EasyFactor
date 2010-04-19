//-----------------------------------------------------------------------
// <copyright file="Location.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class Location
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Location> _locationList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes static members of the Country class
        /// </summary>
        static Location()
        {
            DBDataContext context = new DBDataContext();
            context.ObjectTrackingEnabled = false;
            _locationList = context.Locations.ToList();
        }

        #endregion Constructors

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Location> AllLocations()
        {
            return _locationList;
        }

        #endregion Methods
    }
}
