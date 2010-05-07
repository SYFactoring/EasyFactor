//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Data.Linq;
    using System.Text.RegularExpressions;
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class Contract
    {
		#region?Fields?(1)?

        private static Regex ContractCodeRegex = new Regex(@"^[^~!@#$%\\^&\\*\\+=\\?]+$");

		#endregion?Fields?

		#region?Methods?(1)?

		//?Private?Methods?(1)?

        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ContractCodeRegex.IsMatch(this.ContractCode))
                {
                    throw new ArgumentException("不符合保理合同编码规则: " + this.ContractCode);
                }
            }
        }

		#endregion?Methods?
    }
}
