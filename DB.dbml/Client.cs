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
        #region Properties (1)

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

        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases)
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

        public System.Nullable<double> CreditLineOutstanding
        {
            get
            {
                double? total = this.FinanceOutstanding;

                foreach (ClientCreditLine creditLine in this.ClientCreditLines)
                {
                    if (creditLine.CreditLineType == "保理预付款融资额度" && creditLine.CreditLineStatus == "已生效")
                    {
                        return creditLine.CreditLine - total;
                    }
                }
                return null;
            }
        }

        public ClientCreditLine AssignCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == "已生效" && c.CreditLineType == "买方信用风险担保额度");
            }
        }

        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                return this.ClientCreditLines.SingleOrDefault(c => c.CreditLineStatus == "已生效" && c.CreditLineType == "保理预付款融资额度");
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
        #endregion Methods
    }

}
