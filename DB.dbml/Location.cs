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
		#region?Fields?(1)?

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Location> _locationList = InitializeLocation();

		#endregion?Fields?

		#region?Properties?(1)?

        /// <summary>
        /// 
        /// </summary>
        public static List<Location> AllLocations
        {
            get
            {
                return _locationList.ToList();
            }
        }

		#endregion?Properties?

		#region?Methods?(1)?

		//?Private?Methods?(1)?

        /// <summary>
        /// Initializes static members of the Country class
        /// </summary>
        static List<Location> InitializeLocation()
        {
            DBDataContext context = new DBDataContext();
            context.ObjectTrackingEnabled = false;
            return context.Locations.ToList();
        }

		#endregion?Methods?
    }
}
