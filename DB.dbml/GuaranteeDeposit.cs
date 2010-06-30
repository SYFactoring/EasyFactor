//-----------------------------------------------------------------------
// <copyright file="GuaranteeDeposit.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    partial class GuaranteeDeposit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (TypeUtil.LessZero(GuaranteeDepositAmount))
                {
                    throw new Exception(String.Format("保证金金额{0:N2}不能为负: {1}", GuaranteeDepositAmount,
                                 GuaranteeDepositID));
                }
            }
        }
    }
}
