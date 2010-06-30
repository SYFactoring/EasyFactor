//-----------------------------------------------------------------------
// <copyright file="FactorCreditLine.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FactorCreditLine
    {
        /// <summary>
        /// Gets �˿����
        /// </summary>
        public double CreditLineAssignOutstanding
        {
            get { return CreditLine - Factor.GetAssignOutstanding(CreditLineCurrency); }
        }

        /// <summary>
        /// Gets ʣ����
        /// </summary>
        public double CreditLineOustanding
        {
            get { return CreditLine - Factor.GetTotalCreditCover(CreditLineCurrency); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get { return Factor.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorType
        {
            get { return Factor.FactorType; }
        }

        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (TypeUtil.LessZero(CreditLine))
                {
                    throw new Exception(String.Format("��Ƚ��{0:N2}����Ϊ��: {1}", CreditLine,
                                 ApproveNo));
                }
            }
        }
    }
}