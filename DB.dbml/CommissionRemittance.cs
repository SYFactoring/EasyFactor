//-----------------------------------------------------------------------
// <copyright file="CommissionRemittance.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    partial class CommissionRemittance
    {
        /// <summary>
        /// 
        /// </summary>
        public int BatchCount
        {
            get
            {
                return InvoiceAssignBatches.Count;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyName
        {
            get
            {
                return Factor.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (TypeUtil.LessZero(MsgAmount))
                {
                    throw new Exception(String.Format("消息金额{0:N2}不能为负: {1}", MsgAmount, MsgType));
                }

                if(TypeUtil.LessZero(RemitAmount))
                {
                    throw new Exception(String.Format("回复金额{0:N2}不能为负: {1}", MsgAmount, MsgType));
                }
            }
        }
    }
}
