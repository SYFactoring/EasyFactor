//-----------------------------------------------------------------------
// <copyright file="BaseObject.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    public class BaseObject
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private List<object> _status;

        #endregion Fields

        #region Methods (2)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        public void Backup()
        {
            this._status = new List<object>();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (p.CanWrite && p.PropertyType.IsSerializable)
                {
                    var value = p.GetValue(this, null);
                    this._status.Add(value);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Restore()
        {
            if (this._status != null)
            {
                PropertyInfo[] props = this.GetType().GetProperties();
                int i = 0;
                foreach (PropertyInfo p in props)
                {
                    if (p.CanWrite && p.PropertyType.IsSerializable)
                    {
                        var value = this._status[i++];
                        p.SetValue(this, value, null);
                    }
                }
            }
        }

        #endregion Methods
    }
}
