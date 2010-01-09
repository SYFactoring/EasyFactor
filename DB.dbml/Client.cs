using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.ARMgr;

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
        public ClientCreditLine AssignCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == "已生效" && c.CreditLineType == "买方信用风险担保额度");
            }
        }

        public System.Nullable<double> AssignTotal
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == "启动案"))
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
                return this.Contracts.SingleOrDefault(c => c.ContractStatus == "已生效");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CountryNameCN
        {
            get
            {
                if (_CountryCode != null && !_CountryCode.Trim().Equals(string.Empty))
                {
                    return App.Current.DbContext.Countries.Where(c => c.CountryCode == _CountryCode).SingleOrDefault().CountryNameCN;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// 最高保理预付款融资额度余额
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                if (this.FinanceCreditLine == null )
                {
                    return null;
                }
                return this.FinanceCreditLine.CreditLine - this.FinanceOutstanding.GetValueOrDefault();
            }
        }

        /// <summary>
        /// 保理预付款融资额度
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == "已生效" && c.CreditLineType == "保理预付款融资额度");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == "启动案"))
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
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == "启动案"))
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
