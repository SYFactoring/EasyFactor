//-----------------------------------------------------------------------
// <copyright file="Case.cs" company="Yiming Liu@Fudan">
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
    public partial class Case : BaseObject
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<string> allTransTypes;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes static members of the Case class
        /// </summary>
        static Case()
        {
            allTransTypes = new List<string>();
            allTransTypes.Add("国内卖方保理");
            allTransTypes.Add("国内买方保理");
            allTransTypes.Add("出口保理");
            allTransTypes.Add("进口保理");
            allTransTypes.Add("国内信保保理");
            allTransTypes.Add("国际信保保理");
            allTransTypes.Add("租赁保理");
        }

        #endregion Constructors

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> ConstantTransTypes()
        {
            return allTransTypes;
        }

        #endregion Methods
    }
}
