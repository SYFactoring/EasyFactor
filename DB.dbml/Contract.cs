//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using CMBC.EasyFactor.Utils;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
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

        public string newContractCode()
        {
            var context = new DBDataContext();
            if (this.ContractType.StartsWith("附属合同"))
            {
                Contract mainContract = context.Contracts.SingleOrDefault(c => c.ClientEDICode == this.Client.ClientEDICode && c.ContractStatus == CONTRACT.AVAILABILITY && !c.ContractType.StartsWith("附属合同") && !c.ContractType.StartsWith("补充协议"));
                if (mainContract == null)
                {
                    return String.Empty;
                }
                else
                {
                    int contractCounts = context.Contracts.Count(c => c.ContractCode.StartsWith(mainContract.ContractCode) && c.ContractType.StartsWith("附属合同"));
                    string contractCode = String.Format("{0}-{1:D2}", mainContract.ContractCode, contractCounts + 1);
                    return contractCode;
                }
            }
            else if(this.ContractType.StartsWith("补充协议"))
            {
                Contract mainContract = context.Contracts.SingleOrDefault(c => c.ClientEDICode == this.Client.ClientEDICode && c.ContractStatus == CONTRACT.AVAILABILITY && !c.ContractType.StartsWith("附属合同") && !c.ContractType.StartsWith("补充协议"));
                if (mainContract == null)
                {
                    return String.Empty;
                }
                else
                {
                    int contractCounts = context.Contracts.Count(c => c.ContractCode.StartsWith(mainContract.ContractCode) && c.ContractType.StartsWith("补充合同"));
                    string contractCode = String.Format("{0}-BC-{1:D2}", mainContract.ContractCode, contractCounts + 1);
                    return contractCode;
                }
            }
            else
            {
                String abbrName = this.Client.ClientEDICode.Substring(3, 4);
                int count = context.Contracts.Count(c => c.ClientEDICode == this.Client.ClientEDICode && c.ContractValueDate.Year == this.ContractValueDate.Year);
                string contractCode = String.Format("{0:4}{1:yyyy}{2:D2}", abbrName, this.ContractValueDate, count);
                return contractCode;
            }
        }
    }
}