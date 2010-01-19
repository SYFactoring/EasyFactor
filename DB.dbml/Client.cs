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
		#region Properties (7) 

        /// <summary>
        /// 买方信用风险担保额度
        /// </summary>
        public ClientCreditLine AssignCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "买方信用风险担保额度");
            }
        }

        ///<summary>
        ///买方信用风险担保额度余额
        ///</summary>
        public double AssignCreditLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = AssignCreditLine;
                if (creditLine == null)
                {
                    return 0;
                }
                return creditLine.CreditLine - GetAssignOutstanding(creditLine.CreditLineCurrency);
            }
        }

        //public System.Nullable<double> AssignTotal
        //{
        //    get
        //    {
        //        double? total = null;
        //        foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
        //        {
        //            foreach (CDA cda in curCase.CDAs)
        //            {
        //                double? temp = cda.AssignTotal;
        //                if (temp.HasValue)
        //                {
        //                    if (total == null)
        //                    {
        //                        total = 0;
        //                    }
        //                    total += temp.Value;
        //                }
        //            }
        //        }
        //        return total;
        //    }
        //}
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
        /// 保理预付款融资额度
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "保理预付款融资额度");
            }
        }

        /// <summary>
        /// 最高保理预付款融资额度余额
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = FinanceCreditLine;
                if (creditLine == null)
                {
                    return null;
                }
                return creditLine.CreditLine - GetFinanceOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientCreditLine GroupAssignCreditLine
        {
            get
            {
                ClientCreditLine creditLine = AssignCreditLine;
                if (creditLine != null)
                {
                    return creditLine.GroupCreditLine;
                }
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientCreditLine GroupFinanceCreditLine
        {
            get
            {
                ClientCreditLine creditLine = FinanceCreditLine;
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
        public double GetAssignOutstanding(string currency)
        {
            double result = 0;
            foreach (Case curCase in this.BuyerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
            {
                foreach (CDA cda in curCase.CDAs.Where(c => c.CDAStatus == ConstStr.CDA.SIGNED))
                {
                    double cdaAssignOutstanding = cda.GetAssignOutstanding(currency);
                    result += cdaAssignOutstanding;
                }
            }
            return result;
        }

        /// <summary>
        /// 融资余额
        /// </summary>
        public System.Nullable<double> GetFinanceOutstanding(string currency)
        {
            double? total = null;
            foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
            {
                foreach (CDA cda in curCase.CDAs.Where(c => c.CDAStatus == ConstStr.CDA.SIGNED))
                {
                    double? financeOutstanding = cda.GetFinanceOutstanding(currency);
                    if (financeOutstanding.HasValue)
                    {
                        if (total == null)
                        {
                            total = 0;
                        }
                        total += financeOutstanding.Value;
                    }
                }
            }
            return total;
        }

        ///// <summary>
        ///// 总融资金额
        ///// </summary>
        //public System.Nullable<double> FinanceTotal
        //{
        //    get
        //    {
        //        double? total = null;
        //        foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
        //        {
        //            foreach (CDA cda in curCase.CDAs)
        //            {
        //                double? temp = cda.FinanceTotal;
        //                if (temp.HasValue)
        //                {
        //                    if (total == null)
        //                    {
        //                        total = 0;
        //                    }
        //                    total += temp.Value;
        //                }
        //            }
        //        }
        //        return total;
        //    }
        //}
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

		#endregion Methods 
    }

}
