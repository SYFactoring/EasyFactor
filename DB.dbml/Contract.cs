//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Text.RegularExpressions;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Contract
    {
        private static readonly Regex ContractCodeRegex = new Regex(@"^[^~!@#$%\\^&\\*\\+=\\?]+$");
        //?Private?Methods?(1)?
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ContractCodeRegex.IsMatch(ContractCode))
                {
                    throw new ArgumentException("不符合保理合同编码规则: " + ContractCode);
                }
            }
        }
    }
}