//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Data.Linq;
    using System.Linq;
    using System.Text.RegularExpressions;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class Client 
    {
        #region Properties (7)

        /// <summary>
        /// Gets 买方信用风险担保额度
        /// </summary>
        public ClientCreditLine AssignCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "买方信用风险担保额度");
            }
        }

        ///<summary>
        /// Gets 买方信用风险担保额度余额
        ///</summary>
        public System.Nullable<double> AssignCreditLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = this.AssignCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - this.GetAssignOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets 主合同
        /// </summary>
        public Contract Contract
        {
            get
            {
                return this.Contracts.SingleOrDefault(c => c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY);
            }
        }

        /// <summary>
        /// Gets 保理预付款融资额度
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "保理预付款融资额度");
            }
        }

        /// <summary>
        /// Gets 最高保理预付款融资额度余额
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = this.FinanceCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - this.GetFinanceOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public ClientCreditLine GroupAssignCreditLine
        {
            get
            {
                ClientCreditLine creditLine = this.AssignCreditLine;
                if (creditLine != null)
                {
                    return creditLine.GroupCreditLine;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public ClientCreditLine GroupFinanceCreditLine
        {
            get
            {
                ClientCreditLine creditLine = this.FinanceCreditLine;
                if (creditLine != null)
                {
                    return creditLine.GroupCreditLine;
                }

                return null;
            }
        }

        #endregion Properties

        #region Methods (3)

        // Public Methods (3) 

        /// <summary>
        /// 转让余额
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double GetAssignOutstanding(string currency)
        {
            double result = 0;
            foreach (Case curCase in this.BuyerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
            {
                double assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    assignOutstanding *= exchange;
                }

                result += assignOutstanding;
            }

            return result;
        }

        /// <summary>
        /// 融资余额
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public System.Nullable<double> GetFinanceOutstanding(string currency)
        {
            double? total = null;
            foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
            {
                double? financeOutstanding = curCase.FinanceOutstanding;
                if (financeOutstanding.HasValue)
                {
                    if (total == null)
                    {
                        total = 0;
                    }

                    if (curCase.InvoiceCurrency != currency)
                    {
                        double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        financeOutstanding *= exchange;
                    }

                    total += financeOutstanding.Value;
                }
            }

            return total;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_ClientNameCN != null && !_ClientNameCN.Equals(string.Empty))
            {
                return _ClientNameCN;
            }
            else
            {
                return _ClientNameEN;
            }
        }

        private static Regex ClientEDICodeRegex = new Regex(@"^[a-zA-Z0-9]{2}[a-zA-Z0-9\\-]{1}[a-zA-Z0-9]{4}\d{2}$");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ClientEDICodeRegex.IsMatch(this.ClientEDICode))
                {
                    throw new ArgumentException("不符合保理代码规则");
                }
            }
        }
        #endregion Methods
    }
}
