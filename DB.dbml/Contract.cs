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
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                Regex regex = new Regex(@"^[^~!@#$%\\^&\\*\\+=\\?]+$");
                if (!regex.IsMatch(this.ContractCode))
                {
                    throw new ArgumentException("不符合保理合同编码规则");
                }
            }
        }
    }
}
