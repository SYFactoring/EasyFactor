//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Data.Linq;
using System.Text.RegularExpressions;
using System;
namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Contract : BaseObject
    {
        private static Regex ContractCodeRegex = new Regex(@"^[^~!@#$%\\^&\\*\\+=\\?]+$");

        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ContractCodeRegex.IsMatch(this.ContractCode))
                {
                    throw new ArgumentException("不符合保理合同编码规则");
                }
            }
        }
    }
}
