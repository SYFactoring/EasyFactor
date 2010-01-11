using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.ARMgr;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Client : BaseObject
    {
        #region Properties (8)

        /// <summary>
        /// 买方信用风险担保额度
        /// </summary>
        public ClientCreditLine GetAssignCreditLine(string currency)
        {
            return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "买方信用风险担保额度" && c.CreditLineCurrency == currency);
        }

        public System.Nullable<double> AssignTotal
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
                {
                    foreach (CDA cda in curCase.CDAs)
                    {
                        double? temp = cda.AssignTotal;
                        if (temp.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += temp.Value;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 主合同
        /// </summary>
        public Contract Contract
        {
            get
            {
                return this.Contracts.SingleOrDefault(c => c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY);
            }
        }

        /// <summary>
        /// 最高保理预付款融资额度余额
        /// </summary>
        public System.Nullable<double> GetFinanceLineOutstanding(string currency)
        {
            ClientCreditLine creditLine = GetFinanceCreditLine(currency);
            if (creditLine == null)
            {
                return null;
            }
            return creditLine.CreditLine - this.FinanceOutstanding.GetValueOrDefault();
        }

        /// <summary>
        /// 保理预付款融资额度
        /// </summary>
        public ClientCreditLine GetFinanceCreditLine(string currency)
        {
            return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "保理预付款融资额度" && c.CreditLineCurrency == currency);
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
                {
                    foreach (CDA cda in curCase.CDAs)
                    {
                        double? temp = cda.FinanceOutstanding;
                        if (temp.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += temp.Value;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 总融资金额
        /// </summary>
        public System.Nullable<double> FinanceTotal
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
                {
                    foreach (CDA cda in curCase.CDAs)
                    {
                        double? temp = cda.FinanceTotal;
                        if (temp.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += temp.Value;
                        }
                    }
                }
                return total;
            }
        }

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

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
                return _ClientNameEN_1;
            }
        }

        #endregion Methods
    }

}
